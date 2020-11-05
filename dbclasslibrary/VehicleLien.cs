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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/VehicleLien.cs 5     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for VEHICLE_LIEN table.
	/// </summary>
	[ComVisible(false)]
	public sealed class VehicleLien :DbBaseClass
	{
		private enum eParmList 
		{
			eVehicleLienID = 0,
			eFileTranLogId,
			eVehicleID,
			eNameFirst,
			eNameLast,
			eAddress1,
			eAddress2,
			eCity,
			eState,
			eZip, 
			eUploadKey,
			eActiveStartDt,
			eActiveEndDt	
		};
		
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="VehicleLien"/> class.
		/// </summary>
		public VehicleLien():this(String.Empty)
		{	}

		/// <summary>
		/// Initializes a new instance of the <see cref="VehicleLien"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public VehicleLien(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessVehicleLien";

			_parameterNames = new string[] {
			"p_nVehicleLienID",
			"p_nFileTranLogId",
			"p_nVehicleID",
			"p_nNameFirst",
			"p_nNameLast",
			"p_nAddress1",
			"p_nAddress2",
			"p_nCity",
			"p_nState",
			"p_nZip", 
			"p_nUploadKey",
			"p_nActiveStartDt",
			"p_nActiveEndDt" };
			
			Initialize();
		}	
		#endregion
		#region Initialize 
		/// <summary>
		/// Initializes this instance parameters.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			// VEHICLE_LIEN_ID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.eVehicleLienID],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			// FILE_TRANSMISSION_LOG_ID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eFileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			// VEHICLE_ID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eVehicleID],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			// NAME_FIRST
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eNameFirst],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// NAME_LAST
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eNameLast],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			// ADDRESS1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eAddress1],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// ADDRESS2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eAddress2],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			// CITY
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eCity],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// STATE
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eState],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			// ZIP
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			_parameterNames[(int)eParmList.eZip],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			// UPLOAD_KEY
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eUploadKey],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			// ACTIVE_START_DT
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eActiveStartDt],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			// ACTIVE_END_DT
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eActiveEndDt],"",System.Data.DbType.Date);
		}
		#endregion
		#region VehicleLienID 
		/// <summary>
		/// Gets the vehicle Coverage ID.
		/// </summary>
		/// <value>The vehicle Coverage ID.</value>
		public string VehicleLienID 
		{
			get 
			{
				return GetValue((int)eParmList.eVehicleLienID);
			}
		}
		#endregion
		#region VehicleID 
		/// <summary>
		/// Gets the vehicle ID.
		/// </summary>
		/// <value>The vehicle ID.</value>
		public string VehicleID 
		{
			get 
			{
				return GetValue((int)eParmList.eVehicleID);
			}
			set 
			{
				SetValue((int)eParmList.eVehicleID,value);
			}
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
				return GetValue((int)eParmList.eFileTranLogId);
			}
			set 
			{
				SetValue((int)eParmList.eFileTranLogId,value);
			}
		}
		#endregion
		#region FirstName 
		/// <summary>
		/// Gets or sets the name of the first.
		/// </summary>
		/// <value>The name of the first.</value>
		public string FirstName 
		{
			get 
			{
				return GetValue((int)eParmList.eNameFirst);
			}
			set 
			{
				SetValue((int)eParmList.eNameFirst,value);
			}
		}
		#endregion
		#region LastName 
		/// <summary>
		/// Gets or sets the name of the last.
		/// </summary>
		/// <value>The name of the last.</value>
		public string LastName 
		{
			get 
			{
				return GetValue((int)eParmList.eNameLast);
			}
			set 
			{
				SetValue((int)eParmList.eNameLast,value);
			}
		}
		#endregion
		#region Address1 
		/// <summary>
		/// Gets or sets the address1.
		/// </summary>
		/// <value>The address1.</value>
		public string Address1 
		{
			get 
			{
				return GetValue((int)eParmList.eAddress1);
			}
			set 
			{
				SetValue((int)eParmList.eAddress1,value);
			}
		}
		#endregion
		#region Address2 
		/// <summary>
		/// Gets or sets the address2.
		/// </summary>
		/// <value>The address2.</value>
		public string Address2 
		{
			get 
			{
				return GetValue((int)eParmList.eAddress2);
			}
			set 
			{
				SetValue((int)eParmList.eAddress2,value);
			}
		}
		#endregion
		#region City 
		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City 
		{
			get 
			{
				return GetValue((int)eParmList.eCity);
			}
			set 
			{
				SetValue((int)eParmList.eCity,value);
			}
		}
		#endregion
		#region State 
		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		public string State 
		{
			get 
			{
				return GetValue((int)eParmList.eState);
			}
			set 
			{
				SetValue((int)eParmList.eState,value);
			}
		}
		#endregion
		#region Zip 
		/// <summary>
		/// Gets or sets the zip.
		/// </summary>
		/// <value>The zip.</value>
		public string Zip
		{
			get 
			{
				return GetValue((int)eParmList.eZip);
			}
			set 
			{
				SetValue((int)eParmList.eZip,value);
			}
		}
		#endregion
		#region UploadKey 
		/// <summary>
		/// Gets or sets the upload key.
		/// </summary>
		/// <value>The upload key.</value>
		public string UploadKey 
		{
			get 
			{
				return GetValue((int)eParmList.eUploadKey);
			}
			set 
			{
				SetValue((int)eParmList.eUploadKey,value);
			}
		}
		#endregion
		#region ActiveStartDate 
		/// <summary>
		/// Gets or sets the active start date.
		/// </summary>
		/// <value>The active start date.</value>
		public string ActiveStartDate 
		{
			get 
			{
				return GetValue((int)eParmList.eActiveStartDt);
			}
			set 
			{
				SetValue((int)eParmList.eActiveStartDt,value);
			}
		}
		#endregion
		#region ActiveEndDate 
		/// <summary>
		/// Gets or sets the active end date.
		/// </summary>
		/// <value>The active end date.</value>
		public string ActiveEndDate 
		{
			get 
			{
				return GetValue((int)eParmList.eActiveEndDt);
			}
			set 
			{
				SetValue((int)eParmList.eActiveEndDt,value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/VehicleLien.cs $
 * 
 * 5     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 4     11/19/07 2:22p John.gwynn
 * updates from 2003 project
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 3     11/15/06 5:33p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     8/25/06 10:07a John.gwynn
 * added vehicle coverage extensions and vehicle lien support
 */
#endregion
