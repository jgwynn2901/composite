using System;
using System.Data.Common;
using System.Linq.Expressions;
using System.Reflection;

namespace DbClassLibrary.Linq
{
	/// <summary>
	/// 
	/// </summary>
	public class DbQueryProvider : QueryProvider
	{
		readonly DbConnection _connection;

		/// <summary>
		/// Initializes a new instance of the <see cref="DbQueryProvider"/> class.
		/// </summary>
		/// <param name="connection">The connection.</param>
		public DbQueryProvider(DbConnection connection)
		{
			_connection = connection;
		}

		/// <summary>
		/// Gets the query text.
		/// </summary>
		/// <param name="expression">The expression.</param>
		/// <returns></returns>
		public override string GetQueryText(Expression expression)
		{
			return Translate(expression).CommandText; 
		}

		/// <summary>
		/// Executes the query represented by a specified expression tree.
		/// </summary>
		/// <param name="expression">An expression tree that represents a LINQ query.</param>
		/// <returns>
		/// The value that results from executing the specified query.
		/// </returns>
		public override object Execute(Expression expression)
		{
			var result = Translate(expression);

			var cmd = _connection.CreateCommand();
			cmd.CommandText = result.CommandText;
			var reader = cmd.ExecuteReader();

			var elementType = TypeSystem.GetElementType(expression.Type);
			if (result.Projector != null)
			{
				var projector = result.Projector.Compile();
				return Activator.CreateInstance(
					typeof(ProjectionReader<>).MakeGenericType(elementType),
					BindingFlags.Instance | BindingFlags.NonPublic, null,
					new object[] { reader, projector },
					null
					);
			}
			return Activator.CreateInstance(
				typeof(ObjectReader<>).MakeGenericType(elementType),
				BindingFlags.Instance | BindingFlags.NonPublic, null,
				new object[] { reader },
				null
				);
		}

		/// <summary>
		/// Translates the specified expression.
		/// </summary>
		/// <param name="expression">The expression.</param>
// ReSharper disable MemberCanBeMadeStatic.Local
		private TranslateResult Translate(Expression expression)
// ReSharper restore MemberCanBeMadeStatic.Local
		{
			expression = Evaluator.PartialEval(expression);
			return new QueryTranslator().Translate(expression);
		}
	}
}
