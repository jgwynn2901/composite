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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/DistributionSuppressionRecordSet.cs 3     5/26/09 11:06a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// Encapsulates a set of AddressBook Records
	/// Usage: Set CallflowId and Execute (Do Not Override)
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class DistriubtionSuppressionRecordSet : ActiveRecordSet
	{
		private string benefitState;
		private string branchNumber;
		private string clientCode;



		/// <summary>
		/// Initializes a new instance of the <see cref="DistriubtionSuppressionRecordSet"/> class.
		/// </summary>
		public DistriubtionSuppressionRecordSet()
			: base("DistributionSuppressionRecord")
		{
			benefitState = string.Empty;
			branchNumber = string.Empty;
			clientCode = "ESS";  //default
		}


		#region ClientCode

		/// <summary>
		/// Gets or sets the Client code usually ESS.
		/// </summary>
		public string ClientCode
		{
			get { return clientCode; }
			set { clientCode = value; }
		}
		#endregion


		#region BenefitState

		/// <summary>
		/// Gets or sets the benefit state.
		/// </summary>
		/// <value>The state of the benefit_.</value>
		public string BenefitState
		{
			get { return benefitState; }
			set { benefitState = value; }
		}
		#endregion

		#region BranchNumber
		/// <summary>
		/// Gets or sets the branch number.
		/// </summary>
		public string BranchNumber
		{
			get { return branchNumber; }
			set { branchNumber = value; }






		}
		#endregion

		#region Query
		/// <summary>
		/// Gets or sets the query.
		/// </summary>

		public override string Query
		{
			get
			{
				if (query.Length > 0)
					return query;
				else
					return String.Format("SELECT DISTRIBUTION_SUP_FLAG FROM DISTRIBUTION_SUPPRESSION WHERE BENEFIT_STATE = '{0}' AND BRANCH_NUMBER = '{1}' AND CLIENT_CODE = '{2}' ", benefitState, branchNumber, clientCode);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/DistributionSuppressionRecordSet.cs $
 * 
 * 3     5/26/09 11:06a John.gwynn
 * Added interop definitions
 * 
 * 2     5/12/09 12:31p John.gwynn
 * updates to coordinate with 1.1 code
 * 
 * 2     5/12/09 12:14p John.gwynn
 * 
 * 2     2/10/09 12:14p John.gwynn
 * cleaned up the DistributionSuppressionRecord mess
 * 
 * 1     1/24/08 11:45a Jenny.cheung
 * created for Ess to bring the distribution suppression flag
 * 
 * 1     8/08/07 11:19a John.gwynn
 * restructured the DbClassLibrary adding folders
 * 
 * 2     6/03/07 2:10p John.gwynn
 * 
 * 1     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 */
#endregion