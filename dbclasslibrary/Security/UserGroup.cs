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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Security/UserGroup.cs 2     5/26/09 11:07a John.gwynn $ */
#endregion

using System;

// ReSharper disable once CheckNamespace
namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates getuserid stored proc using user group table.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class UserGroup : DbBaseClass
	{
// ReSharper disable once InconsistentNaming
		private enum eParmList 
		{
			UserId = 0,
			GroupId,
			FileTransLogId
			
		};
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="UserGroup"/> class.
		/// </summary>
		public UserGroup():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="UserGroup"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public UserGroup(string instance) :base(instance)
		{
			_name = "ProcessUserGroup";

			_parameterNames = new[]
				{
					"p_nuserid",
					"p_ngroupid",
					"p_nfiletranslogid"

						
					
				};
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override sealed void Initialize()
		{
			///////////////////////////////////////////////////
			//// user id
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.UserId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// group Id
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.GroupId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// File Trans log Id
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FileTransLogId],"",System.Data.DbType.Int32);
		}	
		#endregion
		#region Public Properties
		
		/// <summary>
		/// Gets or sets the User ID.
		/// </summary>
		/// <value>The User ID.</value>
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
		/// Gets the Group ID.
		/// </summary>
		/// <value>The Group Id.</value>
		public string GroupId
		{
			get 
			{
				return GetValue((int)eParmList.GroupId);
			}
			set 
			{
				SetValue((int)eParmList.GroupId,value);
			}
		}

		/// <summary>
		/// Gets the File Trans Log ID.
		/// </summary>
		/// <value>The File Trans Log Id.</value>
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
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Security/UserGroup.cs $
 * 
 * 2     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 1     4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 1     8/14/07 2:00p Jenny.cheung
 * Added missing UserGroup for upgrade
 * 
 * 4     6/19/07 10:06a Jenny.cheung
 * 
 * 3     6/13/07 11:09a Jenny.cheung
 * 
 * 2     6/08/07 1:42p Jenny.cheung
 * Added FileTransLogId to the class.
 * 
 * 1     5/24/07 5:44p Jenny.cheung
 * created for future use for cedar hill user setup
 * 
 * 4     5/21/07 4:38p Jenny.cheung
 * Updated stored procedure in dbclasslibrary
 * 
 * 3     5/18/07 2:23p Jenny.cheung
 * Incorporated stored procedure into dbclass library
 * 
 * 2     5/18/07 1:17p Jenny.cheung
 * corrected data type for ahsid
 * 
 * 1     5/16/07 11:14a Jenny.cheung
 * corrected file name
 * 
 * 4     5/16/07 11:12a John.gwynn
 * 
 * 3     5/16/07 11:02a John.gwynn
 * corrected Stored Procedure Name
 * 
 * 2     5/16/07 10:26a Jenny.cheung
 * updated field names
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
