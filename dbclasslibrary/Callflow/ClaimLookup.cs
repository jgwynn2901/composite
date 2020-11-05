using System;
using System.Data;

namespace DbClassLibrary.Callflow
{

  /// <summary>
  /// ClaimLookup results
  /// </summary>
  public class ClaimLookupSet : ActiveRecordSet<ClaimLookup>
  {

    public ClaimLookupSet()
      : base("ClaimLookup")
    { }
  }
  /// <summary>
  /// encapsulated the ClaimLookup view for webclaim 
  /// call lookup functionality.
  /// </summary>
  public class ClaimLookup : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ClaimLookup"/> class.
    /// </summary>
    public ClaimLookup()
      : base("CLAIM_LOOKUP")
    {
      columns.Add(new Column("CALL_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("STATUS", String.Empty, "VARCHAR2"));
      columns.Add(new Column("CALL_START_TIME", String.Empty, "DATE"));
      columns.Add(new Column("LOB_CD", String.Empty, "CHAR"));
      columns.Add(new Column("CLAIM_NUMBER", String.Empty, "VARCHAR2"));
      columns.Add(new Column("ACCOUNT", String.Empty, "VARCHAR2"));
      columns.Add(new Column("LOCATION", String.Empty, "VARCHAR2"));
      columns.Add(new Column("EMPLOYEE", String.Empty, "VARCHAR2"));
      columns.Add(new Column("CALLER_INFO", String.Empty, "VARCHAR2"));
      columns.Add(new Column("USER_NAME", String.Empty, "VARCHAR2"));
      columns.Add(new Column("USER_ID", String.Empty, "NUMBER"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ClaimLookup"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public ClaimLookup(IDataReader reader)
      : base(reader, "CLAIM_LOOKUP")
    { }

    #region CallId
    /// <summary>
    /// Gets or sets the call id.
    /// </summary>
    /// <value>The call id.</value>
    public string CallId
    {
      get
      {
        return GetColumnValue("CALL_ID");
      }
      set
      {
        SetColumnValue("CALL_ID", value);
      }
    }
    #endregion

    #region Status
    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>The status.</value>
    public string Status
    {
      get
      {
        return GetColumnValue("STATUS");
      }
      set
      {
        SetColumnValue("STATUS", value);
      }
    }
    #endregion

    #region CallStartTime
    /// <summary>
    /// Gets or sets the call start time.
    /// </summary>
    /// <value>The call start time.</value>
    public string CallStartTime
    {
      get
      {
        return GetColumnValue("CALL_START_TIME");
      }
      set
      {
        SetColumnValue("CALL_START_TIME", value);
      }
    }
    #endregion

    #region LobCd
    /// <summary>
    /// Gets or sets the lob cd.
    /// </summary>
    /// <value>The lob cd.</value>
    public string LobCd
    {
      get
      {
        return GetColumnValue("LOB_CD");
      }
      set
      {
        SetColumnValue("LOB_CD", value);
      }
    }
    #endregion

    #region ClaimNumber
    /// <summary>
    /// Gets or sets the claim number.
    /// </summary>
    /// <value>The claim number.</value>
    public string ClaimNumber
    {
      get
      {
        return GetColumnValue("CLAIM_NUMBER");
      }
      set
      {
        SetColumnValue("CLAIM_NUMBER", value);
      }
    }
    #endregion

    #region Account
    /// <summary>
    /// Gets or sets the account.
    /// </summary>
    /// <value>
    /// The account.
    /// </value>
    public string Account
    {
      get
      {
        return GetColumnValue("ACCOUNT");
      }
      set
      {
        SetColumnValue("ACCOUNT", value);
      }
    }
    #endregion

    #region Location
    /// <summary>
    /// Gets or sets the location.
    /// </summary>
    /// <value>The location.</value>
    public string Location
    {
      get
      {
        return GetColumnValue("LOCATION");
      }
      set
      {
        SetColumnValue("LOCATION", value);
      }
    }
    #endregion

    #region Employee
    public string Employee
    {
      get
      {
        return GetColumnValue("EMPLOYEE");
      }
      set
      {
        SetColumnValue("EMPLOYEE", value);
      }
    }
    #endregion

    #region CallerInfo
    /// <summary>
    /// Gets or sets the caller info.
    /// </summary>
    /// <value>The caller info.</value>
    public string CallerInfo
    {
      get
      {
        return GetColumnValue("CALLER_INFO");
      }
      set
      {
        SetColumnValue("CALLER_INFO", value);
      }
    }
    #endregion

    #region UserName

    /// <summary>
    /// Gets or sets the name of the user.
    /// </summary>
    /// <value>
    /// The name of the user.
    /// </value>
    public string UserName
    {
      get
      {
        return GetColumnValue("USER_NAME");
      }
      set
      {
        SetColumnValue("USER_NAME", value);
      }
    }
    #endregion

    #region UserId
    /// <summary>
    /// Gets or sets the user id.
    /// </summary>
    /// <value>The user id.</value>
    public string UserId
    {
      get
      {
        return GetColumnValue("USER_ID");
      }
      set
      {
        SetColumnValue("USER_ID", value);
      }
    }
    #endregion
  }
}
