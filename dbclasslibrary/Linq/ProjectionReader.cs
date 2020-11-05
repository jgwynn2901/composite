using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace DbClassLibrary.Linq
{
	internal class ProjectionReader<T> : IEnumerable<T>
	{
		Enumerator _enumerator;

		internal ProjectionReader(IDataReader reader, Func<ProjectionRow, T> projector, IQueryProvider provider)
		{
			_enumerator = new Enumerator(reader, projector, provider);
		}

		public IEnumerator<T> GetEnumerator()
		{
			var e = _enumerator;
			if (e == null)
				throw new InvalidOperationException("Cannot enumerate more than once");

			_enumerator = null;
			return e;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		class Enumerator : ProjectionRow, IEnumerator<T>
		{
			private readonly IDataReader _reader;
			private T _current;
			private readonly Func<ProjectionRow, T> _projector;
			private readonly IQueryProvider _provider;


			internal Enumerator(IDataReader reader, Func<ProjectionRow, T> projector, IQueryProvider provider)
			{
				_reader = reader;
				_projector = projector;
				_provider = provider;
			}

			public override IEnumerable<TE> ExecuteSubQuery<TE>(LambdaExpression query)
			{
				var projection = (ProjectionExpression)new Replacer().Replace(query.Body, query.Parameters[0], Expression.Constant(this));
				projection = (ProjectionExpression)Evaluator.PartialEval(projection, CanEvaluateLocally);
				var result = (IEnumerable<TE>)_provider.Execute(projection);
				var list = new List<TE>(result);
				if (typeof(IQueryable<TE>).IsAssignableFrom(query.Body.Type))
				{
					return list.AsQueryable();
				}
				return list;
			}

			private static bool CanEvaluateLocally(Expression expression)
			{
				return expression.NodeType != ExpressionType.Parameter && !expression.NodeType.IsDbExpression();
			}

			public override object GetValue(int index)
			{
				if (index >= 0)
					return _reader.IsDBNull(index) ? null : _reader.GetValue(index).ToString();

				throw new IndexOutOfRangeException();
			}

			public T Current
			{
				get { return _current; }
			}

			object IEnumerator.Current
			{
				get { return _current; }
			}

			public bool MoveNext()
			{
				if (_reader.Read())
				{
					_current = _projector(this);
					return true;
				}
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
				_reader.Dispose();
			}
		}
	}
}
