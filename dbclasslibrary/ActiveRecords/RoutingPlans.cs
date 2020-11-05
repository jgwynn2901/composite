namespace DbClassLibrary.ActiveRecords
{
  public class RoutingPlans : ActiveRecordSet<RoutingPlan>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingPlans"/> class.
    /// </summary>
    public RoutingPlans()
            : base("RoutingPlan")
    { }

    /// <summary>
    /// Loads the routings for call.
    /// </summary>
    /// <param name="acctHrcyStepId">The acct hrcy step identifier.</param>
    /// <param name="lobCd">The lob cd.</param>
    /// <param name="state">The state.</param>
    /// <returns></returns>
    static public RoutingPlans LoadRoutingsForCall(string acctHrcyStepId, string lobCd, string state)
    {
      if (string.IsNullOrEmpty(state))
      {
        return new RoutingPlans
        {
          Query = string.Format("select * from ROUTING_PLAN where ACCNT_HRCY_STEP_ID IN (SELECT ACCNT_HRCY_STEP_ID From ACCOUNT_HIERARCHY_STEP START WITH ACCNT_HRCY_STEP_ID={0} CONNECT BY ACCNT_HRCY_STEP_ID= PRIOR PARENT_NODE_ID) AND LOB_CD='{1}' AND STATE is null AND UPPER(INPUT_SYSTEM_NAME)=UPPER('FNS NET') AND ENABLED_FLG='Y'", 
          acctHrcyStepId, lobCd)
        };
      }
      return new RoutingPlans
      {
        Query = string.Format("select * from ROUTING_PLAN where ACCNT_HRCY_STEP_ID IN (SELECT ACCNT_HRCY_STEP_ID From ACCOUNT_HIERARCHY_STEP START WITH ACCNT_HRCY_STEP_ID={0} CONNECT BY ACCNT_HRCY_STEP_ID= PRIOR PARENT_NODE_ID) AND LOB_CD='{1}' AND (STATE='{2}' OR STATE IS NULL) AND UPPER(INPUT_SYSTEM_NAME)=UPPER('FNS NET') AND ENABLED_FLG='Y'",
        acctHrcyStepId, lobCd, state)
      };
    }
  }

}
