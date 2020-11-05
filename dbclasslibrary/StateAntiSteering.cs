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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/StateAntiSteering.cs 7     7/13/10 11:39a Gwynnj $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class StateAntiSteering : ActiveRecord
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="StateAntiSteering"/> class.
		/// </summary>
		public StateAntiSteering()
			: base("STATE_ANTI_STEERING")
		{
			columns.Add(new Column("STATE_CODE", String.Empty, "CHAR"));
			columns.Add(new Column("STATE_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STEERING_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CLOSING_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STEERING_ACK", String.Empty, "CHAR"));
			columns.Add(new Column("CLOSING_ACK", String.Empty, "CHAR"));
		}
		#region Properties

		#region StateCode
		/// <summary>
		/// STATE_CODE
		/// </summary>
		public string StateCode
		{

			get { return GetColumnValue("STATE_CODE"); }
			set { SetColumnValue("STATE_CODE", value); }
		}
		#endregion

		#region StateName
		/// <summary>
		/// STATE_NAME
		/// </summary>
		public string StateName
		{

			get { return GetColumnValue("STATE_NAME"); }
			set { SetColumnValue("STATE_NAME", value); }
		}
		#endregion

		#region SteeringText
		/// <summary>
		/// STEERING_TEXT
		/// </summary>
		public string SteeringText
		{

			get { return GetColumnValue("STEERING_TEXT"); }
			set { SetColumnValue("STEERING_TEXT", value); }
		}
		#endregion

		#region ClosingText
		/// <summary>
		/// CLOSING_TEXT
		/// </summary>
		public string ClosingText
		{

			get { return GetColumnValue("CLOSING_TEXT"); }
			set { SetColumnValue("CLOSING_TEXT", value); }
		}
		#endregion

		#region SteeringAck
		/// <summary>
		/// STEERING_ACK
		/// </summary>
		public string SteeringAck
		{

			get { return GetColumnValue("STEERING_ACK"); }
			set { SetColumnValue("STEERING_ACK", value); }
		}
		#endregion

		#region ClosingAck
		/// <summary>
		/// CLOSING_ACK
		/// </summary>
		public string ClosingAck
		{

			get { return GetColumnValue("CLOSING_ACK"); }
			set { SetColumnValue("CLOSING_ACK", value); }
		}
		#endregion
		#endregion

		#region Services

		/// <summary>
		/// Gets the anti-steering or closing text by state code.
		/// </summary>
		/// <param name="code">The code.</param>
		/// <param name="closing">if set to <c>true</c> [closing].</param>
		/// <returns></returns>
		static public string GetTextByStateCode(string code, bool closing)
		{
			return GetTextByStateCode(code, ApplicationConfiguration.Instance.DefaultInstance, closing);
		}

		/// <summary>
		/// Gets the anti-steering text by state code.
		/// </summary>
		/// <param name="code">The code.</param>
		/// <returns>Script for given state code</returns>
		static public string GetTextByStateCode(string code)
		{
			return GetTextByStateCode(code, ApplicationConfiguration.Instance.DefaultInstance, false);
		}

		/// <summary>
		/// Gets the script by state code. overload includes specified instance
		/// </summary>
		static public string GetTextByStateCode(string code, string instance)
		{
			return GetTextByStateCode(code, instance, false);
		}

		/// <summary>
		/// Gets the closing script by state code. 
		/// </summary>
		static public string GetClosingTextByStateCode(string code)
		{
			return GetTextByStateCode(code, ApplicationConfiguration.Instance.DefaultInstance, true);
		}

		/// <summary>
		/// Gets the closing script by state code. overload includes specified instance
		/// </summary>
		static public string GetClosingTextByStateCode(string code, string instance)
		{
			return GetTextByStateCode(code, instance, true);
		}

		/// <summary>
		/// Gets the script by state code.
		/// </summary>
		static public string GetTextByStateCode(string code, string instance, bool closing)
		{
			string results = string.Empty;
			if (code.Length == 2)
			{
				StateAntiSteering steering = new StateAntiSteering();
				steering.StateCode = code;
				steering.Instance = instance;
				if (steering.Execute())
					results = closing ? steering.ClosingText : steering.SteeringText;
			}
			return results;
		}

		/// <summary>
		/// state steering acknowledgement
		/// </summary>
		static public bool StateSteeringAcknowledgment(string stateCode)
		{
			return StateAcknowledgment(stateCode, ApplicationConfiguration.Instance.DefaultInstance, false);
		}

		/// <summary>
		/// state steering acknowledgement overload includes specified instance
		/// </summary>
		static public bool StateSteeringAcknowledgment(string stateCode, string instance)
		{
			return StateAcknowledgment(stateCode, instance, false);
		}

		/// <summary>
		/// state closing acknowledgement
		/// </summary>
		static public bool StateClosingAcknowledgment(string stateCode)
		{
			return StateAcknowledgment(stateCode, ApplicationConfiguration.Instance.DefaultInstance, true);
		}

		/// <summary>
		/// state closing acknowledgement overload includes specified instance
		/// </summary>
		static public bool StateClosingAcknowledgment(string stateCode, string instance)
		{
			return StateAcknowledgment(stateCode, instance, true);
		}

		private static bool StateAcknowledgment(string stateCode, string instance, bool closing)
		{
			if (stateCode.Length == 2)
			{
				StateAntiSteering steering = new StateAntiSteering();
				steering.StateCode = stateCode;
				steering.Instance = instance;
				if (steering.Execute())
					return closing ? steering.ClosingAck.Equals("Y") : steering.SteeringAck.Equals("Y");
			}
			return false;
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/StateAntiSteering.cs $
 * 
 * 7     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 6     10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 5     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     3/11/09 1:33p John.gwynn
 * added comments to public members
 * 
 * 2     2/26/09 4:00p John.gwynn
 * 
 * 1     5/03/08 10:41a John.gwynn
 * added StateAntiSteering
 */
#endregion