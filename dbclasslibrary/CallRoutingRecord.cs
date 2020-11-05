#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2008 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/CallRoutingRecord.cs 6     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    [ComVisible(false)]
    public class CallRoutings : ActiveRecordSet<CallRoutingRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRecords"/> class.
        /// </summary>
        public CallRoutings()
            : base("CallRoutingRecord")
        { }
    }
	/// <summary>
	/// Encapsulates the CALL_ROUTING table 
	/// </summary>
	[ComVisible(false)]
	public class CallRoutingRecord : ActiveRecord
	{
        /// <summary>
        /// CallRouting check to ensire status
        /// </summary>
        public static readonly string[] ValidcallStatus = new[] 
                                                              {
                                                                  "COMPLETED",
                                                                  "ABORTED",
                                                                  "ABANDONED",
                                                                  "HOLD",
                                                                  "PEND",
                                                                  "PENDED"                                                                  
                                                              };

		/// <summary>
		/// Initializes a new instance of the <see cref="CallRoutingRecord"/> class.
		/// </summary>
		public CallRoutingRecord(): base("CALL_ROUTING")
		{
			columns.Add(new Column("CALL_ROUTING_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CALL_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("FINAL_SAVE_STATUS", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ROUTING_STATUS", String.Empty, "VARCHAR2"));
			columns.Add(new Column("USER_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("LAST_MESSAGE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SERVER_NAME", String.Empty, "VARCHAR2"));
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="CallRoutingRecord"/> class.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public CallRoutingRecord(IDataReader reader)
            : base(reader, "CALL_ROUTING")
        {
        }

		#region CallRoutingId
		/// <summary>
		/// Gets or sets the call routing id.
		/// </summary>
		/// <value>The call routing id.</value>
		public string CallRoutingId
		{
			get
			{
				return GetColumnValue("CALL_ROUTING_ID");
			}
			set
			{
				SetColumnValue("CALL_ROUTING_ID", value);
			}
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
		#region FinalSaveStatus
		/// <summary>
		/// Gets or sets the final save status.
		/// </summary>
		/// <value>The final save status.</value>
		public string FinalSaveStatus
		{
			get
			{
				return GetColumnValue("FINAL_SAVE_STATUS");
			}
			set
			{
				SetColumnValue("FINAL_SAVE_STATUS", value);
			}
		}
		#endregion
		#region RoutingStatus
		/// <summary>
		/// Gets or sets the routing status.
		/// </summary>
		/// <value>The routing status.</value>
		public string RoutingStatus
		{
			get
			{
				return GetColumnValue("ROUTING_STATUS");
			}
			set
			{
				SetColumnValue("ROUTING_STATUS", value);
			}
		}
		#endregion
		#region UserId
		/// <summary>
		/// Gets or sets the user id.
		/// </summary>
		/// <value>The user id.</value>
		public string UserId
		{
			get
			{
				return GetColumnValue("USER_ID");
			}
			set
			{
				SetColumnValue("USER_ID", value);
			}
		}
		#endregion
		#region LastMessage
		/// <summary>
		/// Gets or sets the last message.
		/// </summary>
		/// <value>The last message.</value>
		public string LastMessage
		{
			get
			{
				return GetColumnValue("LAST_MESSAGE");
			}
			set
			{
				SetColumnValue("LAST_MESSAGE", value);
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

        /// <summary>
        /// Creates the call routing record from call record.
        /// </summary>
        /// <param name="call">The call.</param>
        /// <param name="finalStatus">The final status.</param>
        /// <returns></returns>
        static public bool CreateCallRoutingRecordFromCallRecord(CallRecord call, string finalStatus)
        {
            var results = false;

            try
            {
                if(string.IsNullOrEmpty(finalStatus) || 
                    !IsValidCallStatus(finalStatus)) throw new ApplicationException("Empty or Invalid status");

                var record = new CallRoutingRecord
                {
                    CallId = call.CallId,
                    Instance = call.Instance,
                    FinalSaveStatus = finalStatus,
                    RoutingStatus = "UNPROCESSED",
                    UserId = call.UserId,
                    ServerName = Environment.MachineName
                };
                results = record.Insert();
            }
            catch (Exception ex)
            {
                GeneralUtility.LogError(ex.Message, "CreateCallRoutingRecordFromCallRecord");
            }
            return results;
        }

	    private static bool IsValidCallStatus(string status)
	    {
	        foreach (var val in ValidcallStatus)
                if(val.Contains(status)) return true;
	        return false;
	    }

	    /// <summary>
		/// Creates the call routing record from call record.
		/// </summary>
		/// <param name="call">The call.</param>
		/// <returns></returns>
		static public bool CreateCallRoutingRecordFromCallRecord (CallRecord call)
		{
            return CreateCallRoutingRecordFromCallRecord(call, call.Status);
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/CallRoutingRecord.cs $
 * 
 * 6     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 5     5/06/10 3:55p Ashley.pinto
 * Added IFTCO specific PENDED call status.
 * 
 * 4     4/16/10 5:24p Gwynnj
 * Added support for CallMonitor to manage INPROC calls that are abandoned
 * 
 * 3     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     4/03/08 7:33p John.gwynn
 * built in support for Call Final Save via CallRouting table
 */
#endregion