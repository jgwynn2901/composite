using System.Data;

namespace DbClassLibrary.Security
{
  /// <summary>
  /// LOCATIONS_USER table
  /// </summary>
  /// <seealso cref="DbClassLibrary.ActiveRecord" />
  public class LocationsUser : ActiveRecord
  {
    public LocationsUser()
      : base("LOCATIONS_USER")
    {
      columns.Add(new Column("LOCATION_USER_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCOUNT_USER_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("LOCATION_AHSID", string.Empty, "NUMBER"));
      columns.Add(new Column("LOB_CD", string.Empty, "CHAR"));
      columns.Add(new Column("FNS_CLIENT_CD", string.Empty, "VARCHAR2"));
      columns.Add(new Column("NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("PHONENUMBER", string.Empty, "VARCHAR2"));
      columns.Add(new Column("GREETING", string.Empty, "VARCHAR2"));
      columns.Add(new Column("GREETINGS_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCOUNT_LOCATION_CODE", string.Empty, "VARCHAR2"));
    }
    public LocationsUser(IDataReader reader)
      : base(reader, "LOCATIONS_USER")
		{}

    #region LocationUserId
    /// <summary>
    /// LOCATION_USER_ID
    /// </summary>
    public string LocationUserId
    {

      get { return GetColumnValue("LOCATION_USER_ID"); }
      set { SetColumnValue("LOCATION_USER_ID", value); }
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

    #region AccountUserId
    /// <summary>
    /// ACCOUNT_USER_ID
    /// </summary>
    public string AccountUserId
    {

      get { return GetColumnValue("ACCOUNT_USER_ID"); }
      set { SetColumnValue("ACCOUNT_USER_ID", value); }
    }
    #endregion

    #region LocationAhsId
    /// <summary>
    /// LOCATION_AHSID
    /// </summary>
    public string LocationAhsId
    {

      get { return GetColumnValue("LOCATION_AHSID"); }
      set { SetColumnValue("LOCATION_AHSID", value); }
    }
    #endregion

    #region LobCode
    /// <summary>
    /// LOB_CD
    /// </summary>
    public string LobCode
    {

      get { return GetColumnValue("LOB_CD"); }
      set { SetColumnValue("LOB_CD", value); }
    }
    #endregion

    #region FnsClientCode
    /// <summary>
    /// FNS_CLIENT_CD
    /// </summary>
    public string FnsClientCode
    {

      get { return GetColumnValue("FNS_CLIENT_CD"); }
      set { SetColumnValue("FNS_CLIENT_CD", value); }
    }
    #endregion

    #region Name
    /// <summary>
    /// NAME
    /// </summary>
    public string AccountName
    {

      get { return GetColumnValue("NAME"); }
      set { SetColumnValue("NAME", value); }
    }
    #endregion

    #region Phonenumber
    /// <summary>
    /// PHONENUMBER
    /// </summary>
    public string Phonenumber
    {

      get { return GetColumnValue("PHONENUMBER"); }
      set { SetColumnValue("PHONENUMBER", value); }
    }
    #endregion

    #region Greeting
    /// <summary>
    /// GREETING
    /// </summary>
    public string Greeting
    {

      get { return GetColumnValue("GREETING"); }
      set { SetColumnValue("GREETING", value); }
    }
    #endregion

    #region GreetingsId
    /// <summary>
    /// GREETINGS_ID
    /// </summary>
    public string GreetingsId
    {

      get { return GetColumnValue("GREETINGS_ID"); }
      set { SetColumnValue("GREETINGS_ID", value); }
    }
    #endregion

    #region AccountLocationCode
    /// <summary>
    /// ACCOUNT_LOCATION_CODE
    /// </summary>
    public string AccountLocationCode
    {

      get { return GetColumnValue("ACCOUNT_LOCATION_CODE"); }
      set { SetColumnValue("ACCOUNT_LOCATION_CODE", value); }
    }
    #endregion

  }
}
