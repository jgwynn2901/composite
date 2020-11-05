using System;
using System.Collections.Generic;
using System.Data;

namespace DbClassLibrary.Import
{
	/// <summary>
	/// FROI_IMPORT_RECORD
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class ImportRecordType : ActiveRecord
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="FroiImportField"/> class.
		/// </summary>
		public ImportRecordType()
			: base("FROI_IMP_RECORD")
		{
			columns.Add(new Column("FROI_IMP_RECORD_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("FROI_FILE_DEF_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("FROI_IMP_RECORD_TYPE", String.Empty, "CHAR"));
			columns.Add(new Column("FROI_IMP_RECORD_DESC", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FROI_LOB_CD", String.Empty, "CHAR"));
			columns.Add(new Column("CREATED_DT", String.Empty, "DATE"));
			columns.Add(new Column("LAST_MODIFIED_DT", String.Empty, "DATE"));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ImportRecordType"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public ImportRecordType(IDataReader reader)
			: base(reader, "FROI_IMP_RECORD")
		{ }

		#endregion

		#region FroiImpRecordId
		/// <summary>
		/// FROI_IMP_RECORD_ID
		/// </summary>
		public string FroiImpRecordId
		{
			get { return GetColumnValue("FROI_IMP_RECORD_ID"); }
			set { SetColumnValue("FROI_IMP_RECORD_ID", value); }
		}
		#endregion

		#region FroiFileDefId
		/// <summary>
		/// FROI_FILE_DEF_ID
		/// </summary>
		public string FroiFileDefId
		{
			get { return GetColumnValue("FROI_FILE_DEF_ID"); }
			set { SetColumnValue("FROI_FILE_DEF_ID", value); }
		}
		#endregion

		#region FroiImpRecordType
		/// <summary>
		/// FROI_IMP_RECORD_TYPE
		/// </summary>
		public string FroiImpRecordType
		{
			get { return GetColumnValue("FROI_IMP_RECORD_TYPE").Trim(); }
			set { SetColumnValue("FROI_IMP_RECORD_TYPE", value); }
		}
		#endregion

		#region FroiImpRecordDecription
		/// <summary>
		/// FROI_IMP_RECORD_DESC
		/// </summary>
		public string FroiImpRecordDecription
		{
			get { return GetColumnValue("FROI_IMP_RECORD_DESC"); }
			set { SetColumnValue("FROI_IMP_RECORD_DESC", value); }
		}
		#endregion

		#region FroiLobCode
		/// <summary>
		/// FROI_LOB_CD
		/// </summary>
		public string FroiLobCode
		{
			get { return GetColumnValue("FROI_LOB_CD"); }
			set { SetColumnValue("FROI_LOB_CD", value); }
		}
		#endregion

		#region CreatedDate
		/// <summary>
		/// CREATED_DT
		/// </summary>
		public string CreatedDate
		{
			get { return GetColumnValue("CREATED_DT"); }
		}
		#endregion

		#region LastModifiedDate
		/// <summary>
		/// LAST_MODIFIED_DT
		/// </summary>
		public string LastModifiedDate
		{
			get { return GetColumnValue("LAST_MODIFIED_DT"); }
		}
		#endregion

		/// <summary>
		/// Gets the record types.
		/// </summary>
		public static IEnumerable<ImportRecordType> GetRecordTypes()
		{
			return GetRecordTypes(ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the record types for the given instance.
		/// </summary>
		public static IEnumerable<ImportRecordType> GetRecordTypes(string instance)
		{
			var results = new ImportRecordTypes
			{
				Instance = instance,
				Query = "select * from FROI_IMP_RECORD order by FROI_IMP_RECORD_DESC"
			};

			results.Execute();

			foreach (ImportRecordType t in results)
				yield return t;
		}

		/// <summary>
		/// Gets the record type by id.
		/// </summary>
		public static string GetRecordTypeById(string recordTypeId, string instance)
		{
			var results = new ImportRecordType {Instance = instance, FroiImpRecordId = recordTypeId};
			return results.Execute() ? results.FroiImpRecordType : "";
		}

	}
}
