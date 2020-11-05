using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using DbClassLibrary.ActiveRecords;

namespace DbClassLibrary.Linq
{
	internal class QueryBinder : ExpressionVisitor
	{
		readonly ColumnProjector _columnProjector;
		Dictionary<ParameterExpression, Expression> _map;
		int _aliasCount;

		internal QueryBinder()
		{
			_columnProjector = new ColumnProjector(CanBeColumn);
		}

		private static bool CanBeColumn(Expression expression)
		{
			return expression.NodeType == (ExpressionType)DbExpressionType.Column;
		}

		internal Expression Bind(Expression expression)
		{
			_map = new Dictionary<ParameterExpression, Expression>();
			return Visit(expression);
		}

		private static Expression StripQuotes(Expression e)
		{
			while (e.NodeType == ExpressionType.Quote)
			{
				e = ((UnaryExpression)e).Operand;
			}
			return e;
		}

		private string GetNextAlias()
		{
			return "t" + (_aliasCount++);
		}

		private ProjectedColumns ProjectColumns(Expression expression, string newAlias, params string[] existingAliases)
		{
			return _columnProjector.ProjectColumns(expression, newAlias, existingAliases);
		}

		protected override Expression VisitMethodCall(MethodCallExpression m)
		{
			if (m.Method.DeclaringType == typeof(Queryable) ||
				m.Method.DeclaringType == typeof(Enumerable))
			{
				switch (m.Method.Name)
				{
					case "Where":
						return BindWhere(m.Type, m.Arguments[0], (LambdaExpression)StripQuotes(m.Arguments[1]));
					case "Select":
						return BindSelect(m.Type, m.Arguments[0], (LambdaExpression)StripQuotes(m.Arguments[1]));
					case "SelectMany":
						if (m.Arguments.Count == 2)
						{
							return BindSelectMany(
								m.Type, m.Arguments[0],
								(LambdaExpression)StripQuotes(m.Arguments[1]),
								null
								);
						}
						if (m.Arguments.Count == 3)
						{
							return BindSelectMany(
								m.Type, m.Arguments[0],
								(LambdaExpression)StripQuotes(m.Arguments[1]),
								(LambdaExpression)StripQuotes(m.Arguments[2])
								);
						}
						break;
					case "Join":
						return BindJoin(
							m.Type, m.Arguments[0], m.Arguments[1],
							(LambdaExpression)StripQuotes(m.Arguments[2]),
							(LambdaExpression)StripQuotes(m.Arguments[3]),
							(LambdaExpression)StripQuotes(m.Arguments[4])
							);

				}
				throw new NotSupportedException(string.Format("The method '{0}' is not supported", m.Method.Name));
			}
			return base.VisitMethodCall(m);
		}

		private Expression BindWhere(Type resultType, Expression source, LambdaExpression predicate)
		{
			var projection = (ProjectionExpression)Visit(source);
			_map[predicate.Parameters[0]] = projection.Projector;
			var where = Visit(predicate.Body);
			var alias = GetNextAlias();
			var pc = ProjectColumns(projection.Projector, alias, GetExistingAlias(projection.Source));
			return new ProjectionExpression(
				new SelectExpression(resultType, alias, pc.Columns, projection.Source, where),
				pc.Projector
				);
		}

		private Expression BindSelect(Type resultType, Expression source, LambdaExpression selector)
		{
			var projection = (ProjectionExpression)Visit(source);
			_map[selector.Parameters[0]] = projection.Projector;
			var expression = Visit(selector.Body);
			var alias = GetNextAlias();
			var pc = ProjectColumns(expression, alias, GetExistingAlias(projection.Source));
			return new ProjectionExpression(
				new SelectExpression(resultType, alias, pc.Columns, projection.Source, null),
				pc.Projector
				);
		}
		protected virtual Expression BindSelectMany(Type resultType, Expression source, LambdaExpression collectionSelector, LambdaExpression resultSelector)
		{
			var projection = (ProjectionExpression)Visit(source);
			_map[collectionSelector.Parameters[0]] = projection.Projector;
			var collectionProjection = (ProjectionExpression)Visit(collectionSelector.Body);
			var joinType = IsTable(collectionSelector.Body) ? JoinType.CrossJoin : JoinType.CrossApply;
			var join = new JoinExpression(resultType, joinType, projection.Source, collectionProjection.Source, null);
			var alias = GetNextAlias();
			ProjectedColumns pc;
			if (resultSelector == null)
			{
				pc = ProjectColumns(collectionProjection.Projector, alias, projection.Source.Alias, collectionProjection.Source.Alias);
			}
			else
			{
				_map[resultSelector.Parameters[0]] = projection.Projector;
				_map[resultSelector.Parameters[1]] = collectionProjection.Projector;
				var result = Visit(resultSelector.Body);
				pc = ProjectColumns(result, alias, projection.Source.Alias, collectionProjection.Source.Alias);
			}
			return new ProjectionExpression(
				new SelectExpression(resultType, alias, pc.Columns, join, null),
				pc.Projector
				);
		}


		protected virtual Expression BindJoin(Type resultType, Expression outerSource, Expression innerSource, LambdaExpression outerKey, LambdaExpression innerKey, LambdaExpression resultSelector)
		{
			var outerProjection = (ProjectionExpression)Visit(outerSource);
			var innerProjection = (ProjectionExpression)Visit(innerSource);
			_map[outerKey.Parameters[0]] = outerProjection.Projector;
			var outerKeyExpr = Visit(outerKey.Body);
			_map[innerKey.Parameters[0]] = innerProjection.Projector;
			var innerKeyExpr = Visit(innerKey.Body);
			_map[resultSelector.Parameters[0]] = outerProjection.Projector;
			_map[resultSelector.Parameters[1]] = innerProjection.Projector;
			var resultExpr = Visit(resultSelector.Body);
			var join = new JoinExpression(resultType, JoinType.InnerJoin, outerProjection.Source, innerProjection.Source, Expression.Equal(outerKeyExpr, innerKeyExpr));
			var alias = GetNextAlias();
			var pc = ProjectColumns(resultExpr, alias, outerProjection.Source.Alias, innerProjection.Source.Alias);
			return new ProjectionExpression(
				new SelectExpression(resultType, alias, pc.Columns, join, null),
				pc.Projector
				);
		}


		private static string GetExistingAlias(Expression source)
		{
			switch ((DbExpressionType)source.NodeType)
			{
				case DbExpressionType.Select:
					return ((SelectExpression)source).Alias;
				case DbExpressionType.Table:
					return ((TableExpression)source).Alias;
				default:
					throw new InvalidOperationException(string.Format("Invalid source node type '{0}'", source.NodeType));
			}
		}

		private static bool IsTable(object value)
		{
			var q = value as IQueryable;
			return q != null && q.Expression.NodeType == ExpressionType.Constant;
		}

		private static string GetTableName(object table)
		{
			var tableQuery = (IQueryable)table;
			var rowType = tableQuery.ElementType;
			return TableDefinitionAttribute.ClassTableName(rowType) ?? rowType.Name;
		}

		private static string GetColumnName(MemberInfo member)
		{
			return FieldDefintionAttribute.ClassFieldName(member.DeclaringType, member.Name) ?? member.Name;
		}

		private static Type GetColumnType(MemberInfo member)
		{
			var fi = member as FieldInfo;
			if (fi != null)
				return fi.FieldType;

			var pi = (PropertyInfo)member;
			return pi.PropertyType;
		}

		private static IEnumerable<MemberInfo> GetMappedMembers(Type rowType)
		{
			return (from t in (from p in rowType.GetProperties() select p)
						  from a in t.GetCustomAttributes(true)
						  where a is FieldDefintionAttribute
							 select t).Cast<MemberInfo>();
		}

		private ProjectionExpression GetTableProjection(object value)
		{
			var table = (IQueryable)value;
			var tableAlias = GetNextAlias();
			var selectAlias = GetNextAlias();
			var bindings = new List<MemberBinding>();
			var columns = new List<ColumnDeclaration>();
			foreach (var mi in GetMappedMembers(table.ElementType))
			{
				var columnName = GetColumnName(mi);
				var columnType = GetColumnType(mi);
				var ordinal = columns.Count;
				bindings.Add(Expression.Bind(mi, new ColumnExpression(columnType, selectAlias, columnName, ordinal)));
				columns.Add(new ColumnDeclaration(columnName, new ColumnExpression(columnType, tableAlias, columnName, ordinal)));
			}
			var projector = Expression.MemberInit(Expression.New(table.ElementType), bindings);
			var resultType = typeof(IEnumerable<>).MakeGenericType(table.ElementType);
			return new ProjectionExpression(
				new SelectExpression(
					resultType,
					selectAlias,
					columns,
					new TableExpression(resultType, tableAlias, GetTableName(table)),
					null
					),
				projector
				);
		}

		protected override Expression VisitConstant(ConstantExpression c)
		{
			if (IsTable(c.Value))
				return GetTableProjection(c.Value);
			return c;
		}

		protected override Expression VisitParameter(ParameterExpression p)
		{
			Expression e;
			return _map.TryGetValue(p, out e) ? e : p;
		}

		protected override Expression VisitMemberAccess(MemberExpression m)
		{
			var source = Visit(m.Expression);

			switch (source.NodeType)
			{
				case ExpressionType.MemberInit:
					var min = (MemberInitExpression)source;
					for (int i = 0, n = min.Bindings.Count; i < n; i++)
					{
						var assign = min.Bindings[i] as MemberAssignment;
						if (assign != null && MembersMatch(assign.Member, m.Member))
						{
							return assign.Expression;
						}
					}
					break;
				case ExpressionType.New:
					var nex = (NewExpression)source;
					if (nex.Members != null)
					{
						for (int i = 0, n = nex.Members.Count; i < n; i++)
						{
							if (MembersMatch(nex.Members[i], m.Member))
							{
								return nex.Arguments[i];
							}
						}
					}
					break;
			}
			return source == m.Expression ? m : MakeMemberAccess(source, m.Member);
		}

		private static bool MembersMatch(MemberInfo a, MemberInfo b)
		{
			if (a == b)
			{
				return true;
			}

			if (a is MethodInfo && b is PropertyInfo)
				return a == ((PropertyInfo)b).GetGetMethod();

			if (a is PropertyInfo && b is MethodInfo)
				return ((PropertyInfo)a).GetGetMethod() == b;

			return false;
		}

		private static Expression MakeMemberAccess(Expression source, MemberInfo mi)
		{
			var fi = mi as FieldInfo;
			if (fi != null)
			{
				return Expression.Field(source, fi);
			}
			var pi = (PropertyInfo)mi;
			return Expression.Property(source, pi);
		}
	}
}
