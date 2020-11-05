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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AutoMakeRecordSet.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates recordset for FNSOWNER.AUTO_MAKE
	/// </summary>
	[ComVisible(false)]
	public sealed class AutoMakeRecordSet : ActiveRecordSet
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AutoMakeRecordSet"/> class.
		/// </summary>
		public AutoMakeRecordSet() : base("AutoMakeRecord")
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
					query = String.Format("select MAKE_CODE, MAKE_DESCRIPTION from AUTO_MAKE ORDER BY MAKE_DESCRIPTION");
				}
				return query;
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AutoMakeRecordSet.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     10/01/07 12:08p John.gwynn
 */
#endregion