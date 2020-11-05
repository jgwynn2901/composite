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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/LocationCityFromZip.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates LocationCityFromZip stored proc using LOCATION_CODE table.
	/// </summary>
	[ComVisible(false)]	
	public sealed class LocationCityFromZip :DbBaseClass
	{
    // ReSharper disable once InconsistentNaming
		private enum eParmList 
		{
			ZipCode = 0,
			City,
// ReSharper disable once UnusedMember.Local
			ParmCount
		};
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationCityFromZip"/> class.
		/// </summary>
		public LocationCityFromZip():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationCityFromZip"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public LocationCityFromZip(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetCityFromZip";

			_parameterNames = new[]
				{
					"p_nZipCode",
					"p_nCity"
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
			//// ZipCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.ZipCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// City
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.City],"",System.Data.DbType.AnsiString);
		}	
		#endregion
		#region Public Properties
		
		/// <summary>
		/// Gets or sets the zip code.
		/// </summary>
		/// <value>The zip code.</value>
		public string ZipCode
		{
			get 
			{
				return GetValue((int)eParmList.ZipCode);
			}
			set 
			{
				SetValue((int)eParmList.ZipCode,value);
			}
		}
		/// <summary>
		/// Gets the zip city code.
		/// </summary>
		/// <value>The zip city code.</value>
		public string City
		{
			get 
			{
				return GetValue((int)eParmList.City);
			}
		}
		#endregion
		/// <summary>
		/// Gets the city from zip.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="zip">The zip.</param>
		/// <returns></returns>
		public static string GetCityFromZip (string instance, string zip)
		{
			var results = String.Empty;
			try
			{
				var location = new LocationCityFromZip(instance) {ZipCode = zip};
			  if(location.Execute())
				{
					results = location.City;
				}
			}
			catch(Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message,"GetCityFromZip");
			}
			return results;
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/LocationCityFromZip.cs $
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
