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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SpecificDestination.cs 6     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Manages insrts/updates to SPECIFIC_DESTINATION table
	/// </summary>
	[ComVisible(false)]	
	public class SpecificDestination : DbBaseClass
	{
		private enum eParmList
		{
			SpecdestId = 0,
			AhsId,
			NameFirst,
			NameLast,
			NameMid,
			Nametitle,
			Address1,
			Address2,
			City,
			State,
			Zip,
			Phone,
			AltformFlg,
			Lobcd,
            UploadKey,
            FileTranLogId
		};

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="SpecificDestination"/> class.
		/// </summary>
		public SpecificDestination() : this(String.Empty)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="SpecificDestination"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public SpecificDestination(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessSpecificDestination";

			_parameterNames = new string[] {
				"P_SPECDESTID",
				"P_AHSID",
				"P_NAMEFIRST",
				"P_NAMELAST",
				"P_NAMEMID",
				"P_NAMETITLE",
				"P_ADDRESS1",
				"P_ADDRESS2",
				"P_CITY",
				"P_STATE",
				"P_ZIP",
				"P_PHONE",
				"P_ALTFORMFLG",
				"P_LOBCD",
                "P_UPLOADKEY",
                "P_FILETRANLOGID"
			};

			Initialize();
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
		#region AltformFlg
		/// <summary>
		/// Gets or sets the altform FLG.
		/// </summary>
		/// <value>The altform FLG.</value>
		public string AltformFlg
		{
			get{ return GetValue((int)eParmList.AltformFlg); }
			set{ SetValue((int)eParmList.AltformFlg,value); }
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
		#region Lobcd
		/// <summary>
		/// Gets or sets the lobcd.
		/// </summary>
		/// <value>The lobcd.</value>
		public string Lobcd
		{
			get{ return GetValue((int)eParmList.Lobcd); }
			set{ SetValue((int)eParmList.Lobcd,value); }
		}
		#endregion
		#region NameFirst
		/// <summary>
		/// Gets or sets the name first.
		/// </summary>
		/// <value>The name first.</value>
		public string NameFirst
		{
			get{ return GetValue((int)eParmList.NameFirst); }
			set{ SetValue((int)eParmList.NameFirst,value); }
		}
		#endregion
		#region NameLast
		/// <summary>
		/// Gets or sets the name last.
		/// </summary>
		/// <value>The name last.</value>
		public string NameLast
		{
			get{ return GetValue((int)eParmList.NameLast); }
			set{ SetValue((int)eParmList.NameLast,value); }
		}
		#endregion
		#region NameMid
		/// <summary>
		/// Gets or sets the name mid.
		/// </summary>
		/// <value>The name mid.</value>
		public string NameMid
		{
			get{ return GetValue((int)eParmList.NameMid); }
			set{ SetValue((int)eParmList.NameMid,value); }
		}
		#endregion
		#region Nametitle
		/// <summary>
		/// Gets or sets the nametitle.
		/// </summary>
		/// <value>The nametitle.</value>
		public string Nametitle
		{
			get{ return GetValue((int)eParmList.Nametitle); }
			set{ SetValue((int)eParmList.Nametitle,value); }
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
		#region SpecdestId
		/// <summary>
		/// Gets or sets the specdest id.
		/// </summary>
		/// <value>The specdest id.</value>
		public string SpecdestId
		{
			get{ return GetValue((int)eParmList.SpecdestId); }
			set{ SetValue((int)eParmList.SpecdestId,value); }
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

        #region UploadKey

        /// <summary>
        /// Gets or sets the upload key.
        /// </summary>
        /// <value>The upload key.</value>
        public string UploadKey
        {
            get { return GetValue((int)eParmList.UploadKey); }
            set { SetValue((int)eParmList.UploadKey, value); }
        }
        #endregion
        #region FileTranLogId

        /// <summary>
        /// Gets or sets the file tran log id.
        /// </summary>
        /// <value>The file tran log id.</value>
        public string FileTranLogId
        {
            get { return GetValue((int)eParmList.FileTranLogId); }
            set { SetValue((int)eParmList.FileTranLogId, value); }
        }
        #endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.SpecdestId],"",System.Data.DbType.Int32);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.AhsId],"",System.Data.DbType.Int32);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.NameFirst],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.NameLast],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.NameMid],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Nametitle],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Address1],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Address2],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.City],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.State],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Zip],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Phone],"",System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.AltformFlg],"",System.Data.DbType.AnsiString);
			
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.Lobcd],"",System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.UploadKey], "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
               _parameterNames[(int)eParmList.FileTranLogId], "", System.Data.DbType.AnsiString);


		}
		#endregion

	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/SpecificDestination.cs $
 * 
 * 6     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 5     7/28/08 4:31p Jenny.cheung
 * Added file Transmission log id
 * 
 * 4     7/22/08 10:18a Jenny.cheung
 * Added uploadkey to the table
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 1     3/13/07 6:29p John.gwynn
 * Specific destination plumbing for ESIS Contact file load
 */
#endregion

