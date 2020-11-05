#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Branch.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Wrapper for UIFSEGMENT.ProcessBranch
	/// </summary>
	[ComVisible(false)]
	public class Branch : DbBaseClass
	{
		private enum eParmList
		{
			BranchId = 0,
			AhsId,
			BranchNumber,
			BranchType,
			OfficeNumber,
			OfficeName,
			OfficeType,
			Status,
			Address1,
			Address2,
			Address3,
			City,
			State,
			Zip,
			Phone,
			PhoneAdj,
			PhoneAlt,
			PhoneAlt1,
			PhoneAlt2,
			Fax,
			Backupfax,
			Foreignzip,
			Country,
			ContactFirstname,
			ContactMidinit,
			ContactLastname,
			AltcontactFirstname,
			AltcontactLastname,
			ContactTitle,
			Lat,
			Lon,
			Emailaddress,
			Businesscode,
			Overnightaddress1,
			Overnightaddress2,
			Overnightcity,
			Overnightstate,
			Overnightzip,
			Notes
		};

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="Branch"/> class.
		/// </summary>
		public Branch() : this(String.Empty)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="Branch"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public Branch(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessBranch";

			_parameterNames = new string[]
				{
					"P_NBRANCHID",
					"P_NAHSID",
					"P_NBRANCHNUMBER",
					"P_NBRANCHTYPE",
					"P_NOFFICENUMBER",
					"P_NOFFICENAME",
					"P_NOFFICETYPE",
					"P_NSTATUS",
					"P_NADDRESS1",
					"P_NADDRESS2",
					"P_NADDRESS3",
					"P_NCITY",
					"P_NSTATE",
					"P_NZIP",
					"P_NPHONE",
					"P_NPHONEADJ",
					"P_NPHONEALT",
					"P_NPHONEALT1",
					"P_NPHONEALT2",
					"P_NFAX",
					"P_NBACKUPFAX",
					"P_NFOREIGNZIP",
					"P_NCOUNTRY",
					"P_NCONTACTFIRSTNAME",
					"P_NCONTACTMIDINIT",
					"P_NCONTACTLASTNAME",
					"P_NALTCONTACTFIRSTNAME",
					"P_NALTCONTACTLASTNAME",
					"P_NCONTACTTITLE",
					"P_NLAT",
					"P_NLON",
					"P_NEMAILADDRESS",
					"P_NBUSINESSCODE",
					"P_NOVERNIGHTADDRESS1",
					"P_NOVERNIGHTADDRESS2",
					"P_NOVERNIGHTCITY",
					"P_NOVERNIGHTSTATE",
					"P_NOVERNIGHTZIP",
					"P_NNOTES"
				};

			Initialize();
		}
		#endregion

		#region BranchId
		/// <summary>
		/// Gets or sets the branch id.
		/// </summary>
		/// <value>The branch id.</value>
		public string BranchId
		{
			get{ return GetValue((int)eParmList.BranchId); }
			set{ SetValue((int)eParmList.BranchId,value); }
		}
		#endregion

		#region AhsId
		/// <summary>
		/// Gets or sets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string AhsId
		{
			get{ return GetValue((int)eParmList.AhsId); }
			set{ SetValue((int)eParmList.AhsId,value); }
		}
		#endregion

		#region BranchNumber
		/// <summary>
		/// Gets or sets the branch number.
		/// </summary>
		/// <value>The branch number.</value>
		public string BranchNumber
		{
			get{ return GetValue((int)eParmList.BranchNumber); }
			set{ SetValue((int)eParmList.BranchNumber,value); }
		}
		#endregion

		#region BranchType
		/// <summary>
		/// Gets or sets the type of the branch.
		/// </summary>
		/// <value>The type of the branch.</value>
		public string BranchType
		{
			get{ return GetValue((int)eParmList.BranchType); }
			set{ SetValue((int)eParmList.BranchType,value); }
		}
		#endregion

		#region OfficeNumber
		/// <summary>
		/// Gets or sets the office number.
		/// </summary>
		/// <value>The office number.</value>
		public string OfficeNumber
		{
			get{ return GetValue((int)eParmList.OfficeNumber); }
			set{ SetValue((int)eParmList.OfficeNumber,value); }
		}
		#endregion

		#region OfficeName
		/// <summary>
		/// Gets or sets the name of the office.
		/// </summary>
		/// <value>The name of the office.</value>
		public string OfficeName
		{
			get{ return GetValue((int)eParmList.OfficeName); }
			set{ SetValue((int)eParmList.OfficeName,value); }
		}
		#endregion

		#region OfficeType
		/// <summary>
		/// Gets or sets the type of the office.
		/// </summary>
		/// <value>The type of the office.</value>
		public string OfficeType
		{
			get{ return GetValue((int)eParmList.OfficeType); }
			set{ SetValue((int)eParmList.OfficeType,value); }
		}
		#endregion

		#region Status
		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		public string Status
		{
			get{ return GetValue((int)eParmList.Status); }
			set{ SetValue((int)eParmList.Status,value); }
		}
		#endregion

		#region Address1
		/// <summary>
		/// Gets or sets the address1.
		/// </summary>
		/// <value>The address1.</value>
		public string Address1
		{
			get{ return GetValue((int)eParmList.Address1); }
			set{ SetValue((int)eParmList.Address1,value); }
		}
		#endregion

		#region Address2
		/// <summary>
		/// Gets or sets the address2.
		/// </summary>
		/// <value>The address2.</value>
		public string Address2
		{
			get{ return GetValue((int)eParmList.Address2); }
			set{ SetValue((int)eParmList.Address2,value); }
		}
		#endregion

		#region Address3
		/// <summary>
		/// Gets or sets the address3.
		/// </summary>
		/// <value>The address3.</value>
		public string Address3
		{
			get{ return GetValue((int)eParmList.Address3); }
			set{ SetValue((int)eParmList.Address3,value); }
		}
		#endregion

		#region City
		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City
		{
			get{ return GetValue((int)eParmList.City); }
			set{ SetValue((int)eParmList.City,value); }
		}
		#endregion

		#region State
		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		public string State
		{
			get{ return GetValue((int)eParmList.State); }
			set{ SetValue((int)eParmList.State,value); }
		}
		#endregion

		#region Zip
		/// <summary>
		/// Gets or sets the zip.
		/// </summary>
		/// <value>The zip.</value>
		public string Zip
		{
			get{ return GetValue((int)eParmList.Zip); }
			set{ SetValue((int)eParmList.Zip,value); }
		}
		#endregion

		#region Phone
		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		/// <value>The phone.</value>
		public string Phone
		{
			get{ return GetValue((int)eParmList.Phone); }
			set{ SetValue((int)eParmList.Phone,value); }
		}
		#endregion

		#region PhoneAdj
		/// <summary>
		/// Gets or sets the phone adj.
		/// </summary>
		/// <value>The phone adj.</value>
		public string PhoneAdj
		{
			get{ return GetValue((int)eParmList.PhoneAdj); }
			set{ SetValue((int)eParmList.PhoneAdj,value); }
		}
		#endregion

		#region PhoneAlt
		/// <summary>
		/// Gets or sets the phonealt.
		/// </summary>
		/// <value>The phonealt.</value>
		public string PhoneAlt
		{
			get{ return GetValue((int)eParmList.PhoneAlt); }
			set{ SetValue((int)eParmList.PhoneAlt,value); }
		}
		#endregion

		#region PhoneAlt1
		/// <summary>
		/// Gets or sets the phonealt1.
		/// </summary>
		/// <value>The phonealt1.</value>
		public string PhoneAlt1
		{
			get{ return GetValue((int)eParmList.PhoneAlt1); }
			set{ SetValue((int)eParmList.PhoneAlt1,value); }
		}
		#endregion

		#region PhoneAlt2
		/// <summary>
		/// Gets or sets the phonealt2.
		/// </summary>
		/// <value>The phonealt2.</value>
		public string PhoneAlt2
		{
			get{ return GetValue((int)eParmList.PhoneAlt2); }
			set{ SetValue((int)eParmList.PhoneAlt2,value); }
		}
		#endregion

		#region Fax
		/// <summary>
		/// Gets or sets the fax.
		/// </summary>
		/// <value>The fax.</value>
		public string Fax
		{
			get{ return GetValue((int)eParmList.Fax); }
			set{ SetValue((int)eParmList.Fax,value); }
		}
		#endregion

		#region Backupfax
		/// <summary>
		/// Gets or sets the backupfax.
		/// </summary>
		/// <value>The backupfax.</value>
		public string Backupfax
		{
			get{ return GetValue((int)eParmList.Backupfax); }
			set{ SetValue((int)eParmList.Backupfax,value); }
		}
		#endregion

		#region Foreignzip
		/// <summary>
		/// Gets or sets the foreignzip.
		/// </summary>
		/// <value>The foreignzip.</value>
		public string Foreignzip
		{
			get{ return GetValue((int)eParmList.Foreignzip); }
			set{ SetValue((int)eParmList.Foreignzip,value); }
		}
		#endregion

		#region Country
		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
		public string Country
		{
			get{ return GetValue((int)eParmList.Country); }
			set{ SetValue((int)eParmList.Country,value); }
		}
		#endregion

		#region ContactFirstname
		/// <summary>
		/// Gets or sets the contact firstname.
		/// </summary>
		/// <value>The contact firstname.</value>
		public string ContactFirstname
		{
			get{ return GetValue((int)eParmList.ContactFirstname); }
			set{ SetValue((int)eParmList.ContactFirstname,value); }
		}
		#endregion

		#region ContactMidinit
		/// <summary>
		/// Gets or sets the contact midinit.
		/// </summary>
		/// <value>The contact midinit.</value>
		public string ContactMidinit
		{
			get{ return GetValue((int)eParmList.ContactMidinit); }
			set{ SetValue((int)eParmList.ContactMidinit,value); }
		}
		#endregion

		#region ContactLastname
		/// <summary>
		/// Gets or sets the contact lastname.
		/// </summary>
		/// <value>The contact lastname.</value>
		public string ContactLastname
		{
			get{ return GetValue((int)eParmList.ContactLastname); }
			set{ SetValue((int)eParmList.ContactLastname,value); }
		}
		#endregion

		#region AltcontactFirstname
		/// <summary>
		/// Gets or sets the altcontact firstname.
		/// </summary>
		/// <value>The altcontact firstname.</value>
		public string AltcontactFirstname
		{
			get{ return GetValue((int)eParmList.AltcontactFirstname); }
			set{ SetValue((int)eParmList.AltcontactFirstname,value); }
		}
		#endregion

		#region AltcontactLastname
		/// <summary>
		/// Gets or sets the altcontact lastname.
		/// </summary>
		/// <value>The altcontact lastname.</value>
		public string AltcontactLastname
		{
			get{ return GetValue((int)eParmList.AltcontactLastname); }
			set{ SetValue((int)eParmList.AltcontactLastname,value); }
		}
		#endregion

		#region ContactTitle
		/// <summary>
		/// Gets or sets the contact title.
		/// </summary>
		/// <value>The contact title.</value>
		public string ContactTitle
		{
			get{ return GetValue((int)eParmList.ContactTitle); }
			set{ SetValue((int)eParmList.ContactTitle,value); }
		}
		#endregion

		#region Lat
		/// <summary>
		/// Gets or sets the lat.
		/// </summary>
		/// <value>The lat.</value>
		public  string Lat
		{
			get{ return GetValue((int)eParmList.Lat); }
			set{ SetValue((int)eParmList.Lat,value); }
		}
		#endregion

		#region Lon
		/// <summary>
		/// Gets or sets the lon.
		/// </summary>
		/// <value>The lon.</value>
		public string Lon
		{
			get{ return GetValue((int)eParmList.Lon); }
			set{ SetValue((int)eParmList.Lon,value); }
		}
		#endregion

		#region Emailaddress
		/// <summary>
		/// Gets or sets the emailaddress.
		/// </summary>
		/// <value>The emailaddress.</value>
		public string Emailaddress
		{
			get{ return GetValue((int)eParmList.Emailaddress); }
			set{ SetValue((int)eParmList.Emailaddress,value); }
		}
		#endregion

		#region Businesscode
		/// <summary>
		/// Gets or sets the businesscode.
		/// </summary>
		/// <value>The businesscode.</value>
		public string Businesscode
		{
			get{ return GetValue((int)eParmList.Businesscode); }
			set{ SetValue((int)eParmList.Businesscode,value); }
		}
		#endregion

		#region Overnightaddress1
		/// <summary>
		/// Gets or sets the overnightaddress1.
		/// </summary>
		/// <value>The overnightaddress1.</value>
		public string Overnightaddress1
		{
			get{ return GetValue((int)eParmList.Overnightaddress1); }
			set{ SetValue((int)eParmList.Overnightaddress1,value); }
		}
		#endregion

		#region Overnightaddress2
		/// <summary>
		/// Gets or sets the overnightaddress2.
		/// </summary>
		/// <value>The overnightaddress2.</value>
		public string Overnightaddress2
		{
			get{ return GetValue((int)eParmList.Overnightaddress2); }
			set{ SetValue((int)eParmList.Overnightaddress2,value); }
		}
		#endregion

		#region Overnightcity
		/// <summary>
		/// Gets or sets the overnightcity.
		/// </summary>
		/// <value>The overnightcity.</value>
		public string Overnightcity
		{
			get{ return GetValue((int)eParmList.Overnightcity); }
			set{ SetValue((int)eParmList.Overnightcity,value); }
		}
		#endregion

		#region Overnightstate
		/// <summary>
		/// Gets or sets the overnightstate.
		/// </summary>
		/// <value>The overnightstate.</value>
		public string Overnightstate
		{
			get{ return GetValue((int)eParmList.Overnightstate); }
			set{ SetValue((int)eParmList.Overnightstate,value); }
		}
		#endregion

		#region Overnightzip
		/// <summary>
		/// Gets or sets the overnightzip.
		/// </summary>
		/// <value>The overnightzip.</value>
		public string Overnightzip
		{
			get{ return GetValue((int)eParmList.Overnightzip); }
			set{ SetValue((int)eParmList.Overnightzip,value); }
		}
		#endregion

		#region Notes
		/// <summary>
		/// Gets or sets the notes.
		/// </summary>
		/// <value>The notes.</value>
		public string Notes
		{
			get{ return GetValue((int)eParmList.Notes); }
			set{ SetValue((int)eParmList.Notes,value); }
		}
		#endregion

		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Output,_parameterNames[(int)eParmList.BranchId],"",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.AhsId],"",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.BranchNumber],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.BranchType],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.OfficeNumber],"",System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.OfficeName],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.OfficeType],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Status],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Address1],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Address2],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Address3],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.City],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.State],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Zip],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Phone],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.PhoneAdj],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.PhoneAlt],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.PhoneAlt1],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.PhoneAlt2],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Fax],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Backupfax],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Foreignzip],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Country],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.ContactFirstname],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.ContactMidinit],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.ContactLastname],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.AltcontactFirstname],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.AltcontactLastname],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.ContactTitle],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Lat],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Lon],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Emailaddress],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Businesscode],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Overnightaddress1],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Overnightaddress2],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Overnightcity],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Overnightstate],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Overnightzip],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Notes],"",System.Data.DbType.AnsiString);
		}
		#endregion

	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Branch.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     11/07/07 9:16a Jenny.cheung
 * 
 * 1     9/13/07 8:28p John.gwynn
 * Added Branch
 */
#endregion
