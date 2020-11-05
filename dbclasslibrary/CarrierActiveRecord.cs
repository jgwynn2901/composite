using System.Data;
using System;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	public class CarrierActiveRecord : ActiveRecord
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		private const string _tableName = "CARRIER";
		
		/// <summary>
		/// Initializes a new instance of the <see cref="PolicyActiveRecord"/> class.
		/// </summary>
		public CarrierActiveRecord()
			: base(_tableName)
		{
			columns.Add(new Column("CARRIER_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("TITLE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("BUSINESS_TYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDRESS1", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDRESS2", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CITY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STATE", String.Empty, "CHAR"));
			columns.Add(new Column("ZIP", String.Empty, "VARCHAR2"));
			columns.Add(new Column("PHONE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FEIN", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CARRIER_NUMBER", String.Empty, "VARCHAR2"));
			columns.Add(new Column("BUREAU_CD", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FILE_TRANSMISSION_LOG_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("UPLOAD_KEY", String.Empty, "VARCHAR2"));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PolicyActiveRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public CarrierActiveRecord(IDataReader reader)
			: base(reader, _tableName)
		{ }

		#endregion 

		#region CarrierId
		/// <summary>
		/// CARRIER_ID
		/// </summary>
		public string CarrierId
		{

			get { return GetColumnValue("CARRIER_ID"); }
			set { SetColumnValue("CARRIER_ID", value); }
		}
		#endregion

		#region CarrierName
		/// <summary>
		/// NAME
		/// </summary>
		public string CarrierName
		{

			get { return GetColumnValue("NAME"); }
			set { SetColumnValue("NAME", value); }
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

		#region BusinessType
		/// <summary>
		/// BUSINESS_TYPE
		/// </summary>
		public string BusinessType
		{

			get { return GetColumnValue("BUSINESS_TYPE"); }
			set { SetColumnValue("BUSINESS_TYPE", value); }
		}
		#endregion

		#region Address1
		/// <summary>
		/// ADDRESS1
		/// </summary>
		public string Address1
		{

			get { return GetColumnValue("ADDRESS1"); }
			set { SetColumnValue("ADDRESS1", value); }
		}
		#endregion

		#region Address2
		/// <summary>
		/// ADDRESS2
		/// </summary>
		public string Address2
		{

			get { return GetColumnValue("ADDRESS2"); }
			set { SetColumnValue("ADDRESS2", value); }
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

		#region Fein
		/// <summary>
		/// FEIN
		/// </summary>
		public string Fein
		{

			get { return GetColumnValue("FEIN"); }
			set { SetColumnValue("FEIN", value); }
		}
		#endregion

		#region CarrierNumber
		/// <summary>
		/// CARRIER_NUMBER
		/// </summary>
		public string CarrierNumber
		{

			get { return GetColumnValue("CARRIER_NUMBER"); }
			set { SetColumnValue("CARRIER_NUMBER", value); }
		}
		#endregion

		#region BureauCode
		/// <summary>
		/// BUREAU_CD
		/// </summary>
		public string BureauCode
		{
			get { return GetColumnValue("BUREAU_CD"); }
			set { SetColumnValue("BUREAU_CD", value); }
		}
		#endregion

		#region FileTransmissionLogId
		/// <summary>
		/// FILE_TRANSMISSION_LOG_ID
		/// </summary>
		public string FileTransmissionLogId
		{
			get { return GetColumnValue("FILE_TRANSMISSION_LOG_ID"); }
		}
		#endregion

		#region UploadKey
		/// <summary>
		/// UPLOAD_KEY
		/// </summary>
		public string UploadKey
		{

			get { return GetColumnValue("UPLOAD_KEY"); }
		}
		#endregion
	}
}
