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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Provider.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for PROVIDER table.
	/// </summary>
	[ComVisible(false)]	
	public  class Provider :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="Provider"/> class.
		/// </summary>
		public Provider() :this(String.Empty)
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Provider"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public Provider(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.UpdateProviderStatus";
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
			///// p_providerID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_providerID","",System.Data.DbType.Int32 );
			///////////////////////////////////////////////////
			///// p_uID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_uID","",System.Data.DbType.AnsiString );
			///////////////////////////////////////////////////
			///// p_statusCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_statusCode","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_address1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_address1","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_address2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_address2","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_city
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_city","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_state
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_state","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_zipCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_zipCode","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_phone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_phone","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_email
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_email","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_groupName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_groupName","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_groupContact
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_groupContact","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_groupPhone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_groupPhone","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_mailPreference
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_mailPreference","",System.Data.DbType.AnsiString  );
			///////////////////////////////////////////////////
			///// p_comments
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_comments","",System.Data.DbType.AnsiString  );
			
		}
		#endregion
		#region ProviderId
		/// <summary>
		/// Gets the provider id.
		/// </summary>
		/// <value>The provider id.</value>
		public string ProviderId
		{
			get
			{
				return GetValue("p_providerID");	
			}
		}
		#endregion
		#region Id
		/// <summary>
		/// Gets or sets the UID.
		/// </summary>
		/// <value>The UID.</value>
		public string Id
		{
			get
			{
				return GetValue("p_uID");
			}
			set
			{
				SetValue("p_uID", value);
			}
		}
		#endregion
		#region StatusCode
		/// <summary>
		/// Gets or sets the status code.
		/// </summary>
		/// <value>The status code.</value>
		public string StatusCode
		{
			get
			{
				return GetValue("p_statusCode");
			}
			set
			{
				SetValue("p_statusCode", value);
			}
		}
		#endregion
		#region Address1
		/// <summary>
		/// Gets or sets the address1.
		/// </summary>
		/// <value>The address1.</value>
		public string Address1
		{
			get
			{
				return GetValue("p_address1");
			}
			set
			{
				SetValue("p_address1", value);
			}
		}
		#endregion
		#region Address2
		/// <summary>
		/// Gets or sets the address2.
		/// </summary>
		/// <value>The address2.</value>
		public string Address2
		{
			get
			{
				return GetValue("p_address2");
			}
			set
			{
				SetValue("p_address2", value);
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
				return GetValue("p_city");
			}
			set
			{
				SetValue("p_city", value);
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
				return GetValue("p_state");
			}
			set
			{
				SetValue("p_state", value);
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
				return GetValue("p_zipCode");
			}
			set
			{
				SetValue("p_zipCode", value);
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
				return GetValue("p_phone");
			}
			set
			{
				SetValue("p_phone", value);
			}
		}
		#endregion
		#region Email
		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>The email.</value>
		public string Email
		{
			get
			{
				return GetValue("p_email");
			}
			set
			{
				SetValue("p_email", value);
			}
		}
		#endregion
		#region GroupName
		/// <summary>
		/// Gets or sets the name of the group.
		/// </summary>
		/// <value>The name of the group.</value>
		public string GroupName
		{
			get
			{
				return GetValue("p_groupName");
			}
			set
			{
				SetValue("p_groupName", value);
			}
		}
		#endregion
		#region GroupPhone
		/// <summary>
		/// Gets or sets the group phone.
		/// </summary>
		/// <value>The group phone.</value>
		public string GroupPhone
		{
			get
			{
				return GetValue("p_groupPhone");
			}
			set
			{
				SetValue("p_groupPhone", value);
			}
		}
		#endregion
		#region GroupContact
		/// <summary>
		/// Gets or sets the group contact.
		/// </summary>
		/// <value>The group contact.</value>
		public string GroupContact
		{
			get
			{
				return GetValue("p_groupContact");
			}
			set
			{
				SetValue("p_groupContact", value);
			}
		}
		#endregion
		#region MailPreference
		/// <summary>
		/// Gets or sets the mail preference.
		/// </summary>
		/// <value>The mail preference.</value>
		public string MailPreference
		{
			get
			{
				return GetValue("p_mailPreference");
			}
			set
			{
				SetValue("p_mailPreference", value);
			}
		}
		#endregion
		#region Comments
		/// <summary>
		/// Gets or sets the comments.
		/// </summary>
		/// <value>The comments.</value>
		public string Comments
		{
			get
			{
				return GetValue("p_comments");
			}
			set
			{
				SetValue("p_comments", value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Provider.cs $
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
 * 7     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 6     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 5     9/29/06 11:22a Deepika.sharma
 * dms: Changes for BEE for provider followup 
 * 
 * 4     8/15/06 5:46p John.gwynn
 * added resetCms and Provider parameters for update
 * 
 * 3     7/20/06 3:25p John.gwynn
 * Beech update for non COMPLETED calls
 * 
 * 2     7/14/06 3:02p John.gwynn
 * Beech Provider support mods final version pre-release
 * 
 * 1     7/12/06 10:32a John.gwynn
 * Added Provider support for Beech
 */
#endregion 