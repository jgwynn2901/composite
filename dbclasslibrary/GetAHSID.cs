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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/GetAHSID.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates getuserid stored proc using user table.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class GetAHSID : DbBaseClass
	{
		private enum eParmList 
		{
			locationcode = 0,
			ahsid
			
		};
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="GetuserIDfromUserName"/> class.
		/// </summary>
		public GetAHSID():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="GetuserIDfromUserName"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public GetAHSID(string instance) :base(instance)
		{
			_name = "DBClassLibrary.GetcrawcedarhilllocationAHSID";

			_parameterNames = new string[]
				{
					"p_locationcode",
					"p_ahsid"
						
					
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
			//// locationcode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.locationcode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// ahs Id
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.ahsid],"",System.Data.DbType.Int32);
		}	
		#endregion
		#region Public Properties
		
		/// <summary>
		/// Gets or sets the User Name.
		/// </summary>
		/// <value>The User Name.</value>
		public string Locationcode
		{
			get 
			{
				return GetValue((int)eParmList.locationcode);
			}
			set 
			{
				SetValue((int)eParmList.locationcode,value);
			}
		}
		/// <summary>
		/// Gets the ahs ID.
		/// </summary>
		/// <value>The ahs Id.</value>
		public string Ahsid
		{
			get 
			{
				return GetValue((int)eParmList.ahsid);
			}
		}
		#endregion
		/// <summary>
		/// Gets the ahs ID.
		/// </summary>
		/// <value>The ahsid Id.</value>
		public static string GetLOCATIONAHSID (string instance, string locationcode)
		{
			string results = String.Empty;
			try
			{
				GetAHSID AHS = new GetAHSID(instance);
				AHS.Locationcode = locationcode;
				if(AHS.Execute())
				{
					results = AHS.Ahsid;
				}
			}
			catch(Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message,"GetLOCATIONAHSID");
			}
			return results;
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/GetAHSID.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     11/07/07 9:16a Jenny.cheung
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
