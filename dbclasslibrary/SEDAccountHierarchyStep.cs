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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SEDAccountHierarchyStep.cs 3     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for AccountHierarchyStep.
	/// </summary>
	[ComVisible(false)]	
	public sealed class SEDAccountHierarchyStep :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// default constructor uses the registry db instance
		/// </summary>
		public SEDAccountHierarchyStep():this(String.Empty)
		{
		}
		/// <summary>
		/// user can name db instance
		/// </summary>
		/// <param name="instance"></param>
		public SEDAccountHierarchyStep(string instance) :base (instance)
		{
			_name = "UIFSegment.ProcessSEDAHSSegment";
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
			/////p_nAHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_nAHSID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nFileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nFileTranLogId","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nParentNodeID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nParentNodeID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nClientNodeID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nClientNodeID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nType","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nFNSClientCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nFNSClientCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nName","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNameFirst
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNameFirst","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNameLast
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNameLast","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNameMid
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNameMid","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAddress1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAddress1","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAddress2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAddress2","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAddress3
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAddress3","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nCity
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nCity","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nState
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nState","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nZip
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nZip","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nFips
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nFips","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nCounty
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nCounty","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nCountry
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nCountry","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nPhone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nPhone","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAltPhone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAltPhone","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nFax
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nFax","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAltFax
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAltFax","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nFein
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nFein","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nSic
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nSic","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nSuid
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nSuid","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNatureOfBusiness
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNatureOfBusiness","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nLocationCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nLocationCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nSecName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nSecName","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nSecCd
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nSecCd","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nLocName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nLocName","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nDivisionName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nDivisionName","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nDivisionCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nDivisionCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nDepartmentName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nDepartmentName","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nDepartmentCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nDepartmentCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAutoEscalate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAutoEscalate","N",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNodeLevel
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNodeLevel","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nUploadKey
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nUploadKey","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nActiveStatus
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nActiveStatus","ACTIVE",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nStatusDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nStatusDate","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nManageCareType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nManageCareType","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAdditionalDeliveries
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAdditionalDeliveries","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nSpecificDestination
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nSpecificDestination","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAccountFromDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAccountFromDate","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nAccountToDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAccountToDate","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nCurrentFlag
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nCurrentFlag","Y",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nActecCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nActecCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNodeTypeID	
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNodeTypeID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nNameShort
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNameShort","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAccountPassword
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAccountPassword","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNaicsCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNaicsCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAccountName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAccountName","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAgentBillingMethod
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAgentBillingMethod","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAgentPaymentType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAgentPaymentType","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nEmailAddress
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nEmailAddress","",System.Data.DbType.AnsiString);

            ///////////////////////////////////////////////////
            ///// p_nDisseminationFlag
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                "p_nDisseminationFlag", "", System.Data.DbType.AnsiString);
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
		#region ParentNodeID
		/// <summary>
		/// ParentNodeID property
		/// </summary>
		public string ParentNodeID 
		{
			get 
			{
				return GetValue("p_nParentNodeID");
			}
			set 
			{
				SetValue("p_nParentNodeID",value);
			}
		}
		#endregion
		#region ClientNodeID
		/// <summary>
		/// ClientNodeID property
		/// </summary>
		public string ClientNodeID 
		{
			get 
			{
				return GetValue("p_nClientNodeID");
			}
			set 
			{
				SetValue("p_nClientNodeID",value);
			}
		}
		#endregion
		#region AhsType
		/// <summary>
		/// Type property
		/// </summary>
		public string AhsType 
		{
			get 
			{
				return GetValue("p_nType");
			}
			set 
			{
				SetValue("p_nType",value);
			}
		}
		#endregion
		#region FNSClientCode
		/// <summary>
		/// FNSClientCode property
		/// </summary>
		public string FNSClientCode 
		{
			get 
			{
				return GetValue("p_nFNSClientCode");
			}
			set 
			{
				SetValue("p_nFNSClientCode",value);
			}
		}
		#endregion
		#region Name
		/// <summary>
		/// Name property
		/// </summary>
		public string Name 
		{
			get 
			{
				return GetValue("p_nName");
			}
			set 
			{
				SetValue("p_nName",value);
			}
		}
		#endregion
		#region NameFirst
		/// <summary>
		/// NameFirst property
		/// </summary>
		public string NameFirst 
		{
			get 
			{
				return GetValue("p_nNameFirst");
			}
			set 
			{
				SetValue("p_nNameFirst",value);
			}
		}
		#endregion
		#region NameLast
		/// <summary>
		/// nNameLast property
		/// </summary>
		public string NameLast 
		{
			get 
			{
				return GetValue("p_nNameLast");
			}
			set 
			{
				SetValue("p_nNameLast",value);
			}
		}
		#endregion
		#region NameMid
		/// <summary>
		/// NameMid property
		/// </summary>
		public string NameMid 
		{
			get 
			{
				return GetValue("p_nNameMid");
			}
			set 
			{
				SetValue("p_nNameMid",value);
			}
		}
		#endregion
		#region Address1
		/// <summary>
		/// Address1 property
		/// </summary>
		public string Address1 
		{
			get 
			{
				return GetValue("p_nAddress1");
			}
			set 
			{
				SetValue("p_nAddress1",value);
			}
		}
		#endregion
		#region Address2
		/// <summary>
		/// Address2 property
		/// </summary>
		public string Address2 
		{
			get 
			{
				return GetValue("p_nAddress2");
			}
			set 
			{
				SetValue("p_nAddress2",value);
			}
		}
		#endregion
		#region Address3
		/// <summary>
		/// Address3 property
		/// </summary>
		public string Address3 
		{
			get 
			{
				return GetValue("p_nAddress3");
			}
			set 
			{
				SetValue("p_nAddress3",value);
			}
		}
		#endregion
		#region City
		/// <summary>
		/// City property
		/// </summary>
		public string City 
		{
			get 
			{
				return GetValue("p_nCity");
			}
			set 
			{
				SetValue("p_nCity",value);
			}
		}
		#endregion
		#region State
		/// <summary>
		/// State property
		/// </summary>
		public string State 
		{
			get 
			{
				return GetValue("p_nState");
			}
			set 
			{
				SetValue("p_nState",value);
			}
		}
		#endregion
		#region Zip
		/// <summary>
		/// Zip property
		/// </summary>
		public string Zip 
		{
			get 
			{
				return GetValue("p_nZip");
			}
			set 
			{
				SetValue("p_nZip",value);
			}
		}
		#endregion
		#region Fips
		/// <summary>
		/// Fips property
		/// </summary>
		public string Fips 
		{
			get 
			{
				return GetValue("p_nFips");
			}
			set 
			{
				SetValue("p_nFips",value);
			}
		}
		#endregion
		#region County
		/// <summary>
		/// County property
		/// </summary>
		public string County 
		{
			get 
			{
				return GetValue("p_nCounty");
			}
			set 
			{
				SetValue("p_nCounty",value);
			}
		}
		#endregion
		#region Country
		/// <summary>
		/// Country property
		/// </summary>
		public string Country 
		{
			get 
			{
				return GetValue("p_nCountry");
			}
			set 
			{
				SetValue("p_nCountry",value);
			}
		}
		#endregion
		#region Phone
		/// <summary>
		/// Phone property
		/// </summary>
		public string Phone 
		{
			get 
			{
				return GetValue("p_nPhone");
			}
			set 
			{
				SetValue("p_nPhone",value);
			}
		}
		#endregion
		#region AltPhone
		/// <summary>
		/// AltPhone property
		/// </summary>
		public string AltPhone 
		{
			get 
			{
				return GetValue("p_nAltPhone");
			}
			set 
			{
				SetValue("p_nAltPhone",value);
			}
		}
		#endregion
		#region Fax
		/// <summary>
		/// Fax property
		/// </summary>
		public string Fax 
		{
			get 
			{
				return GetValue("p_nFax");
			}
			set 
			{
				SetValue("p_nFax",value);
			}
		}
		#endregion
		#region AltFax
		/// <summary>
		/// AltFax property
		/// </summary>
		public string AltFax 
		{
			get 
			{
				return GetValue("p_nAltFax");
			}
			set 
			{
				SetValue("p_nAltFax",value);
			}
		}
		#endregion
		#region Fein
		/// <summary>
		/// Fein property
		/// </summary>
		public string Fein 
		{
			get 
			{
				return GetValue("p_nFein");
			}
			set 
			{
				SetValue("p_nFein",value);
			}
		}
		#endregion
		#region Sic
		/// <summary>
		/// Sic property
		/// </summary>
		public string Sic 
		{
			get 
			{
				return GetValue("p_nSic");
			}
			set 
			{
				SetValue("p_nSic",value);
			}
		}
		#endregion
		#region Suid
		/// <summary>
		/// Suid property
		/// </summary>
		public string Suid 
		{
			get 
			{
				return GetValue("p_nSuid");
			}
			set 
			{
				SetValue("p_nSuid",value);
			}
		}
		#endregion
		#region NatureOfBusiness
		/// <summary>
		/// NatureOfBusiness property
		/// </summary>
		public string NatureOfBusiness 
		{
			get 
			{
				return GetValue("p_nNatureOfBusiness");
			}
			set 
			{
				SetValue("p_nNatureOfBusiness",value);
			}
		}
		#endregion
		#region LocationCode
		/// <summary>
		/// LocationCode property
		/// </summary>
		public string LocationCode 
		{
			get 
			{
				return GetValue("p_nLocationCode");
			}
			set 
			{
				SetValue("p_nLocationCode",value);
			}
		}
		#endregion
		#region SecName
		/// <summary>
		/// SecName property
		/// </summary>
		public string SecName 
		{
			get 
			{
				return GetValue("p_nSecName");
			}
			set 
			{
				SetValue("p_nSecName",value);
			}
		}
		#endregion
		#region SecCd
		/// <summary>
		/// SecCd property
		/// </summary>
		public string SecCd 
		{
			get 
			{
				return GetValue("p_nSecCd");
			}
			set 
			{
				SetValue("p_nSecCd",value);
			}
		}
		#endregion
		#region LocName
		/// <summary>
		/// LocName property
		/// </summary>
		public string LocName 
		{
			get 
			{
				return GetValue("p_nLocName");
			}
			set 
			{
				SetValue("p_nLocName",value);
			}
		}
		#endregion
		#region DivisionName
		/// <summary>
		/// DivisionName property
		/// </summary>
		public string DivisionName 
		{
			get 
			{
				return GetValue("p_nDivisionName");
			}
			set 
			{
				SetValue("p_nDivisionName",value);
			}
		}
		#endregion
		#region DivisionCode
		/// <summary>
		/// DivisionCode property
		/// </summary>
		public string DivisionCode 
		{
			get 
			{
				return GetValue("p_nDivisionCode");
			}
			set 
			{
				SetValue("p_nDivisionCode",value);
			}
		}
		#endregion
		#region DepartmentName
		/// <summary>
		/// DepartmentName property
		/// </summary>
		public string DepartmentName 
		{
			get 
			{
				return GetValue("p_nDepartmentName");
			}
			set 
			{
				SetValue("p_nDepartmentName",value);
			}
		}
		#endregion
		#region DepartmentCode
		/// <summary>
		/// DepartmentCode property
		/// </summary>
		public string DepartmentCode 
		{
			get 
			{
				return GetValue("p_nDepartmentCode");
			}
			set 
			{
				SetValue("p_nDepartmentCode",value);
			}
		}
		#endregion
		#region AutoEscalate
		/// <summary>
		/// AutoEscalate property
		/// </summary>
		public string AutoEscalate 
		{
			get 
			{
				return GetValue("p_nAutoEscalate");
			}
			set 
			{
				SetValue("p_nAutoEscalate",value);
			}
		}
		#endregion
		#region NodeLevel
		/// <summary>
		/// NodeLevel property
		/// </summary>
		public string NodeLevel 
		{
			get 
			{
				return GetValue("p_nNodeLevel");
			}
			set 
			{
				SetValue("p_nNodeLevel",value);
			}
		}
		#endregion
		#region UploadKey
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
		#endregion
		#region ActiveStatus
		/// <summary>
		/// ActiveStatus property
		/// </summary>
		public string ActiveStatus 
		{
			get 
			{
				return GetValue("p_nActiveStatus");
			}
			set 
			{
				SetValue("p_nActiveStatus",value);
			}
		}
		#endregion
		#region StatusDate
		/// <summary>
		/// StatusDate property
		/// </summary>
		public string StatusDate 
		{
			get 
			{
				return GetValue("p_nStatusDate");
			}
			set 
			{
				SetValue("p_nStatusDate",value);
			}
		}
		#endregion
		#region ManageCareType
		/// <summary>
		/// ManageCareType property
		/// </summary>
		public string ManageCareType 
		{
			get 
			{
				return GetValue("p_nManageCareType");
			}
			set 
			{
				SetValue("p_nManageCareType",value);
			}
		}
		#endregion
		#region AdditionalDeliveries
		/// <summary>
		/// AdditionalDeliveries property
		/// </summary>
		public string AdditionalDeliveries 
		{
			get 
			{
				return GetValue("p_nAdditionalDeliveries");
			}
			set 
			{
				SetValue("p_nAdditionalDeliveries",value);
			}
		}
		#endregion
		#region SpecificDestination
		/// <summary>
		/// SpecificDestination property
		/// </summary>
		public string SpecificDestination 
		{
			get 
			{
				return GetValue("p_nSpecificDestination");
			}
			set 
			{
				SetValue("p_nSpecificDestination",value);
			}
		}
		#endregion
		#region AccountFromDate
		/// <summary>
		/// AccountFromDate property
		/// </summary>
		public string AccountFromDate 
		{
			get 
			{
				return GetValue("p_nAccountFromDate");
			}
			set 
			{
				SetValue("p_nAccountFromDate",value);
			}
		}
		#endregion
		#region AccountToDate
		/// <summary>
		/// AccountToDate property
		/// </summary>
		public string AccountToDate 
		{
			get 
			{
				return GetValue("p_nAccountToDate");
			}
			set 
			{
				SetValue("p_nAccountToDate",value);
			}
		}
		#endregion
		#region CurrentFlag
		/// <summary>
		/// CurrentFlag property
		/// </summary>
		public string CurrentFlag 
		{
			get 
			{
				return GetValue("p_nCurrentFlag");
			}
			set 
			{
				SetValue("p_nCurrentFlag",value);
			}
		}
		#endregion
		#region ActecCode
		/// <summary>
		/// ActecCode property
		/// </summary>
		public string ActecCode 
		{
			get 
			{
				return GetValue("p_nActecCode");
			}
			set 
			{
				SetValue("p_nActecCode",value);
			}
		}
		#endregion
		#region NodeTypeID
		/// <summary>
		/// NodeTypeID	 property
		/// </summary>
		public string NodeTypeID	 
		{
			get 
			{
				return GetValue("p_nNodeTypeID");
			}
			set 
			{
				SetValue("p_nNodeTypeID",value);
			}
		}
		#endregion
		#region NameShort
		/// <summary>
		/// NameShort property
		/// </summary>
		public string NameShort 
		{
			get 
			{
				return GetValue("p_nNameShort");
			}
			set 
			{
				SetValue("p_nNameShort",value);
			}
		}
		#endregion
		#region AccountPassword
		/// <summary>
		/// AccountPassword property
		/// </summary>
		public string AccountPassword 
		{
			get 
			{
				return GetValue("p_nAccountPassword");
			}
			set 
			{
				SetValue("p_nAccountPassword",value);
			}
		}
		#endregion
		#region NaicsCode
		/// <summary>
		/// NaicsCode property
		/// </summary>
		public string NaicsCode 
		{
			get 
			{
				return GetValue("p_nNaicsCode");
			}
			set 
			{
				SetValue("p_nNaicsCode",value);
			}
		}
		#endregion
		#region AccountName
		/// <summary>
		/// AccountName property
		/// </summary>
		public string AccountName 
		{
			get 
			{
				return GetValue("p_nAccountName");
			}
			set 
			{
				SetValue("p_nAccountName",value);
			}
		}
		#endregion
		#region AgentBillingMethod
		/// <summary>
		/// AgentBillingMethod property
		/// </summary>
		public string AgentBillingMethod 
		{
			get 
			{
				return GetValue("p_nAgentBillingMethod");
			}
			set 
			{
				SetValue("p_nAgentBillingMethod",value);
			}
		}
		#endregion
		#region AgentPaymentType
		/// <summary>
		/// AgentPaymentType property
		/// </summary>
		public string AgentPaymentType 
		{
			get 
			{
				return GetValue("p_nAgentPaymentType");
			}
			set 
			{
				SetValue("p_nAgentPaymentType",value);
			}
		}
		#endregion
		#region EmailAddress
		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		/// <value>The email address.</value>
		public string EmailAddress 
		{
			get 
			{
				return GetValue("p_nEmailAddress");
			}
			set 
			{
				SetValue("p_nEmailAddress",value);
			}
		}
		#endregion
        #region DisseminationFlag

        /// <summary>
        /// Gets or sets the dissemination flag.
        /// </summary>
        /// <value>The dissemination flag.</value>
        public string DisseminationFlag
        {
            get
            {
                return GetValue("p_nDisseminationFlag");
            }
            set
            {
                SetValue("p_nDisseminationFlag", value);
            }
        }
        #endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/SEDAccountHierarchyStep.cs $
 * 
 * 3     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 2     8/12/08 1:39p Jenny.cheung
 * Added for Sedgwick Dissemination SOW
 * 
 * 1     8/12/08 8:20a Jenny.cheung
 * created a separate ahs class for Sedgwick due to extra parameter in the
 * stored procedure
 * 
 * 4     8/07/08 4:01p Jenny.cheung
 * Added DisseminationFlag for Sedgwick
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 8     2/27/07 3:25p John.gwynn
 * Added AhsRecord class for single instance retrieval of AHS records
 * 
 * 7     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 6     10/27/06 5:12p John.gwynn
 * modified type to AhsType
 * 
 * 5     6/12/06 11:25a John.gwynn
 * Updated AHS, reset dependencies to strong named components
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
 * 1     11/16/05 6:20p John.gwynn
 * Added AHS
 */
#endregion