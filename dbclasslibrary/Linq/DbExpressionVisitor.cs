using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;

namespace DbClassLibrary.Linq
{
	internal class DbExpressionVisitor : ExpressionVisitor
	{

		protected override Expression Visit(Expression exp)
		{
			if (exp == null) return null;

			switch ((DbExpressionType)exp.NodeType)
			{
				case DbExpressionType.Table:
					return VisitTable((TableExpression)exp);
				case DbExpressionType.Column:
					return VisitColumn((ColumnExpression)exp);
				case DbExpressionType.Select:
					return VisitSelect((SelectExpression)exp);
				case DbExpressionType.Join:
					return VisitJoin((JoinExpression)exp);
				case DbExpressionType.Projection:
					return VisitProjection((ProjectionExpression)exp);
				default:
					return base.Visit(exp);
			}
		}

		protected virtual Expression VisitTable(TableExpression table)
		{
            return table;
        }

		protected virtual Expression VisitColumn(ColumnExpression column)
		{
			return column;
		}

		protected virtual Expression VisitSelect(SelectExpression select)
		{
			var from = VisitSource(select.From);
			var where = Visit(select.Where);
			var columns = VisitColumnDeclarations(select.Columns);
	
			if (from != select.From || where != select.Where || columns != select.Columns)
				return new SelectExpression(select.Type, select.Alias, columns, from, where);

			return select;
		}

		protected virtual Expression VisitSource(Expression source)
		{
			return Visit(source);
		}

		protected virtual Expression VisitProjection(ProjectionExpression proj)
		{
			var source = (SelectExpression)Visit(proj.Source);
			var projector = Visit(proj.Projector);
	
			if (source != proj.Source || projector != proj.Projector)
				return new ProjectionExpression(source, projector);

			return proj;
		}

		protected ReadOnlyCollection<ColumnDeclaration> VisitColumnDeclarations(ReadOnlyCollection<ColumnDeclaration> columns)
		{
			List<ColumnDeclaration> alternate = null;

			for (int i = 0, n = columns.Count; i < n; i++)
			{
				var column = columns[i];
				var e = Visit(column.Expression);

				if (alternate == null && e != column.Expression)
					alternate = columns.Take(i).ToList();

				if (alternate != null)
					alternate.Add(new ColumnDeclaration(column.Name, e));
			}
			return alternate != null ? alternate.AsReadOnly() : columns;
		}

		protected virtual Expression VisitJoin(JoinExpression join)
		{
			var left = Visit(join.Left);
			var right = Visit(join.Right);
			var condition = Visit(join.Condition);

			if (left != join.Left || right != join.Right || condition != join.Condition)
				return new JoinExpression(join.Type, join.Join, left, right, condition);

			return join;
		}

	}
}
