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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/TransmissionOutcomeStep.cs 7     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;
using System.Text;
using FnsComposite.Interfaces;
using FnsComposite.MessageObjects;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// Encapsulates FNSOWNER.TRANSMISSION_OUTCOME_STEP for OPM
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class TransmissionOutcomeStep : ActiveRecord, ITranOutcomeStep
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="TransmissionOutcome"/> class.
		/// </summary>
		public TransmissionOutcomeStep()
			: base("TRANSMISSION_OUTCOME_STEP")
		{
			// Begin Generated Column Definitions
			columns.Add(new Column("X_MISSION_STEP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("TRANSMISSION_SEQ_STEP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("TRANSMISSION_OUTCOME_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("TRANSMISSION_TYPE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("SEQUENCE", String.Empty, "NUMBER"));
			columns.Add(new Column("RETRY_COUNT", String.Empty, "NUMBER"));
			columns.Add(new Column("RETRY_WAIT_TIME", String.Empty, "NUMBER"));
			columns.Add(new Column("DESTINATION_STRING", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STATUS", String.Empty, "VARCHAR2"));
			columns.Add(new Column("PAGE_COUNT", String.Empty, "NUMBER"));
			columns.Add(new Column("CREATED_DATE", String.Empty, "DATE"));
			columns.Add(new Column("ERROR_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("MODIFIED_DATE", String.Empty, "DATE"));
			columns.Add(new Column("SERVER_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("RESUBMITTED_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("RESUBMIT_COMMENT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("RESUBMIT_REASON_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("RESUBMIT_USER_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("RESUBMIT_SINGLE_STEP_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("RESUBMIT_COUNT", String.Empty, "NUMBER"));
			columns.Add(new Column("RESULT_DESTINATION_STRING", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SPECIFIC_DESTN_SEQ_STEP_ID", String.Empty, "NUMBER"));
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="TransmissionOutcomeStep"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public TransmissionOutcomeStep(IDataReader reader)
			: base(reader, "TRANSMISSION_OUTCOME_STEP")
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="TransmissionOutcomeStep"/> class.
		/// </summary>
		/// <param name="rec">The rec.</param>
		public TransmissionOutcomeStep(ITranOutcomeStep rec)
			: this()
		{
			XMissionStepId = rec.OutcomeStepId;
			TransmissionOutcomeId = rec.OutcomeId;
			TransmissionSeqStepId = rec.SequenceStepId;
			TransmissionTypeId = rec.TransmissionType;
			Sequence = rec.Sequence;
			RetryCount = rec.RetryCount;
			RetryWaitTime = rec.RetryWaitTime;
			DestinationString = rec.DestinationString;
			Status = rec.Status;
			PageCount = rec.PageCount;
			ErrorText = rec.ErrorText;
			ServerName = rec.ServerName;
			ResubmittedFlg = rec.ResubmittedFlg;
		}
		#endregion
		#region XMissionStepId
		/// <summary>
		/// Gets or sets the X mission step id.
		/// </summary>
		/// <value>The X mission step id.</value>
		public string XMissionStepId
		{
			get
			{
				return GetColumnValue("X_MISSION_STEP_ID");
			}
			set
			{
				SetColumnValue("X_MISSION_STEP_ID", value);
			}
		}
		#endregion
		#region TransmissionSeqStepId
		/// <summary>
		/// Gets or sets the transmission seq step id.
		/// </summary>
		/// <value>The transmission seq step id.</value>
		public string TransmissionSeqStepId
		{
			get
			{
				return GetColumnValue("TRANSMISSION_SEQ_STEP_ID");
			}
			set
			{
				SetColumnValue("TRANSMISSION_SEQ_STEP_ID", value);
			}
		}
		#endregion
		#region TransmissionOutcomeId
		/// <summary>
		/// Gets or sets the transmission outcome id.
		/// </summary>
		/// <value>The transmission outcome id.</value>
		public string TransmissionOutcomeId
		{
			get
			{
				return GetColumnValue("TRANSMISSION_OUTCOME_ID");
			}
			set
			{
				SetColumnValue("TRANSMISSION_OUTCOME_ID", value);
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
		#region OutcomeStepId
		/// <summary>
		/// Gets the outcome step id.
		/// </summary>
		/// <value>The outcome step id.</value>
		public string OutcomeStepId
		{
			get { return XMissionStepId; }
		}
		#endregion
		#region OutcomeId
		/// <summary>
		/// Gets the outcome id.
		/// </summary>
		/// <value>The outcome id.</value>
		public string OutcomeId
		{
			get { return TransmissionOutcomeId; }
		}
		#endregion
		#region SequenceStepId
		/// <summary>
		/// Gets the sequence step id.
		/// </summary>
		/// <value>The sequence step id.</value>
		public string SequenceStepId
		{
			get { return TransmissionSeqStepId; }
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
		#region TransmissionType
		/// <summary>
		/// Gets the type of the transmission.
		/// </summary>
		/// <value>The type of the transmission.</value>
		public string TransmissionType
		{
			get { return TransmissionTypeId; }
		}

		#endregion
		#region Status
		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		public string Status
		{
			get
			{
				return GetColumnValue("STATUS");
			}
			set
			{
				SetColumnValue("STATUS", value);
			}
		}
		#endregion
		#region PageCount
		/// <summary>
		/// Gets or sets the page count.
		/// </summary>
		/// <value>The page count.</value>
		public string PageCount
		{
			get
			{
				return GetColumnValue("PAGE_COUNT");
			}
			set
			{
				SetColumnValue("PAGE_COUNT", value);
			}
		}
		#endregion
		#region CreatedDate
		/// <summary>
		/// Gets or sets the created date.
		/// </summary>
		/// <value>The created date.</value>
		public string CreatedDate
		{
			get
			{
				return GetColumnValue("CREATED_DATE");
			}
			set
			{
				SetColumnValue("CREATED_DATE", value);
			}
		}
		#endregion
		#region ErrorText
		/// <summary>
		/// Gets or sets the error text.
		/// </summary>
		/// <value>The error text.</value>
		public string ErrorText
		{
			get
			{
				return GetColumnValue("ERROR_TEXT");
			}
			set
			{
				SetColumnValue("ERROR_TEXT", value);
			}
		}
		#endregion
		#region ModifiedDate
		/// <summary>
		/// Gets or sets the modified date.
		/// </summary>
		/// <value>The modified date.</value>
		public string ModifiedDate
		{
			get
			{
				return GetColumnValue("MODIFIED_DATE");
			}
			set
			{
				SetColumnValue("MODIFIED_DATE", value);
			}
		}
		#endregion
		#region ServerName
		/// <summary>
		/// Gets or sets the name of the server.
		/// </summary>
		/// <value>The name of the server.</value>
		public string ServerName
		{
			get
			{
				return GetColumnValue("SERVER_NAME");
			}
			set
			{
				SetColumnValue("SERVER_NAME", value);
			}
		}
		#endregion
		#region ResubmittedFlg
		/// <summary>
		/// Gets or sets the resubmitted FLG.
		/// </summary>
		/// <value>The resubmitted FLG.</value>
		public string ResubmittedFlg
		{
			get
			{
				return GetColumnValue("RESUBMITTED_FLG");
			}
			set
			{
				SetColumnValue("RESUBMITTED_FLG", value);
			}
		}
		#endregion
		#region ResubmitComment
		/// <summary>
		/// Gets or sets the resubmit comment.
		/// </summary>
		/// <value>The resubmit comment.</value>
		public string ResubmitComment
		{
			get
			{
				return GetColumnValue("RESUBMIT_COMMENT");
			}
			set
			{
				SetColumnValue("RESUBMIT_COMMENT", value);
			}
		}
		#endregion
		#region ResubmitReasonId
		/// <summary>
		/// Gets or sets the resubmit reason id.
		/// </summary>
		/// <value>The resubmit reason id.</value>
		public string ResubmitReasonId
		{
			get
			{
				return GetColumnValue("RESUBMIT_REASON_ID");
			}
			set
			{
				SetColumnValue("RESUBMIT_REASON_ID", value);
			}
		}
		#endregion
		#region ResubmitUserId
		/// <summary>
		/// Gets or sets the resubmit user id.
		/// </summary>
		/// <value>The resubmit user id.</value>
		public string ResubmitUserId
		{
			get
			{
				return GetColumnValue("RESUBMIT_USER_ID");
			}
			set
			{
				SetColumnValue("RESUBMIT_USER_ID", value);
			}
		}
		#endregion
		#region ResubmitSingleStepFlg
		/// <summary>
		/// Gets or sets the resubmit single step flag.
		/// </summary>
		/// <value>The resubmit single step FLG.</value>
		public string ResubmitSingleStepFlg
		{
			get
			{
				return GetColumnValue("RESUBMIT_SINGLE_STEP_FLG");
			}
			set
			{
				SetColumnValue("RESUBMIT_SINGLE_STEP_FLG", value);
			}
		}
		#endregion
		#region ResubmitCount
		/// <summary>
		/// Gets or sets the resubmit count.
		/// </summary>
		/// <value>The resubmit count.</value>
		public string ResubmitCount
		{
			get
			{
				return GetColumnValue("RESUBMIT_COUNT");
			}
			set
			{
				SetColumnValue("RESUBMIT_COUNT", value);
			}
		}
		#endregion
		#region ResultDestinationString
		/// <summary>
		/// Gets or sets the result destination string.
		/// </summary>
		/// <value>The result destination string.</value>
		public string ResultDestinationString
		{
			get
			{
				return GetColumnValue("RESULT_DESTINATION_STRING");
			}
			set
			{
				SetColumnValue("RESULT_DESTINATION_STRING", value);
			}
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
		/// <summary>
		/// Toes the outcome step.
		/// </summary>
		/// <returns></returns>
		public OutcomeStep ToOutcomeStep ()
		{
			OutcomeStep results = new OutcomeStep();

			results.OutcomeStepId = XMissionStepId;
			results.TransmissionType = TransmissionTypeId;
			results.SequenceStepId = TransmissionSeqStepId;
			results.OutcomeId = TransmissionOutcomeId;
			results.ServerName = ServerName;
			results.DestinationString = DestinationString;
			results.Status = Status;
			results.Sequence = Sequence;
			results.ErrorText = ErrorText;
			results.RetryCount = RetryCount;
			results.RetryWaitTime = RetryWaitTime;
			results.PageCount = PageCount;
			results.ResubmittedFlg = ResubmittedFlg;
			 
			return results;
		}
		/// <summary>
		/// Generates the update SQL.
		/// </summary>
		/// <returns></returns>
		protected override string GenerateUpdateSql()
		{
			StringBuilder sql = new StringBuilder();
			sql.AppendFormat("UPDATE {0} SET ", Name);
			sql.AppendFormat("STATUS = '{0}'", Status);
			sql.AppendFormat(",DESTINATION_STRING = '{0}'", DestinationString);
			sql.AppendFormat(",SERVER_NAME = '{0}'", ServerName);
			sql.AppendFormat(",ERROR_TEXT = '{0}'\r\n", ErrorText);
			sql.Append(GeneratePrimaryKeyWhereClause());
			return sql.ToString();
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/TransmissionOutcomeStep.cs $
 * 
 * 7     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 6     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 5     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 4     7/10/07 4:54p John.gwynn
 * added Interfaces folder, and interfaces for outcome and outcome step.
 * Added support for Insert and Update of active records and
 * GetNextSequence() method to retrieve a primary key prior to insert
 * 
 * 3     6/26/07 2:43p John.gwynn
 * 
 * 2     6/03/07 2:53p John.gwynn
 * added Transmissionxxx to ActiveRecordSet factory method and verified
 * unit tests
 * 
 * 1     6/03/07 2:08p John.gwynn
 */
#endregion