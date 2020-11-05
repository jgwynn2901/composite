using System.Data;
using System.Globalization;

namespace DbClassLibrary.Callflow
{
  public class EscalationPlan : ActiveRecord
  {
    public EscalationPlan()
      : base("ESCALATION_PLAN")
    {
      columns.Add(new Column("ESCALATION_PLAN_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("LOB_CD", string.Empty, "CHAR"));
      columns.Add(new Column("DESCRIPTION", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ENABLERULE_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ENABLED_FLG", string.Empty, "CHAR"));
    }

    public EscalationPlan(IDataReader reader)
			: base(reader, "RULES")
		{ }

    #region EscalationPlanId
    /// <summary>
    /// ESCALATION_PLAN_ID
    /// </summary>
    public int EscalationPlanId
    {

      get { return GetColumnValueAsInt("ESCALATION_PLAN_ID") ?? 0; }
      set { SetColumnValue("ESCALATION_PLAN_ID", value.ToString(CultureInfo.InvariantCulture)); }
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

    #region EnableRuleId
    /// <summary>
    /// ENABLERULE_ID
    /// </summary>
    public int EnableRuleId
    {

      get { return GetColumnValueAsInt("ENABLERULE_ID") ?? 0; }
      set { SetColumnValue("ENABLERULE_ID", value.ToString(CultureInfo.InvariantCulture)); }
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

    /// <summary>
    /// gets the Enabled rule text.
    /// </summary>
    /// <returns></returns>
    public string EnabledRuleAsText()
    {
      return RuleRecord.GetRuleText(EnableRuleId);
    }
  }
}
