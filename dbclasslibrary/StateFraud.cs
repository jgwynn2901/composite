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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/StateFraud.cs 6     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class StateFraud : ActiveRecord
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="StateFraud"/> class.
		/// </summary>
		public StateFraud(): base("STATE_FRAUD")
		{
			// Begin AutoGenerated Column Definitions
			columns.Add(new Column("STATE_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STATE_CODE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FRAUD_TEXT", String.Empty, "VARCHAR2"));
			primaryKeyIndex = 1;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="StateFraud"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public StateFraud(IDataReader reader): base(reader, "STATE_FRAUD")
		{
			primaryKeyIndex = 2;
		}

		#region StateName
		/// <summary>
		/// Gets or sets the state code.
		/// </summary>
		/// <value>The state code.</value>
		public string StateName
		{
			get
			{
				return GetColumnValue("STATE_NAME");
			}
			set
			{
				SetColumnValue("STATE_NAME", value);
			}
		}
		#endregion
		#region Script
		/// <summary>
		/// Gets or sets the state code.
		/// </summary>
		/// <value>The state code.</value>
		public string Script
		{
			get
			{
				return GetColumnValue("FRAUD_TEXT");
			}
			set
			{
				SetColumnValue("FRAUD_TEXT", value);
			}
		}
		#endregion
		#region StateCode
		/// <summary>
		/// Gets or sets the state code.
		/// </summary>
		/// <value>The state code.</value>
		public string StateCode
		{
			get
			{
				return GetColumnValue("STATE_CODE");
			}
			set
			{
				SetColumnValue("STATE_CODE", value);
			}
		}
		#endregion
		/// <summary>
		/// Gets the script by state code.
		/// </summary>
		/// <param name="code">The code.</param>
		/// <returns>Script for given state code</returns>
		static public string GetScriptByStateCode(string code)
		{
			return GetScriptByStateCode(code, ApplicationConfiguration.Instance.DefaultInstance);
		}
		/// <summary>
		/// Gets the script by state code.
		/// </summary>
		/// <param name="code">The code.</param>
		/// <param name="instance">The instance.</param>
		/// <returns></returns>
		static public string GetScriptByStateCode(string code,string instance)
		{
			string results = string.Empty;
			if (code.Length == 2)
			{
				StateFraud fraud = new StateFraud();
				fraud.StateCode = code;
				fraud.Instance = instance;
				if (fraud.Execute())
				{
					results = fraud.Script;
				}
			}
			return results;
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/StateFraud.cs $
 * 
 * 6     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 5     10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
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
 * 3     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 2     4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 1     1/30/08 3:28p John.gwynn
 * Added StateFraud script for Esurance phase III
 */
#endregion