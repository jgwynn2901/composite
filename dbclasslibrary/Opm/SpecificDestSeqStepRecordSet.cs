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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/SpecificDestSeqStepRecordSet.cs 2     5/26/09 11:07a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// Encapsulates recordset for FNSOWNER.SPECIFIC_DESTN_SEQ_STEP
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class SpecificDestSeqStepRecordSet : ActiveRecordSet
	{
		private string _specificDestinationId;

		/// <summary>
		/// Initializes a new instance of the <see cref="SpecificDestSeqStepRecordSet"/> class.
		/// </summary>
		public SpecificDestSeqStepRecordSet()
			: base("SpecificDestSeqStepRecord")
		{
			_specificDestinationId = String.Empty;
		}
		#region SpecificDestinationId
		/// <summary>
		/// Gets or sets the specific destination id.
		/// </summary>
		/// <value>The specific destination id.</value>
		public string SpecificDestinationId
		{
			get { return _specificDestinationId; }
			set { _specificDestinationId = value; }
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
				return String.Format("select * from SPECIFIC_DESTN_SEQ_STEP where SPECIFIC_DESTINATION_ID = {0} ", _specificDestinationId);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/SpecificDestSeqStepRecordSet.cs $
 * 
 * 2     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 1     6/04/07 4:46p John.gwynn
 * Added Specific Destination and sequenceStep for OPM
 */
#endregion
