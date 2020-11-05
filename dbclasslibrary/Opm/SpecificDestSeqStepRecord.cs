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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/SpecificDestSeqStepRecord.cs 5     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// Encapsulates FNSOWNER.SPECIFIC_DESTN_SEQ_STEP table for OPM
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class SpecificDestSeqStepRecord : ActiveRecord, ISequenceStep
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="SpecificDestSeqStepRecord"/> class.
		/// </summary>
		public SpecificDestSeqStepRecord()
			: base("SPECIFIC_DESTN_SEQ_STEP")
		{
			// Begin Generated Column Definitions
			columns.Add(new Column("SPECIFIC_DESTN_SEQ_STEP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("SPECIFIC_DESTINATION_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("SEQUENCE", String.Empty, "NUMBER"));
			columns.Add(new Column("RETRY_COUNT", String.Empty, "NUMBER"));
			columns.Add(new Column("RETRY_WAIT_TIME", String.Empty, "NUMBER"));
			columns.Add(new Column("DESTINATION_STRING", String.Empty, "VARCHAR2"));
			columns.Add(new Column("TRANSMISSION_TYPE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ALT_DESTINATION_STRING", String.Empty, "VARCHAR2"));
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="SpecificDestSeqStepRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public SpecificDestSeqStepRecord(IDataReader reader)
			: base(reader, "SPECIFIC_DESTN_SEQ_STEP")
		{
		}
		#endregion
		#region SpecificDestnSeqStepId
		/// <summary>
		/// Gets or sets the specific destn seq step id.
		/// </summary>
		/// <value>The specific destn seq step id.</value>
		public string SpecificDestnSeqStepId
		{
			get
			{
				return GetColumnValue("SPECIFIC_DESTN_SEQ_STEP_ID");
			}
			set
			{
				SetColumnValue("SPECIFIC_DESTN_SEQ_STEP_ID", value);
			}
		}
		#endregion
		#region SpecificDestinationId
		/// <summary>
		/// Gets or sets the specific destination id.
		/// </summary>
		/// <value>The specific destination id.</value>
		public string SpecificDestinationId
		{
			get
			{
				return GetColumnValue("SPECIFIC_DESTINATION_ID");
			}
			set
			{
				SetColumnValue("SPECIFIC_DESTINATION_ID", value);
			}
		}
		#endregion
		#region Sequence
		/// <summary>
		/// Gets or sets the sequence.
		/// </summary>
		/// <value>The sequence.</value>
		public string Sequence
		{
			get
			{
				return GetColumnValue("SEQUENCE");
			}
			set
			{
				SetColumnValue("SEQUENCE", value);
			}
		}
		#endregion
		#region RetryCount
		/// <summary>
		/// Gets or sets the retry count.
		/// </summary>
		/// <value>The retry count.</value>
		public string RetryCount
		{
			get
			{
				return GetColumnValue("RETRY_COUNT");
			}
			set
			{
				SetColumnValue("RETRY_COUNT", value);
			}
		}
		#endregion
		#region RetryWaitTime
		/// <summary>
		/// Gets or sets the retry wait time.
		/// </summary>
		/// <value>The retry wait time.</value>
		public string RetryWaitTime
		{
			get
			{
				return GetColumnValue("RETRY_WAIT_TIME");
			}
			set
			{
				SetColumnValue("RETRY_WAIT_TIME", value);
			}
		}
		#endregion
		#region RoutingPlanId
		/// <summary>
		/// Gets the routing plan id.
		/// </summary>
		/// <value>The routing plan id.</value>
		public string RoutingPlanId
		{
			get { return String.Empty; }
		}

		#endregion
		#region DestinationString
		/// <summary>
		/// Gets or sets the destination string.
		/// </summary>
		/// <value>The destination string.</value>
		public string DestinationString
		{
			get
			{
				return GetColumnValue("DESTINATION_STRING");
			}
			set
			{
				SetColumnValue("DESTINATION_STRING", value);
			}
		}
		#endregion
		#region TransmissionTypeId
		/// <summary>
		/// Gets or sets the transmission type id.
		/// </summary>
		/// <value>The transmission type id.</value>
		public string TransmissionTypeId
		{
			get
			{
				return GetColumnValue("TRANSMISSION_TYPE_ID");
			}
			set
			{
				SetColumnValue("TRANSMISSION_TYPE_ID", value);
			}
		}
		#endregion
		#region AltDestinationString
		/// <summary>
		/// Gets or sets the alt destination string.
		/// </summary>
		/// <value>The alt destination string.</value>
		public string AltDestinationString
		{
			get
			{
				return GetColumnValue("ALT_DESTINATION_STRING");
			}
			set
			{
				SetColumnValue("ALT_DESTINATION_STRING", value);
			}
		}
		#endregion
		#region BatchHold
		/// <summary>
		/// Gets or sets the batch hold.
		/// </summary>
		/// <value>The batch hold.</value>
		public string BatchHold
		{
			get { return string.Empty; }
		}

		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/SpecificDestSeqStepRecord.cs $
 * 
 * 5     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 4     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 3     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 2     8/07/07 6:15p John.gwynn
 * several fixes to default instance to registry when not supplied.
 * Specific destination support. Added ISequenceStep interface for OPM
 * 
 * 1     6/04/07 4:46p John.gwynn
 * Added Specific Destination and sequenceStep for OPM
 */
#endregion