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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/GetFipsFromZip.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates AgentFromUploadKey method
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class GetFipsFromZip : DbBaseClass
	{
		private enum eParmList
		{
			Zip = 0,
			Fips
			
		
			
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="GetFipsFromZip"/> class.
		/// </summary>
		public GetFipsFromZip() : this(String.Empty)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="GetFipsFromZip"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public GetFipsFromZip(string instance) :base(instance)
		{
			_name = "DBClassLibrary.GetFipsFromZip";

			_parameterNames = new string[] {
			"p_nZip",
			"p_nFips"

				
		
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

		#region Fips
		/// <summary>
		/// Gets or sets the fips.
		/// </summary>
		/// <value>The fips.</value>
		public string Fips
		{
			get{ return GetValue((int)eParmList.Fips).Trim(); }
			
		}
		#endregion
		
		
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Input,_parameterNames[(int)eParmList.Zip],"",System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Output,_parameterNames[(int)eParmList.Fips],"",System.Data.DbType.AnsiString);
		}
		#endregion

	
		/// <summary>
		/// Gets the fips from zip.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="Zip">The zip.</param>
		/// <returns></returns>
		public static string GetFipsFromZipCode (string instance, string Zip)
		{
			string results = String.Empty;
			try
			{
				if (Zip.Length > 0)
				{
					GetFipsFromZip Location = new GetFipsFromZip(instance);
					Location.Zip = Zip;
					if (Location.Execute())
					{
						results = Location.Fips;
					}
				}
			}
			catch(Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message,"GetFipsFromZip");
			}
			return results;
		}
	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/GetFipsFromZip.cs $
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     5/01/08 4:20p John.gwynn
 * trim results
 * 
 * 2     5/01/08 1:48p John.gwynn
 * added GetipFromCityState
 * 
 * 1     3/05/08 12:08p Jenny.cheung
 * 
 * 1     11/28/07 3:56p Jenny.cheung
 * Added for Staples account
 * 
 * 1     7/05/07 4:14p John.gwynn
 * support for Safety Policy Load - added AgentIdFromUploadKey 
 */
#endregion
