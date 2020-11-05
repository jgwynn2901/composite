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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/EstarAppraiserDelete.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class EstarAppraiserDelete : DbBaseClass
	{

		#region Constructor
		/// <summary>
		/// 
		/// </summary>
		public EstarAppraiserDelete()
			: this(String.Empty)
		{ }
		/// <summary>
		/// 
		/// </summary>
		public EstarAppraiserDelete(string instance)
			: base(instance)
		{
			_name = "DBCLASSLIBRARY.DELETEFROMESTAR";
			_parameterNames = new string[] { "p_CallID" };
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// 
		/// </summary>
		protected override void Initialize()
		{

			AddParm(System.Data.ParameterDirection.Input, "p_CallId", "", System.Data.DbType.AnsiString);
		}

		/// <summary>
		/// 
		/// </summary>
		public string CallId
		{
			get
			{
				return GetValue("p_CallId");
			}
			set
			{
				SetValue("p_CallId", value);
			}
		}
		#endregion

	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/EstarAppraiserDelete.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     7/21/08 3:00p Deepika.sharma
 * 
 * 1     7/21/08 2:50p Deepika.sharma
 * 
 * 3     3/07/08 11:47a Deepika.sharma
 * dms: comments
 * 
 * 2     1/07/08 12:19p Deepika.sharma
 * dms: Added callid 
 * 
 * 1     11/27/07 2:28p Deepika.sharma
 */
#endregion
