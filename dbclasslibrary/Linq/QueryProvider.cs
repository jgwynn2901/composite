using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DbClassLibrary.Linq
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class QueryProvider : IQueryProvider
	{
		IQueryable<TS> IQueryProvider.CreateQuery<TS>(Expression expression)
		{
			return new Query<TS>(this, expression);
		}

		IQueryable IQueryProvider.CreateQuery(Expression expression)
		{
			var elementType = TypeSystem.GetElementType(expression.Type);
			try
			{
				return (IQueryable)Activator.CreateInstance(typeof(Query<>).MakeGenericType(elementType), new object[] { this, expression });
			}
			catch (TargetInvocationException tie)
			{
				throw tie.InnerException;
			}
		}

		TS IQueryProvider.Execute<TS>(Expression expression)
		{
			return (TS)Execute(expression);
		}

		object IQueryProvider.Execute(Expression expression)
		{
			return Execute(expression);
		}

		/// <summary>
		/// Gets the query text.
		/// </summary>
		/// <param name="expression">The expression.</param>
		/// <returns></returns>
		public abstract string GetQueryText(Expression expression);

		/// <summary>
		/// Executes the query represented by a specified expression tree.
		/// </summary>
		/// <param name="expression">An expression tree that represents a LINQ query.</param>
		/// <returns>
		/// The value that results from executing the specified query.
		/// </returns>
		public abstract object Execute(Expression expression);
	}
}
