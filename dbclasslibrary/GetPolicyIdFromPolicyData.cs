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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/GetPolicyIdFromPolicyData.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates getuserid stored proc using user table.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class GetPolicyIDFromPolicyData : DbBaseClass
	{
		private enum eParmList 
		{
		
            Uploadkey =0,
			PolicyId
			
		};
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="GetuserIDfromUserName"/> class.
		/// </summary>
		public GetPolicyIDFromPolicyData():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="GetuserIDfromUserName"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public GetPolicyIDFromPolicyData(string instance) :base(instance)
		{
            _name = "DBClassLibrary.GetPolicyIdFromUploadKey";

			_parameterNames = new string[]
				{
					
					"P_nUploadkey",
                    "p_nPolicyId"
						
					
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
            //// Uploadkey
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.Uploadkey], "", System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// ahs Id
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.PolicyId],"",System.Data.DbType.Int32);
		}	
		#endregion
		#region Public Properties

        

        /// <summary>
        /// Gets or sets the uploadkey.
        /// </summary>
        /// <value>The uploadkey.</value>
        public string Uploadkey
        {
            get
            {
                return GetValue((int)eParmList.Uploadkey);
            }
            set
            {
                SetValue((int)eParmList.Uploadkey, value);
            }
        }


		/// <summary>
		/// Gets the ahs ID.
		/// </summary>
		/// <value>The ahs Id.</value>
		public string PolicyId
		{
			get 
			{
				return GetValue((int)eParmList.PolicyId);
			}
		}
		#endregion
		
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/GetPolicyIdFromPolicyData.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     6/30/08 6:22p Jenny.cheung
 * 
 * 3     6/13/08 4:28p Jenny.cheung
 * corrected stored procedure name
 * 
 * 2     5/05/08 9:06a Jenny.cheung
 * modified stored procedure for Alaska National
 * 
 * 1     5/01/08 11:31a Jenny.cheung
 * 
 * 1     11/07/07 9:16a Jenny.cheung
 * 
 * 4     5/21/07 4:38p Jenny.cheung
 * Updated stored procedure in dbclasslibrary
 * 
 * 3     5/18/07 2:23p Jenny.cheung
 * Incorporated stored procedure into dbclass library
 * 
 * 2     5/18/07 1:17p Jenny.cheung
 * corrected data type for ahsid
 * 
 * 1     5/16/07 11:14a Jenny.cheung
 * corrected file name
 * 
 * 4     5/16/07 11:12a John.gwynn
 * 
 * 3     5/16/07 11:02a John.gwynn
 * corrected Stored Procedure Name
 * 
 * 2     5/16/07 10:26a Jenny.cheung
 * updated field names
 * 
 * 1     5/14/07 4:39p Jenny.cheung
 * created for crawford cedar hill user setup enhancement
 * 
 * 3     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/17/06 11:40a John.gwynn
 * first of what may be multiple location### classes to provide
 * LOCATION_CODE functionality, in this case: GetCityFromZip
 */
#endregion
