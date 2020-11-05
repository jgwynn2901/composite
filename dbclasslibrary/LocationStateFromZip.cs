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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/LocationStateFromZip.cs 6     10/12/09 5:42p John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates the procedure that derives STATE from LOCATION_CODE table for given ZIP 
	/// </summary>
	[ComVisible(false)]	
	public class LocationStateFromZip :DbBaseClass
	{
		private enum eParmList 
		{
			ZipCode = 0,
			State,
			parmCount
		};
		
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationStateFromZip"/> class.
		/// </summary>
		public LocationStateFromZip():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationStateFromZip"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public LocationStateFromZip(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetStateFromZip";

			_parameterNames = new string[]
				{
					"p_nZipCode",
					"p_nState"
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
			///// State
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.State],"",System.Data.DbType.AnsiString);
		}	
		#endregion
		#region ZipCode
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
		#endregion
		#region State
		/// <summary>
		/// Gets the zip State code.
		/// </summary>
		/// <value>The zip State code.</value>
		public string State
		{
			get 
			{
				return GetValue((int)eParmList.State);
			}
		}
		#endregion
		#region GetStateFromZip

		/// <summary>
		/// Gets the State from zip code.
		/// </summary>
		public static string GetStateFromZip(string zip)
		{
			return GetStateFromZip(ApplicationConfiguration.Instance.DefaultInstance, zip);
		}

		/// <summary>
		/// Gets the State from zip override instance (FIRST for backward compatible).
		/// </summary>
		public static string GetStateFromZip (string instance, string zip)
		{
			string results = String.Empty;
			try
			{
				LocationStateFromZip location = new LocationStateFromZip(instance);
				location.ZipCode = zip;
				if(location.Execute())
				{
					results = location.State.Trim();
				}
			}
			catch(Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message,"GetStateFromZip");
			}
			return results;
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/LocationStateFromZip.cs $
 * 
 * 6     10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 5     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 4     2/26/09 4:00p John.gwynn
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 2     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 1     11/14/06 10:25a John.gwynn
 * Retrieves State from given ZipCode (for ALM policy load)
 */
#endregion
