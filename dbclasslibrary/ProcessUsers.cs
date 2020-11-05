#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2007 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ProcessUsers.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for ProcessUsers.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class ProcessUsers : DbBaseClass
	{
	
		private enum eParmList
		{
			
			UserId = 0,
			UserName,
			SiteId,
			Password,
			Active,
			LastName,
			FirstName,
			ActiveStartDate,
			ActiveEndDate,
			PasswordCreatedDate,
			PasswordEndDate,
			LastChangeDate,
			NewUser,
			InternetUser,
			FileTransLogId
			
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ProcessUsers"/> class.
		/// </summary>
		public ProcessUsers():this(String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="ProcessUsers"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public ProcessUsers(string instance) :base (instance)
		{
			_name = "ProcessUsers";
			
		
			_parameterNames = new string[]
				{
					"p_UserId",
					"p_UserName",
					"p_SiteId",
					"p_Password",
					"p_Active",
					"p_LastName",
					"p_FirstName",
					"p_ActiveStartDate",
					"p_ActiveEndDate",
					"p_PasswordCreatedDate",
					"p_PasswordExpirationDate",
					"p_LastChangeDate",
					"p_NewUser",
					"p_InternetUser",
					"p_FileTransLogId"
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
			///// p_UserId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.UserId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_UserName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.UserName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_SiteId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.SiteId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_Password
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.Password],"",System.Data.DbType.AnsiString);
		
			///////////////////////////////////////////////////
			///// p_Active
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.Active],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_LastName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.LastName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_FirstName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.FirstName],"",System.Data.DbType.AnsiString);
										
			///////////////////////////////////////////////////
			///// p_ActiveStartDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.ActiveStartDate],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_ActiveEndDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.ActiveEndDate],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_PasswordCreatedDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.PasswordCreatedDate],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_PasswordExpirationDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.PasswordEndDate],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_LastChangeDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.LastChangeDate],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_NewUser
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.NewUser],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_InternetUser
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.InternetUser],"",System.Data.DbType.AnsiString);
			
			///////////////////////////////////////////////////
			///// p_FileTransLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)eParmList.FileTransLogId],"",System.Data.DbType.Int32);
			


		}
		#endregion
		#region UserId
		/// <summary>
		/// Gets or sets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string UserId
		{
			get
			{
				return GetValue((int)eParmList.UserId);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.UserId], value);
			}
		}
		#endregion
		#region SiteId
		/// <summary>
		/// Gets or sets the site id.
		/// </summary>
		/// <value>The site id.</value>
		public string SiteId
		{
			get 
			{
				return GetValue((int)eParmList.SiteId);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.SiteId],value);
			}
		}
		#endregion
		#region Password
		/// <summary>
		/// Gets the Password.
		/// </summary>
		/// <value>The Password.</value>
		public string Password
		{
			get 
			{
				return GetValue((int)eParmList.Password);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.Password],value);
			}
		}
		#endregion
		#region Active
		/// <summary>
		/// Gets the Active flag.
		/// </summary>
		/// <value>The active flag.</value>
		public string Active
		{
			get 
			{
				return GetValue((int)eParmList.Active);
			}
			set
			{
			SetValue(_parameterNames[(int)eParmList.Active],value);
			}
		}
		#endregion
		#region UserName
		/// <summary>
		/// Gets the user name.
		/// </summary>
		/// <value>The user  name.</value>
		public string UserName
		{
			get 
			{
				return GetValue((int)eParmList.UserName);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.UserName],value);
			}
		}
		#endregion
		#region FirstName
		/// <summary>
		/// Gets or sets the name of the first.
		/// </summary>
		/// <value>The name of the first.</value>
		public string FirstName
		{
			get 
			{
				return GetValue((int)eParmList.FirstName);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.FirstName],value);
			}
		}
		#endregion
		#region LastName
		/// <summary>
		/// Gets or sets the name of the last.
		/// </summary>
		/// <value>The name of the last.</value>
		public string LastName
		{
			get 
			{
				return GetValue((int)eParmList.LastName);
			}
			set
			{
			SetValue(_parameterNames[(int)eParmList.LastName],value);
			}
		}
		#endregion
		#region ActiveStartDate
		/// <summary>
		/// Gets the active start date.
		/// </summary>
		/// <value>The active start date.</value>
		public string ActiveStartDate
		{
			get 
			{
				return GetValue((int)eParmList.ActiveStartDate);
			}
			set
			{
			SetValue(_parameterNames[(int)eParmList.ActiveStartDate],value);
			}
		}
		#endregion
		#region ActiveEndDate
		/// <summary>
		/// Gets the Active End date.
		/// </summary>
		/// <value>The Active End Date.</value>
		public string ActiveEndDate
		{
			get 
			{
				return GetValue((int)eParmList.ActiveEndDate);
			}
			set
			{
			SetValue(_parameterNames[(int)eParmList.ActiveEndDate],value);
			}
		}
		#endregion
		#region NewUser
		/// <summary>
		/// Gets the New User.
		/// </summary>
		/// <value>The New User.</value>
		public string NewUser
		{
			get 
			{
				return GetValue((int)eParmList.NewUser);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.NewUser],value);
			}
		}
		#endregion
		#region InternetUser
		/// <summary>
		/// Gets the InternetUser.
		/// </summary>
		/// <value>The InternetUser.</value>
		public string InternetUser
		{
			get 
			{
				return GetValue((int)eParmList.InternetUser);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.InternetUser],value);
			}
		}
		#endregion
		#region PasswordCreatedDate
		/// <summary>
		/// Gets the PasswordCreatedDate.
		/// </summary>
		/// <value>The PasswordCreatedDate .</value>
		public string PasswordCreatedDate
		{
			get 
			{
				return GetValue((int)eParmList.PasswordCreatedDate);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.PasswordCreatedDate],value);
			}
		}
		#endregion
		#region PasswordEndDate
		/// <summary>
		/// Gets the Password Expiration Date.
		/// </summary>
		/// <value>The password expiration date.</value>
		public string PasswordEndDate
		{
			get 
			{
				return GetValue((int)eParmList.PasswordEndDate);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.PasswordEndDate],value);
			}
		}
		#endregion
		#region LastChangeDate
		/// <summary>
		/// Gets the Last Change Date.
		/// </summary>
		/// <value>The last change date.</value>
		public string LastChangeDate
		{
			get 
			{
				return GetValue((int)eParmList.LastChangeDate);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.LastChangeDate],value);
			}
		}
		#endregion
		#region FileTransLogId
		/// <summary>
		/// Gets the File Transmission Log Id.
		/// </summary>
		/// <value>The File Transmission Log Id.</value>
		public string FileTransLogId
		{
			get 
			{
				return GetValue((int)eParmList.FileTransLogId);
			}
			set
			{
				SetValue(_parameterNames[(int)eParmList.FileTransLogId],value);
			}
		}
		#endregion
		
	}
}
#region Log


#endregion