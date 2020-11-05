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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/ChangeTransOutcomeStatus.cs 3     2/23/10 2:53p Gwynnj $ */
#endregion

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// wraps prcedure to update TRANSMISSION_OUTCOME state change
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class ChangeTransOutcomeStatus : DbBaseClass
	{
		private enum ParmList
		{
			TransmissionId = 0,
			OldStatus,
			NewStatus,
			Result
		};

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ChangeTransOutcomeStatus"/> class.
		/// </summary>
        public ChangeTransOutcomeStatus()
            : this(ApplicationConfiguration.Instance.DefaultInstance)
		{ }
		/// <summary>
		/// Initializes a new instance of the <see cref="ChangeTransOutcomeStatus"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public ChangeTransOutcomeStatus(string instance) :base(instance)
		{
			_name = "OUTPUTFUNCTIONS.ChangeTransOutcomeStatusOCI";

			_parameterNames = new[] {
					"INTRANSMISSION_ID",
					"INOLDSTATUS",
					"INNEWSTATUS",
					"OUTRESULT" 
				};

			Initialize();
		}
		#endregion
		#region NewStatus
		/// <summary>
		/// Gets or sets the innewstatus.
		/// </summary>
		/// <value>The innewstatus.</value>
		public string NewStatus
		{
			get{ return GetValue((int)ParmList.NewStatus); }
			set{ SetValue((int)ParmList.NewStatus,value); }
		}
		#endregion
		#region OldStatus
		/// <summary>
		/// Gets or sets the old status.
		/// </summary>
		/// <value>The old status.</value>
		public string OldStatus
		{
			get{ return GetValue((int)ParmList.OldStatus); }
			set{ SetValue((int)ParmList.OldStatus,value); }
		}
		#endregion
		#region TransmissionId
		/// <summary>
		/// Gets or sets the intransmission_ id.
		/// </summary>
		/// <value>The intransmission_ id.</value>
		public string TransmissionId
		{
			get{ return GetValue((int)ParmList.TransmissionId); }
			set{ SetValue((int)ParmList.TransmissionId,value); }
		}
		#endregion
		#region Result
		/// <summary>
		/// Gets or sets the result.
		/// </summary>
		/// <value>The result.</value>
		public string Result
		{
			get{ return GetValue((int)ParmList.Result); }
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override sealed void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)ParmList.TransmissionId], "", System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)ParmList.NewStatus], "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)ParmList.OldStatus],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Output, _parameterNames[(int)ParmList.Result], "", System.Data.DbType.Int32);
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/ChangeTransOutcomeStatus.cs $
 * 
 * 3     2/23/10 2:53p Gwynnj
 * Added CallRouting support
 * 
 * 2     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 1     6/26/07 2:43p John.gwynn
 */
#endregion

