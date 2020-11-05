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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Security/User.cs 10    7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using DbClassLibrary.ActiveRecords;

namespace DbClassLibrary.Security
{
  /// <summary>
  /// Encapsulates the USERS table
  /// </summary>
  [System.Runtime.InteropServices.ComVisible(false), TableDefinition(TableName = "FNSOWNER.USERS")]
  public class User : EncryptedActiveRecord
  {
    private string _accountId;
    private AhsRecord _accountRecord;

    /// <summary>
    /// 
    /// </summary>
    public struct AccessPermission
    {
      /// <summary>
      /// Function or process
      /// </summary>
      public string Function;
      /// <summary>
      /// View/Modify etc.
      /// </summary>
      public string AccessType;

      /// <summary>
      /// Initializes a new instance of the <see cref="AccessPermission"/> struct.
      /// </summary>
      /// <param name="function">The function.</param>
      /// <param name="access">The access.</param>
      public AccessPermission(string function, string access)
      {
        Function = function;
        AccessType = access;
      }
    }

    private List<AccessPermission> _lazyAccessPermissions;
    private List<AccessPermission> _lazyGroupPermissions;
    private Dictionary<string, string> _lazyExtensions; 

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="User"/> class.
    /// </summary>
    public User()
      : base("USERS")
    {
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
    /// Initializes a new instance of the <see cref="User"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public User(IDataReader reader)
      : base(reader, "USERS")
    { }

    #endregion

    #region UserId
    /// <summary>
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "USER_ID")]
    public string Id { get { return GetColumnValue("USER_ID"); } set { SetColumnValue("USER_ID", value); } }

    /// <summary>
    /// Gets or sets the user id.
    /// </summary>
    public int UserId
    {
      get
      {
        return GetColumnValueAsInt("USER_ID") ?? -1;
      }
      set
      {
        SetColumnValue("USER_ID", value.ToString(CultureInfo.InvariantCulture));
      }
    }
    #endregion
    #region SiteId
    /// <summary>
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "SITE_ID")]
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
    #region Name
    /// <summary>
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "NAME", encrypt = true)]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "PASSWORD", encrypt = true)]
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
    /// 
    /// </summary>
    public string CreatedDt
    {
      get
      {
        return GetColumnValue("CREATED_DT");
      }

    }
    #endregion
    #region Active
    /// <summary>
    /// 
    /// </summary>
    [FieldDefintion]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "LAST_NAME")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "FIRST_NAME")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "ADDRESS_LINE_1")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "ADDRESS_LINE_2")]
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
    /// 
    /// </summary>
    [FieldDefintion]
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
    /// 
    /// </summary>
    [FieldDefintion]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "ZIP_CODE")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "PHONE_WORK")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "PHONE_WORK_EXTENSION")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "FAX_NUMBER")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "EMAIL_ADDRESS")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "CALLER_TYPE")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "CALLER_DEPARTMENT")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "SUPERVISOR_NAME")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "SUPERVISOR_PHONE_WORK")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "SUPERVISOR_PHONE_EXTENSION")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "ACTIVE_START_DATE")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "ACTIVE_END_DATE")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "PASSWORD_CREATION_DATE")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "PASSWORD_EXPIRATION_DATE")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "LAST_CHANGE_DATE")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "NEW_USER")]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "INTERNET_USER")]
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
    /// 
    /// </summary>
    [FieldDefintion]
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
    /// 
    /// </summary>
    [FieldDefintion(FieldName = "PHONE_MOBILE")]
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
    /// 
    /// </summary>
    [FieldDefintion]
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

    /// <summary>
    /// Initializes the encryption.
    /// </summary>
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

    /// <summary>
    /// Gets the account id.
    /// </summary>
    /// <value>The account id.</value>
    public string AccountId
    {
      get
      {
        if (string.IsNullOrEmpty(_accountId))
        {
          var rec = new ActiveRecord("ACCOUNT_USER") { Instance = Instance };
          rec.Initialize();
          rec.Where = "user_id = :1";
          rec.AddParameter(UserId);
          if (rec.Execute())
            _accountId = rec.GetColumnValue("ACCNT_HRCY_STEP_ID");
        }
        return _accountId;

      }
    }

    /// <summary>
    /// Gets the account.
    /// </summary>
    /// <returns></returns>
    public AhsRecord Account
    {
      get
      {
        if (!string.IsNullOrEmpty(AccountId) && _accountRecord == null)
        {
          _accountRecord = new AhsRecord(Instance) { AhsId = AccountId };
          if (!_accountRecord.Execute())
            _accountRecord.Reset();
        }
        return _accountRecord;
      }
    }

    /// <summary>
    /// Gets the access permissions list.
    /// </summary>
    /// <value>The access permissions list.</value>
    public List<AccessPermission> AccessPermissionsList
    {
      get
      {
        if (_lazyAccessPermissions == null)
          _lazyAccessPermissions = BuildAccessPermissions();

        return _lazyAccessPermissions;
      }
    }

    /// <summary>
    /// Gets the group permissions list.
    /// </summary>
    /// <value>The group permissions list.</value>
    public List<AccessPermission> GroupPermissionsList
    {
      get { return _lazyGroupPermissions ?? (_lazyGroupPermissions = BuildGroupPermissions()); }
    }

    public Dictionary<string, string> Extensions
    {
      get { return _lazyExtensions ?? (_lazyExtensions = BuildExtensions()); }
       
    }

    /// <summary>
    /// Builds the extensions.
    /// </summary>
    /// <returns></returns>
    private Dictionary<string, string> BuildExtensions()
    {
      var results = new Dictionary<string, string>();
      var records = new ActiveRecordSet { Query = "select FIELD_NAME, FIELD_VALUE from USER_EXT where USER_ID = :user_id", Instance = Instance };
      records.AddParameter("user_id", UserId);
      if (!records.Execute()) return results;
      foreach (ActiveRecord rec in records)
      {
        results.Add(rec.GetColumnValue("FIELD_NAME"), rec.GetColumnValue("FIELD_VALUE"));
      }
      return results;
    }

    /// <summary>
    /// Gets the access permission as delimited strings.
    /// </summary>
    /// <value>The user access permissions.</value>
    public string AccessPermissions
    {
      get
      {
        if (_lazyAccessPermissions == null)
          _lazyAccessPermissions = BuildAccessPermissions();
        return BuildPermissionsString(_lazyAccessPermissions);
      }
    }

    /// <summary>
    /// Gets the group permissions as delimited string.
    /// </summary>
    /// <value>The group access permissions.</value>
    public string GroupPermissions
    {
      get
      {
        if (_lazyGroupPermissions == null)
          _lazyGroupPermissions = BuildGroupPermissions();

        return BuildPermissionsString(_lazyGroupPermissions);
      }
    }

    /// <summary>
    /// Adds or updates the extension value by name.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    public bool AddExtension(string name, string value)
    {
      string query;
      if (Extensions.ContainsKey(name) && Extensions[name] != value)
      {
        query =
          string.Format(
            "update USER_EXT set FIELD_VALUE = '{0}' where user_id = {1} and FIELD_NAME = '{2}'", value,
            UserId, name);
      }
      else
      {
        query =
          string.Format(
            "insert into USER_EXT (USER_ID, FIELD_NAME, FIELD_VALUE) VALUES({0}, '{1}', '{2}')", UserId, name, value);
      }
      return GeneralUtility.ExecuteNonQuery(query);
    }

    public string GetOrCreatePseudonym()
    {
      var results = GetPseudonym();
      if (!string.IsNullOrEmpty(results)) return results;
      return CreatePseudonym() ? GetPseudonym() : string.Empty;
    }

    private string GetPseudonym()
    {
      using (
        var reader = GeneralUtility.ExecuteReader("select PSEUDO_TOKEN from users_ext where user_id = :1",
          new object[] { UserId }))
      {
        if (reader.Read())
        {
          return reader.GetValue(0).ToString();
        }
      }
      return string.Empty;
    }

    private bool CreatePseudonym()
    {
      IDictionary<string, object> parms = new Dictionary<string, object>();
      parms.Add("ccUserId", UserId);
      parms.Add("ccEmailAddress", EmailAddress);
      var results =
        GeneralUtility.ExecuteNonQueryWithParms(
          "insert into users_ext values(null, :ccUserId, DBMS_CRYPTO.hash(utl_raw.cast_to_raw(:ccEmailAddress), 3))",
          GeneralUtility.GetDbInstanceFromRegistry(),
          parms);
      
      return results;
    }

    private List<AccessPermission> BuildAccessPermissions()
    {
      var sql = new StringBuilder();

      sql.Append("select upper(function_nm) as FUNCTION_NAME, upper(accesstype) as ACCESS_TYPE from accesspermissions,");
      sql.Append("function, accesstype where accesspermissions.function_id=function.function_id and ");
      sql.Append("accesspermissions.accesstype_id=accesstype.accesstype_id and user_id = :1 order by 1, 2");

      return BuildPermissions(sql.ToString());
    }

    private List<AccessPermission> BuildGroupPermissions()
    {
      var sql = new StringBuilder();
      sql.Append("select upper(function_nm) as FUNCTION_NAME, upper(accesstype) as ACCESS_TYPE from accesspermissions,");
      sql.Append("user_group, function, accesstype where user_group.group_id=AccessPermissions.group_id and ");
      sql.Append("accesspermissions.function_id=function.function_id and ");
      sql.Append("accesspermissions.accesstype_id=accesstype.accesstype_id and user_group.user_id = :1 order by 1, 2");

      return BuildPermissions(sql.ToString());
    }

    private List<AccessPermission> BuildPermissions(string sql)
    {
      var permissions = new List<AccessPermission>();
      var records = new ActiveRecordSet { Query = sql, Instance = Instance };

      records.AddParameter(UserId);
      if (records.Execute())
      {
        foreach (ActiveRecord rec in records)
        {
          permissions.Add(new AccessPermission(rec.GetColumnValue("FUNCTION_NAME"), rec.GetColumnValue("ACCESS_TYPE")));
        }
      }
      return permissions;
    }

    private static string BuildPermissionsString(IEnumerable<AccessPermission> list)
    {
      var permissions = new StringBuilder();

      foreach (var rec in list)
        permissions.AppendFormat("{0}~{1};", rec.Function, rec.AccessType);

      return permissions.ToString();
    }

    /// <summary>
    /// Gets the user by name and password.
    /// </summary>
    /// <param name="name">The user name.</param>
    /// <param name="password">The user password.</param>
    public static User GetUser(string name, string password)
    {
      return GetUser(name, password, ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Gets the user by name and password.
    /// </summary>
    /// <param name="name">The user name.</param>
    /// <param name="password">The user password.</param>
    /// <param name="instance">The database instance.</param>
    public static User GetUser(string name, string password, string instance)
    {
      var current = new User { Where = "name = :1 and password = :2", Instance = instance };
      current.AddParameter(name);
      current.AddParameter(password);
      if (current.Execute())
        return current;

      throw new ApplicationException(current.LastError);
    }

    /// <summary>
    /// Gets the user by username.
    /// </summary>
    /// <param name="name">The user name.</param>
    public static User GetUserByName(string name)
    {
      return GetUserByName(name, ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Gets the user by username.
    /// </summary>
    /// <param name="name">The user name.</param>
    /// <param name="instance">The database instance.</param>
    public static User GetUserByName(string name, string instance)
    {
      var current = new User { Instance = instance, Where = "name = :1" };
      current.AddParameter(name);
      if (current.Execute())
        return current;

      throw new ApplicationException(current.LastError);
    }

    /// <summary>
    /// Gets the user by id.
    /// </summary>
    /// <param name="id">The id.</param>
    public static User GetUserById(int id)
    {
      return GetUserById(id, ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Gets the user by id.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <param name="instance">The database instance.</param>
    public static User GetUserById(int id, string instance)
    {
      var current = new User { Where = "user_id = :1", Instance = instance };
      current.AddParameter(id);
      if (current.Execute())
        return current;

      throw new ApplicationException(current.LastError);
    }
  }
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Security/User.cs $
 * 
 * 10    7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 9     3/12/10 4:47p Gwynnj
 * Linq users
 * 
 * 8     12/02/09 2:51p John.gwynn
 * Fixed bug where USer methods did not propagate the source Instance
 * 
 * 7     10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 6     9/22/09 11:06a John.gwynn
 * Import Field updates
 * 
 * 5     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 4     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 3     4/21/09 4:50p John.gwynn
 * UserId == -1 not null for 1.1 support
 * 
 * 2     4/14/09 3:38p John.gwynn
 * fixed missing instance
 * 
 * 1     4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 4     4/01/09 7:28p John.gwynn
 * added parameterized SQL to ActiveRecord and beefed up User class for
 * use in VbSecurity
 * 
 * 3     1/21/09 1:32p John.gwynn
 * fixed SS keyword bug and added UserId to the CallRecord update
 */
#endregion