using System.Data;
using System.Globalization;

namespace DbClassLibrary.Callflow
{
  public class ClaimNumberAssignmentRule : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ClaimNumberAssignmentRule"/> class.
    /// </summary>
    public ClaimNumberAssignmentRule() : base("CLAIMNUMBERASSIGNMENTRULE")
    {
      columns.Add(new Column("CLAIMNUMBERASSIGNMENTRULE_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("BRANCH_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("LOB_CD", string.Empty, "CHAR"));
      columns.Add(new Column("RULE_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("SEQUENCE", string.Empty, "NUMBER"));
      columns.Add(new Column("LENGTH", string.Empty, "NUMBER"));
      columns.Add(new Column("PREFIX", string.Empty, "VARCHAR2"));
      columns.Add(new Column("SUFFIX", string.Empty, "VARCHAR2"));
      columns.Add(new Column("NEXT", string.Empty, "NUMBER"));
      columns.Add(new Column("MINIMUM", string.Empty, "NUMBER"));
      columns.Add(new Column("REUSE_FLG", string.Empty, "CHAR"));
      columns.Add(new Column("MAXIMUM", string.Empty, "NUMBER"));
      columns.Add(new Column("WARNINGPERCENT", string.Empty, "NUMBER"));
      columns.Add(new Column("USEDUP_FLG", string.Empty, "CHAR"));
      columns.Add(new Column("ASSIGN_TO_ATTR_NAME", string.Empty, "VARCHAR2"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ClaimNumberAssignmentRule"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public ClaimNumberAssignmentRule(IDataReader reader)
      : base(reader, "CLAIMNUMBERASSIGNMENTRULE")
		{ }

    #region ClaimnumberassignmentRuleId
    /// <summary>
    /// CLAIMNUMBERASSIGNMENTRULE_ID
    /// </summary>
    public int ClaimnumberassignmentRuleId
    {

      get { return GetColumnValueAsInt("CLAIMNUMBERASSIGNMENTRULE_ID") ?? 0; }
      set { SetColumnValue("CLAIMNUMBERASSIGNMENTRULE_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region AccntHrcyStepId
    /// <summary>
    /// ACCNT_HRCY_STEP_ID
    /// </summary>
    public int AccntHrcyStepId
    {

      get { return GetColumnValueAsInt("ACCNT_HRCY_STEP_ID") ?? 0; }
      set { SetColumnValue("ACCNT_HRCY_STEP_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region BranchId
    /// <summary>
    /// BRANCH_ID
    /// </summary>
    public string BranchId
    {

      get { return GetColumnValue("BRANCH_ID"); }
      set { SetColumnValue("BRANCH_ID", value); }
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

    #region RuleId
    /// <summary>
    /// RULE_ID
    /// </summary>
    public string RuleId
    {

      get { return GetColumnValue("RULE_ID"); }
      set { SetColumnValue("RULE_ID", value); }
    }
    #endregion

    #region Sequence
    /// <summary>
    /// SEQUENCE
    /// </summary>
    public int Sequence
    {

      get { return GetColumnValueAsInt("SEQUENCE") ?? 0; }
      set { SetColumnValue("SEQUENCE", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region Length
    /// <summary>
    /// LENGTH
    /// </summary>
    public int Length
    {

      get { return GetColumnValueAsInt("LENGTH") ?? 0; }
      set { SetColumnValue("LENGTH", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region Prefix
    /// <summary>
    /// PREFIX
    /// </summary>
    public string Prefix
    {

      get { return GetColumnValue("PREFIX"); }
      set { SetColumnValue("PREFIX", value); }
    }
    #endregion

    #region Suffix
    /// <summary>
    /// SUFFIX
    /// </summary>
    public string Suffix
    {

      get { return GetColumnValue("SUFFIX"); }
      set { SetColumnValue("SUFFIX", value); }
    }
    #endregion

    #region Next
    /// <summary>
    /// NEXT
    /// </summary>
    public int Next
    {

      get { return GetColumnValueAsInt("NEXT") ?? 0; }
      set { SetColumnValue("NEXT", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region Minimum
    /// <summary>
    /// MINIMUM
    /// </summary>
    public int Minimum
    {

      get { return GetColumnValueAsInt("MINIMUM") ?? 0; }
      set { SetColumnValue("MINIMUM", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region ReuseFlag
    /// <summary>
    /// REUSE_FLG
    /// </summary>
    public string ReuseFlag
    {

      get { return GetColumnValue("REUSE_FLG"); }
      set { SetColumnValue("REUSE_FLG", value); }
    }
    #endregion

    #region Maximum
    /// <summary>
    /// MAXIMUM
    /// </summary>
    public int Maximum
    {

      get { return GetColumnValueAsInt("MAXIMUM") ?? 0; }
      set { SetColumnValue("MAXIMUM", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region Warningpercent
    /// <summary>
    /// WARNINGPERCENT
    /// </summary>
    public int Warningpercent
    {

      get { return GetColumnValueAsInt("WARNINGPERCENT") ?? 0; }
      set { SetColumnValue("WARNINGPERCENT", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region UsedupFlag
    /// <summary>
    /// USEDUP_FLG
    /// </summary>
    public string UsedupFlag
    {

      get { return GetColumnValue("USEDUP_FLG"); }
      set { SetColumnValue("USEDUP_FLG", value); }
    }
    #endregion

    #region AssignToAttrName
    /// <summary>
    /// ASSIGN_TO_ATTR_NAME
    /// </summary>
    public string AssignToAttrName
    {

      get { return GetColumnValue("ASSIGN_TO_ATTR_NAME"); }
      set { SetColumnValue("ASSIGN_TO_ATTR_NAME", value); }
    }
    #endregion
  }
}
