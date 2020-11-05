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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/TranSequenceStepRecordSet.cs 3     5/26/09 11:07a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// Encapsulates recordset for FNSOWNER.TRANSMISSION_SEQ_STEP
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class TranSequenceStepRecordSet : ActiveRecordSet
	{
		private string _routingPlan;
		private string _sequence;
		/// <summary>
		/// Initializes a new instance of the <see cref="TranSequenceStepRecordSet"/> class.
		/// </summary>
		public TranSequenceStepRecordSet()
			: base("TransmissionSequenceStep")
		{
			_routingPlan = String.Empty;
			_sequence = "1";
		}
		#region RoutingPlanId
		/// <summary>
		/// Gets or sets the routing plan id.
		/// </summary>
		/// <value>The routing plan id.</value>
		public string RoutingPlanId
		{
			get { return _routingPlan; }
			set { _routingPlan = value; }
		}
		#endregion
		#region Sequence
		/// <summary>
		/// Gets or sets the sequence.
		/// </summary>
		/// <value>The sequence.</value>
		public string Sequence
		{
			get { return _sequence; }
			set { _sequence = value; }
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
					query = String.Format("select * from TRANSMISSION_SEQ_STEP where ROUTING_PLAN_ID = {0} and SEQUENCE = {1}",
					_routingPlan, _sequence);
				}
				return query;
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/TranSequenceStepRecordSet.cs $
 * 
 * 3     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 2     6/26/07 2:43p John.gwynn
 * 
 * 1     6/04/07 4:46p John.gwynn
 * Added Specific Destination and sequenceStep for OPM
 */
#endregion