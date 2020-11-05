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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateANILocationCode.cs 3     5/26/09 11:05a John.gwynn $ */
#endregion
using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// remove any and all Location_Code records of a given account number in the current Alaska National Location  data file 
	///The latest location code data provided in the current location data file for a given account number will be replacing the existing location codes for the same account number.
	/// </summary>
	[ComVisible(false)]	
	public class UpdateANILocationCode :DbBaseClass
	{
		private enum eParmList 
		{
			
            /// <summary>
            /// AccountNumber
            /// </summary>
			AccountNumber = 0,
            /// <summary>
            /// File Tran Log Id
            /// </summary>
            FileTranLogId,
            /// <summary>
			/// Number of Location Code records affected (OUT)
			/// </summary>
			RecordCount,
            /// <summary>
            /// Upload key
            /// </summary>
            UploadKey
		};
		#region Constructor
		/// <summary>
        /// Initializes a new instance of the <see cref="UpdateANILocationCode"/> class.
		/// </summary>
		public UpdateANILocationCode() :this(String.Empty) {}	
		/// <summary>
        /// Initializes a new instance of the <see cref="UpdateANILocationCode"/> class.
		/// </summary>
		/// <param name="instance"></param>
        public UpdateANILocationCode(string instance)
            : base(instance)
		{
			_name = "DBClassLibrary.UpdateANILocationCode";

			_parameterNames = new string[]
			{
				"p_AccountNumber",
                "p_FileTranLogId",
                "p_recordCount",
                "p_UploadKey"
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
			//// AccountNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.AccountNumber],"",System.Data.DbType.AnsiString);

            ///////////////////////////////////////////////////
            //// FileTranLogId
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.FileTranLogId], "", System.Data.DbType.Int32);
           
			///////////////////////////////////////////////////
			///// RecordCount
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.RecordCount],"",System.Data.DbType.Int32);

            ///////////////////////////////////////////////////
            /////UploadKey
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Output,
                _parameterNames[(int)eParmList.UploadKey], "", System.Data.DbType.AnsiString);
		}	
		#endregion
        #region AccountNumber

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>The account number.</value>
        public string AccountNumber
		{
			get 
			{
				return GetValue((int)eParmList.AccountNumber);
			}
			set 
			{
				SetValue((int)eParmList.AccountNumber,value);
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
                SetValue((int)eParmList.FileTranLogId, value);
            }
        }
        #endregion

    
		#region RecordCount
		/// <summary>
		/// Gets the record count.
		/// </summary>
		/// <value>The record count.</value>
		public string RecordCount
		{
			get 
			{
				return GetValue((int)eParmList.RecordCount);
			}
		}
		#endregion

      #region UploadKey
        /// <summary>
        /// Gets the uploadkey.
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
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateANILocationCode.cs $
 * 
 * 3     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 2     7/09/08 10:01a Jenny.cheung
 * 
 * 1     6/26/08 10:19a Jenny.cheung
 * Added for Alaska National to update Location/Policy/AlternateName
 * records
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 1     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 */
#endregion

