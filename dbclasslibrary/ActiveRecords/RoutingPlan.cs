using System.Data;

namespace DbClassLibrary.ActiveRecords
{
  public class RoutingPlan : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingPlan"/> class.
    /// </summary>
    public RoutingPlan(): base("ROUTING_PLAN")
    {
      columns.Add(new Column("ROUTING_PLAN_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("LOB_CD", string.Empty, "CHAR"));
      columns.Add(new Column("DESCRIPTION", string.Empty, "VARCHAR2"));
      columns.Add(new Column("STATE", string.Empty, "CHAR"));
      columns.Add(new Column("ENABLERULE_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("DESTINATION_TYPE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("INPUT_SYSTEM_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ENABLED_FLG", string.Empty, "CHAR"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingPlan"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public RoutingPlan(IDataReader reader)
			: base(reader, "EMPLOYEE")
		{}

    #region RoutingPlanId
    /// <summary>
    /// ROUTING_PLAN_ID
    /// </summary>
    public string RoutingPlanId
    {

      get { return GetColumnValue("ROUTING_PLAN_ID"); }
      set { SetColumnValue("ROUTING_PLAN_ID", value); }
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

    #region State
    /// <summary>
    /// STATE
    /// </summary>
    public string State
    {

      get { return GetColumnValue("STATE"); }
      set { SetColumnValue("STATE", value); }
    }
    #endregion

    #region EnableRuleId
    /// <summary>
    /// ENABLERULE_ID
    /// </summary>
    public string EnableRuleId
    {

      get { return GetColumnValue("ENABLERULE_ID"); }
      set { SetColumnValue("ENABLERULE_ID", value); }
    }
    #endregion

    #region DestinationType
    /// <summary>
    /// DESTINATION_TYPE
    /// </summary>
    public string DestinationType
    {

      get { return GetColumnValue("DESTINATION_TYPE"); }
      set { SetColumnValue("DESTINATION_TYPE", value); }
    }
    #endregion

    #region InputSystemName
    /// <summary>
    /// INPUT_SYSTEM_NAME
    /// </summary>
    public string InputSystemName
    {

      get { return GetColumnValue("INPUT_SYSTEM_NAME"); }
      set { SetColumnValue("INPUT_SYSTEM_NAME", value); }
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
