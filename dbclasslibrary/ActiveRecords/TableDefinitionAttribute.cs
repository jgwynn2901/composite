using System;
using System.Linq;

namespace DbClassLibrary.ActiveRecords
{
    /// <summary>
    /// 
    /// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class TableDefinitionAttribute : Attribute
	{
        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
		public string TableName { get; set; }

        /// <summary>
        /// Classes the name of the table.
        /// </summary>
        /// <param name="_">The _.</param>
        /// <returns></returns>
        static public string ClassTableName (Type _)
        {
        	var attribute = from t in _.GetCustomAttributes(true)
        	                where t is TableDefinitionAttribute
        	                select t;

          var enumerable = attribute as object[] ?? attribute.ToArray();
          return enumerable.Any()  ? 
				((TableDefinitionAttribute)enumerable.First()).TableName : null;
        }
	}

    /// <summary>
    /// 
    /// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class FieldDefintionAttribute : Attribute
    {
// ReSharper disable once InconsistentNaming
      public bool encrypt;
        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>The name of the field.</value>
		public string FieldName { get; set; }

        /// <summary>
        /// Classes the name of the field.
        /// </summary>
        /// <param name="_">The _.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns></returns>
		static public string ClassFieldName(Type _, string fieldName)
		{
			var info = _.GetProperty(fieldName);
			if(info == null) return null;

			var results = from t in info.GetCustomAttributes(true)
													  where t is FieldDefintionAttribute
													   select t;

          var enumerable = results as object[] ?? results.ToArray();
          return enumerable.Any() ? 
				((FieldDefintionAttribute)enumerable.First()).FieldName : null;
		}
	}
}
