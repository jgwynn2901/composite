using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace DbClassLibrary.Linq
{
	///<summary>
	///</summary>
	[ComVisible(false)]
	public class Query<T> : IOrderedQueryable<T>
	{
		readonly QueryProvider _provider;
		readonly Expression _expression;

		/// <summary>
		/// Initializes a new instance of the <see cref="Query&lt;T&gt;"/> class.
		/// </summary>
		/// <param name="provider">The _provider.</param>
		public Query(QueryProvider provider)
		{
			if (provider == null)
			{
				throw new ArgumentNullException("provider");
			}
			_provider = provider;
			_expression = Expression.Constant(this);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Query&lt;T&gt;"/> class.
		/// </summary>
		public Query(QueryProvider provider, Expression expression)
		{
			if (provider == null)
			{
				throw new ArgumentNullException("provider");
			}
			if (expression == null)
			{
				throw new ArgumentNullException("expression");
			}
			if (!typeof(IQueryable<T>).IsAssignableFrom(expression.Type))
			{
				throw new ArgumentOutOfRangeException("expression");
			}
			_provider = provider;
			_expression = expression;
		}

		Expression IQueryable.Expression
		{
			get { return _expression; }
		}

		Type IQueryable.ElementType
		{
			get { return typeof(T); }
		}

		IQueryProvider IQueryable.Provider
		{
			get { return _provider; }
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
		/// </returns>
		public IEnumerator<T> GetEnumerator()
		{
			return ((IEnumerable<T>)_provider.Execute(_expression)).GetEnumerator();
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
		/// </returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)_provider.Execute(_expression)).GetEnumerator();
		}

		/// <summary>
		/// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </returns>
		public override string ToString()
		{
			return _provider.GetQueryText(_expression);
		}
	}
}
