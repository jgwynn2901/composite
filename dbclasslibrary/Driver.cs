/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 1993-2005 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Driver.cs 5     9/10/10 2:45p Gwynnj $ */

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD for DRIVER table.
	/// </summary>
	[ComVisible(false)]	
	public class Driver :DbBaseClass
	{
		/// <summary>
		/// default constructor uses the registry db instance
		/// </summary>
		public Driver() :this(String.Empty)
		{
		}
		/// <summary>
		/// user can name db instance
		/// </summary>
		/// <param name="instance"></param>
		public Driver(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessDriver";
// ReSharper disable DoNotCallOverridableMethodsInConstructor
			Initialize();
// ReSharper restore DoNotCallOverridableMethodsInConstructor
		}
		/// <summary>
		/// Set up parameter definitions here
		/// </summary>
		/// <remarks>
		/// the definitions can be defined externally (configuration) 
		/// and iterated here for maximum flexibility
		/// </remarks>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////p_nDriverID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_nDriverID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_nFileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nFileTranLogId","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_nPolicyID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nPolicyID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nSSN
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nSSN","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNameFirst
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNameFirst","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNameLast
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNameLast","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAddress1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAddress1","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nAddress2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAddress2","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nCity
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nCity","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nState
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nState","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nZip
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nZip","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nPhone
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nPhone","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nRelation
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nRelation","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nLicenseNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nLicenseNumber","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nUploadKey
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nUploadKey","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nActiveStartDt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nActiveStartDt","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nActiveEndDt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nActiveEndDt","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nDriverNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nDriverNumber","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nBirthdDt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nBirthdDt","",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nGender
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nGender","",System.Data.DbType.AnsiString);
		}
		/// <summary>
		/// DriverID property
		/// </summary>
// ReSharper disable InconsistentNaming
		public string DriverID 
// ReSharper restore InconsistentNaming
		{
			get 
			{
				return GetValue("p_nDriverID");
			}
		}
		/// <summary>
		/// FileTranLogId property
		/// </summary>
		public string FileTranLogId 
		{
			get 
			{
				return GetValue("p_nFileTranLogId");
			}
			set 
			{
				SetValue("p_nFileTranLogId",value);
			}
		}
		/// <summary>
		/// PolicyID property
		/// </summary>
// ReSharper disable InconsistentNaming
		public string PolicyID 
// ReSharper restore InconsistentNaming
		{
			get 
			{
				return GetValue("p_nPolicyID");
			}
			set 
			{
				SetValue("p_nPolicyID",value);
			}
		}
		/// <summary>
		/// SSN property
		/// </summary>
// ReSharper disable InconsistentNaming
		public string SSN 
// ReSharper restore InconsistentNaming
		{
			get 
			{
				return GetValue("p_nSSN");
			}
			set 
			{
				SetValue("p_nSSN",value);
			}
		}
		/// <summary>
		/// NameFirst property
		/// </summary>
		public string NameFirst 
		{
			get 
			{
				return GetValue("p_nNameFirst");
			}
			set 
			{
				SetValue("p_nNameFirst",value);
			}
		}
		/// <summary>
		/// NameLast property
		/// </summary>
		public string NameLast 
		{
			get 
			{
				return GetValue("p_nNameLast");
			}
			set 
			{
				SetValue("p_nNameLast",value);
			}
		}
		/// <summary>
		/// Address1 property
		/// </summary>
		public string Address1 
		{
			get 
			{
				return GetValue("p_nAddress1");
			}
			set 
			{
				SetValue("p_nAddress1",value);
			}
		}
		/// <summary>
		/// Address2 property
		/// </summary>
		public string Address2 
		{
			get 
			{
				return GetValue("p_nAddress2");
			}
			set 
			{
				SetValue("p_nAddress2",value);
			}
		}
		/// <summary>
		/// City property
		/// </summary>
		public string City 
		{
			get 
			{
				return GetValue("p_nCity");
			}
			set 
			{
				SetValue("p_nCity",value);
			}
		}
		/// <summary>
		/// State property
		/// </summary>
		public string State 
		{
			get 
			{
				return GetValue("p_nState");
			}
			set 
			{
				SetValue("p_nState",value);
			}
		}
		/// <summary>
		/// Zip property
		/// </summary>
		public string Zip 
		{
			get 
			{
				return GetValue("p_nZip");
			}
			set 
			{
				SetValue("p_nZip",value);
			}
		}
		/// <summary>
		/// Phone property
		/// </summary>
		public string Phone 
		{
			get 
			{
				return GetValue("p_nPhone");
			}
			set 
			{
				SetValue("p_nPhone",value);
			}
		}
		/// <summary>
		/// RelationToInsured property
		/// </summary>
		public string RelationToInsured 
		{
			get 
			{
				return GetValue("p_nRelation");
			}
			set 
			{
				SetValue("p_nRelation",value);
			}
		}
		/// <summary>
		/// LicenseNumber property
		/// </summary>
		public string LicenseNumber 
		{
			get 
			{
				return GetValue("p_nLicenseNumber");
			}
			set 
			{
				SetValue("p_nLicenseNumber",value);
			}
		}
		/// <summary>
		/// UploadKey property
		/// </summary>
		public string UploadKey 
		{
			get 
			{
				return GetValue("p_nUploadKey");
			}
			set 
			{
				SetValue("p_nUploadKey",value);
			}
		}
		/// <summary>
		/// ActiveStartDt property
		/// </summary>
		public string ActiveStartDt 
		{
			get 
			{
				return GetValue("p_nActiveStartDt");
			}
			set 
			{
				SetValue("p_nActiveStartDt",value);
			}
		}
		/// <summary>
		/// ActiveEndDt property
		/// </summary>
		public string ActiveEndDt 
		{
			get 
			{
				return GetValue("p_nActiveEndDt");
			}
			set 
			{
				SetValue("p_nActiveEndDt",value);
			}
		}
		/// <summary>
		/// DriverNumber property
		/// </summary>
		public string DriverNumber 
		{
			get 
			{
				return GetValue("p_nDriverNumber");
			}
			set 
			{
				SetValue("p_nDriverNumber",value);
			}
		}
		/// <summary>
		/// BirthdDt property
		/// </summary>
		public string BirthdDt 
		{
			get 
			{
				return GetValue("p_nBirthdDt");
			}
			set 
			{
				SetValue("p_nBirthdDt",value);
			}
		}
		/// <summary>
		/// Gender property
		/// </summary>
		public string Gender 
		{
			get 
			{
				return GetValue("p_nGender");
			}
			set 
			{
				SetValue("p_nGender",value);
			}
		}
	}
}
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Driver.cs $
 * 
 * 5     9/10/10 2:45p Gwynnj
 * minor reformatting and added ToUpper for web loads
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
 * 5     11/29/06 3:40p John.gwynn
 * Added CsaaDriver and CsaaVehicle
 * 
 * 4     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 3     4/06/06 6:16p John.gwynn
 * Added NcciCode and AhsIdFromLocation
 * 
 * 2     3/04/06 5:27p John.gwynn
 * added the ability to set dbInstance in constructor
 * 
 * 1     11/17/05 5:55p John.gwynn
 * Added AHSPolicy and Driver
 */
