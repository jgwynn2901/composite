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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Contact.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for Contact table.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class Contact :DbBaseClass
	{
		private enum eParmList 
		{
			ContactId = 0,
			FileTranLogId,
			AHSID,
			FullName,
			Type,
			Title,
			Description,
			Address1,
			Address2,
			City,
			State,
			Zip,
			Country,
			Phone,
			Fax,
			Email,
			Enable_flg,
     	UploadKey
			
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="Contact"/> class.
		/// </summary>
		public Contact():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="Contact"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public Contact(string instance) :base (instance)
		{
			_name = "UIFSEGMENT.ProcessContact";

			_parameterNames = new string[]
				{
					"p_nContactID",
					"p_nFileTranLogId",
					"p_nAHSID",
					"p_nName",
					"p_nType",
					"p_nTitle",
					"P_nDescription",
					"p_nAddress1",
					"p_nAddress2",
					"p_nCity",
					"p_nState",
					"p_nZip",
					"P_nCountry",
					"p_nPhone",
					"P_nFax",
					"P_nEmail",
					"p_nEnabledFlag",
					"p_nUploadKey"
					
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
			//// ContactId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
			        _parameterNames[(int)eParmList.ContactId],"",System.Data.DbType.Int32);
			
			///////////////////////////////////////////////////
			///// FileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.FileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			//// AHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.AHSID],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// Name
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FullName],"",System.Data.DbType.AnsiString);
		
			///////////////////////////////////////////////////
			///// BusinessType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Type],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Title
			///////////////////////////////////////////////////
			
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Title],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Description
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Description],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Address1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Address1],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Address2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Address2],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// City
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.City],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// State
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.State],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Zip
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Zip],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Country
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Country],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Phone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Phone],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Fax
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Fax],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Email
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Email],"",System.Data.DbType.AnsiString);
			
			///////////////////////////////////////////////////
			///// Enable flag
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Enable_flg],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// UploadKey
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.UploadKey],"",System.Data.DbType.AnsiString);
		}
		#endregion
		#region ContactId
		
		/// <summary>
		/// Gets the contact id.
		/// </summary>
		/// <value>The contact id.</value>
		public string ContactId
		{
			get 
			{
				return GetValue((int)eParmList.ContactId);
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
				return GetValue((int)eParmList.FileTranLogId);
			}
			set 
			{
				SetValue((int)eParmList.FileTranLogId,value);
			}
		}
		#endregion
		#region AHSID
		
		/// <summary>
		/// Gets the AHS id.
		/// </summary>
		/// <value>The AHS id.</value>
		public string AHSID
		{
		
			get{ return GetValue((int)eParmList.AHSID); }
			set{ SetValue((int)eParmList.AHSID,value); }
		}
		#endregion
		#region FullName
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string FullName
		{
			get 
			{
				return GetValue((int)eParmList.FullName);
			}
			set 
			{
				SetValue((int)eParmList.FullName,value);
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
				return GetValue((int)eParmList.Type);
			}
			set 
			{
				SetValue((int)eParmList.Type,value);
			}
		}
		#endregion
		#region Title
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		public string Title
		{
			get 
			{
				return GetValue((int)eParmList.Title);
			}
			set 
			{
				SetValue((int)eParmList.Title,value);
			}
		}
		#endregion
		#region Description
		/// <summary>
		/// Gets or sets the Description.
		/// </summary>
		/// <value>The Description.</value>
		public string Description
		{
			get 
			{
				return GetValue((int)eParmList.Description);
			}
			set 
			{
				SetValue((int)eParmList.Description,value);
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
				return GetValue((int)eParmList.Address1);
			}
			set 
			{
				SetValue((int)eParmList.Address1,value);
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
				return GetValue((int)eParmList.Address2);
			}
			set 
			{
				SetValue((int)eParmList.Address2,value);
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
				return GetValue((int)eParmList.City);
			}
			set 
			{
				SetValue((int)eParmList.City,value);
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
				return GetValue((int)eParmList.State);
			}
			set 
			{
				SetValue((int)eParmList.State,value);
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
				return GetValue((int)eParmList.Zip);
			}
			set 
			{
				SetValue((int)eParmList.Zip,value);
			}
		}
		#endregion
		#region Country
		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The Country.</value>
		public string Country
		{
			get 
			{
				return GetValue((int)eParmList.Country);
			}
			set 
			{
				SetValue((int)eParmList.Country,value);
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
				return GetValue((int)eParmList.Phone);
			}
			set 
			{
				SetValue((int)eParmList.Phone,value);
			}
		}
		#endregion
		#region Fax
		/// <summary>
		/// Gets or sets the Fax.
		/// </summary>
		/// <value>The Fax.</value>
		public string Fax
		{
			get 
			{
				return GetValue((int)eParmList.Fax);
			}
			set 
			{
				SetValue((int)eParmList.Fax,value);
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
				return GetValue((int)eParmList.Email);
			}
			set 
			{
				SetValue((int)eParmList.Email,value);
			}
		}
		#endregion
		#region Enable_flg
		/// <summary>
		/// Gets or sets the enable flag.
		/// </summary>
		/// <value>The enable flag.</value>
		public string Enable_flg
		{
			get 
			{
				return GetValue((int)eParmList.Enable_flg);
			}
			set 
			{
				SetValue((int)eParmList.Enable_flg,value);
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
				return GetValue((int)eParmList.UploadKey);
			}
			set 
			{
				SetValue((int)eParmList.UploadKey,value);
			}
		}
		#endregion
		
		
		
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Contact.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     3/05/08 12:08p Jenny.cheung
 * 
 * 3     5/08/07 4:41p John.gwynn
 * fixed parameter name to match database
 * 
 * 2     5/08/07 4:16p Jenny.cheung
 * Created for Esis Actec Load
 * 
 * 1     5/02/07 4:18p Jenny.cheung
 * Created ContactSegment for Esis Actec Load
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/27/06 5:13p John.gwynn
 * CRUD for CONTACT table
 */
#endregion
