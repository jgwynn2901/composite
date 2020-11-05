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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Vendor.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for the VENDOR table.
	/// </summary>
	[ComVisible(false)]
	public sealed class Vendor :DbBaseClass
	{
		private enum eParmList 
		{
			VendorId = 0,
			FileTranLogId,
			NetworkId,
			Name,
			OwnerName,
			ManagerName,
			EnabledFlag,
			Address1,
			Address2,
			Address3,
			City,
			State,
			Zip,
			Lat,
			Lon,
			PhoneDay,
			PhoneNight,
			Fax,
			BillingAddress1,
			BillingAddress2,
			BillingAddress3,
			BillingCity,
			BillingState,
			BillingZip,
			PhoneBackup,
			BackupType,
			Override,
			TimeZone,
			Email,
			ServiceDesc,
			MaxRadius,
			Fein,
			StateLicense,
			CityLicense,
			IccDot,
			Carrier,
			Policy,
			Agent,
			ExpirationDate,
			GroupName,
			SpecialtyCode,
			Weight,
			PayTypeCredit,
			PayTypeCheck,
			LocationNumber,
			PreferredReport,
			Notes,
			Fips,
			Threshold,
			CurrentLoad,
			NewAssignments,
			EmergencyUse,
			BusinessHours,
			CoverageArea,
			VendorCode,
			UploadKey,
			TypeOfBusiness,
			ParmCount
		};
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Vendor"/> class.
		/// </summary>
		public Vendor():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="Vendor"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public Vendor(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessVendor";

			_parameterNames = new string[] { "p_nVendorId",		
																			 "p_nFileTranLogId",
																			 "p_nNetworkId",
																			 "p_nName",
																			 "p_nOwnerName",
																			 "p_nManagerName",
																			 "p_nEnabledFlg",
																			 "p_nAddress1",
																			 "p_nAddress2",
																			 "p_nAddress3",
																			 "p_nCity",
																			 "p_nState",
																			 "p_nZip",
																			 "p_nLat",
																			 "p_nLon",
																			 "p_nPhoneDay",
																			 "p_nPhoneNight",
																			 "p_nFax",
																			 "p_nBillingAddress1",
																			 "p_nBillingAddress2",
																			 "p_nBillingAddress3",
																			 "p_nBillingCity",
																			 "p_nBillingState",
																			 "p_nBillingZip",
																			 "p_nPhoneBackup",
																			 "p_nBackupType",
																			 "p_nOverride",
																			 "p_nTimeZone",
																			 "p_nEmail",
																			 "p_nServiceDesc",
																			 "p_nMaxRadius",
																			 "p_nFEIN",
																			 "p_nStateLicense",
																			 "p_nCityLicense",
																			 "p_nIccDot",
																			 "p_nCarrier",
																			 "p_nPolicy",
																			 "p_nAgent",
																			 "p_nExpirationDate",
																			 "p_nGroupName",
																			 "p_nSpecialtyCode",
																			 "p_nWeight",
																			 "p_nPayTypeCredit",
																			 "p_PayTypeCheck",
																			 "p_nLocationNumber",
																			 "p_nPreferredReport",
																			 "p_nNotes",
																			 "p_nFips",
																			 "p_nThreshold",
																			 "p_nCurrentLoad",
																			 "p_nNewAssignments",
																			 "p_nEmergencyUse",
																			 "p_nBusinessHours",
																			 "p_nCoverageArea",
																			 "p_nVendorCode",
																			 "p_nUploadKey",
																			 "p_nTypeOfBusiness"
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
			//// VendorId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.VendorId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// FileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// NetworkId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.NetworkId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// Name
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Name],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// OwnerName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.OwnerName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// ManagerName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.ManagerName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// EnabledFlag
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.EnabledFlag],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Address1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Address1],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Address2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Address2],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Address3
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Address3],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// City
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.City],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// State
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.State],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Zip
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Zip],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Lat
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Lat],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// Lon
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Lon],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// PhoneDay
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.PhoneDay],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// PhoneNight
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.PhoneNight],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Fax
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Fax],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// BillingAddress1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.BillingAddress1],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// BillingAddress2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.BillingAddress2],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// BillingAddress3
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.BillingAddress3],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// BillingCity
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.BillingCity],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// BillingState
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.BillingState],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// BillingZip
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.BillingZip],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// PhoneBackup
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.PhoneBackup],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// BackupType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.BackupType],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Override
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Override],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// TimeZone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.TimeZone],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Email
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Email],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// ServiceDesc
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.ServiceDesc],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// MaxRadius
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.MaxRadius],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// Fein
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Fein],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// StateLicense
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.StateLicense],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// CityLicense
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.CityLicense],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// IccDot
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.IccDot],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Carrier
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Carrier],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Policy
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Policy],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Agent
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Agent],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// ExpirationDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.ExpirationDate],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// GroupName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.GroupName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// SpecialtyCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.SpecialtyCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Weight
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Weight],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// PayTypeCredit
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.PayTypeCredit],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// PayTypeCheck
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.PayTypeCheck],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// LocationNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.LocationNumber],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// PreferredReport
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.PreferredReport],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Notes
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Notes],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Fips
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Fips],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Threshold
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Threshold],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// CurrentLoad
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.CurrentLoad],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// NewAssignments
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.NewAssignments],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// EmergencyUse
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.EmergencyUse],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// BusinessHours
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.BusinessHours],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// CoverageArea
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.CoverageArea],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// VendorCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.VendorCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// UploadKey
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.UploadKey],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// TypeOfBusiness
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.TypeOfBusiness],"",System.Data.DbType.AnsiString);

		}
		#endregion
		#region VendorId
		
		/// <summary>
		/// Gets or sets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string VendorId
		{
			get 
			{
				return GetValue((int)eParmList.VendorId);
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
				return GetValue((int)eParmList.FileTranLogId);
			}
			set 
			{
				SetValue((int)eParmList.FileTranLogId,value);
			}
		}
		#endregion
		#region NetworkId
		/// <summary>
		/// Gets or sets the network id.
		/// </summary>
		/// <value>The network id.</value>
		public string NetworkId
		{
			get 
			{
				return GetValue((int)eParmList.NetworkId);
			}
			set 
			{
				SetValue((int)eParmList.NetworkId,value);
			}
		}
		#endregion
		#region Name
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get 
			{
				return GetValue((int)eParmList.Name);
			}
			set 
			{
				SetValue((int)eParmList.Name,value);
			}
		}
		#endregion
		#region OwnerName
		/// <summary>
		/// Gets or sets the name of the owner.
		/// </summary>
		/// <value>The name of the owner.</value>
		public string OwnerName
		{
			get 
			{
				return GetValue((int)eParmList.OwnerName);
			}
			set 
			{
				SetValue((int)eParmList.OwnerName,value);
			}
		}
		#endregion
		#region ManagerName
		/// <summary>
		/// Gets or sets the name of the manager.
		/// </summary>
		/// <value>The name of the manager.</value>
		public string ManagerName
		{
			get 
			{
				return GetValue((int)eParmList.ManagerName);
			}
			set 
			{
				SetValue((int)eParmList.ManagerName,value);
			}
		}
		#endregion
		#region EnabledFlag
		/// <summary>
		/// Gets or sets the enabled flag.
		/// </summary>
		/// <value>The enabled flag.</value>
		public string EnabledFlag
		{
			get 
			{
				return GetValue((int)eParmList.EnabledFlag);
			}
			set 
			{
				SetValue((int)eParmList.EnabledFlag,value);
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
				return GetValue((int)eParmList.Address1);
			}
			set 
			{
				SetValue((int)eParmList.Address1,value);
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
				return GetValue((int)eParmList.Address2);
			}
			set 
			{
				SetValue((int)eParmList.Address2,value);
			}
		}
		#endregion
		#region Address3
		/// <summary>
		/// Gets or sets the address3.
		/// </summary>
		/// <value>The address3.</value>
		public string Address3
		{
			get 
			{
				return GetValue((int)eParmList.Address3);
			}
			set 
			{
				SetValue((int)eParmList.Address3,value);
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
				return GetValue((int)eParmList.City);
			}
			set 
			{
				SetValue((int)eParmList.City,value);
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
				return GetValue((int)eParmList.State);
			}
			set 
			{
				SetValue((int)eParmList.State,value);
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
				return GetValue((int)eParmList.Zip);
			}
			set 
			{
				SetValue((int)eParmList.Zip,value);
			}
		}
		#endregion
		#region Lat
		/// <summary>
		/// Gets or sets the lat.
		/// </summary>
		/// <value>The lat.</value>
		public string Lat
		{
			get 
			{
				return GetValue((int)eParmList.Lat);
			}
			set 
			{
				SetValue((int)eParmList.Lat,value);
			}
		}
		#endregion
		#region Lon
		/// <summary>
		/// Gets or sets the lon.
		/// </summary>
		/// <value>The lon.</value>
		public string Lon
		{
			get 
			{
				return GetValue((int)eParmList.Lon);
			}
			set 
			{
				SetValue((int)eParmList.Lon,value);
			}
		}
		#endregion
		#region PhoneDay
		/// <summary>
		/// Gets or sets the phone day.
		/// </summary>
		/// <value>The phone day.</value>
		public string PhoneDay
		{
			get 
			{
				return GetValue((int)eParmList.PhoneDay);
			}
			set 
			{
				SetValue((int)eParmList.PhoneDay,value);
			}
		}
		#endregion
		#region PhoneNight
		/// <summary>
		/// Gets or sets the phone night.
		/// </summary>
		/// <value>The phone night.</value>
		public string PhoneNight
		{
			get 
			{
				return GetValue((int)eParmList.PhoneNight);
			}
			set 
			{
				SetValue((int)eParmList.PhoneNight,value);
			}
		}
		#endregion
		#region Fax
		/// <summary>
		/// Gets or sets the fax.
		/// </summary>
		/// <value>The fax.</value>
		public string Fax
		{
			get 
			{
				return GetValue((int)eParmList.Fax);
			}
			set 
			{
				SetValue((int)eParmList.Fax,value);
			}
		}
		#endregion
		#region BillingAddress1
		/// <summary>
		/// Gets or sets the billing address1.
		/// </summary>
		/// <value>The billing address1.</value>
		public string BillingAddress1
		{
			get 
			{
				return GetValue((int)eParmList.BillingAddress1);
			}
			set 
			{
				SetValue((int)eParmList.BillingAddress1,value);
			}
		}
		#endregion
		#region BillingAddress2
		/// <summary>
		/// Gets or sets the billing address2.
		/// </summary>
		/// <value>The billing address2.</value>
		public string BillingAddress2
		{
			get 
			{
				return GetValue((int)eParmList.BillingAddress2);
			}
			set 
			{
				SetValue((int)eParmList.BillingAddress2,value);
			}
		}
		#endregion
		#region BillingAddress3
		/// <summary>
		/// Gets or sets the billing address3.
		/// </summary>
		/// <value>The billing address3.</value>
		public string BillingAddress3
		{
			get 
			{
				return GetValue((int)eParmList.BillingAddress3);
			}
			set 
			{
				SetValue((int)eParmList.BillingAddress3,value);
			}
		}
		#endregion
		#region BillingCity
		/// <summary>
		/// Gets or sets the billing city.
		/// </summary>
		/// <value>The billing city.</value>
		public string BillingCity
		{
			get 
			{
				return GetValue((int)eParmList.BillingCity);
			}
			set 
			{
					SetValue((int)eParmList.BillingCity,value);
			}
		}
		#endregion
		#region BillingState
		/// <summary>
		/// Gets or sets the state of the billing.
		/// </summary>
		/// <value>The state of the billing.</value>
		public string BillingState
		{
			get 
			{
				return GetValue((int)eParmList.BillingState);
			}
			set 
			{
				SetValue((int)eParmList.BillingState,value);
			}
		}
		#endregion
		#region PhoneBackup
		/// <summary>
		/// Gets or sets the phone backup.
		/// </summary>
		/// <value>The phone backup.</value>
		public string PhoneBackup
		{
			get 
			{
				return GetValue((int)eParmList.PhoneBackup);
			}
			set 
			{
				SetValue((int)eParmList.PhoneBackup,value);
			}
		}
		#endregion
		#region BackupType
		/// <summary>
		/// Gets or sets the type of the backup.
		/// </summary>
		/// <value>The type of the backup.</value>
		public string BackupType
		{
			get 
			{
				return GetValue((int)eParmList.BackupType);
			}
			set 
			{
				SetValue((int)eParmList.BackupType,value);
			}
		}
		#endregion
		#region Override
		/// <summary>
		/// Gets or sets the override.
		/// </summary>
		/// <value>The override.</value>
		public string Override
		{
			get 
			{
				return GetValue((int)eParmList.Override);
			}
			set 
			{
				SetValue((int)eParmList.Override,value);
			}
		}
		#endregion
		#region TimeZone
		/// <summary>
		/// Gets or sets the time zone.
		/// </summary>
		/// <value>The time zone.</value>
		public string TimeZone
		{
			get 
			{
				return GetValue((int)eParmList.TimeZone);
			}
			set 
			{
				SetValue((int)eParmList.TimeZone,value);
			}
		}
		#endregion
		#region Email
		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>The email.</value>
		public string Email
		{
			get 
			{
				return GetValue((int)eParmList.Email);
			}
			set 
			{
				SetValue((int)eParmList.Email,value);
			}
		}
		#endregion
		#region ServiceDesc
		/// <summary>
		/// Gets or sets the service desc.
		/// </summary>
		/// <value>The service desc.</value>
		public string ServiceDesc
		{
			get 
			{
				return GetValue((int)eParmList.ServiceDesc);
			}
			set 
			{
				SetValue((int)eParmList.ServiceDesc,value);
			}
		}
		#endregion
		#region MaxRadius
		/// <summary>
		/// Gets or sets the max radius.
		/// </summary>
		/// <value>The max radius.</value>
		public string MaxRadius
		{
			get 
			{
				return GetValue((int)eParmList.MaxRadius);
			}
			set 
			{
				SetValue((int)eParmList.MaxRadius,value);
			}
		}
		#endregion
		#region Fein
		/// <summary>
		/// Gets or sets the fein.
		/// </summary>
		/// <value>The fein.</value>
		public string Fein
		{
			get 
			{
				return GetValue((int)eParmList.Fein);
			}
			set 
			{
				SetValue((int)eParmList.Fein,value);
			}
		}
		#endregion
		#region StateLicense
		/// <summary>
		/// Gets or sets the state license.
		/// </summary>
		/// <value>The state license.</value>
		public string StateLicense
		{
			get 
			{
				return GetValue((int)eParmList.StateLicense);
			}
			set 
			{
				SetValue((int)eParmList.StateLicense,value);
			}
		}
		#endregion
		#region CityLicense
		/// <summary>
		/// Gets or sets the city license.
		/// </summary>
		/// <value>The city license.</value>
		public string CityLicense
		{
			get 
			{
				return GetValue((int)eParmList.CityLicense);
			}
			set 
			{
				SetValue((int)eParmList.CityLicense,value);
			}
		}
		#endregion
		#region IccDot
		/// <summary>
		/// Gets or sets the icc dot.
		/// </summary>
		/// <value>The icc dot.</value>
		public string IccDot
		{
			get 
			{
				return GetValue((int)eParmList.IccDot);
			}
			set 
			{
				SetValue((int)eParmList.IccDot,value);
			}
		}
		#endregion
		#region Carrier
		/// <summary>
		/// Gets or sets the carrier.
		/// </summary>
		/// <value>The carrier.</value>
		public string Carrier
		{
			get 
			{
				return GetValue((int)eParmList.Carrier);
			}
			set 
			{
				SetValue((int)eParmList.Carrier,value);
			}
		}
		#endregion
		#region Policy
		/// <summary>
		/// Gets or sets the policy.
		/// </summary>
		/// <value>The policy.</value>
		public string Policy
		{
			get 
			{
				return GetValue((int)eParmList.Policy);
			}
			set 
			{
				SetValue((int)eParmList.Policy,value);
			}
		}
		#endregion
		#region Agent
		/// <summary>
		/// Gets or sets the agent.
		/// </summary>
		/// <value>The agent.</value>
		public string Agent
		{
			get 
			{
				return GetValue((int)eParmList.Agent);
			}
			set 
			{
				SetValue((int)eParmList.Agent,value);
			}
		}
		#endregion
		#region ExpirationDate
		/// <summary>
		/// Gets or sets the expiration date.
		/// </summary>
		/// <value>The expiration date.</value>
		public string ExpirationDate
		{
			get 
			{
				return GetValue((int)eParmList.ExpirationDate);
			}
			set 
			{
				SetValue((int)eParmList.ExpirationDate,value);
			}
		}
		#endregion
		#region GroupName
		/// <summary>
		/// Gets or sets the name of the group.
		/// </summary>
		/// <value>The name of the group.</value>
		public string GroupName
		{
			get 
			{
				return GetValue((int)eParmList.GroupName);
			}
			set 
			{
				SetValue((int)eParmList.GroupName,value);
			}
		}
		#endregion
		#region SpecialtyCode
		/// <summary>
		/// Gets or sets the specialty code.
		/// </summary>
		/// <value>The specialty code.</value>
		public string SpecialtyCode
		{
			get 
			{
				return GetValue((int)eParmList.SpecialtyCode);
			}
			set 
			{
				SetValue((int)eParmList.SpecialtyCode,value);
			}
		}
		#endregion
		#region Weight
		/// <summary>
		/// Gets or sets the weight.
		/// </summary>
		/// <value>The weight.</value>
		public string Weight
		{
			get 
			{
				return GetValue((int)eParmList.Weight);
			}
			set 
			{
				SetValue((int)eParmList.Weight,value);
			}
		}
		#endregion
		#region PayTypeCredit
		/// <summary>
		/// Gets or sets the pay type credit.
		/// </summary>
		/// <value>The pay type credit.</value>
		public string PayTypeCredit
		{
			get 
			{
				return GetValue((int)eParmList.PayTypeCredit);
			}
			set 
			{
				SetValue((int)eParmList.PayTypeCredit,value);
			}
		}
		#endregion
		#region PayTypeCheck
		/// <summary>
		/// Gets or sets the pay type check.
		/// </summary>
		/// <value>The pay type check.</value>
		public string PayTypeCheck
		{
			get 
			{
				return GetValue((int)eParmList.PayTypeCheck);
			}
			set 
			{
				SetValue((int)eParmList.PayTypeCheck,value);
			}
		}
		#endregion
		#region LocationNumber
		/// <summary>
		/// Gets or sets the location number.
		/// </summary>
		/// <value>The location number.</value>
		public string LocationNumber
		{
			get 
			{
				return GetValue((int)eParmList.LocationNumber);
			}
			set 
			{
				SetValue((int)eParmList.LocationNumber,value);
			}
		}
		#endregion
		#region PreferredReport
		/// <summary>
		/// Gets or sets the preferred report.
		/// </summary>
		/// <value>The preferred report.</value>
		public string PreferredReport
		{
			get 
			{
				return GetValue((int)eParmList.PreferredReport);
			}
			set 
			{
				SetValue((int)eParmList.PreferredReport,value);
			}
		}
		#endregion
		#region Notes
		/// <summary>
		/// Gets or sets the notes.
		/// </summary>
		/// <value>The notes.</value>
		public string Notes
		{
			get 
			{
				return GetValue((int)eParmList.Notes);
			}
			set 
			{
				SetValue((int)eParmList.Notes,value);
			}
		}
		#endregion
		#region Fips
		/// <summary>
		/// Gets or sets the fips.
		/// </summary>
		/// <value>The fips.</value>
		public string Fips
		{
			get 
			{
				return GetValue((int)eParmList.Fips);
			}
			set 
			{
				SetValue((int)eParmList.Fips,value);
			}
		}
		#endregion
		#region Threshold
		/// <summary>
		/// Gets or sets the threshold.
		/// </summary>
		/// <value>The threshold.</value>
		public string Threshold
		{
			get 
			{
				return GetValue((int)eParmList.Threshold);
			}
			set 
			{
				SetValue((int)eParmList.Threshold,value);
			}
		}
		#endregion
		#region CurrentLoad
		/// <summary>
		/// Gets or sets the current load.
		/// </summary>
		/// <value>The current load.</value>
		public string CurrentLoad
		{
			get 
			{
				return GetValue((int)eParmList.CurrentLoad);
			}
			set 
			{
				SetValue((int)eParmList.CurrentLoad,value);
			}
		}
		#endregion
		#region NewAssignments
		/// <summary>
		/// Gets or sets the new assignments.
		/// </summary>
		/// <value>The new assignments.</value>
		public string NewAssignments
		{
			get 
			{
				return GetValue((int)eParmList.NewAssignments);
			}
			set 
			{
				SetValue((int)eParmList.NewAssignments,value);
			}
		}
		#endregion
		#region EmergencyUse
		/// <summary>
		/// Gets or sets the emergency use.
		/// </summary>
		/// <value>The emergency use.</value>
		public string EmergencyUse
		{
			get 
			{
				return GetValue((int)eParmList.EmergencyUse);
			}
			set 
			{
				SetValue((int)eParmList.EmergencyUse,value);
			}
		}
		#endregion
		#region BusinessHours
		/// <summary>
		/// Gets or sets the business hours.
		/// </summary>
		/// <value>The business hours.</value>
		public string BusinessHours
		{
			get 
			{
				return GetValue((int)eParmList.BusinessHours);
			}
			set 
			{
				SetValue((int)eParmList.BusinessHours,value);
			}
		}
		#endregion
		#region CoverageArea
		/// <summary>
		/// Gets or sets the coverage area.
		/// </summary>
		/// <value>The coverage area.</value>
		public string CoverageArea
		{
			get 
			{
				return GetValue((int)eParmList.CoverageArea);
			}
			set 
			{
				SetValue((int)eParmList.CoverageArea,value);
			}
		}
		#endregion
		#region VendorCode
		/// <summary>
		/// Gets or sets the vendor code.
		/// </summary>
		/// <value>The vendor code.</value>
		public string VendorCode
		{
			get 
			{
				return GetValue((int)eParmList.VendorCode);
			}
			set 
			{
				SetValue((int)eParmList.VendorCode,value);
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
				return GetValue((int)eParmList.UploadKey);
			}
			set 
			{
				SetValue((int)eParmList.UploadKey,value);
			}
		}
		#endregion
		#region TypeOfBusiness
		/// <summary>
		/// Gets or sets the upload key.
		/// </summary>
		/// <value>The upload key.</value>
		public string TypeOfBusiness
		{
			get 
			{
				return GetValue((int)eParmList.TypeOfBusiness);
			}
			set 
			{
				SetValue((int)eParmList.TypeOfBusiness,value);
			}
		}
		#endregion	
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Vendor.cs $
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
 * 4     11/26/06 9:31a John.gwynn
 * added TypeOfBusiness parm
 * 
 * 3     11/15/06 5:33p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/17/06 11:41a John.gwynn
 * New Vendor class for InputProcessManager vendor loads including Kemper
 * and CSAA.
 */
#endregion