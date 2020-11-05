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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Vehicle.cs 7     10/31/09 10:07a Ashley.pinto $ */
using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD for VEHICLE table.
	/// </summary>
	[ComVisible(false)]
	public class Vehicle :DbBaseClass
	{
		/// <summary>
		/// default constructor uses the registry db instance
		/// </summary>
		public Vehicle():this(String.Empty)
		{
		}
		/// <summary>
		/// user can name db instance
		/// </summary>
		/// <param name="instance"></param>
		public Vehicle(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessVehicle";
			Initialize();
		}
		/// <summary>
		/// Set up parameter definitions here
		/// </summary>
		/// <remarks>
		/// the definitions can be defined externally (configuration) 
		/// and iterated here for maximum flexibility
		/// </remarks>
		protected override void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Output, "p_nVehicleID","",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input, "p_nFileTranLogId","",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input, "p_nPolicyID","",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input, "p_nVIN","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nYEAR","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nMAKE","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nMODEL","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nLICENSE_PLATE","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nLICENSE_PLATE_STATE","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nREGISTRATION_STATE","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nCOLOR","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nUploadKey","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nActiveStartDt","",System.Data.DbType.Date);
			AddParm(System.Data.ParameterDirection.Input, "p_nActiveEndDt","",System.Data.DbType.Date);
			AddParm(System.Data.ParameterDirection.Input, "p_nDriver1Number","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nDriver1Percent","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nDriver2Number","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nDriver2Percent","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nMisc","",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nVehicleNumber","",System.Data.DbType.AnsiString);
        }
		/// <summary>
		/// VehicleID property
		/// </summary>
		public string VehicleID 
		{
			get 
			{
				return GetValue("p_nVehicleID");
			}
		}
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
		/// <summary>
		/// VIN property
		/// </summary>
		public string VIN 
		{
			get 
			{
				return GetValue("p_nVIN");
			}
			set 
			{
				SetValue("p_nVIN",value);
			}
		}
		/// <summary>
		/// Year property
		/// </summary>
		public string Year 
		{
			get 
			{
				return GetValue("p_nYEAR");
			}
			set 
			{
				SetValue("p_nYEAR",value);
			}
		}
		/// <summary>
		/// Make property
		/// </summary>
		public string Make 
		{
			get 
			{
				return GetValue("p_nMAKE");
			}
			set 
			{
				SetValue("p_nMAKE",value);
			}
		}
		/// <summary>
		/// Model property
		/// </summary>
		public string Model
		{
			get 
			{
				return GetValue("p_nMODEL");
			}
			set 
			{
				SetValue("p_nMODEL",value);
			}
		}
		/// <summary>
		/// LicensePlate property
		/// </summary>
		public string LicensePlate 
		{
			get 
			{
				return GetValue("p_nLICENSE_PLATE");
			}
			set 
			{
				SetValue("p_nLICENSE_PLATE",value);
			}
		}
		/// <summary>
		/// LicensePlateState property
		/// </summary>
		public string LicensePlateState 
		{
			get 
			{
				return GetValue("p_nLICENSE_PLATE_STATE");
			}
			set 
			{
				SetValue("p_nLICENSE_PLATE_STATE",value);
			}
		}
		/// <summary>
		/// RegistrationState property
		/// </summary>
		public string RegistrationState 
		{
			get 
			{
				return GetValue("p_nREGISTRATION_STATE");
			}
			set 
			{
				SetValue("p_nREGISTRATION_STATE",value);
			}
		}
		/// <summary>
		/// Color property
		/// </summary>
		public string Color 
		{
			get 
			{
				return GetValue("p_nCOLOR");
			}
			set 
			{
				SetValue("p_nCOLOR",value);
			}
		}
		/// <summary>
		/// UploadKey property
		/// </summary>
		public string UploadKey 
		{
			get 
			{
				return GetValue("p_nUploadKey");
			}
			set 
			{
				SetValue("p_nUploadKey",value);
			}
		}
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
		/// <summary>
		/// Driver1Number property
		/// </summary>
		public string Driver1Number 
		{
			get 
			{
				return GetValue("p_nDriver1Number");
			}
			set 
			{
				SetValue("p_nDriver1Number",value);
			}
		}
		/// <summary>
		/// Driver1Percent property
		/// </summary>
		public string Driver1Percent 
		{
			get 
			{
				return GetValue("Driver1Percent");
			}
			set 
			{
				SetValue("Driver1Percent",value);
			}
		}
		/// <summary>
		/// Driver2Number property
		/// </summary>
		public string Driver2Number 
		{
			get 
			{
				return GetValue("p_nDriver2Number");
			}
			set 
			{
				SetValue("p_nDriver2Number",value);
			}
		}
		/// <summary>
		/// Driver2Percent property
		/// </summary>
		public string Driver2Percent 
		{
			get 
			{
				return GetValue("p_nDriver2Percent");
			}
			set 
			{
				SetValue("p_nDriver2Percent",value);
			}
		}
		/// <summary>
		/// Misc property
		/// </summary>
		public string Misc 
		{
			get 
			{
				return GetValue("p_nMisc");
			}
			set 
			{
				SetValue("p_nMisc",value);
			}
		}
		/// <summary>
		/// VehicleNumber property
		/// </summary>
		public string VehicleNumber 
		{
			get 
			{
				return GetValue("p_nVehicleNumber");
			}
			set 
			{
				SetValue("p_nVehicleNumber",value);
			}
		}
	}
}
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Vehicle.cs $
 * 
 * 7     10/31/09 10:07a Ashley.pinto
 * Sedgwick CCE Implementation
 * 
 * 6     10/23/09 11:25a Ashley.pinto
 * missed update
 * 
 * 5     10/23/09 11:24a Ashley.pinto
 * Sedgwick CCE Vehicle Feed Implementation.
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
 * 6     11/29/06 3:40p John.gwynn
 * Added CsaaDriver and CsaaVehicle
 * 
 * 5     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 4     4/06/06 6:16p John.gwynn
 * Added NcciCode and AhsIdFromLocation
 * 
 * 3     3/04/06 5:27p John.gwynn
 * added the ability to set dbInstance in constructor
 * 
 * 2     11/16/05 6:21p John.gwynn
 * Added AHS
 * 
 * 1     11/15/05 6:41p John.gwynn
 */
