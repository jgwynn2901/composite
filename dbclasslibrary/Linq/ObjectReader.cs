using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace DbClassLibrary.Linq
{
	internal class ObjectReader<T> : IEnumerable<T> where T : ActiveRecord, new()
	{
		Enumerator _enumerator;

		internal ObjectReader(IDataReader reader)
		{
			_enumerator = new Enumerator(reader);
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

		class Enumerator : IEnumerator<T>
		{
			readonly IDataReader _reader;

			internal Enumerator(IDataReader reader)
			{
				_reader = reader;
			}

			public T Current { get; private set; }

			object IEnumerator.Current
			{
				get { return Current; }
			}

			public bool MoveNext()
			{
				if (_reader.Read())
				{
					var instance = new T();
					instance.Fill(_reader);
					Current = instance;
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
