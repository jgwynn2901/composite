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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/CrawfordNcciCodes.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for CrawfordNcciCodes.
	/// </summary>
	[ComVisible(false)]	
	public sealed class CrawfordNcciCodes : DbBaseClass
	{
		private enum eParmList 
		{
			eCraNcciClassCodeId = 0,
			eAhsId,
			eLobCode,
			eJobCode,
			eStateCode,
			eNcciCode
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="CrawfordNcciCodes"/> class.
		/// </summary>
		public CrawfordNcciCodes():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="CrawfordNcciCodes"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public CrawfordNcciCodes(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessCrawfordNcciRecord";

			_parameterNames = new string[] {
																			 "p_CraNcciClassCodeId",
																			 "p_AHSID",
																			 "p_LobCode",
																			 "p_JobCode",
																			 "p_StateCode",
																			 "p_NcciCode" };
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
			/////p_CraNcciClassCodeId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
			        _parameterNames[(int)eParmList.eCraNcciClassCodeId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_AHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eAhsId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_LobCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eLobCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_JobCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eJobCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_StateCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eStateCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_NcciCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eNcciCode],"",System.Data.DbType.AnsiString);
			#endregion
			
		}
		#region Public Properties
		
		/// <summary>
		/// Gets the cra ncci class code id.
		/// </summary>
		/// <value>The cra ncci class code id.</value>
		public int CraNcciClassCodeId 
		{
			get 
			{
				string result = GetValue((int) eParmList.eCraNcciClassCodeId);
				return result.Length > 0 ? Convert.ToInt32(result): -1;
			}
		}
		/// <summary>
		/// Gets or sets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string AhsId
		{
			get 
			{
				return GetValue((int)eParmList.eAhsId);
			}
			set 
			{
				SetValue((int)eParmList.eAhsId,value);
			}
		}
		/// <summary>
		/// Gets or sets the lob code.
		/// </summary>
		/// <value>The lob code.</value>
		public string LobCode
		{
			get 
			{
				return GetValue((int)eParmList.eLobCode);
			}
			set 
			{
				SetValue((int)eParmList.eLobCode,value);
			}
		}
		/// <summary>
		/// Gets or sets the job code.
		/// </summary>
		/// <value>The job code.</value>
		public string JobCode
		{
			get 
			{
				return GetValue((int)eParmList.eJobCode);
			}
			set 
			{
				SetValue((int)eParmList.eJobCode,value);
			}
		}
		/// <summary>
		/// Gets or sets the state code.
		/// </summary>
		/// <value>The state code.</value>
		public string StateCode
		{
			get 
			{
				return GetValue((int)eParmList.eStateCode);
			}
			set 
			{
				SetValue((int)eParmList.eStateCode,value);
			}
		}
		/// <summary>
		/// Gets or sets the ncci code.
		/// </summary>
		/// <value>The ncci code.</value>
		public string NcciCode
		{
			get 
			{
				return GetValue((int)eParmList.eNcciCode);
			}
			set 
			{
				SetValue((int)eParmList.eNcciCode,value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/CrawfordNcciCodes.cs $
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