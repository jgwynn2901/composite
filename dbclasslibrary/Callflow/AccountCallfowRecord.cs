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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/AccountCallflow.cs 7     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;

namespace DbClassLibrary.Callflow
{
    public class AccountCallflows : ActiveRecordSet<AccountCallflow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Callflow"/> class.
        /// </summary>
        public AccountCallflows()
            : base("AccountCallflow")
        { }

        public int AhsId { get; set; }
        public string LineOfBusiness { get; set; }
        public int CallflowId { get; set; }

        public override string Query
        {
            get
            {
                return string.IsNullOrEmpty(query)
                    ? string.Format("select * from ACCOUNT_CALLFLOW where {0}", BuildWhereClause())
                    : query;
            }
        }

        private string BuildWhereClause()
        {
            return CallflowId > 0
                ? string.Format(" callflow_id = {0}", CallflowId)
                : string.Format(" accnt_hrcy_step_id = {0} and LOB_CD = '{1}' and call_start_flg <>'Y'", AhsId, LineOfBusiness);
        }
    }
	/// <summary>
	/// 
	/// </summary>
	public sealed class AccountCallflow: ActiveRecord
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="AccountCallflow"/> class.
		/// </summary>
		public AccountCallflow()
			: base("ACCOUNT_CALLFLOW")
		{
			// Begin Generated Column Definitions
			columns.Add(new Column("ACCOUNTCALLFLOW_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ACCNT_HRCY_STEP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CALLFLOW_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("LOB_CD", String.Empty, "CHAR"));
			columns.Add(new Column("CALL_START_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("VALIDRULE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("GROUP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ACTIVE_START_DT", String.Empty, "DATE"));
			columns.Add(new Column("ACTIVE_END_DT", String.Empty, "DATE"));
			columns.Add(new Column("CALLFLOW_TYPE", String.Empty, "VARCHAR2"));
    		// End Generated Column Definitions
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="AccountCallflow"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public AccountCallflow(IDataReader reader)
			: base(reader, "ACCOUNT_CALLFLOW")
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AccountCallflow"/> class.
		/// </summary>
		/// <param name="source">The source.</param>
		public AccountCallflow(ActiveRecord source)
			: base(source)
		{ }

		#endregion
		#region AccountcallflowId
		/// <summary>
		/// Gets or sets the accountcallflow id.
		/// </summary>
		/// <value>The accountcallflow id.</value>
		public string AccountcallflowId
		{
			get
			{
				return GetColumnValue("ACCOUNTCALLFLOW_ID");
			}
			set
			{
				SetColumnValue("ACCOUNTCALLFLOW_ID", value);
			}
		}
		#endregion
		#region AccntHrcyStepId
		/// <summary>
		/// Gets or sets the accnt hrcy step id.
		/// </summary>
		/// <value>The accnt hrcy step id.</value>
		public int AccntHrcyStepId
		{
			get
			{
				return GetColumnValueAsInt("ACCNT_HRCY_STEP_ID") ?? 0;
			}
			set
			{
				SetColumnValue("ACCNT_HRCY_STEP_ID", value.ToString());
			}
		}
		#endregion
		#region CallflowId
		/// <summary>
		/// Gets or sets the callflow id.
		/// </summary>
		/// <value>The callflow id.</value>
		public int CallflowId
		{
			get
			{
				return GetColumnValueAsInt("CALLFLOW_ID") ?? 0;
			}
			set
			{
				SetColumnValue("CALLFLOW_ID", value.ToString());
			}
		}
		#endregion
		#region LobCd
		/// <summary>
		/// Gets or sets the lob cd.
		/// </summary>
		/// <value>The lob cd.</value>
		public string LobCd
		{
			get
			{
				return GetColumnValue("LOB_CD");
			}
			set
			{
				SetColumnValue("LOB_CD", value);
			}
		}
		#endregion
		#region CallStartFlg
		/// <summary>
		/// Gets or sets the call start FLG.
		/// </summary>
		/// <value>The call start FLG.</value>
		public string CallStartFlg
		{
			get
			{
				return GetColumnValue("CALL_START_FLG");
			}
			set
			{
				SetColumnValue("CALL_START_FLG", value);
			}
		}
		#endregion
		#region ValidRuleId
		/// <summary>
		/// Gets or sets the valid rule id.
		/// </summary>
		/// <value>The valid rule id.</value>
		public string ValidRuleId
		{
			get
			{
				return GetColumnValue("VALIDRULE_ID");
			}
			set
			{
				SetColumnValue("VALIDRULE_ID", value);
			}
		}
		#endregion
		#region GroupId
		/// <summary>
		/// Gets or sets the group id.
		/// </summary>
		/// <value>The group id.</value>
		public string GroupId
		{
			get
			{
				return GetColumnValue("GROUP_ID");
			}
			set
			{
				SetColumnValue("GROUP_ID", value);
			}
		}
		#endregion
		#region ActiveStartDt
		/// <summary>
		/// Gets or sets the active start dt.
		/// </summary>
		/// <value>The active start dt.</value>
		public string ActiveStartDt
		{
			get
			{
				return GetColumnValue("ACTIVE_START_DT");
			}
			set
			{
				SetColumnValue("ACTIVE_START_DT", value);
			}
		}
		#endregion
		#region ActiveEndDt
		/// <summary>
		/// Gets or sets the active end dt.
		/// </summary>
		/// <value>The active end dt.</value>
		public string ActiveEndDt
		{
			get
			{
				return GetColumnValue("ACTIVE_END_DT");
			}
			set
			{
				SetColumnValue("ACTIVE_END_DT", value);
			}
		}
		#endregion
		#region CallflowType
		/// <summary>
		/// Gets or sets the type of the callflow.
		/// </summary>
		/// <value>The type of the callflow.</value>
		public string CallflowType
		{
			get
			{
				return GetColumnValue("CALLFLOW_TYPE");
			}
			set
			{
				SetColumnValue("CALLFLOW_TYPE", value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/AccountCallflow.cs $
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
 * 5     5/26/09 7:03p John.gwynn
 * Added deep cloning and ToArray, ToList support (ToArray is for interop
 * ToList is because we have no LINQ today)
 * 
 * 4     5/26/09 11:06a John.gwynn
 * Added interop definitions
 * 
 * 3     6/03/07 2:09p John.gwynn
 * 
 * 2     4/23/07 6:23p John.gwynn
 * Added interop wrapper classes (work in progress)
 * 
 * 1     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 */
#endregion
