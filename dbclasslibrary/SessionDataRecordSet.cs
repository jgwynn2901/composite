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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SessionDataRecordSet.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class SessionDataRecordSet : ActiveRecordSet
	{
		private readonly string sessionKey;
		/// <summary>
		/// Initializes a new instance of the <see cref="AutoMakeRecordSet"/> class.
		/// </summary>
		public SessionDataRecordSet(string key)
			: base("SessionData")
		{
			sessionKey = key;
		}
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
					query = String.Format("select SESSION_KEY, NAME, VALUE from SESSION_DATA where SESSION_KEY = '{0}'", sessionKey);
				}
				return query;
			}
		}
		#endregion
	}
}
