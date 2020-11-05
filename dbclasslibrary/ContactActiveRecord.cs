using System;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	[ComVisible(false)]
	public class ContactActiveRecord : ActiveRecord
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactActiveRecord"/> class.
		/// </summary>
		public ContactActiveRecord() :base("CONTACT")
		{
			columns.Add(new Column("CONTACT_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACCNT_HRCY_STEP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("PHONE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("TYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("TITLE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DESCRIPTION", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FAX", String.Empty, "VARCHAR2"));
			columns.Add(new Column("EMAIL", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ENABLE_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("FILE_TRANSMISSION_LOG_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ADDRESS_LINE1", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDRESS_LINE2", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CITY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STATE", String.Empty, "CHAR"));
			columns.Add(new Column("ZIP", String.Empty, "CHAR"));
			columns.Add(new Column("UPLOAD_KEY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("COUNTRY", String.Empty, "VARCHAR2"));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactActiveRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public ContactActiveRecord(IDataReader reader)
			: base(reader, "CONTACT")
		{}

		#region ContactId
		/// <summary>
		/// CONTACT_ID
		/// </summary>
		public string ContactId
		{

			get { return GetColumnValue("CONTACT_ID"); }
			set { SetColumnValue("CONTACT_ID", value); }
		}
		#endregion

		#region ContactName
		/// <summary>
		/// NAME
		/// </summary>
		public string ContactName
		{

			get { return GetColumnValue("NAME"); }
			set { SetColumnValue("NAME", value); }
		}
		#endregion

		#region AccntHrcyStepId
		/// <summary>
		/// ACCNT_HRCY_STEP_ID
		/// </summary>
		public string AccntHrcyStepId
		{

			get { return GetColumnValue("ACCNT_HRCY_STEP_ID"); }
			set { SetColumnValue("ACCNT_HRCY_STEP_ID", value); }
		}
		#endregion

		#region Phone
		/// <summary>
		/// PHONE
		/// </summary>
		public string Phone
		{

			get { return GetColumnValue("PHONE"); }
			set { SetColumnValue("PHONE", value); }
		}
		#endregion

		#region Type
		/// <summary>
		/// TYPE
		/// </summary>
		public string Type
		{

			get { return GetColumnValue("TYPE"); }
			set { SetColumnValue("TYPE", value); }
		}
		#endregion

		#region Title
		/// <summary>
		/// TITLE
		/// </summary>
		public string Title
		{

			get { return GetColumnValue("TITLE"); }
			set { SetColumnValue("TITLE", value); }
		}
		#endregion

		#region Description
		/// <summary>
		/// DESCRIPTION
		/// </summary>
		public string Description
		{

			get { return GetColumnValue("DESCRIPTION"); }
			set { SetColumnValue("DESCRIPTION", value); }
		}
		#endregion

		#region Fax
		/// <summary>
		/// FAX
		/// </summary>
		public string Fax
		{

			get { return GetColumnValue("FAX"); }
			set { SetColumnValue("FAX", value); }
		}
		#endregion

		#region Email
		/// <summary>
		/// EMAIL
		/// </summary>
		public string Email
		{

			get { return GetColumnValue("EMAIL"); }
			set { SetColumnValue("EMAIL", value); }
		}
		#endregion

		#region EnableFlag
		/// <summary>
		/// ENABLE_FLG
		/// </summary>
		public string EnableFlag
		{

			get { return GetColumnValue("ENABLE_FLG"); }
			set { SetColumnValue("ENABLE_FLG", value); }
		}
		#endregion

		#region FileTransmissionLogId
		/// <summary>
		/// FILE_TRANSMISSION_LOG_ID
		/// </summary>
		public string FileTransmissionLogId
		{

			get { return GetColumnValue("FILE_TRANSMISSION_LOG_ID"); }
			set { SetColumnValue("FILE_TRANSMISSION_LOG_ID", value); }
		}
		#endregion

		#region AddressLine1
		/// <summary>
		/// ADDRESS_LINE1
		/// </summary>
		public string AddressLine1
		{

			get { return GetColumnValue("ADDRESS_LINE1"); }
			set { SetColumnValue("ADDRESS_LINE1", value); }
		}
		#endregion

		#region AddressLine2
		/// <summary>
		/// ADDRESS_LINE2
		/// </summary>
		public string AddressLine2
		{

			get { return GetColumnValue("ADDRESS_LINE2"); }
			set { SetColumnValue("ADDRESS_LINE2", value); }
		}
		#endregion

		#region City
		/// <summary>
		/// CITY
		/// </summary>
		public string City
		{

			get { return GetColumnValue("CITY"); }
			set { SetColumnValue("CITY", value); }
		}
		#endregion

		#region State
		/// <summary>
		/// STATE
		/// </summary>
		public string State
		{

			get { return GetColumnValue("STATE"); }
			set { SetColumnValue("STATE", value); }
		}
		#endregion

		#region Zip
		/// <summary>
		/// ZIP
		/// </summary>
		public string Zip
		{

			get { return GetColumnValue("ZIP"); }
			set { SetColumnValue("ZIP", value); }
		}
		#endregion

		#region UploadKey
		/// <summary>
		/// UPLOAD_KEY
		/// </summary>
		public string UploadKey
		{

			get { return GetColumnValue("UPLOAD_KEY"); }
			set { SetColumnValue("UPLOAD_KEY", value); }
		}
		#endregion

		#region Country
		/// <summary>
		/// COUNTRY
		/// </summary>
		public string Country
		{

			get { return GetColumnValue("COUNTRY"); }
			set { SetColumnValue("COUNTRY", value); }
		}
		#endregion
	}
}
