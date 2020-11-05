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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Agent.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for the AGENT table.
	/// </summary>
	[ComVisible(false)]	
	public sealed class Agent :DbBaseClass
	{
		private enum EParmList 
		{
			AgentId = 0,
			FileTranLogId,
			BranchId,
			AgentBranchNum,
			AgentNumber,
			Status,
			TypeCd,
			Name,
			Address,
			City,
			State,
			Zip,
			Phone,
			Fax,
			FaxCd,
			Lat,
			Lon,
			EmailAddress,
			ContactType,
			NameFirst,
			NameMid,
			NameLast,
			PhoneExt,
			PrefInd,
			GatCode,
			UploadKey,
			IsUpdate
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="Agent"/> class.
		/// </summary>
		public Agent():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="Agent"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public Agent(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessAgent";

			_parameterNames = new[]
				{
					"p_nAgentID",
					"p_nFileTranLogId",
					"p_nBranchID",
					"p_nAgentBranchNum",
					"p_nAgentNumber",
					"p_nStatus",
					"p_nTypeCD",
					"p_nName",
					"p_nAddress",
					"p_nCity",
					"p_nState",
					"p_nZip",
					"p_nPhone",
					"p_nFAX",
					"p_nFAXCD",
					"p_nLAT",
					"p_nLON",
					"p_nEmailAddress",
					"p_nContactType",
					"p_nNameFirst",
					"p_nNameMid",
					"p_nNameLast",
					"p_nPhoneExt",
					"p_nPrefInd",
					"p_nGAT_CODE",
					"p_nUploadKey",
					"p_nIsUpdate"
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
			//// AgentId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
			        _parameterNames[(int)EParmList.AgentId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// FileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)EParmList.FileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// BranchId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.BranchId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// AgentBranchNum
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.AgentBranchNum],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// AgentNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.AgentNumber],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Status
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.Status],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// TypeCd
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.TypeCd],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Name
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.Name],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Address
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.Address],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// City
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.City],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// State
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.State],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Zip
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.Zip],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Phone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.Phone],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Fax
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.Fax],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// FaxCd
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.FaxCd],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Lat
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.Lat],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// Lon
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.Lon],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// EmailAddress
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.EmailAddress],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// ContactType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.ContactType],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// NameFirst
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.NameFirst],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// NameMid
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.NameMid],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// NameLast
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.NameLast],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// PhoneExt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.PhoneExt],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// PrefInd
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.PrefInd],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// GatCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.GatCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// UploadKey
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)EParmList.UploadKey],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// IsUpdate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)EParmList.IsUpdate],"",System.Data.DbType.Int32);
		}
		#endregion
		#region AgentId
		
		
		/// <summary>
		/// Gets the agent id.
		/// </summary>
		/// <value>The agent id.</value>
		public string AgentId
		{
			get 
			{
				return GetValue((int)EParmList.AgentId);
			}
		}
		#endregion
		#region IsUpdate
		/// <summary>
		/// Gets a value indicating whether this instance is update.
		/// </summary>
		/// <value><c>true</c> if this instance is update; otherwise, <c>false</c>.</value>
		public bool IsUpdate
		{
			get 
			{
				string result = GetValue((int) EParmList.IsUpdate);
				return result.Length > 0 && Convert.ToInt32(result) > 0;
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
				return GetValue((int)EParmList.FileTranLogId);
			}
			set 
			{
				SetValue((int)EParmList.FileTranLogId,value);
			}
		}
		#endregion
		#region BranchId
		/// <summary>
		/// Gets or sets the branch id.
		/// </summary>
		/// <value>The branch id.</value>
		public string BranchId
		{
			get 
			{
				return GetValue((int)EParmList.BranchId);
			}
			set 
			{
				SetValue((int)EParmList.BranchId,value);
			}
		}
		#endregion
		#region AgentBranchNum
		/// <summary>
		/// Gets or sets the agent branch num.
		/// </summary>
		/// <value>The agent branch num.</value>
		public string AgentBranchNum
		{
			get 
			{
				return GetValue((int)EParmList.AgentBranchNum);
			}
			set 
			{
				SetValue((int)EParmList.AgentBranchNum,value);
			}
		}
		#endregion
		#region AgentNumber
		/// <summary>
		/// Gets or sets the agent number.
		/// </summary>
		/// <value>The agent number.</value>
		public string AgentNumber
		{
			get 
			{
				return GetValue((int)EParmList.AgentNumber);
			}
			set 
			{
				SetValue((int)EParmList.AgentNumber,value);
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
				return GetValue((int)EParmList.Status);
			}
			set 
			{
				SetValue((int)EParmList.Status,value);
			}
		}
		#endregion
		#region TypeCd
		/// <summary>
		/// Gets or sets the type cd.
		/// </summary>
		/// <value>The type cd.</value>
		public string TypeCd
		{
			get 
			{
				return GetValue((int)EParmList.TypeCd);
			}
			set 
			{
				SetValue((int)EParmList.TypeCd,value);
			}
		}
		#endregion
		#region Name
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get 
			{
				return GetValue((int)EParmList.Name);
			}
			set 
			{
				SetValue((int)EParmList.Name,value);
			}
		}
		#endregion
		#region Address
		/// <summary>
		/// Gets or sets the address.
		/// </summary>
		/// <value>The address.</value>
		public string Address
		{
			get 
			{
				return GetValue((int)EParmList.Address);
			}
			set 
			{
				SetValue((int)EParmList.Address,value);
			}
		}
		#endregion
		#region City
		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City
		{
			get 
			{
				return GetValue((int)EParmList.City);
			}
			set 
			{
				SetValue((int)EParmList.City,value);
			}
		}
		#endregion
		#region State
		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		public string State
		{
			get 
			{
				return GetValue((int)EParmList.State);
			}
			set 
			{
				SetValue((int)EParmList.State,value);
			}
		}
		#endregion
		#region Zip
		/// <summary>
		/// Gets or sets the zip.
		/// </summary>
		/// <value>The zip.</value>
		public string Zip
		{
			get 
			{
				return GetValue((int)EParmList.Zip);
			}
			set 
			{
				SetValue((int)EParmList.Zip,value);
			}
		}
		#endregion
		#region Phone
		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		/// <value>The phone.</value>
		public string Phone
		{
			get 
			{
				return GetValue((int)EParmList.Phone);
			}
			set 
			{
				SetValue((int)EParmList.Phone,value);
			}
		}
		#endregion
		#region Fax
		/// <summary>
		/// Gets or sets the fax.
		/// </summary>
		/// <value>The fax.</value>
		public string Fax
		{
			get 
			{
				return GetValue((int)EParmList.Fax);
			}
			set 
			{
				SetValue((int)EParmList.Fax,value);
			}
		}
		#endregion
		#region FaxCd
		/// <summary>
		/// Gets or sets the fax cd.
		/// </summary>
		/// <value>The fax cd.</value>
		public string FaxCd
		{
			get 
			{
				return GetValue((int)EParmList.FaxCd);
			}
			set 
			{
				SetValue((int)EParmList.FaxCd,value);
			}
		}
		#endregion
		#region Latitude
		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		/// <value>The latitude.</value>
		public string Latitude
		{
			get 
			{
				return GetValue((int)EParmList.Lat);
			}
			set 
			{
				SetValue((int)EParmList.Lat,value);
			}
		}
		#endregion
		#region Longitude
		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		/// <value>The longitude.</value>
		public string Longitude
		{
			get 
			{
				return GetValue((int)EParmList.Lon);
			}
			set 
			{
				SetValue((int)EParmList.Lon,value);
			}
		}
		#endregion
		#region EmailAddress
		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		/// <value>The email address.</value>
		public string EmailAddress
		{
			get 
			{
				return GetValue((int)EParmList.EmailAddress);
			}
			set 
			{
				SetValue((int)EParmList.EmailAddress,value);
			}
		}
		#endregion
		#region ContactType
		/// <summary>
		/// Gets or sets the type of the contact.
		/// </summary>
		/// <value>The type of the contact.</value>
		public string ContactType
		{
			get 
			{
				return GetValue((int)EParmList.ContactType);
			}
			set 
			{
				SetValue((int)EParmList.ContactType,value);
			}
		}
		#endregion
		#region NameFirst
		/// <summary>
		/// Gets or sets the name first.
		/// </summary>
		/// <value>The name first.</value>
		public string NameFirst
		{
			get 
			{
				return GetValue((int)EParmList.NameFirst);
			}
			set 
			{
				SetValue((int)EParmList.NameFirst,value);
			}
		}
		#endregion
		#region NameMid
		/// <summary>
		/// Gets or sets the name mid.
		/// </summary>
		/// <value>The name mid.</value>
		public string NameMid
		{
			get 
			{
				return GetValue((int)EParmList.NameMid);
			}
			set 
			{
				SetValue((int)EParmList.NameMid,value);
			}
		}
		#endregion
		#region NameLast
		/// <summary>
		/// Gets or sets the name last.
		/// </summary>
		/// <value>The name last.</value>
		public string NameLast
		{
			get 
			{
				return GetValue((int)EParmList.NameLast);
			}
			set 
			{
				SetValue((int)EParmList.NameLast,value);
			}
		}
		#endregion
		#region PhoneExt
		/// <summary>
		/// Gets or sets the phone ext.
		/// </summary>
		/// <value>The phone ext.</value>
		public string PhoneExt
		{
			get 
			{
				return GetValue((int)EParmList.PhoneExt);
			}
			set 
			{
				SetValue((int)EParmList.PhoneExt,value);
			}
		}
		#endregion
		#region PrefInd
		/// <summary>
		/// Gets or sets the pref ind.
		/// </summary>
		/// <value>The pref ind.</value>
		public string PrefInd
		{
			get 
			{
				return GetValue((int)EParmList.PrefInd);
			}
			set 
			{
				SetValue((int)EParmList.PrefInd,value);
			}
		}
		#endregion
		#region GatCode
		/// <summary>
		/// Gets or sets the gat code.
		/// </summary>
		/// <value>The gat code.</value>
		public string GatCode
		{
			get 
			{
				return GetValue((int)EParmList.GatCode);
			}
			set 
			{
				SetValue((int)EParmList.GatCode,value);
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
				return GetValue((int)EParmList.UploadKey);
			}
			set 
			{
				SetValue((int)EParmList.UploadKey,value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Agent.cs $
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
 * 3     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/27/06 5:13p John.gwynn
 * CRUD for AGENT table
 */
#endregion
