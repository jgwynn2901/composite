namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	public class PolicyActiveRecordSet : ActiveRecordSet
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PolicyActiveRecordSet"/> class.
		/// </summary>
		public PolicyActiveRecordSet()
			: base("PolicyActiveRecord")
		{}

		/// <summary>
		/// Gets the policies by AhsId, line of business and date of loss.
		/// </summary>
		static public PolicyActiveRecordSet GetPoliciesByAhsIdLobLossDate(string ahsId, string lobCd, string lossDate)
		{
			return GetPoliciesByAhsIdLobLossDate(ahsId, lobCd, lossDate, ApplicationConfiguration.Instance.DefaultInstance);		
		}

		/// <summary>
		/// Gets the policies by AhsId, line of business and date of loss.
		/// </summary>
		static public PolicyActiveRecordSet GetPoliciesByAhsIdLobLossDate(string ahsId, string lobCd, string lossDate, string instance)
		{
			PolicyActiveRecordSet results = new PolicyActiveRecordSet();
			results.Instance = instance;
			results.Query = string.Format("select * from POLICY where POLICY_ID in (select POLICY_ID from AHS_POLICY where ACCNT_HRCY_STEP_ID = {0} AND LOB_CD = '{1}') AND TO_DATE('{2}','MMDDYYYY') BETWEEN EFFECTIVE_DATE AND EXPIRATION_DATE", ahsId, lobCd, lossDate);
			results.Execute();
			return results;
		}
	}
}
