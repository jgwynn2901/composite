using System;
using System.Data.OracleClient;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Oracle;

namespace DbClassLibrary.Linq
{
	class ActiveQueryProvider : QueryProvider
	{
		private readonly string _instance;

		public ActiveQueryProvider() :this(ApplicationConfiguration.Instance.DefaultInstance)
		{}

		public ActiveQueryProvider(string instance)
		{
			_instance = instance;
		}

		public string Instance
		{
			get { return _instance; }
		}

		public override string GetQueryText(Expression expression)
		{
			return Translate(expression).CommandText;
		}

		public override object Execute(Expression expression)
		{
			return Execute(Translate(expression));
		}


		public object Execute(TranslateResult query)
		{
			var projector = query.Projector.Compile();
			GeneralUtility.DebugLog(query.CommandText, ToString());

			var db = (OracleDatabase)DatabaseFactory.CreateDatabase(_instance);
			var cmd = (OracleCommand)db.GetSqlStringCommand(query.CommandText);
			var reader = db.ExecuteReader(cmd);

			var elementType = TypeSystem.GetElementType(query.Projector.Body.Type);
			
			return Activator.CreateInstance(
					typeof(ProjectionReader<>).MakeGenericType(elementType),
					BindingFlags.Instance | BindingFlags.NonPublic, null,
					new object[] { reader, projector, this },
					null
					);
		}

		internal class TranslateResult
		{
			internal string CommandText;
			internal LambdaExpression Projector;
		}

		private static TranslateResult Translate(Expression expression)
		{
			var projection = expression as ProjectionExpression;
			if (projection == null)
			{
				expression = Evaluator.PartialEval(expression);
				projection = (ProjectionExpression)new QueryBinder().Bind(expression);
			}

			var commandText = new QueryFormatter().Format(projection.Source);
			var projector = new ProjectionBuilder().Build(projection.Projector, projection.Source.Alias);
			return new TranslateResult { CommandText = commandText, Projector = projector };
		}
	}
}
