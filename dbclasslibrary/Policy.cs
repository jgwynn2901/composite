#region Header
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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Policy.cs 5     5/26/09 11:05a John.gwynn $ */
#endregion
using System;
using System.Runtime.InteropServices;
using FnsComposite.Interfaces;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for POLICY table.
	/// </summary>
	[ComVisible(false)]	
	public class Policy :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// default constructor uses the registry db instance
		/// </summary>
		public Policy() :this (String.Empty)
		{
		}
		/// <summary>
		/// user can name db instance
		/// </summary>
		/// <param name="instance"></param>
		public Policy (string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessPolicy";
			Initialize();
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="Policy"/> class.
        /// </summary>
        /// <param name="rec">The rec.</param>
        public Policy(IPolicy rec)
            : this()
        {
            AHSID = rec.AhsId;
            LOB_CD = rec.LineOfBusiness;
            CarrierID = rec.CarrierId;
            AgentID = rec.AgentId;
            CompanyCode = rec.CompanyCode;
            PolicyNumber = rec.PolicyNumber;
            EffectiveDate = rec.EffectiveDate;
            ExpirationDate = rec.ExpirationDate;
            Description = rec.Description;
            PolCovCodes = rec.CoverageCodes;
            PolicyType = rec.PolicyType;
            DivisionCode = rec.DivisionCode;
            FileTranLogId = rec.FileTranLogId;
            UploadKey = rec.UploadKey;
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
			/////p_nPolicyID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
							"p_nPolicyID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nFileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
							"p_nFileTranLogId","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nAHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAHSID","1",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nCarrierID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					"p_nCarrierID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nAgentID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nAgentID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nLOB_CD
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nLOB_CD","TST",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nCompanyCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nCompanyCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nPolicyNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nPolicyNumber","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nEffectiveDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nEffectiveDate","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nExpirationDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nExpirationDate","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nOriginalEffective
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nOriginalEffective","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nDescription
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nDescription","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nCancelDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nCancelDate","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nSelfInsured
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nSelfInsured","N",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nManagedCareType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nManagedCareType","NEITHER",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAdditionalDelivery
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nAdditionalDelivery","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nDivisionCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nDivisionCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nUploadKey
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nUploadKey","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nPolCovCodes
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nPolCovCodes","",System.Data.DbType.AnsiString);
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
			///////////////////////////////////////////////////
			///// p_nPolicyType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
						"p_nPolicyType","",System.Data.DbType.AnsiString);
		}
		#endregion
		#region PolicyID
		/// <summary>
		/// Gets the policy ID.
		/// </summary>
		/// <value>The policy ID.</value>
		public string PolicyID 
		{
			get 
			{
				return GetValue("p_nPolicyID");
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
				return GetValue("p_nFileTranLogId");
			}
			set 
			{
				SetValue("p_nFileTranLogId",value);
			}
		}
		#endregion
		#region AHSID
		/// <summary>
		/// Gets or sets the AHSID.
		/// </summary>
		/// <value>The AHSID.</value>
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
		#region CarrierID
		/// <summary>
		/// Gets or sets the carrier ID.
		/// </summary>
		/// <value>The carrier ID.</value>
		public string CarrierID 
		{
			get 
			{
				return GetValue("p_nCarrierID");
			}
			set 
			{
				SetValue("p_nCarrierID",value);
			}
		}
		#endregion
		#region AgentID
		/// <summary>
		/// Gets or sets the agent ID.
		/// </summary>
		/// <value>The agent ID.</value>
		public string AgentID 
		{
			get 
			{
				return GetValue("p_nAgentID");
			}
			set 
			{
				SetValue("p_nAgentID",value);
			}
		}
		#endregion
		#region LOB_CD
		/// <summary>
		/// Gets or sets the LOB_CD.
		/// </summary>
		/// <value>The LOB_CD.</value>
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
		#region CompanyCode
		/// <summary>
		/// Gets or sets the company code.
		/// </summary>
		/// <value>The company code.</value>
		public string CompanyCode 
		{
			get 
			{
				return GetValue("p_nCompanyCode");
			}
			set 
			{
				SetValue("p_nCompanyCode",value);
			}
		}
		#endregion
		#region PolicyNumber
		/// <summary>
		/// Gets or sets the policy number.
		/// </summary>
		/// <value>The policy number.</value>
		public string PolicyNumber 
		{
			get 
			{
				return GetValue("p_nPolicyNumber");
			}
			set 
			{
				SetValue("p_nPolicyNumber",value);
			}
		}
		#endregion
		#region EffectiveDate
		/// <summary>
		/// Gets or sets the effective date.
		/// </summary>
		/// <value>The effective date.</value>
		public string EffectiveDate 
		{
			get 
			{
				return GetValue("p_nEffectiveDate");
			}
			set 
			{
				SetValue("p_nEffectiveDate",value);
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
				return GetValue("p_nExpirationDate");
			}
			set 
			{
				SetValue("p_nExpirationDate",value);
			}
		}
		#endregion
		#region OriginalEffective
		/// <summary>
		/// Gets or sets the original effective date.
		/// </summary>
		/// <value>The original effective date.</value>
		public string OriginalEffective 
		{
			get 
			{
				return GetValue("p_nOriginalEffective");
			}
			set 
			{
				SetValue("p_nOriginalEffective",value);
			}
		}
		#endregion
		#region Description
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description 
		{
			get 
			{
				return GetValue("p_nDescription");
			}
			set 
			{
				SetValue("p_nDescription",value);
			}
		}
		#endregion
		#region CancelDate
		/// <summary>
		/// Gets or sets the cancel date.
		/// </summary>
		/// <value>The cancel date.</value>
		public string CancelDate 
		{
			get 
			{
				return GetValue("p_nCancelDate");
			}
			set 
			{
				SetValue("p_nCancelDate",value);
			}
		}
		#endregion
		#region SelfInsured
		/// <summary>
		/// Gets or sets the self insured.
		/// </summary>
		/// <value>The self insured.</value>
		public string SelfInsured 
		{
			get 
			{
				return GetValue("p_nSelfInsured");
			}
			set 
			{
				SetValue("p_nSelfInsured",value);
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
				return GetValue("p_nManagedCareType");
			}
			set 
			{
				SetValue("p_nManagedCareType",value);
			}
		}
		#endregion
		#region AdditionalDelivery
		/// <summary>
		/// Gets or sets the additional delivery.
		/// </summary>
		/// <value>The additional delivery.</value>
		public string AdditionalDelivery 
		{
			get 
			{
				return GetValue("p_nAdditionalDelivery");
			}
			set 
			{
				SetValue("p_nAdditionalDelivery",value);
			}
		}
		#endregion
		#region DivisionCode
		/// <summary>
		/// Gets or sets the division code.
		/// </summary>
		/// <value>The division code.</value>
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
		#region UploadKey
		/// <summary>
		/// Gets or sets the upload key.
		/// </summary>
		/// <value>The upload key.</value>
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
		#region PolCovCodes
		/// <summary>
		/// Gets or sets the policy coverage codes.
		/// </summary>
		/// <value>The policy coverage codes.</value>
		public string PolCovCodes 
		{
			get 
			{
				return GetValue("p_nPolCovCodes");
			}
			set 
			{
				SetValue("p_nPolCovCodes",value);
			}
		}
		#endregion
		#region ActiveStartDt
		/// <summary>
		/// Gets or sets the active start date.
		/// </summary>
		/// <value>The active start date.</value>
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
		/// Gets or sets the active end date.
		/// </summary>
		/// <value>The active end date.</value>
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
		#region PolicyType
		/// <summary>
		/// Gets or sets the type of the policy.
		/// </summary>
		/// <value>The type of the policy.</value>
		public string PolicyType 
		{
			get 
			{
				return GetValue("p_nPolicyType");
			}
			set 
			{
				SetValue("p_nPolicyType",value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Policy.cs $
 * 
 * 5     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 4     4/24/08 5:05p Jenny.cheung
 * incorporated the IPolicy to Policy.cs
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 6     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
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
#endregion