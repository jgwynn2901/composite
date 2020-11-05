#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by Innovation First Notice 
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/UserRecord.cs 4     7/13/10 11:39a Gwynnj $ */
#endregion
using System;
using System.Data;
using System.Globalization;
using DbClassLibrary.ActiveRecords;

namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// Encapsulates a record from the USERS table
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class UserRecord : EncryptedActiveRecord
	{
		private const string Table = "USERS";
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="UserRecord"/> class.
		/// </summary>
		public UserRecord()
			: base(Table)
		{
			// Begin Generated Column Definitions
			columns.Add(new Column("USER_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("SITE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("PASSWORD", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CREATED_DT", String.Empty, "DATE"));
			columns.Add(new Column("ACTIVE", String.Empty, "CHAR"));
			columns.Add(new Column("LAST_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FIRST_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDRESS_LINE_1", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDRESS_LINE_2", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CITY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STATE", String.Empty, "CHAR"));
			columns.Add(new Column("ZIP_CODE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("PHONE_WORK", String.Empty, "VARCHAR2"));
			columns.Add(new Column("PHONE_WORK_EXTENSION", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FAX_NUMBER", String.Empty, "VARCHAR2"));
			columns.Add(new Column("EMAIL_ADDRESS", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CALLER_TYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CALLER_DEPARTMENT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SUPERVISOR_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SUPERVISOR_PHONE_WORK", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SUPERVISOR_PHONE_EXTENSION", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACTIVE_START_DATE", String.Empty, "DATE"));
			columns.Add(new Column("ACTIVE_END_DATE", String.Empty, "DATE"));
			columns.Add(new Column("PASSWORD_CREATION_DATE", String.Empty, "DATE"));
			columns.Add(new Column("PASSWORD_EXPIRATION_DATE", String.Empty, "DATE"));
			columns.Add(new Column("LAST_CHANGE_DATE", String.Empty, "DATE"));
			columns.Add(new Column("NEW_USER", String.Empty, "CHAR"));
			columns.Add(new Column("INTERNET_USER", String.Empty, "CHAR"));
			columns.Add(new Column("REUSE", String.Empty, "CHAR"));
			columns.Add(new Column("PHONE_MOBILE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("TITLE", String.Empty, "VARCHAR2"));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UserRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public UserRecord(IDataReader reader)
			: base(reader, Table)
		{
		}
		#endregion

    protected override void InitEncryption()
    {
      if (!Instance.StartsWith("SED", StringComparison.InvariantCultureIgnoreCase)) return;
      EncryptAttributes.Clear();
      EncryptAttributes.Add("NAME");
      EncryptAttributes.Add("PASSWORD");
      EncryptAttributes.Add("LAST_NAME");
      EncryptAttributes.Add("FIRST_NAME");
      EncryptAttributes.Add("PHONE_WORK");
    }

		#region UserId
		/// <summary>
		/// Gets or sets the user id.
		/// </summary>
		/// <value>The user id.</value>
		public int UserId
		{
			get
			{
				return GetColumnValueAsInt("USER_ID") ?? 0;
			}
			set
			{
				SetColumnValue("USER_ID", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion
		#region SiteId
		/// <summary>
		/// Gets or sets the site id.
		/// </summary>
		/// <value>The site id.</value>
		public string SiteId
		{
			get
			{
				return GetColumnValue("SITE_ID");
			}
			set
			{
				SetColumnValue("SITE_ID", value);
			}
		}
		#endregion
		#region UserName
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		public string UserName
		{
			get
			{
				return GetColumnValue("NAME");
			}
			set
			{
				SetColumnValue("NAME", value);
			}
		}
		#endregion
		#region Password
		/// <summary>
		/// Gets or sets the password.
		/// </summary>
		/// <value>The password.</value>
		public string Password
		{
			get
			{
				return GetColumnValue("PASSWORD");
			}
			set
			{
				SetColumnValue("PASSWORD", value);
			}
		}
		#endregion
		#region CreatedDt
		/// <summary>
		/// Gets or sets the created dt.
		/// </summary>
		/// <value>The created dt.</value>
		public string CreatedDt
		{
			get
			{
				return GetColumnValue("CREATED_DT");
			}
			set
			{
				SetColumnValue("CREATED_DT", value);
			}
		}
		#endregion
		#region Active
		/// <summary>
		/// Gets or sets the active.
		/// </summary>
		/// <value>The active.</value>
		public string Active
		{
			get
			{
				return GetColumnValue("ACTIVE");
			}
			set
			{
				SetColumnValue("ACTIVE", value);
			}
		}
		#endregion
		#region LastName
		/// <summary>
		/// Gets or sets the name of the last.
		/// </summary>
		/// <value>The name of the last.</value>
		public string LastName
		{
			get
			{
				return GetColumnValue("LAST_NAME");
			}
			set
			{
				SetColumnValue("LAST_NAME", value);
			}
		}
		#endregion
		#region FirstName
		/// <summary>
		/// Gets or sets the name of the first.
		/// </summary>
		/// <value>The name of the first.</value>
		public string FirstName
		{
			get
			{
				return GetColumnValue("FIRST_NAME");
			}
			set
			{
				SetColumnValue("FIRST_NAME", value);
			}
		}
		#endregion
		#region AddressLine1
		/// <summary>
		/// Gets or sets the address line1.
		/// </summary>
		/// <value>The address line1.</value>
		public string AddressLine1
		{
			get
			{
				return GetColumnValue("ADDRESS_LINE_1");
			}
			set
			{
				SetColumnValue("ADDRESS_LINE_1", value);
			}
		}
		#endregion
		#region AddressLine2
		/// <summary>
		/// Gets or sets the address line2.
		/// </summary>
		/// <value>The address line2.</value>
		public string AddressLine2
		{
			get
			{
				return GetColumnValue("ADDRESS_LINE_2");
			}
			set
			{
				SetColumnValue("ADDRESS_LINE_2", value);
			}
		}
		#endregion
		#region City
		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City
		{
			get
			{
				return GetColumnValue("CITY");
			}
			set
			{
				SetColumnValue("CITY", value);
			}
		}
		#endregion
		#region State
		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		public string State
		{
			get
			{
				return GetColumnValue("STATE");
			}
			set
			{
				SetColumnValue("STATE", value);
			}
		}
		#endregion
		#region ZipCode
		/// <summary>
		/// Gets or sets the zip code.
		/// </summary>
		/// <value>The zip code.</value>
		public string ZipCode
		{
			get
			{
				return GetColumnValue("ZIP_CODE");
			}
			set
			{
				SetColumnValue("ZIP_CODE", value);
			}
		}
		#endregion
		#region PhoneWork
		/// <summary>
		/// Gets or sets the phone work.
		/// </summary>
		/// <value>The phone work.</value>
		public string PhoneWork
		{
			get
			{
				return GetColumnValue("PHONE_WORK");
			}
			set
			{
				SetColumnValue("PHONE_WORK", value);
			}
		}
		#endregion
		#region PhoneWorkExtension
		/// <summary>
		/// Gets or sets the phone work extension.
		/// </summary>
		/// <value>The phone work extension.</value>
		public string PhoneWorkExtension
		{
			get
			{
				return GetColumnValue("PHONE_WORK_EXTENSION");
			}
			set
			{
				SetColumnValue("PHONE_WORK_EXTENSION", value);
			}
		}
		#endregion
		#region FaxNumber
		/// <summary>
		/// Gets or sets the fax number.
		/// </summary>
		/// <value>The fax number.</value>
		public string FaxNumber
		{
			get
			{
				return GetColumnValue("FAX_NUMBER");
			}
			set
			{
				SetColumnValue("FAX_NUMBER", value);
			}
		}
		#endregion
		#region EmailAddress
		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		/// <value>The email address.</value>
		public string EmailAddress
		{
			get
			{
				return GetColumnValue("EMAIL_ADDRESS");
			}
			set
			{
				SetColumnValue("EMAIL_ADDRESS", value);
			}
		}
		#endregion
		#region CallerType
		/// <summary>
		/// Gets or sets the type of the caller.
		/// </summary>
		/// <value>The type of the caller.</value>
		public string CallerType
		{
			get
			{
				return GetColumnValue("CALLER_TYPE");
			}
			set
			{
				SetColumnValue("CALLER_TYPE", value);
			}
		}
		#endregion
		#region CallerDepartment
		/// <summary>
		/// Gets or sets the caller department.
		/// </summary>
		/// <value>The caller department.</value>
		public string CallerDepartment
		{
			get
			{
				return GetColumnValue("CALLER_DEPARTMENT");
			}
			set
			{
				SetColumnValue("CALLER_DEPARTMENT", value);
			}
		}
		#endregion
		#region SupervisorName
		/// <summary>
		/// Gets or sets the name of the supervisor.
		/// </summary>
		/// <value>The name of the supervisor.</value>
		public string SupervisorName
		{
			get
			{
				return GetColumnValue("SUPERVISOR_NAME");
			}
			set
			{
				SetColumnValue("SUPERVISOR_NAME", value);
			}
		}
		#endregion
		#region SupervisorPhoneWork
		/// <summary>
		/// Gets or sets the supervisor phone work.
		/// </summary>
		/// <value>The supervisor phone work.</value>
		public string SupervisorPhoneWork
		{
			get
			{
				return GetColumnValue("SUPERVISOR_PHONE_WORK");
			}
			set
			{
				SetColumnValue("SUPERVISOR_PHONE_WORK", value);
			}
		}
		#endregion
		#region SupervisorPhoneExtension
		/// <summary>
		/// Gets or sets the supervisor phone extension.
		/// </summary>
		/// <value>The supervisor phone extension.</value>
		public string SupervisorPhoneExtension
		{
			get
			{
				return GetColumnValue("SUPERVISOR_PHONE_EXTENSION");
			}
			set
			{
				SetColumnValue("SUPERVISOR_PHONE_EXTENSION", value);
			}
		}
		#endregion
		#region ActiveStartDate
		/// <summary>
		/// Gets or sets the active start date.
		/// </summary>
		/// <value>The active start date.</value>
		public string ActiveStartDate
		{
			get
			{
				return GetColumnValue("ACTIVE_START_DATE");
			}
			set
			{
				SetColumnValue("ACTIVE_START_DATE", value);
			}
		}
		#endregion
		#region ActiveEndDate
		/// <summary>
		/// Gets or sets the active end date.
		/// </summary>
		/// <value>The active end date.</value>
		public string ActiveEndDate
		{
			get
			{
				return GetColumnValue("ACTIVE_END_DATE");
			}
			set
			{
				SetColumnValue("ACTIVE_END_DATE", value);
			}
		}
		#endregion
		#region PasswordCreationDate
		/// <summary>
		/// Gets or sets the password creation date.
		/// </summary>
		/// <value>The password creation date.</value>
		public string PasswordCreationDate
		{
			get
			{
				return GetColumnValue("PASSWORD_CREATION_DATE");
			}
			set
			{
				SetColumnValue("PASSWORD_CREATION_DATE", value);
			}
		}
		#endregion
		#region PasswordExpirationDate
		/// <summary>
		/// Gets or sets the password expiration date.
		/// </summary>
		/// <value>The password expiration date.</value>
		public string PasswordExpirationDate
		{
			get
			{
				return GetColumnValue("PASSWORD_EXPIRATION_DATE");
			}
			set
			{
				SetColumnValue("PASSWORD_EXPIRATION_DATE", value);
			}
		}
		#endregion
		#region LastChangeDate
		/// <summary>
		/// Gets or sets the last change date.
		/// </summary>
		/// <value>The last change date.</value>
		public string LastChangeDate
		{
			get
			{
				return GetColumnValue("LAST_CHANGE_DATE");
			}
			set
			{
				SetColumnValue("LAST_CHANGE_DATE", value);
			}
		}
		#endregion
		#region NewUser
		/// <summary>
		/// Gets or sets the new user.
		/// </summary>
		/// <value>The new user.</value>
		public string NewUser
		{
			get
			{
				return GetColumnValue("NEW_USER");
			}
			set
			{
				SetColumnValue("NEW_USER", value);
			}
		}
		#endregion
		#region InternetUser
		/// <summary>
		/// Gets or sets the internet user.
		/// </summary>
		/// <value>The internet user.</value>
		public string InternetUser
		{
			get
			{
				return GetColumnValue("INTERNET_USER");
			}
			set
			{
				SetColumnValue("INTERNET_USER", value);
			}
		}
		#endregion
		#region Reuse
		/// <summary>
		/// Gets or sets the reuse.
		/// </summary>
		/// <value>The reuse.</value>
		public string Reuse
		{
			get
			{
				return GetColumnValue("REUSE");
			}
			set
			{
				SetColumnValue("REUSE", value);
			}
		}
		#endregion
		#region PhoneMobile
		/// <summary>
		/// Gets or sets the phone mobile.
		/// </summary>
		/// <value>The phone mobile.</value>
		public string PhoneMobile
		{
			get
			{
				return GetColumnValue("PHONE_MOBILE");
			}
			set
			{
				SetColumnValue("PHONE_MOBILE", value);
			}
		}
		#endregion
		#region Title
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		public string Title
		{
			get
			{
				return GetColumnValue("TITLE");
			}
			set
			{
				SetColumnValue("TITLE", value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/UserRecord.cs $
 * 
 * 4     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 3     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 2     5/26/09 11:06a John.gwynn
 * Added interop definitions
 * 
 * 1     6/26/07 2:43p John.gwynn
 */
#endregion