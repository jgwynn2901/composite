#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AhsActiveRecord.cs 12    7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;
using System.Runtime.InteropServices;
using FnsComposite.Interfaces;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	[ComVisible(false)]
	public class AhsActiveRecord : ActiveRecord, IAccountHierarchyStep
	{
	    private AhsActiveRecord _lazyParent;
		/// <summary>
		/// Initializes a new instance of the <see cref="AhsActiveRecord"/> class.
		/// </summary>
		public AhsActiveRecord()
			: base("ACCOUNT_HIERARCHY_STEP")
		{
			// Begin Generated Column Definitions
			columns.Add(new Column("ACCNT_HRCY_STEP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("NODE_TYPE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("PARENT_NODE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CLIENT_NODE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("PEER_NODE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("AUTO_ESCALATE", String.Empty, "CHAR"));
			columns.Add(new Column("NAME_FIRST", String.Empty, "VARCHAR2"));
			columns.Add(new Column("TYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("NAME_LAST", String.Empty, "VARCHAR2"));
			columns.Add(new Column("NAME_MI", String.Empty, "CHAR"));
    		columns.Add(new Column("FNS_CLIENT_CD", String.Empty, "CHAR"));
			columns.Add(new Column("ADDRESS_1", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDRESS_2", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDRESS_3", String.Empty, "VARCHAR2"));
			columns.Add(new Column("COUNTRY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CITY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STATE", String.Empty, "CHAR"));
			columns.Add(new Column("ZIP", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FIPS", String.Empty, "CHAR"));
			columns.Add(new Column("COUNTY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("PHONE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FAX", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ALT_FAX", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FEIN", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SIC", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SUID", String.Empty, "VARCHAR2"));
			columns.Add(new Column("NATURE_OF_BUSINESS", String.Empty, "VARCHAR2"));
			columns.Add(new Column("NODE_LEVEL", String.Empty, "NUMBER"));
			columns.Add(new Column("LOCATION_CODE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ESCALATION_CALLBACK_NUM", String.Empty, "VARCHAR2"));
			columns.Add(new Column("UPLOAD_KEY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACTIVE_STATUS", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STATUS_DATE", String.Empty, "DATE"));
			columns.Add(new Column("CREATED_DT", String.Empty, "DATE"));
			columns.Add(new Column("MODIFIED_DT", String.Empty, "DATE"));
			columns.Add(new Column("ALT_PHONE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SEC_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SEC_CD", String.Empty, "VARCHAR2"));
			columns.Add(new Column("LOC_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DIVISION_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DIVISION_CD", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DEPT_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DEPT_CD", String.Empty, "VARCHAR2"));
			columns.Add(new Column("MANAGED_CARE_TYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SPECIFIC_DESTINATION_FLAG", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDITIONAL_DELIVERIES", String.Empty, "VARCHAR2"));
			columns.Add(new Column("NAME_SHORT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACTEC_CD", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FILE_TRAN_LOG_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CURRENT_FLG", String.Empty, "CHAR"));
      columns.Add(new Column("ACCOUNT_FROM_DATE", String.Empty, "SHORTDATE"));
      columns.Add(new Column("ACCOUNT_TO_DATE", String.Empty, "SHORTDATE"));
      columns.Add(new Column("EXCEPTION_DT", String.Empty, "SHORTDATE"));
			columns.Add(new Column("ACTIVE_START_DATE", String.Empty, "DATE"));
			columns.Add(new Column("ACTIVE_END_DATE", String.Empty, "DATE"));
			columns.Add(new Column("ACCOUNT_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("EMAIL_ADDRESS", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACCOUNT_PASSWORD", String.Empty, "VARCHAR2"));
			columns.Add(new Column("NAICS_CD", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AGENT_BILLING_METHOD", String.Empty, "CHAR"));
			columns.Add(new Column("AGENT_PAYMENT_TYPE", String.Empty, "VARCHAR2"));
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="AhsActiveRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public AhsActiveRecord(IDataReader reader)
			: base(reader, "ACCOUNT_HIERARCHY_STEP")
		{
		}
		#region AccntHrcyStepId
		/// <summary>
		/// Gets or sets the accnt hrcy step id.
		/// </summary>
		/// <value>The accnt hrcy step id.</value>
		public string AccntHrcyStepId
		{
			get
			{
				return GetColumnValue("ACCNT_HRCY_STEP_ID");
			}
			set
			{
				SetColumnValue("ACCNT_HRCY_STEP_ID", value);
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
				return GetColumnValue("NODE_TYPE_ID");
			}
			set
			{
				SetColumnValue("NODE_TYPE_ID", value);
			}
		}
		#endregion
		#region ParentNodeId
		/// <summary>
		/// Gets or sets the parent node id.
		/// </summary>
		/// <value>The parent node id.</value>
		public string ParentNodeId
		{
			get
			{
				return GetColumnValue("PARENT_NODE_ID");
			}
			set
			{
				SetColumnValue("PARENT_NODE_ID", value);
			}
		}
		#endregion
		#region ClientNodeId
		/// <summary>
		/// Gets or sets the client node id.
		/// </summary>
		/// <value>The client node id.</value>
		public string ClientNodeId
		{
			get
			{
				return GetColumnValue("CLIENT_NODE_ID");
			}
			set
			{
				SetColumnValue("CLIENT_NODE_ID", value);
			}
		}
		#endregion
		#region Name
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		public new string FullName
		{
			get
			{
				return GetColumnValue("NAME");
			}
			set
			{
				SetColumnValue("NAME", value);
			}
		}
		#endregion
		#region PeerNodeId
		/// <summary>
		/// Gets or sets the peer node id.
		/// </summary>
		/// <value>The peer node id.</value>
		public string PeerNodeId
		{
			get
			{
				return GetColumnValue("PEER_NODE_ID");
			}
			set
			{
				SetColumnValue("PEER_NODE_ID", value);
			}
		}
		#endregion
		#region AutoEscalate
		/// <summary>
		/// Gets or sets the auto escalate.
		/// </summary>
		/// <value>The auto escalate.</value>
		public string AutoEscalate
		{
			get
			{
				return GetColumnValue("AUTO_ESCALATE");
			}
			set
			{
				SetColumnValue("AUTO_ESCALATE", value);
			}
		}
		#endregion
		#region NameFirst
		/// <summary>
		/// Gets or sets the name first.
		/// </summary>
		/// <value>The name first.</value>
		public string NameFirst
		{
			get
			{
				return GetColumnValue("NAME_FIRST");
			}
			set
			{
				SetColumnValue("NAME_FIRST", value);
			}
		}
		#endregion
		#region Type
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string Type
		{
			get
			{
				return GetColumnValue("TYPE");
			}
			set
			{
				SetColumnValue("TYPE", value);
			}
		}
		#endregion
		#region NameLast
		/// <summary>
		/// Gets or sets the name last.
		/// </summary>
		/// <value>The name last.</value>
		public string NameLast
		{
			get
			{
				return GetColumnValue("NAME_LAST");
			}
			set
			{
				SetColumnValue("NAME_LAST", value);
			}
		}
		#endregion
		#region NameMi
		/// <summary>
		/// Gets or sets the name mi.
		/// </summary>
		/// <value>The name mi.</value>
		public string NameMi
		{
			get
			{
				return GetColumnValue("NAME_MI");
			}
			set
			{
				SetColumnValue("NAME_MI", value);
			}
		}
		#endregion
		#region FnsClientCd
		/// <summary>
		/// Gets or sets the FNS client cd.
		/// </summary>
		/// <value>The FNS client cd.</value>
		public string FnsClientCd
		{
			get
			{
				return GetColumnValue("FNS_CLIENT_CD");
			}
			set
			{
				SetColumnValue("FNS_CLIENT_CD", value);
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
				return GetColumnValue("ADDRESS_1");
			}
			set
			{
				SetColumnValue("ADDRESS_1", value);
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
				return GetColumnValue("ADDRESS_2");
			}
			set
			{
				SetColumnValue("ADDRESS_2", value);
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
				return GetColumnValue("ADDRESS_3");
			}
			set
			{
				SetColumnValue("ADDRESS_3", value);
			}
		}
		#endregion
		#region Country
		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
		public string Country
		{
			get
			{
				return GetColumnValue("COUNTRY");
			}
			set
			{
				SetColumnValue("COUNTRY", value);
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
				return GetColumnValue("CITY");
			}
			set
			{
				SetColumnValue("CITY", value);
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
				return GetColumnValue("STATE");
			}
			set
			{
				SetColumnValue("STATE", value);
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
				return GetColumnValue("ZIP");
			}
			set
			{
				SetColumnValue("ZIP", value);
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
				return GetColumnValue("FIPS");
			}
			set
			{
				SetColumnValue("FIPS", value);
			}
		}
		#endregion
		#region County
		/// <summary>
		/// Gets or sets the county.
		/// </summary>
		/// <value>The county.</value>
		public string County
		{
			get
			{
				return GetColumnValue("COUNTY");
			}
			set
			{
				SetColumnValue("COUNTY", value);
			}
		}
		#endregion
		#region Phone
		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		/// <value>The phone.</value>
		public string Phone
		{
			get
			{
				return GetColumnValue("PHONE");
			}
			set
			{
				SetColumnValue("PHONE", value);
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
				return GetColumnValue("FAX");
			}
			set
			{
				SetColumnValue("FAX", value);
			}
		}
		#endregion
		#region AltFax
		/// <summary>
		/// Gets or sets the alt fax.
		/// </summary>
		/// <value>The alt fax.</value>
		public string AltFax
		{
			get
			{
				return GetColumnValue("ALT_FAX");
			}
			set
			{
				SetColumnValue("ALT_FAX", value);
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
				return GetColumnValue("FEIN");
			}
			set
			{
				SetColumnValue("FEIN", value);
			}
		}
		#endregion
		#region Sic
		/// <summary>
		/// Gets or sets the sic.
		/// </summary>
		/// <value>The sic.</value>
		public string Sic
		{
			get
			{
				return GetColumnValue("SIC");
			}
			set
			{
				SetColumnValue("SIC", value);
			}
		}
		#endregion
		#region Suid
		/// <summary>
		/// Gets or sets the su id.
		/// </summary>
		/// <value>The su id.</value>
        public string Suid
		{
			get
			{
				return GetColumnValue("SUID");
			}
			set
			{
				SetColumnValue("SUID", value);
			}
		}
		#endregion
		#region NatureOfBusiness
		/// <summary>
		/// Gets or sets the nature of business.
		/// </summary>
		/// <value>The nature of business.</value>
		public string NatureOfBusiness
		{
			get
			{
				return GetColumnValue("NATURE_OF_BUSINESS");
			}
			set
			{
				SetColumnValue("NATURE_OF_BUSINESS", value);
			}
		}
		#endregion
		#region NodeLevel
		/// <summary>
		/// Gets or sets the node level.
		/// </summary>
		/// <value>The node level.</value>
		public string NodeLevel
		{
			get
			{
				return GetColumnValue("NODE_LEVEL");
			}
			set
			{
				SetColumnValue("NODE_LEVEL", value);
			}
		}
		#endregion
		#region LocationCode
		/// <summary>
		/// Gets or sets the location code.
		/// </summary>
		/// <value>The location code.</value>
		public string LocationCode
		{
			get
			{
				return GetColumnValue("LOCATION_CODE");
			}
			set
			{
				SetColumnValue("LOCATION_CODE", value);
			}
		}
		#endregion
		#region EscalationCallbackNum
		/// <summary>
		/// Gets or sets the escalation callback num.
		/// </summary>
		/// <value>The escalation callback num.</value>
		public string EscalationCallbackNum
		{
			get
			{
				return GetColumnValue("ESCALATION_CALLBACK_NUM");
			}
			set
			{
				SetColumnValue("ESCALATION_CALLBACK_NUM", value);
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
				return GetColumnValue("UPLOAD_KEY");
			}
			set
			{
				SetColumnValue("UPLOAD_KEY", value);
			}
		}
		#endregion
		#region ActiveStatus
		/// <summary>
		/// Gets or sets the active status.
		/// </summary>
		/// <value>The active status.</value>
		public string ActiveStatus
		{
			get
			{
				return GetColumnValue("ACTIVE_STATUS");
			}
			set
			{
				SetColumnValue("ACTIVE_STATUS", value);
			}
		}
		#endregion
		#region StatusDate
		/// <summary>
		/// Gets or sets the status date.
		/// </summary>
		/// <value>The status date.</value>
		public string StatusDate
		{
			get
			{
				return GetColumnValue("STATUS_DATE");
			}
			set
			{
				SetColumnValue("STATUS_DATE", value);
			}
		}
		#endregion
		#region CreatedDt
		/// <summary>
		/// Gets or sets the created dt.
		/// </summary>
		/// <value>The created dt.</value>
		public string CreatedDt
		{
			get
			{
				return GetColumnValue("CREATED_DT");
			}
			set
			{
				SetColumnValue("CREATED_DT", value);
			}
		}
		#endregion
		#region ModifiedDt
		/// <summary>
		/// Gets or sets the modified dt.
		/// </summary>
		/// <value>The modified dt.</value>
		public string ModifiedDt
		{
			get
			{
				return GetColumnValue("MODIFIED_DT");
			}
			set
			{
				SetColumnValue("MODIFIED_DT", value);
			}
		}
		#endregion
		#region AltPhone
		/// <summary>
		/// Gets or sets the alt phone.
		/// </summary>
		/// <value>The alt phone.</value>
		public string AltPhone
		{
			get
			{
				return GetColumnValue("ALT_PHONE");
			}
			set
			{
				SetColumnValue("ALT_PHONE", value);
			}
		}
		#endregion
		#region SecName
		/// <summary>
		/// Gets or sets the name of the sec.
		/// </summary>
		/// <value>The name of the sec.</value>
		public string SecName
		{
			get
			{
				return GetColumnValue("SEC_NAME");
			}
			set
			{
				SetColumnValue("SEC_NAME", value);
			}
		}
		#endregion
		#region SecCd
		/// <summary>
		/// Gets or sets the sec cd.
		/// </summary>
		/// <value>The sec cd.</value>
		public string SecCd
		{
			get
			{
				return GetColumnValue("SEC_CD");
			}
			set
			{
				SetColumnValue("SEC_CD", value);
			}
		}
		#endregion
		#region LocName
		/// <summary>
		/// Gets or sets the name of the loc.
		/// </summary>
		/// <value>The name of the loc.</value>
		public string LocName
		{
			get
			{
				return GetColumnValue("LOC_NAME");
			}
			set
			{
				SetColumnValue("LOC_NAME", value);
			}
		}
		#endregion
		#region DivisionName
		/// <summary>
		/// Gets or sets the name of the division.
		/// </summary>
		/// <value>The name of the division.</value>
		public string DivisionName
		{
			get
			{
				return GetColumnValue("DIVISION_NAME");
			}
			set
			{
				SetColumnValue("DIVISION_NAME", value);
			}
		}
		#endregion
		#region DivisionCd
		/// <summary>
		/// Gets or sets the division cd.
		/// </summary>
		/// <value>The division cd.</value>
		public string DivisionCd
		{
			get
			{
				return GetColumnValue("DIVISION_CD");
			}
			set
			{
				SetColumnValue("DIVISION_CD", value);
			}
		}
		#endregion
		#region DeptName
		/// <summary>
		/// Gets or sets the name of the dept.
		/// </summary>
		/// <value>The name of the dept.</value>
		public string DeptName
		{
			get
			{
				return GetColumnValue("DEPT_NAME");
			}
			set
			{
				SetColumnValue("DEPT_NAME", value);
			}
		}
		#endregion
		#region DeptCd
		/// <summary>
		/// Gets or sets the dept cd.
		/// </summary>
		/// <value>The dept cd.</value>
		public string DeptCd
		{
			get
			{
				return GetColumnValue("DEPT_CD");
			}
			set
			{
				SetColumnValue("DEPT_CD", value);
			}
		}
		#endregion
		#region ManagedCareType
		/// <summary>
		/// Gets or sets the type of the managed care.
		/// </summary>
		/// <value>The type of the managed care.</value>
		public string ManagedCareType
		{
			get
			{
				return GetColumnValue("MANAGED_CARE_TYPE");
			}
			set
			{
				SetColumnValue("MANAGED_CARE_TYPE", value);
			}
		}
		#endregion
		#region SpecificDestinationFlag
		/// <summary>
		/// Gets or sets the specific destination flag.
		/// </summary>
		/// <value>The specific destination flag.</value>
		public string SpecificDestinationFlag
		{
			get
			{
				return GetColumnValue("SPECIFIC_DESTINATION_FLAG");
			}
			set
			{
				SetColumnValue("SPECIFIC_DESTINATION_FLAG", value);
			}
		}
		#endregion
		#region AdditionalDeliveries
		/// <summary>
		/// Gets or sets the additional deliveries.
		/// </summary>
		/// <value>The additional deliveries.</value>
		public string AdditionalDeliveries
		{
			get
			{
				return GetColumnValue("ADDITIONAL_DELIVERIES");
			}
			set
			{
				SetColumnValue("ADDITIONAL_DELIVERIES", value);
			}
		}
		#endregion
		#region NameShort
		/// <summary>
		/// Gets or sets the name short.
		/// </summary>
		/// <value>The name short.</value>
		public string NameShort
		{
			get
			{
				return GetColumnValue("NAME_SHORT");
			}
			set
			{
				SetColumnValue("NAME_SHORT", value);
			}
		}
		#endregion
		#region ActecCd
		/// <summary>
		/// Gets or sets the actec cd.
		/// </summary>
		/// <value>The actec cd.</value>
		public string ActecCd
		{
			get
			{
				return GetColumnValue("ACTEC_CD");
			}
			set
			{
				SetColumnValue("ACTEC_CD", value);
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
				return GetColumnValue("FILE_TRAN_LOG_ID");
			}
			set
			{
				SetColumnValue("FILE_TRAN_LOG_ID", value);
			}
		}
		#endregion
		#region CurrentFlg
		/// <summary>
		/// Gets or sets the current FLG.
		/// </summary>
		/// <value>The current FLG.</value>
		public string CurrentFlg
		{
			get
			{
				return GetColumnValue("CURRENT_FLG");
			}
			set
			{
				SetColumnValue("CURRENT_FLG", value);
			}
		}
		#endregion
		#region AccountFromDate
		/// <summary>
		/// Gets or sets the account from date.
		/// </summary>
		/// <value>The account from date.</value>
		public string AccountFromDate
		{
			get
			{
        return GetColumnValueAsShortDate("ACCOUNT_FROM_DATE");
			}
			set
			{
				SetColumnValue("ACCOUNT_FROM_DATE", value);
			}
		}
		#endregion
		#region AccountToDate
		/// <summary>
		/// Gets or sets the account to date.
		/// </summary>
		/// <value>The account to date.</value>
		public string AccountToDate
		{
			get
			{
        return GetColumnValueAsShortDate("ACCOUNT_TO_DATE");
			}
			set
			{
				SetColumnValue("ACCOUNT_TO_DATE", value);
			}
		}
		#endregion
		#region ExceptionDt
		/// <summary>
		/// Gets or sets the exception dt.
		/// </summary>
		/// <value>The exception dt.</value>
		public string ExceptionDt
		{
			get
			{
        return GetColumnValueAsShortDate("EXCEPTION_DT");
			}
			set
			{
				SetColumnValue("EXCEPTION_DT", value);
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
        return GetColumnValueAsShortDate("ACTIVE_START_DATE");
			}
			set
			{
				SetColumnValue("ACTIVE_START_DATE", value);
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
        return GetColumnValueAsShortDate("ACTIVE_END_DATE");
			}
			set
			{
				SetColumnValue("ACTIVE_END_DATE", value);
			}
		}
		#endregion
		#region AccountName
		/// <summary>
		/// Gets or sets the name of the account.
		/// </summary>
		/// <value>The name of the account.</value>
		public string AccountName
		{
			get
			{
				return GetColumnValue("ACCOUNT_NAME");
			}
			set
			{
				SetColumnValue("ACCOUNT_NAME", value);
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
				return GetColumnValue("EMAIL_ADDRESS");
			}
			set
			{
				SetColumnValue("EMAIL_ADDRESS", value);
			}
		}
		#endregion
		#region AccountPassword
		/// <summary>
		/// Gets or sets the account password.
		/// </summary>
		/// <value>The account password.</value>
		public string AccountPassword
		{
			get
			{
				return GetColumnValue("ACCOUNT_PASSWORD");
			}
			set
			{
				SetColumnValue("ACCOUNT_PASSWORD", value);
			}
		}
		#endregion
		#region NaicsCd
		/// <summary>
		/// Gets or sets the naics cd.
		/// </summary>
		/// <value>The naics cd.</value>
		public string NaicsCd
		{
			get
			{
				return GetColumnValue("NAICS_CD");
			}
			set
			{
				SetColumnValue("NAICS_CD", value);
			}
		}
		#endregion
		#region AgentBillingMethod
		/// <summary>
		/// Gets or sets the agent billing method.
		/// </summary>
		/// <value>The agent billing method.</value>
		public string AgentBillingMethod
		{
			get
			{
				return GetColumnValue("AGENT_BILLING_METHOD");
			}
			set
			{
				SetColumnValue("AGENT_BILLING_METHOD", value);
			}
		}
		#endregion
		#region AgentPaymentType
		/// <summary>
		/// Gets or sets the type of the agent payment.
		/// </summary>
		/// <value>The type of the agent payment.</value>
		public string AgentPaymentType
		{
			get
			{
				return GetColumnValue("AGENT_PAYMENT_TYPE");
			}
			set
			{
				SetColumnValue("AGENT_PAYMENT_TYPE", value);
			}
		}
		#endregion

		#region IAccountHierarchyStep Members


		/// <summary>
		/// Gets or sets the actec code.
		/// </summary>
		/// <value>The actec code.</value>
		public string ActecCode
		{
			get
			{
				return ActecCd;
			}
			set
			{
				ActecCd = value;
			}
		}

		/// <summary>
		/// Gets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string AhsId
		{
			get
			{
				return AccntHrcyStepId;
			}
			set
			{
				AccntHrcyStepId = value;
			}
		}

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string AhsType
		{
			get
			{
				return Type;
			}
			set
			{
				Type = value;
			}
		}

		/// <summary>
		/// Gets or sets the department code.
		/// </summary>
		/// <value>The department code.</value>
		public string DepartmentCode
		{
			get
			{
				return DeptCd;
			}
			set
			{
				DeptCd = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the department.
		/// </summary>
		/// <value>The name of the department.</value>
		public string DepartmentName
		{
			get
			{
				return DeptName;
			}
			set
			{
				DeptName = value;
			}
		}

		/// <summary>
		/// Gets or sets the division code.
		/// </summary>
		/// <value>The division code.</value>
		public string DivisionCode
		{
			get
			{
				return DivisionCd;
			}
			set
			{
				DivisionCd = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the first.
		/// </summary>
		/// <value>The name of the first.</value>
		public string FirstName
		{
			get
			{
				return NameFirst;
			}
			set
			{
				NameFirst = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the last.
		/// </summary>
		/// <value>The name of the last.</value>
		public string LastName
		{
			get
			{
				return NameLast;
			}
			set
			{
				NameLast = value;
			}
		}

		/// <summary>
		/// Gets or sets the mid initial.
		/// </summary>
		/// <value>The mid initial.</value>
		public string MidInitial
		{
			get
			{
				return NameMi;
			}
			set
			{
				NameMi = value;
			}
		}

		/// <summary>
		/// Gets or sets the naics code.
		/// </summary>
		/// <value>The naics code.</value>
		public string NaicsCode
		{
			get
			{
				return NaicsCd;
			}
			set
			{
				NaicsCd = value;
			}
		}

		/// <summary>
		/// Gets or sets the sec code.
		/// </summary>
		/// <value>The sec code.</value>
		public string SecCode
		{
			get
			{
				return SecCd;
			}
			set
			{
				SecCd = value;
			}
		}

		

		#endregion

		/// <summary>
		/// Generates the update SQL.
		/// </summary>
		protected override string GenerateUpdateSql()
		{
			return GenerateUpdateSqlForChanges();
		}

		/// <summary>
		/// Gets the ahs active record by upload key.
		/// </summary>
		public static AhsActiveRecord GetAhsActiveRecordByUploadKey(string uploadKey, string instance)
		{
			var records = new AhsActiveRecordSet
			                 	{
			                 		Instance = instance,
			                 		Query = "select * from ACCOUNT_HIERARCHY_STEP where UPLOAD_KEY = :uploadKey"
			                 	};

			records.AddParameter("uploadKey", uploadKey);
			
			if(!records.Execute())
				throw new ApplicationException(records.LastError);

			foreach(var record in records)
				return record;

			return null;
		}

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        /// <value>The parent.</value>
	    public AhsActiveRecord ParentNode
	    {
	        get
	        {
                if (ParentNodeId.Length > 0 && _lazyParent == null)
                    _lazyParent = GetParentNode();
	            return _lazyParent;
	        }
	    }

	    private AhsActiveRecord GetParentNode()
	    {
	        var results = new AhsActiveRecord
	                          {
	                              Instance = Instance,
	                              AccntHrcyStepId = ParentNodeId
	                          };
            return results.Execute() ? results : null;
	    }
	}
}
