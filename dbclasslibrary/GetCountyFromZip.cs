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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/GetCountyFromZip.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CountyFromZip method
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class GetCountyFromZip : DbBaseClass
	{
		private enum eParmList
		{
			Zip = 0,
			County
			
		
			
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="GetCountyFromZip"/> class.
		/// </summary>
		public GetCountyFromZip() : this(String.Empty)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="GetCountyFromZip"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public GetCountyFromZip(string instance) :base(instance)
		{
			_name = "DBClassLibrary.GetCountyFromZip";

			_parameterNames = new string[] {
			"p_nZip",
			"p_nCounty"

				
		
			};

			Initialize();
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

		#region County
	
		/// <summary>
		/// Gets the county.
		/// </summary>
		/// <value>The county.</value>
		public string County
		{
			get{ return GetValue((int)eParmList.County); }
			
		}
		#endregion
		
		
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Zip],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Output,_parameterNames[(int)eParmList.County],"",System.Data.DbType.AnsiString);
		}
		#endregion

	
		/// <summary>
		/// Gets the fips from zip.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="Zip">The zip.</param>
		/// <returns></returns>
		public static string GetCountyFromZipCode (string instance, string Zip)
		{
			string results = String.Empty;
			try
			{
				GetCountyFromZip Location = new GetCountyFromZip(instance);
				Location.Zip = Zip;
				if(Location.Execute())
				{
					results = Location.County;
				}
			}
			catch(Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message,"GetCountyFromZip");
			}
			return results;
		}
		
	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/GetCountyFromZip.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     3/05/08 12:08p Jenny.cheung
 * 
 * 2     1/10/08 2:25p Jenny.cheung
 * corrected reference for GetCountyFromZip
 * 
 * 1     1/08/08 4:47p Jenny.cheung
 * Added GetCountyFromZip
 * 
 * 1     11/28/07 3:56p Jenny.cheung
 * Added for Staples account
 * 
 * 1     7/05/07 4:14p John.gwynn
 * support for Safety Policy Load - added AgentIdFromUploadKey 
 */
#endregion
