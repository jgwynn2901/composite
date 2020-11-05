using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace DbClassLibrary.Linq
{
	/// <summary>
	/// Source from Wayward Weblog
	/// This class is obsolete in 4.0 
	/// Where it is defined and exposed
	/// for consumption.
	/// </summary>
	public abstract class ExpressionVisitor
	{
		/// <summary>
		/// Visits the specified exp.
		/// </summary>
		/// <param name="exp">The exp.</param>
		/// <returns></returns>
		protected virtual Expression Visit(Expression exp)
		{
			if (exp == null)
				return exp;
			switch (exp.NodeType)
			{
				case ExpressionType.Negate:
				case ExpressionType.NegateChecked:
				case ExpressionType.Not:
				case ExpressionType.Convert:
				case ExpressionType.ConvertChecked:
				case ExpressionType.ArrayLength:
				case ExpressionType.Quote:
				case ExpressionType.TypeAs:
					return VisitUnary((UnaryExpression)exp);
				case ExpressionType.Add:
				case ExpressionType.AddChecked:
				case ExpressionType.Subtract:
				case ExpressionType.SubtractChecked:
				case ExpressionType.Multiply:
				case ExpressionType.MultiplyChecked:
				case ExpressionType.Divide:
				case ExpressionType.Modulo:
				case ExpressionType.And:
				case ExpressionType.AndAlso:
				case ExpressionType.Or:
				case ExpressionType.OrElse:
				case ExpressionType.LessThan:
				case ExpressionType.LessThanOrEqual:
				case ExpressionType.GreaterThan:
				case ExpressionType.GreaterThanOrEqual:
				case ExpressionType.Equal:
				case ExpressionType.NotEqual:
				case ExpressionType.Coalesce:
				case ExpressionType.ArrayIndex:
				case ExpressionType.RightShift:
				case ExpressionType.LeftShift:
				case ExpressionType.ExclusiveOr:
					return VisitBinary((BinaryExpression)exp);
				case ExpressionType.TypeIs:
					return VisitTypeIs((TypeBinaryExpression)exp);
				case ExpressionType.Conditional:
					return VisitConditional((ConditionalExpression)exp);
				case ExpressionType.Constant:
					return VisitConstant((ConstantExpression)exp);
				case ExpressionType.Parameter:
					return VisitParameter((ParameterExpression)exp);
				case ExpressionType.MemberAccess:
					return VisitMemberAccess((MemberExpression)exp);
				case ExpressionType.Call:
					return VisitMethodCall((MethodCallExpression)exp);
				case ExpressionType.Lambda:
					return VisitLambda((LambdaExpression)exp);
				case ExpressionType.New:
					return VisitNew((NewExpression)exp);
				case ExpressionType.NewArrayInit:
				case ExpressionType.NewArrayBounds:
					return VisitNewArray((NewArrayExpression)exp);
				case ExpressionType.Invoke:
					return VisitInvocation((InvocationExpression)exp);
				case ExpressionType.MemberInit:
					return VisitMemberInit((MemberInitExpression)exp);
				case ExpressionType.ListInit:
					return VisitListInit((ListInitExpression)exp);
				default:
					throw new Exception(string.Format("Unhandled expression type: '{0}'", exp.NodeType));
			}
		}

		/// <summary>
		/// Visits the binding.
		/// </summary>
		/// <param name="binding">The binding.</param>
		/// <returns></returns>
		protected virtual MemberBinding VisitBinding(MemberBinding binding)
		{
			switch (binding.BindingType)
			{
				case MemberBindingType.Assignment:
					return VisitMemberAssignment((MemberAssignment)binding);
				case MemberBindingType.MemberBinding:
					return VisitMemberMemberBinding((MemberMemberBinding)binding);
				case MemberBindingType.ListBinding:
					return VisitMemberListBinding((MemberListBinding)binding);
				default:
					throw new Exception(string.Format("Unhandled binding type '{0}'", binding.BindingType));
			}
		}

		/// <summary>
		/// Visits the element initializer.
		/// </summary>
		/// <param name="initializer">The initializer.</param>
		/// <returns></returns>
		protected virtual ElementInit VisitElementInitializer(ElementInit initializer)
		{
			var arguments = VisitExpressionList(initializer.Arguments);
			return arguments != initializer.Arguments ? Expression.ElementInit(initializer.AddMethod, arguments) : initializer;
		}

		/// <summary>
		/// Visits the unary.
		/// </summary>
		/// <param name="u">The u.</param>
		/// <returns></returns>
		protected virtual Expression VisitUnary(UnaryExpression u)
		{
			var operand = Visit(u.Operand);
			return operand != u.Operand ? Expression.MakeUnary(u.NodeType, operand, u.Type, u.Method) : u;
		}

		/// <summary>
		/// Visits the binary.
		/// </summary>
		/// <param name="b">The b.</param>
		/// <returns></returns>
		protected virtual Expression VisitBinary(BinaryExpression b)
		{
			var left = Visit(b.Left);
			var right = Visit(b.Right);
			var conversion = Visit(b.Conversion);
			if (left != b.Left || right != b.Right || conversion != b.Conversion)
			{
				if (b.NodeType == ExpressionType.Coalesce && b.Conversion != null)
					return Expression.Coalesce(left, right, conversion as LambdaExpression);
				return Expression.MakeBinary(b.NodeType, left, right, b.IsLiftedToNull, b.Method);
			}
			return b;
		}

		/// <summary>
		/// Visits the type is.
		/// </summary>
		/// <param name="b">The b.</param>
		/// <returns></returns>
		protected virtual Expression VisitTypeIs(TypeBinaryExpression b)
		{
			var expr = Visit(b.Expression);
			return expr != b.Expression ? Expression.TypeIs(expr, b.TypeOperand) : b;
		}

		/// <summary>
		/// Visits the constant.
		/// </summary>
		/// <param name="c">The c.</param>
		/// <returns></returns>
		protected virtual Expression VisitConstant(ConstantExpression c)
		{
			return c;
		}

		/// <summary>
		/// Visits the conditional.
		/// </summary>
		/// <param name="c">The c.</param>
		/// <returns></returns>
		protected virtual Expression VisitConditional(ConditionalExpression c)
		{
			var test = Visit(c.Test);
			var ifTrue = Visit(c.IfTrue);
			var ifFalse = Visit(c.IfFalse);
			if (test != c.Test || ifTrue != c.IfTrue || ifFalse != c.IfFalse)
			{
				return Expression.Condition(test, ifTrue, ifFalse);
			}
			return c;
		}

		/// <summary>
		/// Visits the parameter.
		/// </summary>
		/// <param name="p">The p.</param>
		/// <returns></returns>
		protected virtual Expression VisitParameter(ParameterExpression p)
		{
			return p;
		}

		/// <summary>
		/// Visits the member access.
		/// </summary>
		/// <param name="m">The m.</param>
		/// <returns></returns>
		protected virtual Expression VisitMemberAccess(MemberExpression m)
		{
			var exp = Visit(m.Expression);
			return exp != m.Expression ? Expression.MakeMemberAccess(exp, m.Member) : m;
		}

		/// <summary>
		/// Visits the method call.
		/// </summary>
		/// <param name="m">The m.</param>
		/// <returns></returns>
		protected virtual Expression VisitMethodCall(MethodCallExpression m)
		{
			var obj = Visit(m.Object);
			IEnumerable<Expression> args = VisitExpressionList(m.Arguments);
			if (obj != m.Object || args != m.Arguments)
			{
				return Expression.Call(obj, m.Method, args);
			}
			return m;
		}

		/// <summary>
		/// Visits the expression list.
		/// </summary>
		/// <param name="original">The original.</param>
		/// <returns></returns>
		protected virtual ReadOnlyCollection<Expression> VisitExpressionList(ReadOnlyCollection<Expression> original)
		{
			List<Expression> list = null;
			for (int i = 0, n = original.Count; i < n; i++)
			{
				var p = Visit(original[i]);
				if (list != null)
				{
					list.Add(p);
				}
				else if (p != original[i])
				{
					list = new List<Expression>(n);
					for (var j = 0; j < i; j++)
					{
						list.Add(original[j]);
					}
					list.Add(p);
				}
			}
			return list != null ? list.AsReadOnly() : original;
		}

		/// <summary>
		/// Visits the member assignment.
		/// </summary>
		/// <param name="assignment">The assignment.</param>
		/// <returns></returns>
		protected virtual MemberAssignment VisitMemberAssignment(MemberAssignment assignment)
		{
			var e = Visit(assignment.Expression);
			return e != assignment.Expression ? Expression.Bind(assignment.Member, e) : assignment;
		}

		/// <summary>
		/// Visits the member member binding.
		/// </summary>
		/// <param name="binding">The binding.</param>
		/// <returns></returns>
		protected virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding binding)
		{
			var bindings = VisitBindingList(binding.Bindings);
			return bindings != binding.Bindings ? Expression.MemberBind(binding.Member, bindings) : binding;
		}

		/// <summary>
		/// Visits the member list binding.
		/// </summary>
		/// <param name="binding">The binding.</param>
		/// <returns></returns>
		protected virtual MemberListBinding VisitMemberListBinding(MemberListBinding binding)
		{
			var initializers = VisitElementInitializerList(binding.Initializers);
			return initializers != binding.Initializers ? Expression.ListBind(binding.Member, initializers) : binding;
		}

		/// <summary>
		/// Visits the binding list.
		/// </summary>
		/// <param name="original">The original.</param>
		/// <returns></returns>
		protected virtual IEnumerable<MemberBinding> VisitBindingList(ReadOnlyCollection<MemberBinding> original)
		{
			List<MemberBinding> list = null;
			for (int i = 0, n = original.Count; i < n; i++)
			{
				var b = VisitBinding(original[i]);
				if (list != null)
				{
					list.Add(b);
				}
				else if (b != original[i])
				{
					list = new List<MemberBinding>(n);
					for (var j = 0; j < i; j++)
					{
						list.Add(original[j]);
					}
					list.Add(b);
				}
			}
			if (list != null)
				return list;
			return original;
		}

		/// <summary>
		/// Visits the element initializer list.
		/// </summary>
		/// <param name="original">The original.</param>
		/// <returns></returns>
		protected virtual IEnumerable<ElementInit> VisitElementInitializerList(ReadOnlyCollection<ElementInit> original)
		{
			List<ElementInit> list = null;
			for (int i = 0, n = original.Count; i < n; i++)
			{
				var init = VisitElementInitializer(original[i]);
				if (list != null)
				{
					list.Add(init);
				}
				else if (init != original[i])
				{
					list = new List<ElementInit>(n);
					for (var j = 0; j < i; j++)
					{
						list.Add(original[j]);
					}
					list.Add(init);
				}
			}
			if (list != null)
				return list;
			return original;
		}

		/// <summary>
		/// Visits the lambda.
		/// </summary>
		/// <param name="lambda">The lambda.</param>
		/// <returns></returns>
		protected virtual Expression VisitLambda(LambdaExpression lambda)
		{
			var body = Visit(lambda.Body);
			return body != lambda.Body ? Expression.Lambda(lambda.Type, body, lambda.Parameters) : lambda;
		}

		/// <summary>
		/// Visits the new.
		/// </summary>
		/// <param name="nex">The nex.</param>
		/// <returns></returns>
		protected virtual NewExpression VisitNew(NewExpression nex)
		{
			IEnumerable<Expression> args = VisitExpressionList(nex.Arguments);
			if (args != nex.Arguments)
			{
				if (nex.Members != null)
					return Expression.New(nex.Constructor, args, nex.Members);
				return Expression.New(nex.Constructor, args);
			}
			return nex;
		}

		/// <summary>
		/// Visits the member init.
		/// </summary>
		/// <param name="init">The init.</param>
		/// <returns></returns>
		protected virtual Expression VisitMemberInit(MemberInitExpression init)
		{
			var n = VisitNew(init.NewExpression);
			var bindings = VisitBindingList(init.Bindings);

			if (n != init.NewExpression || bindings != init.Bindings)
				return Expression.MemberInit(n, bindings);

			return init;
		}

		/// <summary>
		/// Visits the list init.
		/// </summary>
		/// <param name="init">The init.</param>
		/// <returns></returns>
		protected virtual Expression VisitListInit(ListInitExpression init)
		{
			var n = VisitNew(init.NewExpression);
			var initializers = VisitElementInitializerList(init.Initializers);
			if (n != init.NewExpression || initializers != init.Initializers)
				return Expression.ListInit(n, initializers);

			return init;
		}

		/// <summary>
		/// Visits the new array.
		/// </summary>
		/// <param name="na">The na.</param>
		/// <returns></returns>
		protected virtual Expression VisitNewArray(NewArrayExpression na)
		{
			IEnumerable<Expression> exprs = VisitExpressionList(na.Expressions);
			if (exprs != na.Expressions)
				return na.NodeType == ExpressionType.NewArrayInit ? 
					Expression.NewArrayInit(na.Type.GetElementType(), exprs) : 
					Expression.NewArrayBounds(na.Type.GetElementType(), exprs);

			return na;
		}

		/// <summary>
		/// Visits the invocation.
		/// </summary>
		/// <param name="iv">The iv.</param>
		/// <returns></returns>
		protected virtual Expression VisitInvocation(InvocationExpression iv)
		{
			var args = VisitExpressionList(iv.Arguments);
			var expr = Visit(iv.Expression);
			if (args != iv.Arguments || expr != iv.Expression)
				return Expression.Invoke(expr, args);

			return iv;
		}
	}
}
