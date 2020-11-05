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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/EstarAppraiser.cs 6     10/13/09 4:20p Deepika.sharma $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// stored procedure interface for EStar Appraiser data updates
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class EstarAppraiser : DbBaseClass
	{

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="EstarAppraiser"/> class.
		/// </summary>
		public EstarAppraiser()
			: this(String.Empty)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="EstarAppraiser"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public EstarAppraiser(string instance)
			: base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessEstarAppraiser";

			_parameterNames = new string[] {
											   "P_NESTAR_APPRAISER_ID","P_NUPLOAD_KEY","P_NESTAR_APPRAISER_CODE","P_NNAME","P_NDISTANCE","P_NADDRESS_LINE1","P_NADDRESS_LINE2","P_NADDRESS_CITY","P_NADDRESS_STATE","P_NADDRESS_ZIP","P_NPHONE","P_NFAX","P_NCREATED_DT","P_NLAST_MODIFIED_DT","P_NNAME_LAST","P_NNAME_FIRST","P_NTYPE"};

			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{

			AddParm(System.Data.ParameterDirection.Output, "p_nEstar_Appraiser_Id", "", System.Data.DbType.Int32);
			AddParm(System.Data.ParameterDirection.Input, "p_nUpload_Key", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nEstar_Appraiser_Code", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nName", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nDistance", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nAddress_Line1", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nAddress_Line2", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nAddress_City", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nAddress_State", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nAddress_Zip", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nPhone", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nFax", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nCreated_Dt", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nLast_Modified_Dt", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nName_Last", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nName_First", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nType", "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, "p_nCallId", "", System.Data.DbType.AnsiString);
		}
		#endregion

		#region EstarAppraiserId
		/// <summary>
		/// Gets the estar appraiser id.
		/// </summary>
		/// <value>The estar appraiser id.</value>
		public string EstarAppraiserId
		{
			get
			{
                return GetValue("p_nEstar_Appraiser_Id");
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
				return GetValue("p_nUpload_Key");
			}
			set
			{
				SetValue("p_nUpload_Key", value);
			}
		}
		#endregion

		#region EstarAppraiserCode
		/// <summary>
		/// Gets or sets the estar appraiser code.
		/// </summary>
		/// <value>The estar appraiser code.</value>
		public string EstarAppraiserCode
		{
			get
			{
				return GetValue("p_nEstar_Appraiser_Code");
			}
			set
			{
				SetValue("p_nEstar_Appraiser_Code", value);
			}
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
				return GetValue("p_nName");
			}
			set
			{
				SetValue("p_nName", value);
			}
		}
		#endregion

		#region Distance
		/// <summary>
		/// Gets or sets the distance.
		/// </summary>
		/// <value>The distance.</value>
		public string Distance
		{
			get
			{
				return GetValue("p_nDistance");
			}
			set
			{
				SetValue("p_nDistance", value);
			}
		}
		#endregion

		#region AddressLine1
		/// <summary>
		/// Gets or sets the address line1.
		/// </summary>
		/// <value>The address line1.</value>
		public string AddressLine1
		{
			get
			{
				return GetValue("p_nAddress_Line1");
			}
			set
			{
				SetValue("p_nAddress_Line1", value);
			}
		}
		#endregion

		#region AddressLine2
		/// <summary>
		/// Gets or sets the address line2.
		/// </summary>
		/// <value>The address line2.</value>
		public string AddressLine2
		{
			get
			{
				return GetValue("p_nAddress_Line2");
			}
			set
			{
				SetValue("p_nAddress_Line2", value);
			}
		}
		#endregion

		#region AddressCity
		/// <summary>
		/// Gets or sets the address city.
		/// </summary>
		/// <value>The address city.</value>
		public string AddressCity
		{
			get
			{
				return GetValue("p_nAddress_City");
			}
			set
			{
				SetValue("p_nAddress_City", value);
			}
		}
		#endregion

		#region AddressState
		/// <summary>
		/// Gets or sets the state of the address.
		/// </summary>
		/// <value>The state of the address.</value>
		public string AddressState
		{
			get
			{
				return GetValue("p_nAddress_State");
			}
			set
			{
				SetValue("p_nAddress_State", value);
			}
		}
		#endregion

		#region AddressZip
		/// <summary>
		/// Gets or sets the address zip.
		/// </summary>
		/// <value>The address zip.</value>
		public string AddressZip
		{
			get
			{
				return GetValue("p_nAddress_Zip");
			}
			set
			{
				SetValue("p_nAddress_Zip", value);
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
				return GetValue("p_nPhone");
			}
			set
			{
				SetValue("p_nPhone", value);
			}
		}
		#endregion

		#region Fax
		/// <summary>
		/// Gets or sets the fax.
		/// </summary>
		/// <value>The fax.</value>
		public string Fax
		{
			get
			{
				return GetValue("p_nFax");
			}
			set
			{
				SetValue("p_nFax", value);
			}
		}
		#endregion

		#region CreatedDt

		/// <summary>
		/// Gets or sets the created dt.
		/// </summary>
		/// <value>The created dt.</value>
		public String CreatedDt
		{
			get
			{
				return GetValue("p_nCreated_Dt");
			}
			set
			{
				SetValue("p_nCreated_Dt", value);
			}
		}
		#endregion

		#region LastModifiedDt
		/// <summary>
		/// Gets or sets the last modified dt.
		/// </summary>
		/// <value>The last modified dt.</value>
		public String LastModifiedDt
		{
			get
			{
				return GetValue("p_nLast_Modified_Dt");
			}
			set
			{
				SetValue("p_nLast_Modified_Dt", value);
			}
		}
		#endregion

		#region NameLast
		/// <summary>
		/// Gets or sets the name last.
		/// </summary>
		/// <value>The name last.</value>
		public string NameLast
		{
			get
			{
				return GetValue("p_nName_Last");
			}
			set
			{
				SetValue("p_nName_Last", value);
			}
		}
		#endregion

		#region NameFirst
		/// <summary>
		/// Gets or sets the name first.
		/// </summary>
		/// <value>The name first.</value>
		public string NameFirst
		{
			get
			{
				return GetValue("p_nName_First");
			}
			set
			{
				SetValue("p_nName_First", value);
			}
		}
		#endregion

		#region Type
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string Type
		{
			get
			{
				return GetValue("p_nType");
			}
			set
			{
				SetValue("p_nType", value);
			}
		}
		#endregion
		#region CallId
		/// <summary>
		/// Gets or sets the call id.
		/// </summary>
		/// <value>The call id.</value>
		public string CallId
		{
			get
			{
				return GetValue("p_nCallId");
			}
			set
			{
				SetValue("p_nCallId", value);
			}
		}
		#endregion


	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/EstarAppraiser.cs $
 * 
 * 6     10/13/09 4:20p Deepika.sharma
 * dms: typo - causing appointments to not save
 * 
 * 5     10/09/09 11:00a Deepika.sharma
 * Esurance appointments not showing issue. 
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     2/01/08 1:50p John.gwynn
 * updates from 2003 source plus several minor resharper mods and comments
 * 
 * 2     1/02/08 4:14p John.gwynn
 * added XML doc comments
 * 
 * 1     12/03/07 12:31p Deepika.sharma
 * 
 * 1     11/27/07 2:28p Deepika.sharma
 */
#endregion
