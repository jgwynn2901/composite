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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ClaimSubmission.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for CLAIM_SUBMISSION table.
	/// </summary>
	[ComVisible(false)]	
	public sealed class ClaimSubmission :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimSubmission"/> class.
		/// </summary>
		public ClaimSubmission():this(String.Empty)
		{	}

		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimSubmission"/> class.
		/// </summary>
		/// <param name="instance">The database instance.</param>
		public ClaimSubmission(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.CreateClaimSubmission";

			Initialize();
		}
		#endregion
		#region Parameters
		/// <summary>
		/// Initializes this instance parameters.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			///// claimSubId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"claimSubId","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// callId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"callId","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// rquId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"rquId","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// policyNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"policyNumber","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// dateOfLoss
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"dateOfLoss","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// fileFormatCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"fileFormatCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// lossFileNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"lossFileNumber","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// claimNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"claimNumber","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// claimStatus
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"claimStatus","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// errorCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"errorCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// errorText
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"errorText","",System.Data.DbType.AnsiString);
		}
		#endregion
		#region ClaimSubmissionId
		/// <summary>
		/// Gets the claim submission id.
		/// </summary>
		/// <value>The claim submission id.</value>
		public string ClaimSubmissionId 
		{
			get 
			{
				return GetValue("claimSubId");
			}
		}
		#endregion
		#region CallId
		/// <summary>
		/// Gets or sets the call id.
		/// </summary>
		/// <value>The call id.</value>
		public string CallId 
		{
			get 
			{
				return GetValue("callId");
			}
			set 
			{
				SetValue("callId",value);
			}
		}
		#endregion
		#region RqId
		/// <summary>
		/// Gets or sets the rq id.
		/// </summary>
		/// <value>The rq id.</value>
		public string RqId 
		{
			get 
			{
				return GetValue("rquId");
			}
			set 
			{
				SetValue("rquId",value);
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
				return GetValue("policyNumber");
			}
			set 
			{
				SetValue("policyNumber",value);
			}
		}
		#endregion
		#region DateOfLoss
		/// <summary>
		/// Gets or sets the date of loss.
		/// </summary>
		/// <value>The date of loss.</value>
		public string DateOfLoss 
		{
			get 
			{
				return GetValue("dateOfLoss");
			}
			set 
			{
				SetValue("dateOfLoss",value);
			}
		}
		#endregion
		#region FileFormatCode
		/// <summary>
		/// Gets or sets the file format code.
		/// </summary>
		/// <value>The file format code.</value>
		public string FileFormatCode 
		{
			get 
			{
				return GetValue("fileFormatCode");
			}
			set 
			{
				SetValue("fileFormatCode",value);
			}
		}
		#endregion
		#region LossFileNumber
		/// <summary>
		/// Gets or sets the loss file number.
		/// </summary>
		/// <value>The loss file number.</value>
		public string LossFileNumber 
		{
			get 
			{
				return GetValue("lossFileNumber");
			}
			set 
			{
				SetValue("lossFileNumber",value);
			}
		}
		#endregion
		#region ClaimNumber
		/// <summary>
		/// Gets or sets the claim number.
		/// </summary>
		/// <value>The claim number.</value>
		public string ClaimNumber 
		{
			get 
			{
				return GetValue("claimNumber");
			}
			set 
			{
				SetValue("claimNumber",value);
			}
		}
		#endregion
		#region Status
		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		public string Status 
		{
			get 
			{
				return GetValue("claimStatus");
			}
			set 
			{
				SetValue("claimStatus",value);
			}
		}
		#endregion
		#region ErrorCode
		/// <summary>
		/// Gets or sets the error code.
		/// </summary>
		/// <value>The error code.</value>
		public string ErrorCode 
		{
			get 
			{
				return GetValue("errorCode");
			}
			set 
			{
				SetValue("errorCode",value);
			}
		}
		#endregion
		#region ErrorText
		/// <summary>
		/// Gets or sets the error text.
		/// </summary>
		/// <value>The error text.</value>
		public string ErrorText 
		{
			get 
			{
				return GetValue("errorText");
			}
			set 
			{
				SetValue("errorText",value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ClaimSubmission.cs $
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
 * 5     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 4     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 3     5/08/06 6:46p John.gwynn
 * Formatting updates and support for SENP and CRAWP utilities
 * 
 * 2     4/18/06 5:43p John.gwynn
 * Claim submission unit testing
 * 
 * 1     4/17/06 6:27p John.gwynn
 * support for Selective ClaimSubmission tracking
 */ 
#endregion
