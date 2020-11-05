#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2007 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AhsRecord.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for AhsRecord.
	/// </summary>
	[ComVisible(false)]	
	public class AhsRecord : DbBaseClass
	{
		/// <summary>
		/// enumerated column list for ACCOUNT_HIERARCY_STEP tabe
		/// </summary>
		public enum ResultList
		{
			/// <summary>
			/// ACCNT_HRCY_STEP_ID
			/// </summary>
			AhsId = 0,
			/// <summary>
			/// NODE_TYPE_ID
			/// </summary>
			NodeTypeId,
			/// <summary>
			/// PARENT_NODE_ID
			/// </summary>
			ParentNodeId,
			/// <summary>
			/// CLIENT_NODE_ID
			/// </summary>
			ClientNodeId,
			/// <summary>
			/// TYPE
			/// </summary>
			AhsType,
			/// <summary>
			/// NAME
			/// </summary>
			FullName,
			/// <summary>
			/// NAME_FIRST
			/// </summary>
			FirstName,
			/// <summary>
			/// NAME_LAST
			/// </summary>
			LastName,
			/// <summary>
			/// NAME_MI
			/// </summary>
			MidInitial,
			/// <summary>
			/// ADDRESS_1
			/// </summary>
			Address1,
			/// <summary>
			/// ADDRESS_2
			/// </summary>
			Address2,
			/// <summary>
			/// ADDRESS_3
			/// </summary>
			Address3,
			/// <summary>
			/// CITY
			/// </summary>
			City,
			/// <summary>
			/// STATE
			/// </summary>
			State,
			/// <summary>
			/// ZIP
			/// </summary>
			Zip,
			/// <summary>
			/// PHONE
			/// </summary>
			Phone,
			/// <summary>
			/// ALT_PHONE
			/// </summary>
			AltPhone,
			/// <summary>
			/// FAX
			/// </summary>
			Fax,
			/// <summary>
			/// ALT_FAX
			/// </summary>
			AltFax,
			/// <summary>
			/// FIPS
			/// </summary>
			Fips,
			/// <summary>
			/// COUNTY
			/// </summary>
			County,
			/// <summary>
			/// COUNTRY
			/// </summary>
			Country,
			/// <summary>
			/// FEIN
			/// </summary>
			Fein,
			/// <summary>
			/// SIC
			/// </summary>
			Sic,
			/// <summary>
			/// SUID
			/// </summary>
			Suid,
			/// <summary>
			/// NATURE_OF_BUSINESS
			/// </summary>
			NatureOfBusiness,
			/// <summary>
			/// NODE_LEVEL
			/// </summary>
			NodeLevel,
			/// <summary>
			/// LOCATION_CODE
			/// </summary>
			LocationCode,
			/// <summary>
			/// UPLOAD_KEY
			/// </summary>
			UploadKey,
			/// <summary>
			/// ACTIVE_STATUS
			/// </summary>
			ActiveStatus,
			/// <summary>
			/// SEC_NAME
			/// </summary>
			SecName,
			/// <summary>
			/// SEC_CD
			/// </summary>
			SecCode,
			/// <summary>
			/// LOC_NAME
			/// </summary>
			LocName,
			/// <summary>
			/// DIVISION_NAME
			/// </summary>
			DivisionName,
			/// <summary>
			/// DIVISION_CD
			/// </summary>
			DivisionCode,
			/// <summary>
			/// DEPT_NAME
			/// </summary>
			DepartmentName,
			/// <summary>
			/// DEPT_CD
			/// </summary>
			DepartmentCode,
			/// <summary>
			/// NAME_SHORT
			/// </summary>
			NameShort,
			/// <summary>
			/// ACTEC_CD
			/// </summary>
			ActecCode,
			/// <summary>
			/// FILE_TRAN_LOG_ID
			/// </summary>
			FileTranLogId,
			/// <summary>
			/// ACCOUNT_FROM_DATE
			/// </summary>
			AccountFromDate,
			/// <summary>
			/// ACCOUNT_TO_DATE
			/// </summary>
			AccountToDate,
			/// <summary>
			/// ACCOUNT_NAME
			/// </summary>
			AccountName,
			/// <summary>
			/// EMAIL_ADDRESS
			/// </summary>
			EmailAddress,
			/// <summary>
			/// NAICS_CD
			/// </summary>
			NaicsCode,
			/// <summary>
			/// AGENT_BILLING_METHOD
			/// </summary>
			AgentBillingMethod,
			/// <summary>
			/// AGENT_PAYMENT_TYPE
			/// </summary>
			AgentPaymentType,
			/// <summary>
			/// SPECIFIC_DESTINATION_FLAG
			/// </summary>
			SpecificDestinationFlag
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="AhsRecord"/> class.
		/// </summary>
		public AhsRecord():this(String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="AhsRecord"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public AhsRecord(string instance) :base (instance)
		{
			_name = "DBCLASSLIBRARY.GetAHSRecord";
			_hasCursor = true;
			
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
			///// p_AHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_AHSID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_UploadKey
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_UploadKey","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// results
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"results","",System.Data.DbType.Object);
		}
		#endregion
		#region AhsId
		/// <summary>
		/// Gets or sets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string AhsId
		{
			get
			{
				return GetDataRowValue((int)ResultList.AhsId);
			}
			set
			{
				SetValue("p_AHSID", value);
			}
		}
		#endregion
		#region NodeTypeId
		/// <summary>
		/// Gets or sets the node type id.
		/// </summary>
		/// <value>The node type id.</value>
		public string NodeTypeId
		{
			get 
			{
				return GetDataRowValue((int)ResultList.NodeTypeId);
			}
		}
		#endregion
		#region ParentNodeId
		/// <summary>
		/// Gets the parent node id.
		/// </summary>
		/// <value>The parent node id.</value>
		public string ParentNodeId
		{
			get 
			{
				return GetDataRowValue((int)ResultList.ParentNodeId);
			}
		}
		#endregion
		#region ClientNodeId
		/// <summary>
		/// Gets the client node id.
		/// </summary>
		/// <value>The client node id.</value>
		public string ClientNodeId
		{
			get 
			{
				return GetDataRowValue((int)ResultList.ClientNodeId);
			}
		}
		#endregion
		#region AhsType
		/// <summary>
		/// Gets the type of the ahs.
		/// </summary>
		/// <value>The type of the ahs.</value>
		public string AhsType
		{
			get 
			{
				return GetDataRowValue((int)ResultList.AhsType);
			}
		}
		#endregion
		#region FullName
		/// <summary>
		/// Gets the full name.
		/// </summary>
		/// <value>The full name.</value>
		public string FullName
		{
			get 
			{
				return GetDataRowValue((int)ResultList.FullName);
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
				return GetDataRowValue((int)ResultList.FirstName);
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
				return GetDataRowValue((int)ResultList.LastName);
			}
		}
		#endregion
		#region MidInitial
		/// <summary>
		/// Gets the mid initial.
		/// </summary>
		/// <value>The mid initial.</value>
		public string MidInitial
		{
			get 
			{
				return GetDataRowValue((int)ResultList.MidInitial);
			}
		}
		#endregion
		#region Address1
		/// <summary>
		/// Gets the address1.
		/// </summary>
		/// <value>The address1.</value>
		public string Address1
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Address1);
			}
		}
		#endregion
		#region Address2
		/// <summary>
		/// Gets the address2.
		/// </summary>
		/// <value>The address2.</value>
		public string Address2
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Address2);
			}
		}
		#endregion
		#region Address3
		/// <summary>
		/// Gets the address3.
		/// </summary>
		/// <value>The address3.</value>
		public string Address3
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Address3);
			}
		}
		#endregion
		#region City
		/// <summary>
		/// Gets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City
		{
			get 
			{
				return GetDataRowValue((int)ResultList.City);
			}
		}
		#endregion
		#region State
		/// <summary>
		/// Gets the state.
		/// </summary>
		/// <value>The state.</value>
		public string State
		{
			get 
			{
				return GetDataRowValue((int)ResultList.State);
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
				return GetDataRowValue((int)ResultList.Zip);
			}
		}
		#endregion
		#region Phone
		/// <summary>
		/// Gets the phone.
		/// </summary>
		/// <value>The phone.</value>
		public string Phone
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Phone);
			}
		}
		#endregion
		#region AltPhone
		/// <summary>
		/// Gets the alt phone.
		/// </summary>
		/// <value>The alt phone.</value>
		public string AltPhone
		{
			get 
			{
				return GetDataRowValue((int)ResultList.AltPhone);
			}
		}
		#endregion
		#region Fax
		/// <summary>
		/// Gets the fax.
		/// </summary>
		/// <value>The fax.</value>
		public string Fax
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Fax);
			}
		}
		#endregion
		#region AltFax
		/// <summary>
		/// Gets the alt fax.
		/// </summary>
		/// <value>The alt fax.</value>
		public string AltFax
		{
			get 
			{
				return GetDataRowValue((int)ResultList.AltFax);
			}
		}
		#endregion
		#region Fips
		/// <summary>
		/// Gets the fips.
		/// </summary>
		/// <value>The fips.</value>
		public string Fips
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Fips);
			}
		}
		#endregion
		#region County
		/// <summary>
		/// Gets the county.
		/// </summary>
		/// <value>The county.</value>
		public string County
		{
			get 
			{
				return GetDataRowValue((int)ResultList.County);
			}
		}
		#endregion
		#region Country
		/// <summary>
		/// Gets the country.
		/// </summary>
		/// <value>The country.</value>
		public string Country
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Country);
			}
		}
		#endregion
		#region Fein
		/// <summary>
		/// Gets the fein.
		/// </summary>
		/// <value>The fein.</value>
		public string Fein
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Fein);
			}
		}
		#endregion
		#region Sic
		/// <summary>
		/// Gets the sic.
		/// </summary>
		/// <value>The sic.</value>
		public string Sic
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Sic);
			}
		}
		#endregion
		#region Suid
		/// <summary>
		/// Gets the suid.
		/// </summary>
		/// <value>The suid.</value>
		public string Suid
		{
			get 
			{
				return GetDataRowValue((int)ResultList.Suid);
			}
		}
		#endregion
		#region NatureOfBusiness
		/// <summary>
		/// Gets the nature of business.
		/// </summary>
		/// <value>The nature of business.</value>
		public string NatureOfBusiness
		{
			get 
			{
				return GetDataRowValue((int)ResultList.NatureOfBusiness);
			}
		}
		#endregion
		#region NodeLevel
		/// <summary>
		/// Gets the node level.
		/// </summary>
		/// <value>The node level.</value>
		public string NodeLevel
		{
			get 
			{
				return GetDataRowValue((int)ResultList.NodeLevel);
			}
		}
		#endregion
		#region LocationCode
		/// <summary>
		/// Gets the location code.
		/// </summary>
		/// <value>The location code.</value>
		public string LocationCode
		{
			get 
			{
				return GetDataRowValue((int)ResultList.LocationCode);
			}
		}
		#endregion
		#region UploadKey
		/// <summary>
		/// Gets the upload key.
		/// </summary>
		/// <value>The upload key.</value>
		public string UploadKey
		{
			get 
			{
				return GetDataRowValue((int)ResultList.UploadKey);
			}
			set
			{
				SetValue("p_UploadKey", value);
			}
		}
		#endregion
		#region ActiveStatus
		/// <summary>
		/// Gets the active status.
		/// </summary>
		/// <value>The active status.</value>
		public string ActiveStatus
		{
			get 
			{
				return GetDataRowValue((int)ResultList.ActiveStatus);
			}
		}
		#endregion
		#region SecName
		/// <summary>
		/// Gets the name of the sec.
		/// </summary>
		/// <value>The name of the sec.</value>
		public string SecName
		{
			get 
			{
				return GetDataRowValue((int)ResultList.SecName);
			}
		}
		#endregion
		#region SecCode
		/// <summary>
		/// Gets the sec code.
		/// </summary>
		/// <value>The sec code.</value>
		public string SecCode
		{
			get 
			{
				return GetDataRowValue((int)ResultList.SecCode);
			}
		}
		#endregion
		#region LocName
		/// <summary>
		/// Gets the name of the loc.
		/// </summary>
		/// <value>The name of the loc.</value>
		public string LocName
		{
			get 
			{
				return GetDataRowValue((int)ResultList.LocName);
			}
		}
		#endregion
		#region DivisionName
		/// <summary>
		/// Gets the name of the division.
		/// </summary>
		/// <value>The name of the division.</value>
		public string DivisionName
		{
			get 
			{
				return GetDataRowValue((int)ResultList.DivisionName);
			}
		}
		#endregion
		#region DivisionCode
		/// <summary>
		/// Gets the division code.
		/// </summary>
		/// <value>The division code.</value>
		public string DivisionCode
		{
			get 
			{
				return GetDataRowValue((int)ResultList.DivisionCode);
			}
		}
		#endregion
		#region DepartmentName
		/// <summary>
		/// Gets the name of the department.
		/// </summary>
		/// <value>The name of the department.</value>
		public string DepartmentName
		{
			get 
			{
				return GetDataRowValue((int)ResultList.DepartmentName);
			}
		}
		#endregion
		#region DepartmentCode
		/// <summary>
		/// Gets the department code.
		/// </summary>
		/// <value>The department code.</value>
		public string DepartmentCode
		{
			get 
			{
				return GetDataRowValue((int)ResultList.DepartmentCode);
			}
		}
		#endregion
		#region NameShort
		/// <summary>
		/// Gets the name short.
		/// </summary>
		/// <value>The name short.</value>
		public string NameShort
		{
			get 
			{
				return GetDataRowValue((int)ResultList.NameShort);
			}
		}
		#endregion
		#region ActecCode
		/// <summary>
		/// Gets the actec code.
		/// </summary>
		/// <value>The actec code.</value>
		public string ActecCode
		{
			get 
			{
				return GetDataRowValue((int)ResultList.ActecCode);
			}
		}
		#endregion
		#region FileTranLogId
		/// <summary>
		/// Gets the file tran log id.
		/// </summary>
		/// <value>The file tran log id.</value>
		public string FileTranLogId
		{
			get 
			{
				return GetDataRowValue((int)ResultList.FileTranLogId);
			}
		}
		#endregion
		#region AccountFromDate
		/// <summary>
		/// Gets the account from date.
		/// </summary>
		/// <value>The account from date.</value>
		public string AccountFromDate
		{
			get 
			{
				return GetDataRowValue((int)ResultList.AccountFromDate);
			}
		}
		#endregion
		#region AccountToDate
		/// <summary>
		/// Gets the account to date.
		/// </summary>
		/// <value>The account to date.</value>
		public string AccountToDate
		{
			get 
			{
				return GetDataRowValue((int)ResultList.AccountToDate);
			}
		}
		#endregion
		#region AccountName
		/// <summary>
		/// Gets the name of the account.
		/// </summary>
		/// <value>The name of the account.</value>
		public string AccountName
		{
			get 
			{
				return GetDataRowValue((int)ResultList.AccountName);
			}
		}
		#endregion
		#region EmailAddress
		/// <summary>
		/// Gets the email address.
		/// </summary>
		/// <value>The email address.</value>
		public string EmailAddress
		{
			get 
			{
				return GetDataRowValue((int)ResultList.EmailAddress);
			}
		}
		#endregion
		#region NaicsCode
		/// <summary>
		/// Gets the naics code.
		/// </summary>
		/// <value>The naics code.</value>
		public string NaicsCode
		{
			get 
			{
				return GetDataRowValue((int)ResultList.NaicsCode);
			}
		}
		#endregion
		#region AgentBillingMethod
		/// <summary>
		/// Gets the agent billing method.
		/// </summary>
		/// <value>The agent billing method.</value>
		public string AgentBillingMethod
		{
			get 
			{
				return GetDataRowValue((int)ResultList.AgentBillingMethod);
			}
		}
		#endregion
		#region AgentPaymentType
		/// <summary>
		/// Gets the type of the agent payment.
		/// </summary>
		/// <value>The type of the agent payment.</value>
		public string AgentPaymentType
		{
			get 
			{
				return GetDataRowValue((int)ResultList.AgentPaymentType);
			}
		}
		#endregion
		#region SpecificDestinationFlag
		/// <summary>
		/// Gets the specific destination flag.
		/// </summary>
		/// <value>The specific destination flag.</value>
		public string SpecificDestinationFlag
		{
			get 
			{
				return GetDataRowValue((int)ResultList.SpecificDestinationFlag);
			}
		}
		#endregion
		
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AhsRecord.cs $
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
 * 3     3/14/07 5:09p John.gwynn
 * added SpecificDestinationFlag
 * 
 * 2     2/27/07 4:58p John.gwynn
 * added UploadKey as a parameter for retrieval
 * 
 * 1     2/27/07 3:25p John.gwynn
 * Added AhsRecord class for single instance retrieval of AHS records
 */
#endregion