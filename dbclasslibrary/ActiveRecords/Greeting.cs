using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Data;

namespace DbClassLibrary.ActiveRecords
{
  public class Greetings : ActiveRecordSet<Greeting>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Employees"/> class.
    /// </summary>
    public Greetings()
      : base("Greeting")
    { }

    /// <summary>
    /// Gets or sets the user id.
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or sets the contract number.
    /// </summary>
    /// <value>The contract number.</value>
    public string ContractNumber { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is internet nodes user.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is internet nodes user; otherwise, <c>false</c>.
    /// </value>
    public bool IsInternetNodesUser { get; set; }

    private const string SqlSelectInternet = "SELECT distinct G.GREETINGS_ID FROM LOCATIONS_USER LU, ACCOUNT_USER AU ,USERS U, GREETINGS G " +
                                   "WHERE LU.ACCOUNT_USER_ID = AU.USER_ID AND AU.USER_ID = U.USER_ID AND G.GREETINGS_ID = LU.GREETINGS_ID AND U.USER_ID = ";

    private const string SqlSelectNodes = "SELECT distinct G.GREETINGS_ID FROM " +
                                          "LOCATIONS_USER LU, ACCOUNT_CALLFLOW AC, ACCOUNT_USER AU, LOB L, USERS U, GREETINGS G " +
                                          "WHERE LU.LOB_CD = L.LOB_CD AND LU.ACCOUNT_USER_ID = AU.USER_ID " +
                                          "AND AC.LOB_CD=L.LOB_CD " +
                                          "AND AU.USER_ID = U.USER_ID AND G.GREETINGS_ID = LU.GREETINGS_ID AND U.USER_ID = ";

    /// <summary>
    /// Gets the sub select based of node flag.
    /// </summary>
    /// <returns></returns>
    private string GetSubSelect()
    {
      return IsInternetNodesUser
                 ? SqlSelectNodes
                 : SqlSelectInternet;
    }


    /// <summary>
    /// Gets the lob codes associated with an internet user.
    /// </summary>
    static public string GetLobCodes(string userId, string accountNumber)
    {

      var records = new ActiveRecordSet
                      {
                        Query = string.Format(
                                    "SELECT DISTINCT LU.LOB_CD || ' - ' || L.LOB_NAME AS LOB_DESC " +
                                    "FROM LOB L, LOCATIONS_USER LU, ACCOUNT_USER AU ,USERS U " +
                                    "WHERE LU.LOB_CD=L.LOB_CD  and LU.ACCOUNT_USER_ID = AU.USER_ID AND AU.USER_ID = U.USER_ID " +
                                    "AND U.USER_ID = {0} AND LU.ACCOUNT_LOCATION_CODE = '{1}'", userId, accountNumber)
                      };

      var results = string.Empty;
      if (!records.Execute()) return results;
      var first = true;
      foreach (ActiveRecord record in records)
      {
        if (!first)
          results += ";";
        else
          first = false;
        results += record.GetColumnValue("LOB_DESC").Trim();
      }
      return results;
    }

    /// <summary>
    /// Gets or sets the query.
    /// </summary>
    public override string Query
    {
      get
      {
        var newquery = new StringBuilder("SELECT * FROM GREETINGS ");
        if (!string.IsNullOrEmpty(ContractNumber))
        {
          newquery.AppendFormat("WHERE CONTRACT_NUM = '{0}' ", ContractNumber);
        }
        else if (!string.IsNullOrEmpty(UserId))
        {
          newquery.Append("where GREETINGS_ID IN (");
          newquery.Append(GetSubSelect());
          newquery.Append(UserId);
          newquery.Append(") ");
        }
        newquery.Append("ORDER BY CONTRACT_NUM");
        return newquery.ToString();
      }
      set
      {
        throw new NotImplementedException();
      }
    }
  }

  [ComVisible(false), TableDefinition(TableName = "FNSOWNER.GREETINGS")]
  public class Greeting : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Greeting"/> class.
    /// </summary>
    public Greeting()
      : base("GREETINGS")
    {
      columns.Add(new Column("GREETINGS_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("CONTRACT_NUM", string.Empty, "CHAR"));
      columns.Add(new Column("TEXT", string.Empty, "VARCHAR2"));
      columns.Add(new Column("LOB_CODES", string.Empty, "VARCHAR2"));
      columns.Add(new Column("HAS_EMPLOYEE_FEED", string.Empty, "CHAR"));
      columns.Add(new Column("CONTRACT_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("SRS_FLG", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ACCOUNT_LOCATION_CODE", string.Empty, "VARCHAR2"));

      if (!GeneralUtility.IsSedgwick()) return;
      columns.Add(new Column("DS_SHORT_SCRIPT_FLG", string.Empty, "VARCHAR2"));
      columns.Add(new Column("LV_SHORT_SCRIPT_FLG", string.Empty, "VARCHAR2"));
      columns.Add(new Column("POLICY_CF_FLG", string.Empty, "VARCHAR2"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Greeting"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public Greeting(IDataReader reader)
      : base(reader, "GREETINGS")
    { }


    #region ContractNum
    /// <summary>
    /// CONTRACT_NUM
    /// </summary>
    public string ContractNum
    {
      get { return GetColumnValue("CONTRACT_NUM"); }
      set { SetColumnValue("CONTRACT_NUM", value); }
    }
    #endregion

    #region Text
    /// <summary>
    /// TEXT
    /// </summary>
    public string Text
    {
      get { return GetColumnValue("TEXT"); }
      set { SetColumnValue("TEXT", value); }
    }
    #endregion

    #region LobCodes
    /// <summary>
    /// LOB_CODES
    /// </summary>
    public string LobCodes
    {
      get { return GetColumnValue("LOB_CODES"); }
      set { SetColumnValue("LOB_CODES", value); }
    }
    #endregion

    #region HasEmployeeFeed
    /// <summary>
    /// HAS_EMPLOYEE_FEED
    /// </summary>
    public string HasEmployeeFeed
    {
      get { return GetColumnValue("HAS_EMPLOYEE_FEED"); }
      set { SetColumnValue("HAS_EMPLOYEE_FEED", value); }
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

    #region ContractName
    /// <summary>
    /// CONTRACT_NAME
    /// </summary>
    public string ContractName
    {
      get { return GetColumnValue("CONTRACT_NAME"); }
      set { SetColumnValue("CONTRACT_NAME", value); }
    }
    #endregion

    #region AccountLocationCode
    /// <summary>
    /// LOB_CODES
    /// </summary>
    public string AccountLocationCode
    {
      get { return GetColumnValue("ACCOUNT_LOCATION_CODE"); }
      set { SetColumnValue("ACCOUNT_LOCATION_CODE", value); }
    }
    #endregion

    public string SrsFlag
    {
      get { return GetColumnValue("SRS_FLG"); }
      set { SetColumnValue("SRS_FLG", value); }
    }

    public string DsShortScriptFlag
    {
      get { return GetColumnValue("DS_SHORT_SCRIPT_FLG"); }
      set { SetColumnValue("DS_SHORT_SCRIPT_FLG", value); }
    }

    public string LvShortScriptFlag
    {
      get { return GetColumnValue("LV_SHORT_SCRIPT_FLG"); }
      set { SetColumnValue("LV_SHORT_SCRIPT_FLG", value); }
    }

    public string PolicyCfFlag
    {
      get { return GetColumnValue("POLICY_CF_FLG"); }
      set { SetColumnValue("POLICY_CF_FLG", value); }
    }
  }
}
