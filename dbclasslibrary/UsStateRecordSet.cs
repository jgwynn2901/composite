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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/UsStateRecordSet.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Collections.Generic;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates recordset for FNSOWNER.US_STATES
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class UsStateRecordSet : ActiveRecordSet
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UsStateRecordSet"/> class.
		/// </summary>
		public UsStateRecordSet(): base("UsState")
		{}
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
					query = String.Format("select STATE_CODE, DESCRIPTION from US_STATES ORDER BY DESCRIPTION");
				}
				return query;
			}
		}
		#endregion
		/// <summary>
		/// Gets the us states.
		/// </summary>
		/// <returns></returns>
		public static List<UsState> GetUsStates ()
		{
			UsStateRecordSet states = new UsStateRecordSet();
			List<UsState> results = new List<UsState>();
			if(states.Execute())
			{
				foreach(UsState s in states)
				{
					results.Add(s);
				}
			}
			return results;
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/UsStateRecordSet.cs $
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     1/30/08 3:28p John.gwynn
 * Added StateFraud script for Esurance phase III
 */
#endregion