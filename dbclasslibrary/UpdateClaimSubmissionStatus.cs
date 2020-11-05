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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateClaimSubmissionStatus.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion
using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Updates the CLAIM_SUBMISSION.STATUS with the supplied value
	/// </summary>
	[ComVisible(false)]	
	public class UpdateClaimSubmissionStatus :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateClaimSubmissionStatus"/> class.
		/// </summary>
		public UpdateClaimSubmissionStatus():this(String.Empty)
		{	}

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateClaimSubmissionStatus"/> class.
		/// </summary>
		/// <param name="instance">The database instance.</param>
		public UpdateClaimSubmissionStatus(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.UpdateClaimSubmissionStatus";

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
			///// claimSubId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"claimSubId","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// rquId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"rquId","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// claimStatus
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"claimStatus","",System.Data.DbType.AnsiString);
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
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateClaimSubmissionStatus.cs $
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
 * 4     11/15/06 5:33p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 3     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 2     4/18/06 5:43p John.gwynn
 * Claim submission unit testing
 * 
 * 1     4/17/06 6:27p John.gwynn
 * support for Selective ClaimSubmission tracking
 */ 
#endregion
