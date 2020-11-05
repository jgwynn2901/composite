#region File Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 1993-2005 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AHSPolicy.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for AHS_POLICY table.
	/// </summary>
	[ComVisible(false)]	
// ReSharper disable InconsistentNaming
	public sealed class AHSPolicy :DbBaseClass
// ReSharper restore InconsistentNaming
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="AHSPolicy"/> class.
		/// </summary>
		public AHSPolicy() :this(String.Empty)
		{
		}
		/// <summary>
		/// user can name db instance
		/// </summary>
		/// <param name="instance"></param>
		public AHSPolicy(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessAHSPolicy";
			
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Set up parameter definitions here
		/// </summary>
		/// <remarks>
		/// the definitions can be defined externally (configuration) 
		/// and iterated here for maximum flexibility
		/// </remarks>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////p_nAHSPOLID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_nAHSPOLID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nAHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAHSID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nPolicyID	
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nPolicyID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nLOB_CD
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nLOB_CD","TST",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nFileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nFileTranLogId","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nActiveStartDt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nActiveStartDt","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nActiveEndDt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nActiveEndDt","",System.Data.DbType.Date);
		}
		#endregion
		#region AHSPOLID
		/// <summary>
		/// AHSPOLID property
		/// </summary>
		public string AHSPOLID 
		{
			get 
			{
				return GetValue("p_nAHSPOLID");
			}
		}
		#endregion
		#region AHSID
		/// <summary>
		/// AHSID property
		/// </summary>
		public string AHSID 
		{
			get 
			{
				return GetValue("p_nAHSID");
			}
			set 
			{
				SetValue("p_nAHSID",value);
			}
		}
		#endregion
		#region PolicyID
		/// <summary>
		/// PolicyID property
		/// </summary>
		public string PolicyID 
		{
			get 
			{
				return GetValue("p_nPolicyID");
			}
			set 
			{
				SetValue("p_nPolicyID",value);
			}
		}
		#endregion
		#region LOB_CD
		/// <summary>
		/// LOB_CD property
		/// </summary>
		public string LOB_CD 
		{
			get 
			{
				return GetValue("p_nLOB_CD");
			}
			set 
			{
				SetValue("p_nLOB_CD",value);
			}
		}
		#endregion
		#region FileTranLogId
		/// <summary>
		/// FileTranLogId property
		/// </summary>
		public string FileTranLogId 
		{
			get 
			{
				return GetValue("p_nFileTranLogId");
			}
			set 
			{
				SetValue("p_nFileTranLogId",value);
			}
		}
		#endregion
		#region ActiveStartDt
		/// <summary>
		/// ActiveStartDt property
		/// </summary>
		public string ActiveStartDt 
		{
			get 
			{
				return GetValue("p_nActiveStartDt");
			}
			set 
			{
				SetValue("p_nActiveStartDt",value);
			}
		}
		#endregion
		#region ActiveEndDt
		/// <summary>
		/// ActiveEndDt property
		/// </summary>
		public string ActiveEndDt 
		{
			get 
			{
				return GetValue("p_nActiveEndDt");
			}
			set 
			{
				SetValue("p_nActiveEndDt",value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AHSPolicy.cs $
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
 * 5     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 4     5/08/06 6:46p John.gwynn
 * Formatting updates and support for SENP and CRAWP utilities
 * 
 * 3     4/06/06 6:16p John.gwynn
 * Added NcciCode and AhsIdFromLocation
 * 
 * 2     3/04/06 5:27p John.gwynn
 * added the ability to set dbInstance in constructor
 * 
 * 1     11/17/05 5:55p John.gwynn
 * Added AHSPolicy and Driver
 */
#endregion