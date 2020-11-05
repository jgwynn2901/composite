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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateCsaaVendorNetwork.cs 5     7/25/12 3:17p Pintoa $ */
#endregion
using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// remove any and all VENDOR records from CSAA load that were NOT
	/// touched by the most recent load (fileTranLogId)
	/// Kemper requires each load to be full refresh. 
	/// </summary>
	[ComVisible(false)]	
	public class UpdateCsaaVendorNetwork :DbBaseClass
	{
		private enum eParmList 
		{
			/// <summary>
			/// FileTranLogId of the current LOAD (IN)
			/// </summary>
			FileTranLogId = 0,
			/// <summary>
			/// Number of VENDOR records affected (OUT)
			/// </summary>
			RecordCount
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateCsaaVendorNetwork"/> class.
		/// </summary>
		public UpdateCsaaVendorNetwork() :this(String.Empty) {}	
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateCsaaVendorNetwork"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public UpdateCsaaVendorNetwork(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.UpdateCsaaVendorNetwork";

			_parameterNames = new string[]
			{
				"p_fileTranLogId",
				"p_recordCount"
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
			//// FileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// RecordCount
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.RecordCount],"",System.Data.DbType.Int32);
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
	}

    /// <summary>
    /// 
    /// </summary>
    [ComVisible(false)]
    public class UpdateAaaVendorNetwork : DbBaseClass
    {
        private enum eParmList
        {
            /// <summary>
            /// FileTranLogId of the current LOAD (IN)
            /// </summary>
            FileTranLogId = 0,
            /// <summary>
            /// Number of VENDOR records affected (OUT)
            /// </summary>
            RecordCount
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAaaVendorNetwork"/> class.
        /// </summary>
        public UpdateAaaVendorNetwork() : this(String.Empty) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAaaVendorNetwork"/> class.
        /// </summary>
        /// <param name="instance"></param>
        public UpdateAaaVendorNetwork(string instance)
            : base(instance)
        {
            _name = "DBCLASSLIBRARY.UpdateAaaVendorNetwork";

            _parameterNames = new[]
			{
				"p_fileTranLogId",
				"p_recordCount"
			};

            Initialize();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        protected override sealed void Initialize()
        {
            ///////////////////////////////////////////////////
            //// FileTranLogId
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.FileTranLogId], string.Empty, System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            ///// RecordCount
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Output, _parameterNames[(int)eParmList.RecordCount], string.Empty, System.Data.DbType.Int32);
        }

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
    }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateCsaaVendorNetwork.cs $
 * 
 * 5     7/25/12 3:17p Pintoa
 * New sp to update AAA vendor network.
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
 * 1     12/01/06 11:19a John.gwynn
 * Added UpdateCsaaVendorNetwork
 */
#endregion

