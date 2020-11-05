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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/LocationUser.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for LocationUser.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class LocationUser : DbBaseClass
	{
		private enum eParmList 
		{
			eLocationUserId = 0,
			eAhsId,
			eUserId,
			eLocationAHSId,
			eClientCode,
			eLOBCode,
			eGreeting,
			eLocName,
			ePhone,
			eFileTransmissionLogId
			
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationUser"/> class.
		/// </summary>
		public LocationUser():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationUser"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public LocationUser(string instance) :base(instance)
		{
			_name = "DBClassLibrary.ProcessLocationsUser";

			_parameterNames = new string[] 
											{
												"p_nLocationUserID",
												"p_nAHSID",
												"p_nUserID",
												"p_nLocationAHSID",
												"p_nClientCd",
												"p_nLOBCD",
												"p_nGreeting",
												"p_nLocName",
												"p_nPhone",
												"p_nFileTransLogId"
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
			/////p_nLocationUserID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.eLocationUserId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_nAHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eAhsId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nUserId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eUserId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nLocationAHSId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eLocationAHSId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nClientCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eClientCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nLocationCd
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eLOBCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nGreeting
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eGreeting],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nLocName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eLocName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nPhone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.ePhone],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nFileTransLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eFileTransmissionLogId],"",System.Data.DbType.Int32);
		}
	
		#endregion
	
		#region Public Properties
		
	/// <summary>
	/// Gets the cra ncci class code id.
	/// </summary>
	/// <value>The cra ncci class code id.</value>
	public int eLocationUserId 
{
	get 
{
	string result = GetValue((int) eParmList.eLocationUserId);
	return result.Length > 0 ? Convert.ToInt32(result): -1;
}
}
	/// <summary>
	/// Gets or sets the ahs id.
	/// </summary>
	/// <value>The ahs id.</value>
	public string AhsId
{
	get 
{
	return GetValue((int)eParmList.eAhsId);
}
	set 
{
	SetValue((int)eParmList.eAhsId,value);
}
}
	/// <summary>
	/// Gets or sets the lob code.
	/// </summary>
	/// <value>The lob code.</value>
	public string LobCode
{
	get 
{
	return GetValue((int)eParmList.eLOBCode);
}
	set 
{
	SetValue((int)eParmList.eLOBCode,value);
}
}
	/// <summary>
	/// Gets or sets the Client Code.
	/// </summary>
	/// <value>The Client code.</value>
	public string ClientCd
{
	get 
{
	return GetValue((int)eParmList.eClientCode);
}
	set 
{
	SetValue((int)eParmList.eClientCode,value);
}
}
	/// <summary>
	/// Gets or sets the Location AHS ID.
	/// </summary>
	/// <value>The Location AHS ID.</value>
	public string LocationAHSID
{
	get 
{
	return GetValue((int)eParmList.eLocationAHSId);
}
	set 
{
	SetValue((int)eParmList.eLocationAHSId,value);
}
}
	/// <summary>
	/// Gets or sets the Greeting.
	/// </summary>
	/// <value>The Greeting.</value>
	public string Greeting
{
	get 
{
	return GetValue((int)eParmList.eGreeting);
}
	set 
{
	SetValue((int)eParmList.eGreeting,value);
}
}
	/// <summary>
	/// Gets or sets the Loc Name.
	/// </summary>
	/// <value>The Location  name.</value>
	public string LocName
{
	get 
{
	return GetValue((int)eParmList.eLocName);
}
	set 
{
	SetValue((int)eParmList.eLocName,value);
}
}
		/// <summary>
		/// Gets or sets the Locaction AHSID.
		/// </summary>
		/// <value>The Location AHSID.</value>
		public string UserID
		{
			get 
			{
				return GetValue((int)eParmList.eUserId);
			}
			set 
			{
				SetValue((int)eParmList.eUserId,value);
			}
		}
		/// <summary>
		/// Gets or sets the Phone.
		/// </summary>
		/// <value>The Phone.</value>
		public string Phone
		{
			get 
			{
				return GetValue((int)eParmList.ePhone);
			}
			set 
			{
				SetValue((int)eParmList.ePhone,value);
			}
		}

		/// <summary>
		/// Gets or sets the FileTransmissionId.
		/// </summary>
		/// <value>The FileTransmissionId.</value>
		public string FileTransmissionId
		{
			get 
			{
				return GetValue((int)eParmList.eFileTransmissionLogId);
			}
			set 
			{
				SetValue((int)eParmList.eFileTransmissionLogId,value);
			}
		}
	#endregion

}
	}
#region Log

#endregion