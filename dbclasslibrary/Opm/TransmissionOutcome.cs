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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/TransmissionOutcome.cs 10    7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;
using System.Text;
using FnsComposite.Interfaces;
using FnsComposite.MessageObjects;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// Encapsulates FNSOWNER.TRANSMISSION_OUTCOME for OPM
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class TransmissionOutcome : ActiveRecord, ITransmissionOutcome
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="TransmissionOutcome"/> class.
		/// </summary>
		public TransmissionOutcome()
			: base("TRANSMISSION_OUTCOME")
		{
			// Begin Generated Column Definitions
			columns.Add(new Column("TRANSMISSION_OUTCOME_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CALL_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("STATUS", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ROUTING_PLAN_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CREATED_DATE", String.Empty, "DATE"));
			columns.Add(new Column("LAST_ERROR_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("MODIFIED_DATE", String.Empty, "DATE"));
			columns.Add(new Column("RESUBMITTED_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("RESUBMIT_REASON_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("RESUBMIT_COMMENT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("RESUBMIT_USER_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("RESUBMIT_COUNT", String.Empty, "NUMBER"));
			columns.Add(new Column("LAST_DESTINATION_STRING", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SPECIFIC_DESTINATION_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("SUB_DESTINATION_STRING", String.Empty, "VARCHAR2"));
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="TransmissionOutcome"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public TransmissionOutcome(IDataReader reader)
			: base(reader, "TRANSMISSION_OUTCOME")
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="TransmissionOutcome"/> class.
		/// </summary>
		/// <param name="rec">The rec.</param>
		public TransmissionOutcome(ITransmissionOutcome rec): this()
		{
			TransmissionOutcomeId = rec.OutcomeId;
			CallId = rec.CallId;
			Status = rec.Status;
			RoutingPlanId = rec.RoutingPlanId;
			SpecificDestinationId = rec.SpecificDestinationId;
			LastErrorText = rec.LastErrorText;
			LastDestinationString = rec.LastDestinationString;
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
		#region CallId
		/// <summary>
		/// Gets or sets the call id.
		/// </summary>
		/// <value>The call id.</value>
		public string CallId
		{
			get
			{
				return GetColumnValue("CALL_ID");
			}
			set
			{
				SetColumnValue("CALL_ID", value);
			}
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
		#region RoutingPlanId
		/// <summary>
		/// Gets or sets the routing plan id.
		/// </summary>
		/// <value>The routing plan id.</value>
		public string RoutingPlanId
		{
			get
			{
				return GetColumnValue("ROUTING_PLAN_ID");
			}
			set
			{
				SetColumnValue("ROUTING_PLAN_ID", value);
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
		#region LastErrorText
		/// <summary>
		/// Gets or sets the last error text.
		/// </summary>
		/// <value>The last error text.</value>
		public string LastErrorText
		{
			get
			{
				return GetColumnValue("LAST_ERROR_TEXT");
			}
			set
			{
				SetColumnValue("LAST_ERROR_TEXT", value);
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
		#region LastDestinationString
		/// <summary>
		/// Gets or sets the last destination string.
		/// </summary>
		/// <value>The last destination string.</value>
		public string LastDestinationString
		{
			get
			{
				return GetColumnValue("LAST_DESTINATION_STRING");
			}
			set
			{
				SetColumnValue("LAST_DESTINATION_STRING", value);
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
		#region SubDestinationString
		/// <summary>
		/// Gets or sets the sub destination string.
		/// </summary>
		/// <value>The sub destination string.</value>
		public string SubDestinationString
		{
			get
			{
				return GetColumnValue("SUB_DESTINATION_STRING");
			}
			set
			{
				SetColumnValue("SUB_DESTINATION_STRING", value);
			}
		}
		#endregion
		/// <summary>
		/// converts dbclass to message.
		/// </summary>
		/// <returns></returns>
		public Outcome ToOutcome ()
		{
			Outcome results = new Outcome();
			
			results.Id = TransmissionOutcomeId;
			results.CallId = CallId;
			results.Status = Status;
			results.RoutingPlanId = RoutingPlanId;
			results.LastError = LastError;
			results.SpecificDestinationId = SpecificDestinationId;
			results.LastErrorText = LastErrorText;

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
			sql.AppendFormat(",LAST_DESTINATION_STRING = '{0}'", LastDestinationString);
			sql.AppendFormat(",SUB_DESTINATION_STRING = '{0}'", SubDestinationString);
			sql.AppendFormat(",LAST_ERROR_TEXT = '{0}'\r\n", LastErrorText);
			sql.Append(GeneratePrimaryKeyWhereClause());
			return sql.ToString();
		}

		/// <summary>
		/// Generates the insert SQL.
		/// </summary>
		/// <returns></returns>
		protected override string GenerateInsertSql()
		{
			StringBuilder sql = new StringBuilder();
			sql.AppendFormat("INSERT INTO {0} (ROUTING_PLAN_ID, CALL_ID, STATUS) ", Name);
			sql.AppendFormat("VALUES ({0}, {1}, '{2}')", RoutingPlanId, CallId, Status);
			return sql.ToString();
		}

		/// <summary>
		/// Generates the where clause.
		/// </summary>
		/// <returns></returns>
		protected override string GenerateWhereClause ()
		{
			if (string.IsNullOrEmpty(TransmissionOutcomeId))
				Where = string.Format("ROUTING_PLAN_ID = {0} AND CALL_ID = {1}", RoutingPlanId, CallId);
			return base.GenerateWhereClause();
		}

		/// <summary>
		/// Updates the outcome status using lock.
		/// </summary>
		/// <param name="current">The current.</param>
		/// <param name="newStatus">The new status.</param>
		/// <param name="instance">The instance.</param>
		/// <returns></returns>
		static public bool UpdateOutcomeStatusUsingLock (ITransmissionOutcome current, string newStatus, string instance)
		{
			bool results = false;
			try
			{
				ChangeTransOutcomeStatus outcome = new ChangeTransOutcomeStatus(instance);
				outcome.TransmissionId = current.OutcomeId;
				outcome.OldStatus = current.Status;
				outcome.NewStatus = newStatus;
				if (outcome.OldStatus != outcome.NewStatus)
				{
					outcome.Execute();
					results = outcome.Result.Equals("1");
				}
			}
			catch (Exception ex)
			{
				GeneralUtility.LogError(ex.Message, "UpdateOutcomeStatusUsingLock");
				results = false;
			}
			return results;
		}
		/// <summary>
		/// Creates the transmission outcome record.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="routingPlan">The routing plan.</param>
		/// <param name="callId">The call id.</param>
		/// <returns></returns>
		static public bool CreateTransmissionOutcomeRecord(string instance, string routingPlan, string callId)
		{
			bool results = false;
			try
			{
				TransmissionOutcome outcome = new TransmissionOutcome();
				outcome.Instance = instance;
				outcome.RoutingPlanId = routingPlan;
				outcome.Status = "UNPROCESSED";
				outcome.CallId = callId;
				if(!outcome.Insert())
					throw new ApplicationException(outcome.LastErrorText);
			}
			catch (Exception ex)
			{
				GeneralUtility.LogError(ex.Message, "UpdateOutcomeStatusUsingLock");
				results = false;
			}
			return results;
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/TransmissionOutcome.cs $
 * 
 * 10    7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 9     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 8     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 7     8/19/08 6:24p John.gwynn
 * added ability to retrieve record using RoutingPlanId and CallId combo 
 * 
 * 6     8/17/08 7:14p John.gwynn
 * added support for creating an Outcome record given a specific routing
 * plan and callId
 * 
 * 5     8/27/07 12:10p John.gwynn
 * 
 * 4     7/10/07 4:54p John.gwynn
 * added Interfaces folder, and interfaces for outcome and outcome step.
 * Added support for Insert and Update of active records and
 * GetNextSequence() method to retrieve a primary key prior to insert
 * 
 * 3     6/26/07 2:43p John.gwynn
 * 
 * 2     6/03/07 2:52p John.gwynn
 * added Transmissionxxx to ActiveRecordSet factory method and verified
 * unit tests
 * 
 * 1     6/03/07 2:07p John.gwynn
 */
#endregion