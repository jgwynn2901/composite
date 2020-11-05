using System;
using System.Data;
using System.Globalization;
using System.Linq;

namespace DbClassLibrary.Security
{
  public class UserAuthentications : ActiveRecordSet<UserAuthentication>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="UserAuthentications"/> class.
    /// </summary>
    public UserAuthentications()
      : base("UserAuthentication")
    {}

    /// <summary>
    /// Creates the user authentication.
    /// </summary>
    /// <param name="userId">The user identifier.</param>
    /// <param name="device">The device.</param>
    /// <returns></returns>
    /// <exception cref="ApplicationException"></exception>
    public static UserAuthentication CreateUserAuthentication(int userId, string device)
    {
      var userAuth = new UserAuthentication
      {
        UserId = userId,
        SourceDevice = device
      };
      userAuth.UserAuthId = int.Parse(userAuth.GetNextSequence());
      if (!userAuth.Insert())
      {
        throw new ApplicationException(userAuth.LastError);
      }
     return new UserAuthentications
     {
       Query = "select * from USER_AUTH where USER_AUTH_ID = " + userAuth.UserAuthId
     }.Results().First();
    }
    /// <summary>
    /// Gets the last authentication.
    /// </summary>
    /// <param name="userId">The user identifier.</param>
    /// <returns></returns>
    public static UserAuthentication GetLastAuthentication(int userId)
    {
      return new UserAuthentications
      {
        Query = string.Format("select * from USER_AUTH where USER_ID = {0} AND SYSDATE < SESSION_END order by 1 DESC", userId)
      }.Results().FirstOrDefault();
    }

    /// <summary>
    /// Finds the record by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    public static UserAuthentication Find(int id)
    {
      return new UserAuthentications
      {
        Query = "select * from USER_AUTH where USER_AUTH_ID = " + id
      }.Results().FirstOrDefault();
    }
    /// <summary>
    /// Verifies the user authentication.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    public static bool VerifyUserAuthentication(int id)
    {
      var results =
        GeneralUtility.ExecuteNonQuery(
          string.Format("UPDATE USER_AUTH set VERIFIED = 'Y', SESSION_END = SESSION_START + 30 WHERE USER_ID = {0} AND SYSDATE < SESSION_END", id));
      return results;
    }
  }
  public class UserAuthentication : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="UserAuthentication"/> class.
    /// </summary>
    public UserAuthentication() 
      : base("USER_AUTH")
    {
      columns.Add(new Column("USER_AUTH_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("USER_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("TOKEN", string.Empty, "CHAR"));
      columns.Add(new Column("SESSION_START", string.Empty, "DATE"));
      columns.Add(new Column("SESSION_END", string.Empty, "DATE"));
      columns.Add(new Column("VERIFIED", string.Empty, "CHAR"));
      columns.Add(new Column("SOURCE_DEVICE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
      columns.Add(new Column("LAST_MODIFIED_DT", string.Empty, "DATE"));
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserAuthentication"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public UserAuthentication(IDataReader reader)
      : base(reader, "USER_AUTH")
		{}

    #region UserAuthId
    /// <summary>
    /// USER_AUTH_ID
    /// </summary>
    public int UserAuthId
    {
      get { return GetColumnValueAsInt("USER_AUTH_ID") ?? -1; }
      set { SetColumnValue("USER_AUTH_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region UserId
    /// <summary>
    /// USER_ID
    /// </summary>
    public int UserId
    {
      get { return GetColumnValueAsInt("USER_ID") ?? -1; }
      set { SetColumnValue("USER_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region Token
    /// <summary>
    /// TOKEN
    /// </summary>
    public string Token
    {
      get { return GetColumnValue("TOKEN"); }
    }
    #endregion

    #region SessionStart
    /// <summary>
    /// SESSION_START
    /// </summary>
    public string SessionStart
    {
      get { return GetColumnValue("SESSION_START"); }
    }
    #endregion

    #region SessionEnd
    /// <summary>
    /// SESSION_END
    /// </summary>
    public string SessionEnd
    {
      get { return GetColumnValue("SESSION_END"); }
    }
    #endregion
    #region Verified
    /// <summary>
    /// USER_AUTH_ID
    /// </summary>
    public string Verified
    {
      get { return GetColumnValue("VERIFIED"); }
      set { SetColumnValue("VERIFIED", value); }
    }
    #endregion
    #region SourceDevice
    /// <summary>
    /// SOURCE_DEVICE
    /// </summary>
    public string SourceDevice
    {
      get { return GetColumnValue("SOURCE_DEVICE"); }
      set { SetColumnValue("SOURCE_DEVICE", value); }
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
    /// Generates the insert columns clause.
    /// </summary>
    /// <returns></returns>
    protected override string GenerateInsertColumnsClause()
    {
      return UserAuthId > 0
        ? "(USER_AUTH_ID, USER_ID, SOURCE_DEVICE)"
        : "(USER_ID, SOURCE_DEVICE)";
    }

    /// <summary>
    /// Generates the insert values clause.
    /// </summary>
    /// <returns></returns>
    protected override string GenerateInsertValuesClause()
    {
      return UserAuthId > 0
        ?
        string.Format("({0}, {1}, '{2}')", UserAuthId, UserId, SourceDevice) 
        : 
        string.Format("({0}, '{1}')", UserId, SourceDevice);
    }
  }
}
