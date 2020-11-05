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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/ChangeTransOutcomeStepStatus.cs 2     5/26/09 11:07a John.gwynn $ */
#endregion
using System;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// wraps prcedure to update TRANSMISSION_OUTCOME state change
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class ChangeTransOutcomeStepStatus : DbBaseClass
	{
		private enum eParmList
		{
			TransmissionStepId = 0,
			OldStatus,
			NewStatus,
			Server,
			Result
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ChangeTransOutcomeStepStatus"/> class.
		/// </summary>
		public ChangeTransOutcomeStepStatus()
			: this(String.Empty)
		{ }
		/// <summary>
		/// Initializes a new instance of the <see cref="ChangeTransOutcomeStepStatus"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public ChangeTransOutcomeStepStatus(string instance)
			: base(instance)
		{
			_name = "OUTPUTFUNCTIONS.ChangeTransOutStepStatusOCI";

			_parameterNames = new string[] {
					"INTRANSMISSION_STEP_ID",
					"INOLDSTATUS",
					"INNEWSTATUS",
					"INSERVERNAME",
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
			get { return GetValue((int)eParmList.NewStatus); }
			set { SetValue((int)eParmList.NewStatus, value); }
		}
		#endregion
		#region OldStatus
		/// <summary>
		/// Gets or sets the old status.
		/// </summary>
		/// <value>The old status.</value>
		public string OldStatus
		{
			get { return GetValue((int)eParmList.OldStatus); }
			set { SetValue((int)eParmList.OldStatus, value); }
		}
		#endregion
		#region Server
		/// <summary>
		/// Gets or sets the server.
		/// </summary>
		/// <value>The server.</value>
		public string Server
		{
			get { return GetValue((int)eParmList.Server); }
			set { SetValue((int)eParmList.Server, value); }			
		}
		#endregion
		#region TransmissionStepId
		/// <summary>
		/// Gets or sets the intransmission_ id.
		/// </summary>
		/// <value>The intransmission_ id.</value>
		public string TransmissionStepId
		{
			get { return GetValue((int)eParmList.TransmissionStepId); }
			set { SetValue((int)eParmList.TransmissionStepId, value); }
		}
		#endregion
		#region Result
		/// <summary>
		/// Gets or sets the result.
		/// </summary>
		/// <value>The result.</value>
		public string Result
		{
			get { return GetValue((int)eParmList.Result); }
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.TransmissionStepId], "", System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.NewStatus], "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.OldStatus], "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Server], "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Output, _parameterNames[(int)eParmList.Result], "", System.Data.DbType.Int32);
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/ChangeTransOutcomeStepStatus.cs $
 * 
 * 2     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 1     6/26/07 2:43p John.gwynn
 */
#endregion

