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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AccountUser.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for AccountUser.
	/// </summary>
	[ComVisible(false)]
	public sealed class AccountUser : DbBaseClass
	{
		private enum eParmList 
		{
			UserId = 0,
			AhsId,
			FileTransLogId
			
		};
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="AccountUser"/> class.
		/// </summary>
		public AccountUser():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="AccountUser"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public AccountUser(string instance) :base(instance)
		{
			_name = "ProcessAccountUser";

			_parameterNames = new string[] {
																			 "p_nUserId",
																			 "p_nAHSID",
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
			/////p_nUserId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.UserId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_nAHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.AhsId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_nFileTransLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FileTransLogId],"",System.Data.DbType.Int32);
		
			#endregion
			
		}
		#region Public Properties
		
		/// <summary>
		/// Gets the user id.
		/// </summary>
		/// <value>The cra ncci class code id.</value>
		public string UserId
		{
			get 
			{
				return GetValue((int)eParmList.UserId);
			}
			set 
			{
				SetValue((int)eParmList.UserId,value);
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
				return GetValue((int)eParmList.AhsId);
			}
			set 
			{
				SetValue((int)eParmList.AhsId,value);
			}
		}
		/// <summary>
		/// Gets or sets the file transmissiong log id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string FileTransLogId
		{
			get 
			{
				return GetValue((int)eParmList.FileTransLogId);
			}
			set 
			{
				SetValue((int)eParmList.FileTransLogId,value);
			}
		}
	
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AccountUser.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     8/14/07 1:58p Jenny.cheung
 * Added missing accountuser for the upgrade.
 * 
 * 5     6/19/07 10:22a Jenny.cheung
 * 
 * 4     6/19/07 10:16a Jenny.cheung
 * 
 * 3     6/13/07 11:08a Jenny.cheung
 * 
 * 2     6/08/07 11:30a Jenny.cheung
 * corrected the parameter to be an input instead of output
 * 
 * 1     5/24/07 5:43p Jenny.cheung
 * created for future use
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/04/06 1:11p John.gwynn
 * new classes to support .Net loads for InputProcessingManager
 */
#endregion