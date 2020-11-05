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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/FileTranLogRecord.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion


using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	
	
	/// <summary>
	/// Summary description for FileTranLogRecord.
	/// </summary>
	[ComVisible(false)]
	public class FileTranLogRecord : DbBaseClass
	{
		private enum eParmList 
		{
			eFileTranLogId = 0,
			eFileTranDefId,
			eFileName,
			eStatus,
			eServer,
			eParentId
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="FileTranLogRecord"/> class.
		/// </summary>
		public FileTranLogRecord():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="FileTranLogRecord"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public FileTranLogRecord(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.CreateFileTranLogRecord";

			_parameterNames = new string[] {
																			 "p_nFileTranLogId",
																			 "p_nFileTranDefId",
																			 "p_nFileName",
																			 "p_nStatus",
																			 "p_nServer",
																			 "p_nParenId" };
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
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.eFileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_nFileTranDefId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eFileTranDefId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nFileName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eFileName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nStatus
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eStatus],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nServer
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eServer],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nParenId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eParentId],"",System.Data.DbType.Int32);
		}
		#endregion
		#region Public Properties
		
		/// <summary>
		/// Gets the file tran log id.
		/// </summary>
		/// <value>The file tran log id.</value>
		public int FileTranLogId 
		{
			get 
			{
				string result = GetValue((int) eParmList.eFileTranLogId);
				return result.Length > 0 ? Convert.ToInt32(result): -1;
			}
		}
		/// <summary>
		/// Gets or sets the file tran def id.
		/// </summary>
		/// <value>The file tran def id.</value>
		public string FileTranDefId
		{
			get 
			{
				return GetValue((int)eParmList.eFileTranDefId);
			}
			set 
			{
				SetValue((int)eParmList.eFileTranDefId,value);
			}
		}
		/// <summary>
		/// Gets or sets the name of the file.
		/// </summary>
		/// <value>The name of the file.</value>
		public string FileName
		{
			get 
			{
				return GetValue((int)eParmList.eFileName);
			}
			set 
			{
				SetValue((int)eParmList.eFileName,value);
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
		/// <summary>
		/// Gets or sets the server.
		/// </summary>
		/// <value>The server.</value>
		public string Server
		{
			get 
			{
				return GetValue((int)eParmList.eServer);
			}
			set 
			{
				SetValue((int)eParmList.eServer,value);
			}
		}
		/// <summary>
		/// Gets or sets the parent id.
		/// </summary>
		/// <value>The parent id.</value>
		public string ParentId
		{
			get 
			{
				return GetValue((int)eParmList.eParentId);
			}
			set 
			{
				SetValue((int)eParmList.eParentId,value);
			}
		}
		#endregion
		
		/// <summary>
		/// Updates the status.
		/// </summary>
		/// <param name="status">The status.</param>
		/// <returns></returns>
		public bool UpdateStatus (string status)
		{
			bool results = false;
			
			if (status.Length > 0)
			{
				FileTranLogUpdate update = new FileTranLogUpdate(_databaseInstance);
				update.FileTranLogId = GetValue((int) eParmList.eFileTranLogId);
				update.Status = status;
				results = update.Execute();	
			}
			return results;
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/FileTranLogRecord.cs $
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