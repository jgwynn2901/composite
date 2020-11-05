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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/CopyAttributesRecordSet.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates Recorset for FNSOWNER.COPY.ATTRIBUTES
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class CopyAttributesRecordSet : ActiveRecordSet
	{
		private string _groupName;

		/// <summary>
		/// Initializes a new instance of the <see cref="CopyAttributesRecordSet"/> class.
		/// </summary>
		public CopyAttributesRecordSet()
			: base("CopyAttributesRecord")
		{}
		/// <summary>
		/// Gets or sets the name of the group.
		/// </summary>
		/// <value>The name of the group.</value>
		public string GroupName
		{
			get { return _groupName; }
			set { _groupName = value; }
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
					query = String.Format("select * from COPY_ATTRIBUTES where GROUP_NAME = '{0}' ", _groupName);
				}
				return query;
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/CopyAttributesRecordSet.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     8/27/07 12:10p John.gwynn
 */
#endregion