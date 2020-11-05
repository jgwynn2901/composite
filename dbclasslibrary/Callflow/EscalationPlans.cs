using System.Collections.Generic;

namespace DbClassLibrary.Callflow
{
  public class EscalationPlans : ActiveRecordSet<EscalationPlan>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="EscalationPlans"/> class.
    /// </summary>
    public EscalationPlans() : base("EscalationPlan")
    {}

    /// <summary>
    /// Gets the escalation plans for a given client and lob code.
    /// </summary>
    /// <param name="ahsId">The ahs identifier.</param>
    /// <param name="lobCd">The lob cd.</param>
    /// <returns></returns>
    public static IEnumerable<EscalationPlan> FindByAccountLob(int ahsId, string lobCd)
    {
      var plans = new EscalationPlans
      {
        Query = "SELECT * FROM ESCALATION_PLAN where ACCNT_HRCY_STEP_ID IN ("
                + "SELECT  ACCNT_HRCY_STEP_ID From ACCOUNT_HIERARCHY_STEP START WITH ACCNT_HRCY_STEP_ID= :ahs_id "
                + "CONNECT BY ACCNT_HRCY_STEP_ID= PRIOR PARENT_NODE_ID) "
                + "AND LOB_CD='"+lobCd + "' AND ENABLED_FLG='Y'"
      };
      plans.AddParameter("ahs_id", ahsId);
      return plans.Results();
    }
  }

}
