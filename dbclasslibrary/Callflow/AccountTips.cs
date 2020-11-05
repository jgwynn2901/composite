using System.Data;

namespace DbClassLibrary.Callflow
{
  public class AccountTips : ActiveRecordSet<AccountTip>
  {
    private const string SqlSelectInternet = 
      "select L.* from ACCOUNT_TIP_LIST L, ACCOUNT_TIP A "
      + "where L.ENABLED_FLG = 'Y' AND L.ACCOUNT_TIP_ID = A.ACCOUNT_TIP_ID "
      + "and A.ACCNT_HRCY_STEP_ID = {0} " 
      + "and A.LOB_CD = '{1}' order by tip_sequence";

    /// <summary>
    /// Initializes a new instance of the <see cref="AccountTips"/> class.
    /// </summary>
    public AccountTips()
      : base("AccountTip")
    { }

    /// <summary>
    /// Gets or sets the Account AhsId.
    /// </summary>
    public int AccountId { get; set; }

    /// <summary>
    /// Gets or sets the Line of Business
    /// </summary>
    public string LobCd { get; set; }

    /// <summary>
    /// Gets or sets the query.
    /// </summary>
    /// <value>
    /// The query.
    /// </value>
    public override string Query
    {
      get
      {
        return string.Format(SqlSelectInternet, AccountId, LobCd);
      }
    }
  }

  public class AccountTip : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountTip"/> class.
    /// </summary>
    public AccountTip()
      : base("ACCOUNT_TIP_LIST")
    {
      columns.Add(new Column("ACCOUNT_TIP_LIST_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCOUNT_TIP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("TIP_SEQUENCE", string.Empty, "NUMBER"));
      columns.Add(new Column("TIP_DESCRIPTION", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ENABLED_FLG", string.Empty, "CHAR"));
    }


    /// <summary>
    /// Initializes a new instance of the <see cref="AccountTip"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public AccountTip(IDataReader reader)
      : base(reader, "ACCOUNT_TIP_LIST")
    { }

    #region AccountTipListId
    /// <summary>
    /// ACCOUNT_TIP_LIST_ID
    /// </summary>
    public string AccountTipListId
    {
      get { return GetColumnValue("ACCOUNT_TIP_LIST_ID"); }
      set { SetColumnValue("ACCOUNT_TIP_LIST_ID", value); }
    }
    #endregion

    #region AccountTipId
    /// <summary>
    /// ACCOUNT_TIP_ID
    /// </summary>
    public string AccountTipId
    {
      get { return GetColumnValue("ACCOUNT_TIP_ID"); }
      set { SetColumnValue("ACCOUNT_TIP_ID", value); }
    }
    #endregion

    #region TipSequence
    /// <summary>
    /// TIP_SEQUENCE
    /// </summary>
    public string TipSequence
    {
      get { return GetColumnValue("TIP_SEQUENCE"); }
      set { SetColumnValue("TIP_SEQUENCE", value); }
    }
    #endregion

    #region TipDescription
    /// <summary>
    /// TIP_DESCRIPTION
    /// </summary>
    public string TipDescription
    {
      get { return GetColumnValue("TIP_DESCRIPTION"); }
      set { SetColumnValue("TIP_DESCRIPTION", value); }
    }
    #endregion

    #region EnabledFlag
    /// <summary>
    /// ENABLED_FLG
    /// </summary>
    public string EnabledFlag
    {
      get { return GetColumnValue("ENABLED_FLG"); }
      set { SetColumnValue("ENABLED_FLG", value); }
    }
    #endregion
  }
}
