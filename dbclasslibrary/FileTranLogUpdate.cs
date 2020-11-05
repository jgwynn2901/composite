#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2006 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/FileTranLogUpdate.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion


using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	
	
	/// <summary>
	/// Summary description for FileTranLogUpdate.
	/// </summary>
	[ComVisible(false)]	
	public class FileTranLogUpdate : DbBaseClass
	{
		private enum eParmList 
		{
			eFileTranLogId = 0,
			eStatus
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="FileTranLogUpdate"/> class.
		/// </summary>
		public FileTranLogUpdate():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="FileTranLogUpdate"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public FileTranLogUpdate(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.UpdateFileTranLogStatus";

			_parameterNames = new string[] {
																			 "p_nFileTranLogId",
																			 "p_nStatus" };
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////p_nFileTranLogID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eFileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nStatus
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eStatus],"",System.Data.DbType.AnsiString);
		}
		#endregion

		#region Public Properties
		
		/// <summary>
		/// Gets the file tran log id.
		/// </summary>
		/// <value>The file tran log id.</value>
		public string  FileTranLogId 
		{
			get 
			{
				return GetValue((int)eParmList.eFileTranLogId);
			}
			set 
			{
				SetValue((int)eParmList.eFileTranLogId,value);
			}
		}
		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		public string Status
		{
			get 
			{
				return GetValue((int)eParmList.eStatus);
			}
			set 
			{
				SetValue((int)eParmList.eStatus,value);
			}
		}
		#endregion
		
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/FileTranLogUpdate.cs $
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/04/06 1:11p John.gwynn
 * new classes to support .Net loads for InputProcessingManager
 */
#endregion
