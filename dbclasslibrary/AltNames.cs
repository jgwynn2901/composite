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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AltNames.cs 6     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	
    /// <summary>
    /// AltName table
    /// </summary>
	[ComVisible(false)]
	public sealed class AlternateName : DbBaseClass
	{
		private enum eParmList 
		{
			AltNameId = 0,
			AHSID,
			FullName,
			FileTranLogId,
            SequenceNumber,
            UploadKey,
            PolicyId
			
			
		};
		#region Constructor
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AlternateName"/> class.
        /// </summary>
		public AlternateName():this(String.Empty) {}	
	
		/// <summary>
        /// Initializes a new instance of the <see cref="AlternateName"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public AlternateName(string instance) :base (instance)
		{
            _name = "DBClassLibrary.ProcessAlternateName";

			_parameterNames = new string[]
				{
					"p_nAlternateNameID",
					"p_nAHSID",
					"p_nName",
                    "p_nFileTranLogId",
                    "p_nSequenceNumber",
                    "p_nUploadKey",
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
			//// ContactId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
			        _parameterNames[(int)eParmList.AltNameId],"",System.Data.DbType.Int32);
			
			///////////////////////////////////////////////////
			//// AHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.AHSID],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// Name
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FullName],"",System.Data.DbType.AnsiString);

            ///////////////////////////////////////////////////
            ///// FileTranLogId
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                    _parameterNames[(int)eParmList.FileTranLogId], "", System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            ///// SequenceNumber
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                    _parameterNames[(int)eParmList.SequenceNumber], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// UploadKey
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                    _parameterNames[(int)eParmList.UploadKey], "", System.Data.DbType.AnsiString);

            ///////////////////////////////////////////////////
            ///// Policy ID
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                    _parameterNames[(int)eParmList.PolicyId], "", System.Data.DbType.Int32);
		
		
			
		}
		#endregion
		#region AltNameId


        /// <summary>
        /// Gets the alt name id.
        /// </summary>
        /// <value>The alt name id.</value>
        public string AltNameId
		{
			get 
			{
				return GetValue((int)eParmList.AltNameId);
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
		#region AHSID
		
		/// <summary>
		/// Gets the AHS id.
		/// </summary>
		/// <value>The AHS id.</value>
		public string AHSID
		{
		
			get
            {
                return GetValue((int)eParmList.AHSID); 
                
            }

			set
			{
			    SetValue((int)eParmList.AHSID,value);
			}
		}
		#endregion
		#region FullName
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string FullName
		{
			get 
			{
				return GetValue((int)eParmList.FullName);
			}
			set 
			{
				SetValue((int)eParmList.FullName,value);
			}
		}
		#endregion

        #region SequenceNumber

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        /// <value>The sequence number.</value>
        public string SequenceNumber
        {
            get
            {
                return GetValue((int)eParmList.SequenceNumber);
            }
            set
            {
                SetValue((int)eParmList.SequenceNumber, value);
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
                SetValue((int)eParmList.UploadKey, value);
            }
        }
        #endregion
        #region PolicyId


        /// <summary>
        /// Gets or sets the policy id.
        /// </summary>
        /// <value>The policy id.</value>
        public string PolicyId
        {

            get
            {
                return GetValue((int)eParmList.PolicyId);

            }

            set
            {
                SetValue((int)eParmList.PolicyId, value);
            }
        }
        #endregion

		
		
		
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AltNames.cs $
 * 
 * 6     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 5     6/30/08 6:23p Jenny.cheung
 * 
 * 4     5/13/08 11:55a Jenny.cheung
 * updated AltName class to call stored procedure from dbclasslibrary
 * package
 * 
 * 3     5/05/08 11:45a Jenny.cheung
 * 
 * 2     5/05/08 9:08a Jenny.cheung
 * Modified Alternate Name class
 * 
 * 1     5/01/08 11:31a Jenny.cheung
 * 
 * 1     3/05/08 12:08p Jenny.cheung
 * 
 * 3     5/08/07 4:41p John.gwynn
 * fixed parameter name to match database
 * 
 * 2     5/08/07 4:16p Jenny.cheung
 * Created for Esis Actec Load
 * 
 * 1     5/02/07 4:18p Jenny.cheung
 * Created ContactSegment for Esis Actec Load
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/27/06 5:13p John.gwynn
 * CRUD for CONTACT table
 */
#endregion
