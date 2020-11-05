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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AutoModelRecordSet.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates recordset for FNSOWNER.AUTO_MAKE
	/// </summary>
	[ComVisible(false)]
	public sealed class AutoModelRecordSet : ActiveRecordSet
	{
		private string _makeCode;
		/// <summary>
		/// Initializes a new instance of the <see cref="AutoModelRecordSet"/> class.
		/// </summary>
		public AutoModelRecordSet() : base("AutoModelRecord")
		{}
		/// <summary>
		/// Gets or sets the make code.
		/// </summary>
		/// <value>The make code.</value>
		public string MakeCode
		{
			get{ return _makeCode; }
			set{ _makeCode = value; }
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
					query = String.Format("select AUTO_MODEL_ID, MAKE_CODE, MODEL_CODE, MODEL_DESCRIPTION from AUTO_MODEL WHERE MAKE_CODE = '{0}' ORDER BY MODEL_DESCRIPTION",
						_makeCode);
				}
				return query;
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AutoModelRecordSet.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     10/01/07 12:08p John.gwynn
 */
#endregion