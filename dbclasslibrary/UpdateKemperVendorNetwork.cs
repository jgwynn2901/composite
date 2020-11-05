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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateKemperVendorNetwork.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion
using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// remove any and all VENDOR records from KMP load that were NOT
	/// touched by the most recent load (fileTranLogId)
	/// Kemper requires each load to be full refresh. 
	/// </summary>
	[ComVisible(false)]	
	public class UpdateKemperVendorNetwork :DbBaseClass
	{
		private enum eParmList 
		{
			/// <summary>
			/// FileTranLogId of the current LOAD (IN)
			/// </summary>
			FileTranLogId = 0,
			/// <summary>
			/// Number of VENDOR records affected (OUT)
			/// </summary>
			RecordCount
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateKemperVendorNetwork"/> class.
		/// </summary>
		public UpdateKemperVendorNetwork() :this(String.Empty) {}	
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateKemperVendorNetwork"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public UpdateKemperVendorNetwork(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.UpdateKemperVendorNetwork";

			_parameterNames = new string[]
			{
				"p_fileTranLogId",
				"p_recordCount"
			};
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
			//// FileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// RecordCount
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.RecordCount],"",System.Data.DbType.Int32);
		}	
		#endregion
		#region FileTranLogId
		/// <summary>
		/// Gets or sets the file tran log id.
		/// </summary>
		/// <value>The file tran log id.</value>
		public string FileTranLogId
		{
			get 
			{
				return GetValue((int)eParmList.FileTranLogId);
			}
			set 
			{
				SetValue((int)eParmList.FileTranLogId,value);
			}
		}
		#endregion
		#region RecordCount
		/// <summary>
		/// Gets the record count.
		/// </summary>
		/// <value>The record count.</value>
		public string RecordCount
		{
			get 
			{
				return GetValue((int)eParmList.RecordCount);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateKemperVendorNetwork.cs $
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
 * 1     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 */
#endregion

