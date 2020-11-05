using System.Data;
using System.Globalization;

namespace DbClassLibrary.Callflow
{
  public class RoutingAddressRule : ActiveRecord
  {
    public RoutingAddressRule()
      : base("ROUTINGADDRESSRULE")
    {
      columns.Add(new Column("ROUTINGADDRESSRULE_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ROUTINGADDRESS_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("LOB_CD", string.Empty, "CHAR"));
      columns.Add(new Column("ROUTINGRULE_ID", string.Empty, "NUMBER"));
    }

    public RoutingAddressRule(IDataReader reader)
      : base(reader, "ROUTINGADDRESSRULE")
		{ }

    #region RoutingaddressRuleId
    /// <summary>
    /// ROUTINGADDRESSRULE_ID
    /// </summary>
    public int RoutingaddressRuleId
    {

      get { return GetColumnValueAsInt("ROUTINGADDRESSRULE_ID") ?? 0; }
      set { SetColumnValue("ROUTINGADDRESSRULE_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region RoutingaddressId
    /// <summary>
    /// ROUTINGADDRESS_ID
    /// </summary>
    public int RoutingaddressId
    {

      get { return GetColumnValueAsInt("ROUTINGADDRESS_ID") ?? 0; }
      set { SetColumnValue("ROUTINGADDRESS_ID", value.ToString(CultureInfo.InvariantCulture)); }
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

    #region RoutingRuleId
    /// <summary>
    /// ROUTINGRULE_ID
    /// </summary>
    public string RoutingRuleId
    {

      get { return GetColumnValue("ROUTINGRULE_ID"); }
      set { SetColumnValue("ROUTINGRULE_ID", value); }
    }
    #endregion
  }
}
