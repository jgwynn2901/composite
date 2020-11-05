#region Header
/**************************************************************************
* Innovation First Notice
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2009 by Innovation First Notice 
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Security/SecurityLog.cs 4     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;

namespace DbClassLibrary.Security
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class SecurityLog : ActiveRecord
	{

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="SecurityLog"/> class.
		/// </summary>
		public SecurityLog()
			: base("SECURITY_LOG")
		{
			columns.Add(new Column("SECURITY_LOG_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("USER_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("LOGON_TIME", String.Empty, "DATE"));
			columns.Add(new Column("PHONEEXTENSION", String.Empty, "CHAR"));
			columns.Add(new Column("LOGOFF_TIME", String.Empty, "DATE"));
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="SecurityLog"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public SecurityLog(IDataReader reader)
			: base(reader, "SECURITY_LOG")
		{ }

		#endregion

		#region Properties

		#region SecurityLogId
		/// <summary>
		/// SECURITY_LOG_ID
		/// </summary>
		public int SecurityLogId
		{

			get { return GetColumnValueAsInt("SECURITY_LOG_ID") ?? -1; }
			set { SetColumnValue("SECURITY_LOG_ID", value.ToString()); }
		}
		#endregion

		#region UserId
		/// <summary>
		/// USER_ID
		/// </summary>
		public string UserId
		{

			get { return GetColumnValue("USER_ID"); }
			set { SetColumnValue("USER_ID", value); }
		}
		#endregion

		#region LogonTime
		/// <summary>
		/// LOGON_TIME
		/// </summary>
		public string LogonTime
		{

			get { return GetColumnValue("LOGON_TIME"); }
			set { SetColumnValue("LOGON_TIME", value); }
		}
		#endregion

		#region Phoneextension
		/// <summary>
		/// PHONEEXTENSION
		/// </summary>
		public string Phoneextension
		{

			get { return GetColumnValue("PHONEEXTENSION"); }
			set { SetColumnValue("PHONEEXTENSION", value); }
		}
		#endregion

		#region LogoffTime
		/// <summary>
		/// LOGOFF_TIME
		/// </summary>
		public string LogoffTime
		{

			get { return GetColumnValue("LOGOFF_TIME"); }
			set { SetColumnValue("LOGOFF_TIME", value); }
		}
		#endregion

		#endregion

		#region Overrides

		/// <summary>
		/// Generates the update SQL for this table.
		/// In this case we only update the LogOff time
		/// </summary>
		/// <returns></returns>
		protected override string GenerateUpdateSql()
		{
		  return !string.IsNullOrEmpty(LogoffTime) ? "update SECURITY_LOG set LOGOFF_TIME = sysdate where user_id = :1 and LOGOFF_TIME is null" : "";
		}

	  /// <summary>
		/// N.B. the update SQL is using parameters so they must be added
		/// here in order for the update to resolve correctly.
		/// </summary>
		protected override void AddUpdateParameters()
		{
			AddParameter(UserId);
		}
		#endregion
	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Security/SecurityLog.cs $
 * 
 * 4     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
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
 * 2     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 1     4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 */
#endregion