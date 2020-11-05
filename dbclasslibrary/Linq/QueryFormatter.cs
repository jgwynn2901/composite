using System;
using System.Linq.Expressions;
using System.Text;

namespace DbClassLibrary.Linq
{
	internal class QueryFormatter : DbExpressionVisitor
	{
		StringBuilder _sb;
		int _indent = 2;
		int _depth;

		internal string Format(Expression expression)
		{
			_sb = new StringBuilder();
			Visit(expression);
			return _sb.ToString();
		}

		protected enum Indentation
		{
			Same,
			Inner,
			Outer
		}

		internal int IndentationWidth
		{
			get { return _indent; }
			set { _indent = value; }
		}

		private void AppendNewLine(Indentation style)
		{
			_sb.AppendLine();
			if (style == Indentation.Inner)
			{
				_depth++;
			}
			else if (style == Indentation.Outer)
			{
				_depth--;
				System.Diagnostics.Debug.Assert(_depth >= 0);
			}
			for (int i = 0, n = _depth * _indent; i < n; i++)
			{
				_sb.Append(" ");
			}
		}

		protected override Expression VisitMethodCall(MethodCallExpression m)
		{
			throw new NotSupportedException(string.Format("The method '{0}' is not supported", m.Method.Name));
		}

		protected override Expression VisitUnary(UnaryExpression u)
		{
			switch (u.NodeType)
			{
				case ExpressionType.Not:
					_sb.Append(" NOT ");
					Visit(u.Operand);
					break;
				default:
					throw new NotSupportedException(string.Format("The unary operator '{0}' is not supported", u.NodeType));
			}
			return u;
		}

		protected override Expression VisitBinary(BinaryExpression b)
		{
			_sb.Append("(");
			Visit(b.Left);
			switch (b.NodeType)
			{
				case ExpressionType.And:
				case ExpressionType.AndAlso:
					_sb.Append(" AND ");
					break;
				case ExpressionType.Or:
					_sb.Append(" OR");
					break;
				case ExpressionType.Equal:
					_sb.Append(" = ");
					break;
				case ExpressionType.NotEqual:
					_sb.Append(" <> ");
					break;
				case ExpressionType.LessThan:
					_sb.Append(" < ");
					break;
				case ExpressionType.LessThanOrEqual:
					_sb.Append(" <= ");
					break;
				case ExpressionType.GreaterThan:
					_sb.Append(" > ");
					break;
				case ExpressionType.GreaterThanOrEqual:
					_sb.Append(" >= ");
					break;
				default:
					throw new NotSupportedException(string.Format("The binary operator '{0}' is not supported", b.NodeType));
			}
			Visit(b.Right);
			_sb.Append(")");
			return b;
		}

		protected override Expression VisitConstant(ConstantExpression c)
		{
			if (c.Value == null)
			{
				_sb.Append("NULL");
			}
			else
			{
				switch (Type.GetTypeCode(c.Value.GetType()))
				{
					case TypeCode.Boolean:
						_sb.Append(((bool)c.Value) ? 1 : 0);
						break;
					case TypeCode.String:
						_sb.Append("'");
						_sb.Append(c.Value);
						_sb.Append("'");
						break;
					case TypeCode.Object:
						throw new NotSupportedException(string.Format("The constant for '{0}' is not supported", c.Value));
					default:
						_sb.Append(c.Value);
						break;
				}
			}
			return c;
		}

		protected override Expression VisitColumn(ColumnExpression column)
		{
			if (!string.IsNullOrEmpty(column.Alias))
			{
				_sb.Append(column.Alias);
				_sb.Append(".");
			}
			_sb.Append(column.Name);
			return column;
		}

		protected override Expression VisitSelect(SelectExpression select)
		{
			_sb.Append("SELECT ");
			for (int i = 0, n = select.Columns.Count; i < n; i++)
			{
				var column = select.Columns[i];
				if (i > 0)
				{
					_sb.Append(", ");
				}
				var c = Visit(column.Expression) as ColumnExpression;

				if (c == null || c.Name != select.Columns[i].Name)
				{
					_sb.Append(" AS ");
					_sb.Append(column.Name);
				}
			}

			if (select.From != null)
			{
				AppendNewLine(Indentation.Same);
				_sb.Append("FROM ");
				VisitSource(select.From);
			}

			if (select.Where != null)
			{
				AppendNewLine(Indentation.Same);
				_sb.Append("WHERE ");
				Visit(select.Where);
			}
			return select;
		}

		protected override Expression VisitSource(Expression source)
		{
			switch ((DbExpressionType)source.NodeType)
			{
				case DbExpressionType.Table:
					var table = (TableExpression)source;
					_sb.Append(table.Name);
					_sb.Append(" ");
					_sb.Append(table.Alias);
					break;
				case DbExpressionType.Select:
					var select = (SelectExpression)source;
					_sb.Append("(");
					AppendNewLine(Indentation.Inner);
					Visit(select);
					AppendNewLine(Indentation.Outer);
					_sb.Append(")");
					_sb.Append(" ");
					_sb.Append(select.Alias);
					break;
				case DbExpressionType.Join:
					VisitJoin((JoinExpression)source);
					break;
				default:
					throw new InvalidOperationException("Select source is not valid type");
			}
			return source;
		}

		protected override Expression VisitJoin(JoinExpression join)
		{
			VisitSource(join.Left);
			AppendNewLine(Indentation.Same);

			switch (join.Join)
			{
				case JoinType.CrossJoin:
					_sb.Append("CROSS JOIN ");
					break;
				case JoinType.InnerJoin:
					_sb.Append("INNER JOIN ");
					break;
				case JoinType.CrossApply:
					_sb.Append("CROSS APPLY ");
					break;
			}

			VisitSource(join.Right);

			if (join.Condition != null)
			{
				AppendNewLine(Indentation.Inner);
				_sb.Append("ON ");
				Visit(join.Condition);
				AppendNewLine(Indentation.Outer);
			}
			return join;
		}

	}
}
