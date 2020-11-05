using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DbClassLibrary.Linq
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class ProjectionRow
	{
		/// <summary>
		/// Gets the value.
		/// </summary>
		public abstract object GetValue(int index);

		/// <summary>
		/// Execute sub-query.
		/// </summary>
		public abstract IEnumerable<TE> ExecuteSubQuery<TE>(LambdaExpression query);
	}

    //internal class ColumnProjection
    //{
    //    internal string Columns;
    //    internal Expression Selector;
    //}

	internal class ColumnProjector : DbExpressionVisitor
	{
		readonly Nominator _nominator;
		Dictionary<ColumnExpression, ColumnExpression> _map;
		List<ColumnDeclaration> _columns;
		HashSet<string> _columnNames;
		HashSet<Expression> _candidates;
		string[] _existingAliases;
		string _newAlias;
		int _iColumn;

		internal ColumnProjector(Func<Expression, bool> fnCanBeColumn)
		{
			_nominator = new Nominator(fnCanBeColumn);
		}

		internal ProjectedColumns ProjectColumns(Expression expression, string newAlias, params string[] existingAliases)
		{
			_map = new Dictionary<ColumnExpression, ColumnExpression>();
			_columns = new List<ColumnDeclaration>();
			_columnNames = new HashSet<string>();
			_newAlias = newAlias;
			_existingAliases = existingAliases;
			_candidates = _nominator.Nominate(expression);
			return new ProjectedColumns(Visit(expression), _columns.AsReadOnly());
		}

		protected override Expression Visit(Expression expression)
		{
			if (_candidates.Contains(expression))
			{
				string columnName;
				int ordinal;
				if (expression.NodeType == (ExpressionType)DbExpressionType.Column)
				{
					var column = (ColumnExpression)expression;
					ColumnExpression mapped;
					if (_map.TryGetValue(column, out mapped))
						return mapped;

					if (_existingAliases.Contains(column.Alias))
					{
						ordinal = _columns.Count;
						columnName = GetUniqueColumnName(column.Name);
						_columns.Add(new ColumnDeclaration(columnName, column));
						mapped = new ColumnExpression(column.Type, _newAlias, columnName, ordinal);
						_map[column] = mapped;
						_columnNames.Add(columnName);
						return mapped;
					}
					// must be referring to outer scope
					return column;
				}
				columnName = GetNextColumnName();
				ordinal = _columns.Count;
				_columns.Add(new ColumnDeclaration(columnName, expression));
				return new ColumnExpression(expression.Type, _newAlias, columnName, ordinal);
			}
			return base.Visit(expression);
		}

		private bool IsColumnNameInUse(string name)
		{
			return _columnNames.Contains(name);
		}

		private string GetUniqueColumnName(string name)
		{
			var baseName = name;
			var suffix = 1;
			while (IsColumnNameInUse(name))
			{
				name = baseName + (suffix++);
			}
			return name;
		}

		private string GetNextColumnName()
		{
			return GetUniqueColumnName("c" + (_iColumn++));
		}

		class Nominator : DbExpressionVisitor
		{
			readonly Func<Expression, bool> _fnCanBeColumn;
			bool _isBlocked;
			HashSet<Expression> _candidates;

			internal Nominator(Func<Expression, bool> fnCanBeColumn)
			{
				_fnCanBeColumn = fnCanBeColumn;
			}

			internal HashSet<Expression> Nominate(Expression expression)
			{
				_candidates = new HashSet<Expression>();
				_isBlocked = false;
				Visit(expression);
				return _candidates;
			}

			protected override Expression Visit(Expression expression)
			{
				if (expression != null)
				{
					var saveIsBlocked = _isBlocked;
					_isBlocked = false;
					base.Visit(expression);
					if (!_isBlocked)
					{
						if (_fnCanBeColumn(expression))
							_candidates.Add(expression);
						else
							_isBlocked = true;
					}
					_isBlocked |= saveIsBlocked;
				}
				return expression;
			}
		}
	}
}
