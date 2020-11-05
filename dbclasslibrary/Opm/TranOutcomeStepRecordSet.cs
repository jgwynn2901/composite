#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by Innovation First Notice 
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/TranOutcomeStepRecordSet.cs 3     5/26/09 11:07a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// Encapsulates recordset for FNSOWNER.TRANSMISSION_OUTCOME_STEP
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class TranOutcomeStepRecordSet : ActiveRecordSet
	{
		private string _outcomeId;
		/// <summary>
		/// Initializes a new instance of the <see cref="TranOutcomeStepRecordSet"/> class.
		/// </summary>
		public TranOutcomeStepRecordSet()
			: base("TransmissionOutcomeStep")
		{
			_outcomeId = String.Empty;
		}
		#region OutcomeId
		/// <summary>
		/// Gets or sets the outcome id.
		/// </summary>
		/// <value>The outcome id.</value>
		public string OutcomeId
		{
			get { return _outcomeId; }
			set { _outcomeId = value; }
		}
		#endregion
		#region Query
		/// <summary>
		/// sets the default query (can be overriden)
		/// </summary>
		/// <value>The query.</value>
		public override string Query
		{
			get
			{
				if (query.Length == 0)
				{
					query = String.Format("select * from TRANSMISSION_OUTCOME_STEP where TRANSMISSION_OUTCOME_ID = {0} ", _outcomeId);
				}
				return query;
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/TranOutcomeStepRecordSet.cs $
 * 
 * 3     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 2     6/26/07 2:43p John.gwynn
 * 
 * 1     6/03/07 2:07p John.gwynn
 */
#endregion