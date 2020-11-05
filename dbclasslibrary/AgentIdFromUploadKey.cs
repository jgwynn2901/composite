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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AgentIdFromUploadKey.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates AgentFromUploadKey method
	/// </summary>
	[ComVisible(false)]
	public class AgentIdFromUploadKey : DbBaseClass
	{
		private enum eParmList
		{
			UploadKey = 0,
			Results,
			
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentIdFromUploadKey"/> class.
		/// </summary>
		public AgentIdFromUploadKey() : this(String.Empty)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentIdFromUploadKey"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public AgentIdFromUploadKey(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetAgentIdFromUploadKey";

			_parameterNames = new string[] {
			"P_NUPLOADKEY",
			"P_NRESUTS"
			};

			Initialize();
		}
		#endregion
		#region AgentId
		/// <summary>
		/// Gets or sets the agent id.
		/// </summary>
		/// <value>The agent id.</value>
		public string AgentId
		{
			get{ return GetValue((int)eParmList.Results); }
			set{ SetValue((int)eParmList.Results,value); }
		}
		#endregion
		#region UploadKey
		/// <summary>
		/// Gets or sets the upload key.
		/// </summary>
		/// <value>The upload key.</value>
		public string UploadKey
		{
			get{ return GetValue((int)eParmList.UploadKey); }
			set{ SetValue((int)eParmList.UploadKey,value); }
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.UploadKey],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Output,_parameterNames[(int)eParmList.Results],"",System.Data.DbType.Int32);
		}
		#endregion
	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AgentIdFromUploadKey.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     11/07/07 9:16a Jenny.cheung
 * 
 * 1     7/05/07 4:14p John.gwynn
 * support for Safety Policy Load - added AgentIdFromUploadKey 
 */
#endregion
