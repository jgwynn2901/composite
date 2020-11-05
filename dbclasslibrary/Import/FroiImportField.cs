#region Header
/**************************************************************************
* Innovation First Notice
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2009 by Innovation First Notice 
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Import/FroiImportField.cs 6     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;
using System.Globalization;
using System.Text;
using DbClassLibrary.Security;

namespace DbClassLibrary.Import
{
	/// <summary>
	/// Encapsulates the USERS table
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class FroiImportField : ActiveRecord, IFroiImportField
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="FroiImportField"/> class.
		/// </summary>
		public FroiImportField()
			: base("FROI_IMP_MAP")
		{
			columns.Add(new Column("FROI_IMP_MAP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("FROI_FILE_DEF_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ATTRIBUTE_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STARTPOS", String.Empty, "NUMBER"));
			columns.Add(new Column("LENGTH", String.Empty, "NUMBER"));
			columns.Add(new Column("CREATED_DT", String.Empty, "DATE"));
			columns.Add(new Column("LAST_MODIFIED_DT", String.Empty, "DATE"));
			columns.Add(new Column("LEGACY_FIELD_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DATA_DEFINITION", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DEFAULT_VALUE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FROI_IMP_RECORD_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("FROI_IMP_RECORD_TYPE", String.Empty, "CHAR"));
		  _canDelete = true;
		}

	  /// <summary>
	  /// Initializes a new instance of the <see cref="User"/> class.
	  /// </summary>
	  /// <param name="reader">The reader.</param>
	  public FroiImportField(IDataReader reader)
	    : base(reader, "FROI_IMP_MAP")
	  {
      _canDelete = true;
	  }

		#endregion

		#region FroiImpMapId
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			get
			{
				return GetColumnValueAsInt("FROI_IMP_MAP_ID") ?? 0;
			}
			set
			{
				SetColumnValue("FROI_IMP_MAP_ID", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region FroiFileDefId
		/// <summary>
		/// Gets or sets the froi file_def_id.
		/// </summary>
		public int FroiFileDefId
		{
			get
			{
				return GetColumnValueAsInt("FROI_FILE_DEF_ID") ?? 0;
			}
			set
			{
				SetColumnValue("FROI_FILE_DEF_ID", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region AttributeName
		/// <summary>
		/// 
		/// </summary>
		public string AttributeName
		{
			get
			{
				return GetColumnValue("ATTRIBUTE_NAME");
			}
			set
			{
				SetColumnValue("ATTRIBUTE_NAME", value);
			}
		}

		#endregion
		
		#region StartPosition
		/// <summary>
		/// 
		/// </summary>
		public int StartPosition
		{
			get
			{
				return GetColumnValueAsInt("STARTPOS") ?? 0;
			}
			set
			{
				SetColumnValue("STARTPOS", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region Length
		/// <summary>
		/// 
		/// </summary>
		public int Length
		{
			get
			{
				return GetColumnValueAsInt("LENGTH") ?? 0;
			}
			set
			{
				SetColumnValue("LENGTH", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region CreatedDate
		/// <summary>
		/// 
		/// </summary>
		public string CreatedDate
		{
			get
			{
				return GetColumnValue("CREATED_DT");
			}
		}
		#endregion

		#region LastModifiedDate
		/// <summary>
		/// 
		/// </summary>
		public string LastModifiedDate
		{
			get
			{
				return GetColumnValue("LAST_MODIFIED_DT");
			}
		}
		#endregion

		#region LegacyFieldName
		/// <summary>
		/// 
		/// </summary>
		public string LegacyFieldName
		{
			get
			{
				return GetColumnValue("LEGACY_FIELD_NAME");
			}
			set
			{
				SetColumnValue("LEGACY_FIELD_NAME", value);
			}
		}
		#endregion

		#region DataDefinition
		/// <summary>
		/// 
		/// </summary>
		public string DataDefinition
		{
			get
			{
				return GetColumnValue("DATA_DEFINITION");
			}
			set
			{
				SetColumnValue("DATA_DEFINITION", value);
			}
		}
		#endregion

		#region DefaultValue

		/// <summary>
		/// If nothing to map use this field to set a default value
		/// </summary>
		public string DefaultValue
		{
			get
			{
				return GetColumnValue("DEFAULT_VALUE");
			}
			set
			{
				SetColumnValue("DEFAULT_VALUE", value);
			}
		}
		#endregion

		#region FroiImpRecordId
		/// <summary>
		/// 
		/// </summary>
		public int FroiImpRecordId
		{
			get
			{
				return GetColumnValueAsInt("FROI_IMP_RECORD_ID")?? 0 ;
			}
			set
			{
				SetColumnValue("FROI_IMP_RECORD_ID", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region FroiImpRecordType
		/// <summary>
		/// 
		/// </summary>
		public string FroiImpRecordType
		{
			get
			{
				return GetColumnValue("FROI_IMP_RECORD_TYPE");
			}
			set
			{
				SetColumnValue("FROI_IMP_RECORD_TYPE", value);
			}
		}
		#endregion

		#region IFroiImportField Members

		/// <summary>
		/// 
		/// </summary>
		public string FunctionName
		{
			get { return GetColumnValue("FUNCTION_NAME"); }
		}

		/// <summary>
		/// 
		/// </summary>
		public int ConversionCount
		{
			get { return GetColumnValueAsInt("CONV_COUNT") ?? 0; }
		}

		#endregion

		
		/// <summary>
		/// Gets the type of the import fields by record type and instance.
		/// </summary>
		public static FroiImportFields GetImportFieldsByRecordType(string recordType, string instance)
		{
		  var query =
		    string.Format(
		      "select * from FROI_IMP_MAP where FROI_IMP_RECORD_ID = (SELECT FROI_IMP_RECORD_ID from FROI_IMP_RECORD where FROI_IMP_RECORD_TYPE = '{0}') order by STARTPOS",
		      recordType);
		  return GetImportFields(instance, query);
		}

	  private static FroiImportFields GetImportFields(string instance, string query)
	  {
      var results = new FroiImportFields
      {
        Instance = instance,
        Query = query
      };

      results.Execute();
      return results;
	  }

    public static FroiImportFields GetImportFieldsByLobType(string instance, string lob, string recordType)
    {
      var query =
        string.Format(
          "select * from FROI_IMP_MAP where FROI_IMP_RECORD_ID = (SELECT FROI_IMP_RECORD_ID from FROI_IMP_RECORD where FROI_IMP_RECORD_TYPE = '{0}' AND FROI_LOB_CD = '{1}') order by STARTPOS",
          recordType, lob);

		  return GetImportFields(instance, query);
    }
		
		#region Update
		/// <summary>
		/// Generates the update SQL.
		/// </summary>
		protected override string GenerateUpdateSql()
		{
			var sql = new StringBuilder();
			sql.AppendFormat("UPDATE {0} SET ", Name);
			sql.AppendLine("ATTRIBUTE_NAME = :1, STARTPOS = :2, LENGTH = :3, LEGACY_FIELD_NAME = :4, DATA_DEFINITION = :5, DEFAULT_VALUE = :6");
			sql.Append(GeneratePrimaryKeyWhereClause());
			return sql.ToString();
		}

		/// <summary>
		/// If you use parameters in your update SQL
		/// You must also override this method to add
		/// their corresponding values from properties.
		/// </summary>
		protected override void AddUpdateParameters()
		{
			AddParameter(AttributeName);
			AddParameter(StartPosition);
			AddParameter(Length);
			AddParameter(LegacyFieldName);
			AddParameter(DataDefinition);
			AddParameter(DefaultValue);
		}
		
		#endregion

		#region Delete

		/// <summary>
		/// Generates the delete SQL
		/// subclasses must implement this explicitely
		/// for delete to work.  Carefully we presume...
		/// </summary>
		/// <returns></returns>
		protected override string GenerateDeleteSql()
		{
			var sql = new StringBuilder();
			sql.AppendFormat("DELETE FROM {0} ", Name);
			sql.Append(GeneratePrimaryKeyWhereClause());
			return sql.ToString();
		}

		#endregion

		#region IImportField Members


		/// <summary>
		/// Gets the corresponding field index or start position.
		/// </summary>
		/// <value></value>
		public int Index
		{
			get { return StartPosition; }
		}

		/// <summary>
		/// Gets the filed name (which could be a composite in some cases.)
		/// </summary>
		/// <value></value>
		public new string FullName
		{
			get { return (DataDefinition.Length > 0 ? string.Format("{0}.{1}", DataDefinition, AttributeName) : AttributeName); }
		}

		#endregion
	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Import/FroiImportField.cs $ 
 * 
 * 6     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 5     2/23/10 2:53p Gwynnj
 * Added CallRouting support
 * 
 * 4     9/29/09 6:05p John.gwynn
 * Added DepartmentCodes for Esis Excel Load
 * 
 * 3     9/25/09 2:37p John.gwynn
 * Added ActiveRecordSet<T> to achieve covariance with respect to the
 * IEnumerable<ActiveRecord> base implementation for articulating strongly
 * typed repositories.
 * 
 * 2     9/22/09 11:06a John.gwynn
 * Import Field updates
 * 
 * 1     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     5/26/09 9:39a Varun.jain
 * 
 * 2     1/21/09 1:32p John.gwynn
 * fixed SS keyword bug and added UserId to the CallRecord update
 */
#endregion