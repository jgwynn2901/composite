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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/GetUserId.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates getuserid stored proc using user table.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class GetuserIDfromUserName : DbBaseClass
	{
		private enum eParmList 
		{
			username = 0,
			userid
				
		};
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="GetuserIDfromUserName"/> class.
		/// </summary>
		public GetuserIDfromUserName():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="GetuserIDfromUserName"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public GetuserIDfromUserName(string instance) :base(instance)
		{
			_name = "DBClassLibrary.GetuserIDfromusername";

			_parameterNames = new string[]
				{
					"p_username",
					"p_userid"
								
					
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
			
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.username],"",System.Data.DbType.AnsiString);
		
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.userid],"",System.Data.DbType.Int32);

					
		}	
		#endregion
		#region Public Properties
		
		/// <summary>
		/// Gets or sets the User Name.
		/// </summary>
		/// <value>The User Name.</value>
		public string UserName
		{
			get 
			{
				return GetValue((int)eParmList.username);
			}
			set 
			{
				SetValue((int)eParmList.username,value);
			}
		}

		/// <summary>
		/// Gets or sets the User Name.
		/// </summary>
		/// <value>The User Name.</value>
		public string UserId
		{
			get 
			{
				return GetValue((int)eParmList.userid);
			}
			set 
			{
				SetValue((int)eParmList.userid,value);
			}
		}

		#endregion
		/// <summary>
		/// Gets the User ID.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="username">The User name.</param>
		/// <returns></returns>
		public static string GetUserID (string instance, string username)
		{
			string results = String.Empty;
			try
			{
				GetuserIDfromUserName users = new GetuserIDfromUserName(instance);
				users.UserName = username;
				if(users.Execute())
				{
					results = users.UserId;
				}
			}
			catch(Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message,"GetUserID");
			}
			return results;
		}

		

	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/GetUserId.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     11/07/07 9:16a Jenny.cheung
 * 
 * 5     6/19/07 10:05a Jenny.cheung
 * 
 * 4     5/21/07 4:38p Jenny.cheung
 * Updated stored procedure in dbclasslibrary
 * 
 * 3     5/18/07 2:23p Jenny.cheung
 * Incorporated stored procedure into dbclass library
 * 
 * 2     5/16/07 11:55a Jenny.cheung
 * 
 * 1     5/14/07 4:39p Jenny.cheung
 * created for crawford cedar hill user setup enhancement
 * 
 * 3     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/17/06 11:40a John.gwynn
 * first of what may be multiple location### classes to provide
 * LOCATION_CODE functionality, in this case: GetCityFromZip
 */
#endregion
