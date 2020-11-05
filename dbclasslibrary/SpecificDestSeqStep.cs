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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SpecificDestSeqStep.cs 5     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD for SPECIFIC_DEST_SEQ_STEP table
	/// </summary>
	[ComVisible(false)]	
	public class SpecificDestSeqStep : DbBaseClass
	{
		private enum eParmList
		{
			SpecDestSeqStepId = 0,
			SpecDestId,
			Sequence,
			RetryCount,
			RetryWaitTime,
			DestinationString,
			TranTypeId,
			AltDestString,
			FileTranLogId
		};

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="SpecificDestSeqStep"/> class.
		/// </summary>
		public SpecificDestSeqStep() : this(String.Empty)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="SpecificDestSeqStep"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public SpecificDestSeqStep(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessSpecificDestSeqStep";

			_parameterNames = new string[] {
				"P_SPECDESTSEQSTEPID",
				"P_SPECDESTID",
				"P_SEQUENCE",
				"P_RETRYCOUNT",
				"P_RETRYWAITTIME",
				"P_DESTINATIONSTRING",
				"P_TRANTYPEID",
				"P_ALTDESTSTRING",
                "P_FILETRANLOGID"
				};

			Initialize();
		}
		#endregion
		#region AltDestString
		/// <summary>
		/// Gets or sets the altdeststring.
		/// </summary>
		/// <value>The altdeststring.</value>
		public string AltDestString
		{
			get{ return GetValue((int)eParmList.AltDestString); }
			set{ SetValue((int)eParmList.AltDestString,value); }
		}
		#endregion
		#region DestinationString
		/// <summary>
		/// Gets or sets the destination string.
		/// </summary>
		/// <value>The destination string.</value>
		public string DestinationString
		{
			get{ return GetValue((int)eParmList.DestinationString); }
			set{ SetValue((int)eParmList.DestinationString,value); }
		}
		#endregion
		#region RetryCount
		/// <summary>
		/// Gets or sets the retry count.
		/// </summary>
		/// <value>The retry count.</value>
		public string RetryCount
		{
			get{ return GetValue((int)eParmList.RetryCount); }
			set{ SetValue((int)eParmList.RetryCount,value); }
		}
		#endregion
		#region RetryWaitTime
		/// <summary>
		/// Gets or sets the retry wait time.
		/// </summary>
		/// <value>The retry wait time.</value>
		public string RetryWaitTime
		{
			get{ return GetValue((int)eParmList.RetryWaitTime); }
			set{ SetValue((int)eParmList.RetryWaitTime,value); }
		}
		#endregion
		#region Sequence
		/// <summary>
		/// Gets or sets the sequence.
		/// </summary>
		/// <value>The sequence.</value>
		public string Sequence
		{
			get{ return GetValue((int)eParmList.Sequence); }
			set{ SetValue((int)eParmList.Sequence,value); }
		}
		#endregion
		#region SpecDestId
		/// <summary>
		/// Gets or sets the spec dest id.
		/// </summary>
		/// <value>The spec dest id.</value>
		public string SpecDestId
		{
			get{ return GetValue((int)eParmList.SpecDestId); }
			set{ SetValue((int)eParmList.SpecDestId,value); }
		}
		#endregion
		#region SpecDestSeqStepId
		/// <summary>
		/// Gets or sets the spec dest seq step id.
		/// </summary>
		/// <value>The spec dest seq step id.</value>
		public string SpecDestSeqStepId
		{
			get{ return GetValue((int)eParmList.SpecDestSeqStepId); }
			set{ SetValue((int)eParmList.SpecDestSeqStepId,value); }
		}
		#endregion
		#region TranTypeId
		/// <summary>
		/// Gets or sets the tran type id.
		/// </summary>
		/// <value>The tran type id.</value>
		public string TranTypeId
		{
			get{ return GetValue((int)eParmList.TranTypeId); }
			set{ SetValue((int)eParmList.TranTypeId,value); }
		}
		#endregion
        #region FileTranLogId

        /// <summary>
        /// Gets or sets the file tran log id.
        /// </summary>
        /// <value>The file tran log id.</value>
        public string FileTranLogId
        {
            get { return GetValue((int)eParmList.FileTranLogId); }
            set { SetValue((int)eParmList.FileTranLogId, value); }
        }
        #endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Output,_parameterNames[(int)eParmList.SpecDestSeqStepId],"",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.SpecDestId],"",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Sequence],"",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.RetryCount],"",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.RetryWaitTime],"",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.DestinationString],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.TranTypeId],"",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.AltDestString],"",System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.FileTranLogId], "", System.Data.DbType.AnsiString);

		}
		#endregion

	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/SpecificDestSeqStep.cs $
 * 
 * 5     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 4     7/28/08 4:35p Jenny.cheung
 * added file_transmission_log_id due to Sedgwick SOW
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 1     3/13/07 6:29p John.gwynn
 * Specific destination plumbing for ESIS Contact file load
 */
#endregion

