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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Carrier.cs 6     10/28/09 5:21p John.gwynn $ */
#endregion

using System.Runtime.InteropServices;
using FnsComposite.SegmentObjects;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for Carrier table.
	/// </summary>
	[ComVisible(false)]	
	public sealed class Carrier :DbBaseClass, ICarrier
	{
		private enum ParmList 
		{
			CarrierId = 0,
			FileTranLogId,
			Name,
			Title,
			BusinessType,
			Address1,
			Address2,
			City,
			State,
			Zip,
			Phone,
			Fein,
			CarrierNumber,
			BureauCode,
			UploadKey
		};
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="Carrier"/> class.
		/// </summary>
		/// <param name="source">The source.</param>
		public Carrier (ICarrier source) : this (string.Empty)
		{
			FileTranLogId = source.FileTranLogId;
			Name = source.FullName;
			Title = source.Title;
			BusinessType = source.BusinessType;
			Address1 = source.Address1;
			Address2 = source.Address2;
			City = source.City;
			State = source.State;
			Zip = source.Zip;
			Phone = source.Phone;
			Fein = source.Fein;
			CarrierNumber = source.CarrierNumber;
			BureauCode = source.BureauCode;
			UploadKey = source.UploadKey;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="Carrier"/> class.
		/// </summary>
		public Carrier():this(string.Empty)
		{ }	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="Carrier"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public Carrier(string instance) :base (instance)
		{
			_name = "UIFSEGMENT.ProcessCarrier";

			_parameterNames = new[]
				{
					"p_nCarrierID",
					"p_nFileTranLogId",
					"p_nName",
					"p_nTitle",
					"p_nBusinessType",
					"p_nAddress1",
					"p_nAddress2",
					"p_nCity",
					"p_nState",
					"p_nZip",
					"p_nPhone",
					"p_nFEIN",
					"p_nCarrierNumber",
					"p_nBureauCode",
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
			//// CarrierId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
			        _parameterNames[(int)ParmList.CarrierId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// FileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)ParmList.FileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// Name
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.Name],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Title
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.Title],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// BusinessType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.BusinessType],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Address1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.Address1],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Address2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.Address2],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// City
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.City],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// State
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.State],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Zip
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.Zip],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Phone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.Phone],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Fein
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.Fein],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// CarrierNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.CarrierNumber],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// BureauCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.BureauCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// UploadKey
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.UploadKey],"",System.Data.DbType.AnsiString);
		}
		#endregion
		#region CarrierId
		
		/// <summary>
		/// Gets the carrier id.
		/// </summary>
		/// <value>The carrier id.</value>
		public string CarrierId
		{
			get 
			{
				return GetValue((int)ParmList.CarrierId);
			}
			set
			{
				
			}
		}
		#endregion
		#region FileTranLogId

		/// <summary>
		/// Gets or sets the file tran log id.
		/// </summary>
		public string FileTranLogId
		{
			get 
			{
				return GetValue((int)ParmList.FileTranLogId);
			}
			set 
			{
				SetValue((int)ParmList.FileTranLogId,value);
			}
		}

		/// <summary>
		/// Gets or sets the full name.
		/// </summary>
		/// <value>The full name.</value>
		public string FullName
		{
			get { return Name; }
			set { Name = value; }
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
				return GetValue((int)ParmList.Name);
			}
			set 
			{
				SetValue((int)ParmList.Name,value);
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
				return GetValue((int)ParmList.Title);
			}
			set 
			{
				SetValue((int)ParmList.Title,value);
			}
		}
		#endregion
		#region BusinessType
		/// <summary>
		/// Gets or sets the type of the business.
		/// </summary>
		/// <value>The type of the business.</value>
		public string BusinessType
		{
			get 
			{
				return GetValue((int)ParmList.BusinessType);
			}
			set 
			{
				SetValue((int)ParmList.BusinessType,value);
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
				return GetValue((int)ParmList.Address1);
			}
			set 
			{
				SetValue((int)ParmList.Address1,value);
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
				return GetValue((int)ParmList.Address2);
			}
			set 
			{
				SetValue((int)ParmList.Address2,value);
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
				return GetValue((int)ParmList.City);
			}
			set 
			{
				SetValue((int)ParmList.City,value);
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
				return GetValue((int)ParmList.State);
			}
			set 
			{
				SetValue((int)ParmList.State,value);
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
				return GetValue((int)ParmList.Zip);
			}
			set 
			{
				SetValue((int)ParmList.Zip,value);
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
				return GetValue((int)ParmList.Phone);
			}
			set 
			{
				SetValue((int)ParmList.Phone,value);
			}
		}
		#endregion
		#region Fein
		/// <summary>
		/// Gets or sets the fein.
		/// </summary>
		/// <value>The fein.</value>
		public string Fein
		{
			get 
			{
				return GetValue((int)ParmList.Fein);
			}
			set 
			{
				SetValue((int)ParmList.Fein,value);
			}
		}
		#endregion
		#region CarrierNumber
		/// <summary>
		/// Gets or sets the carrier number.
		/// </summary>
		/// <value>The carrier number.</value>
		public string CarrierNumber
		{
			get 
			{
				return GetValue((int)ParmList.CarrierNumber);
			}
			set 
			{
				SetValue((int)ParmList.CarrierNumber,value);
			}
		}
		#endregion
		#region BureauCode
		/// <summary>
		/// Gets or sets the bureau code.
		/// </summary>
		/// <value>The bureau code.</value>
		public string BureauCode
		{
			get 
			{
				return GetValue((int)ParmList.BureauCode);
			}
			set 
			{
				SetValue((int)ParmList.BureauCode,value);
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
				return GetValue((int)ParmList.UploadKey);
			}
			set 
			{
				SetValue((int)ParmList.UploadKey,value);
			}
		}

		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Carrier.cs $
 * 
 * 6     10/28/09 5:21p John.gwynn
 * Removed redundant IAccountHeirarchyStep interface
 * 
 * 5     10/27/09 12:40p John.gwynn
 * Carrier now implements ICarrier and can be constructed from it.
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
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/27/06 5:13p John.gwynn
 * CRUD for CARRIER table
 */
#endregion
