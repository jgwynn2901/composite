#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/RuleRecordSet.cs 4     12/03/09 12:21p John.gwynn $ */
#endregion

using System.Collections.Generic;

namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class RuleRecordSet : ActiveRecordSet
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RuleRecordSet"/> class.
		/// </summary>
		public RuleRecordSet()
			: base("RuleRecord")
		{}
		/// <summary>
		/// Gets the rule set by client and event.
		/// </summary>
		/// <param name="clientId">The client id.</param>
		/// <param name="eventName">Name of the event.</param>
		/// <param name="instance">The instance.</param>
		/// <returns></returns>
		public static List<RuleRecord> GetRuleSetByClientAndEvent(string clientId, string eventName, string instance)
		{
			var list = new List<RuleRecord>();
			var resultSet = new RuleRecordSet
			                	{
			                		Instance = instance,
			                		Query = string.Format(
			                			"SELECT * FROM RULES WHERE RULE_ID IN (SELECT RULE_ID FROM RULE_SET WHERE ACCNT_HRCY_STEP_ID = {0} and EVENT = '{1}')",
			                			clientId, eventName)
			                	};
			if (resultSet.Execute())
			{
				foreach(RuleRecord r in resultSet)
					list.Add(r);
			}
			return list;
		}
	}
}
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/RuleRecordSet.cs $
 * 
 * 4     12/03/09 12:21p John.gwynn
 * SessionCache may be null
 * 
 * 3     6/05/09 7:28p John.gwynn
 * added CallData with ActiveRecord support for LONG RAW (only call_data
 * parameter at this point)
 * 
 * 2     5/26/09 11:06a John.gwynn
 * Added interop definitions
 * 
 * 1     10/30/07 7:14p John.gwynn
 * ActiveRecordSet now sets instance on record instantiation.  Added
 * support for Evaluation of dynamic Business rules (see RuleRecordSet)
 * and added UsStates for eSurance dropdowns
 */