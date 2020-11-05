using System.Linq.Expressions;
using System.Reflection;

namespace DbClassLibrary.Linq
{
	internal class ProjectionBuilder : DbExpressionVisitor
	{
		ParameterExpression _row;
		string _alias;

		private static MethodInfo MiGetValue;
		private static MethodInfo MiExecuteSubQuery;

		internal ProjectionBuilder()
		{
			if (MiGetValue != null) return;
			MiGetValue = typeof(ProjectionRow).GetMethod("GetValue");
			MiExecuteSubQuery = typeof(ProjectionRow).GetMethod("ExecuteSubQuery");
		}

		internal LambdaExpression Build(Expression expression, string alias)
		{
			_row = Expression.Parameter(typeof(ProjectionRow), "row");
			_alias = alias;
			var body = Visit(expression);
			return Expression.Lambda(body, _row);
		}

		protected override Expression VisitColumn(ColumnExpression column)
		{
            if (column.Alias == _alias) 
				return Expression.Convert(Expression.Call(_row, MiGetValue, Expression.Constant(column.Ordinal)), column.Type);
			return column;
		}

		protected override Expression VisitProjection(ProjectionExpression proj)
		{
			var subQuery = Expression.Lambda(base.VisitProjection(proj), _row);
			var elementType = TypeSystem.GetElementType(subQuery.Body.Type);
			var mi = MiExecuteSubQuery.MakeGenericMethod(elementType);
			return Expression.Convert(
				Expression.Call(_row, mi, Expression.Constant(subQuery)),
				proj.Type
				);
		}

	}
}
