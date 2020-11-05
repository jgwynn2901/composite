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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/GetZipFromCityState.cs 3     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class GetZipFromCityState : DbBaseClass
	{
		private enum eParmList
		{
			City = 0,
			State,
			Zip
		};

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="GetZipFromCityState"/> class.
		/// </summary>
		public GetZipFromCityState(): this(String.Empty)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="GetZipFromCityState"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public GetZipFromCityState(string instance)
			: base(instance)
		{
			_name = "DBCLASSLIBRARY.GetZipFromCityState";

			_parameterNames = new string[] {
				"P_NCITY",
				"P_NSTATE",
				"P_NZIP"
			};

			Initialize();
		}
		#endregion

		#region City
		/// <summary>
		/// Gets or sets the ncity.
		/// </summary>
		/// <value>The ncity.</value>
		public string City
		{
			get { return GetValue((int)eParmList.City); }
			set { SetValue((int)eParmList.City, value); }
		}
		#endregion

		#region State
		/// <summary>
		/// Gets or sets the nstate.
		/// </summary>
		/// <value>The nstate.</value>
		public string State
		{
			get { return GetValue((int)eParmList.State); }
			set { SetValue((int)eParmList.State, value); }
		}
		#endregion

		#region Zip
		/// <summary>
		/// Gets or sets the nzip.
		/// </summary>
		/// <value>The nzip.</value>
		public string Zip
		{
			get { return GetValue((int)eParmList.Zip).Trim(); }
		}
		#endregion

		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.City], "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.State], "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Output, _parameterNames[(int)eParmList.Zip], "", System.Data.DbType.AnsiString);
		}
		#endregion

		/// <summary>
		/// Gets the zip from city state instance.
		/// </summary>
		/// <param name="city">The city.</param>
		/// <param name="state">The state.</param>
		/// <param name="instance">The instance.</param>
		/// <returns></returns>
		public static string GetZipFromCityStateInstance(string city, string state, string instance)
		{
			string results = String.Empty;
			try
			{
				if (city.Length > 0 && state.Length == 2)
				{
					GetZipFromCityState location = new GetZipFromCityState(instance);
					location.City = city.ToUpper();
					location.State = state.ToUpper();

					if (location.Execute())
					{
						results = location.Zip;
					}
				}
			}
			catch (Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message, "GetZipFromCityStateInstance");
			}
			return results;
		}
	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/GetZipFromCityState.cs $
 * 
 * 3     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 2     5/01/08 4:20p John.gwynn
 * trim results
 * 
 * 1     5/01/08 1:48p John.gwynn
 * added GetipFromCityState
 */
#endregion
