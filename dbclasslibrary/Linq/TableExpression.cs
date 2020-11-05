using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace DbClassLibrary.Linq
{
	internal enum DbExpressionType
	{
		Table = 1000, // make sure these don't overlap with ExpressionType
		Column,
		Select,
		Projection,
		Join
	}

	internal enum JoinType
	{
		CrossJoin,
		InnerJoin,
		CrossApply,
	}


	internal static class DbExpressionExtensions
	{
		internal static bool IsDbExpression(this ExpressionType et)
		{
			return ((int)et) >= 1000;
		}
	}

	internal class TableExpression : Expression
	{
		readonly string _alias;
		readonly string _name;

		internal TableExpression(Type type, string alias, string name)
            : base((ExpressionType)DbExpressionType.Table, type)
		{
            _alias = alias;
            _name = name;
        }

		internal string Alias
		{
			get { return _alias; }
		}

		internal string Name
		{
			get { return _name; }
		}
	}

	internal class ColumnExpression : Expression
	{
		readonly string _alias;
		readonly string _name;
		readonly int _ordinal;

		internal ColumnExpression(Type type, string alias, string name, int ordinal)
			: base((ExpressionType)DbExpressionType.Column, type)
		{
			_alias = alias;
			_name = name;
			_ordinal = ordinal;
		}

		internal string Alias
		{
			get { return _alias; }
		}

		internal string Name
		{
			get { return _name; }
		}

		internal int Ordinal
		{
			get { return _ordinal; }
		}
	}

	internal class ColumnDeclaration
	{
		readonly string _name;
		readonly Expression _expression;

		internal ColumnDeclaration(string name, Expression expression)
		{
			_name = name;
			_expression = expression;
		}

		internal string Name
		{
			get { return _name; }
		}

		internal Expression Expression
		{
			get { return _expression; }
		}
	}

	internal class SelectExpression : Expression
	{
		readonly string _alias;
		readonly ReadOnlyCollection<ColumnDeclaration> _columns;
		readonly Expression _from;
		readonly Expression _where;

		internal SelectExpression(Type type, string alias, 
			IEnumerable<ColumnDeclaration> columns, Expression from, Expression where) 
			: base((ExpressionType)DbExpressionType.Select, type)
		{
			_alias = alias;
			_columns = columns as ReadOnlyCollection<ColumnDeclaration> ?? new List<ColumnDeclaration>(columns).AsReadOnly();

			_from = from;
			_where = where;
		}

		internal string Alias
		{
			get { return _alias; }
		}

		internal ReadOnlyCollection<ColumnDeclaration> Columns
		{
			get { return _columns; }
		}

		internal Expression From
		{
			get { return _from; }
		}

		internal Expression Where
		{
			get { return _where; }
		}
	}



	internal class ProjectionExpression : Expression
	{
		readonly SelectExpression _source;
		readonly Expression _projector;

		internal ProjectionExpression(SelectExpression source, Expression projector)
			: base((ExpressionType)DbExpressionType.Projection, source.Type)
		{
			_source = source;
			_projector = projector;
		}

		internal SelectExpression Source
		{
			get { return _source; }
		}

		internal Expression Projector
		{
			get { return _projector; }
		}
	}

	internal class JoinExpression : Expression
	{
		private readonly JoinType _joinType;
		private readonly Expression _left;
		private readonly Expression _right;
		private readonly Expression _condition;

		internal JoinExpression(Type type, JoinType joinType, Expression left, Expression right, Expression condition)
			: base((ExpressionType)DbExpressionType.Join, type)
		{
			_joinType = joinType;
			_left = left;
			_right = right;
			_condition = condition;
		}

		internal JoinType Join
		{
			get { return _joinType; }
		}

		internal Expression Left
		{
			get { return _left; }
		}

		internal Expression Right
		{
			get { return _right; }
		}

		internal new Expression Condition
		{
			get { return _condition; }
		}
	}
}
