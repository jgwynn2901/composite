using System;
using System.Runtime.InteropServices;
using Microsoft.Practices.EnterpriseLibrary.Caching;

namespace DbClassLibrary.ActiveRecords
{
	/// <summary>
	/// repository with cache for LocationCode elements
	/// </summary>
	[ComVisible(false)]
	public sealed class LocationCodes : ActiveRecordSet
	{
		private static readonly ICacheManager SessionCache;

		static LocationCodes()
		{
			try
			{
				SessionCache = CacheFactory.GetCacheManager("DataAccessObjectCacheManager");
			}
			catch (Exception ex)
			{
				GeneralUtility.LogError(ex.Message, "LocationCodes");
			}
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationCodes"/> class.
		/// </summary>
		public LocationCodes()
			: base("LocationCode")
		{}

		/// <summary>
		/// Gets the primary location code for given zip code.
		/// </summary>
		public static LocationCode GetPrimaryLocationCodeForZip(string zip)
		{
			return GetPrimaryLocationCodeForZip(zip, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the primary location code for given zip code.
		/// </summary>
		public static LocationCode GetPrimaryLocationCodeForZip(string zip, string instance)
		{
			string usOrCanadaZipCode;
			
			if(!GeneralUtility.TryParseZipCode(zip,out usOrCanadaZipCode))
				return null;

			if (SessionCache != null && SessionCache.Contains(usOrCanadaZipCode))
				return SessionCache[usOrCanadaZipCode] as LocationCode;

			var results = new LocationCodes
			              	{
								Instance = instance,
			              		Query = "select * from LOCATION_CODE where zip = :zip_code and PRIMARY_LOC =  'Y'"
			              	};

			results.AddParameter("zip_code", usOrCanadaZipCode);

			if (results.Execute() && results.Count > 0)
				foreach (LocationCode code in results)
				{
					if (SessionCache != null)
					{
						lock (SessionCache)
						{
							if (!SessionCache.Contains(zip))
								SessionCache.Add(zip, code);
						}
					}
					return code;
				}

			return null;
		}

		/// <summary>
		/// Gets the fips from zip.
		/// </summary>
		public static string GetFipsFromZip(string zip)
		{
			return GetFipsFromZip(zip, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the county from zip.
		/// </summary>
		public static string GetCountyFromZip(string zip)
		{
			return GetCountyFromZip(zip, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the country from zip.
		/// </summary>
		public static string GetCountryFromZip(string zip)
		{
			return GetCountryFromZip(zip, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the city from zip.
		/// </summary>
		/// <returns></returns>
		public static string GetCityFromZip(string zip)
		{
			return GetCityFromZip(zip, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the state from zip.
		/// </summary>
		public static string GetStateFromZip(string zip)
		{
			return GetStateFromZip(zip, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the latitude from zip.
		/// </summary>
		public static string GetLatitudeFromZip(string zip)
		{
			return GetLatitudeFromZip(zip, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the longitude from zip.
		/// </summary>
		public static string GetLongitudeFromZip(string zip)
		{
			return GetLongitudeFromZip(zip, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the state of the zip from city.
		/// </summary>
		public static string GetZipFromCityState(string city, string state)
		{
			return GetZipFromCityState(city, state, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the fips from zip.
		/// </summary>
		public static string GetFipsFromZip(string zip, string instance)
		{
			var results = GetPrimaryLocationCodeForZip(zip, instance);
			return results != null ? results.Fips : "";
		}

		/// <summary>
		/// Gets the county from zip.
		/// </summary>
		public static string GetCountyFromZip(string zip, string instance)
		{
			var results = GetPrimaryLocationCodeForZip(zip, instance);
			return results != null ? results.County : "";
		}

		/// <summary>
		/// Gets the country from zip.
		/// </summary>
		public static string GetCountryFromZip(string zip, string instance)
		{
			var results = GetPrimaryLocationCodeForZip(zip, instance);
			return results != null ? results.Country : "";
		}

		/// <summary>
		/// Gets the latitude from zip.
		/// </summary>
		public static string GetLatitudeFromZip(string zip, string instance)
		{
			var results = GetPrimaryLocationCodeForZip(zip, instance);
			return results != null ? results.Lat : "";
		}

		/// <summary>
		/// Gets the longitude from zip.
		/// </summary>
		public static string GetLongitudeFromZip(string zip, string instance)
		{
			var results = GetPrimaryLocationCodeForZip(zip, instance);
			return results != null ? results.Lon : "";
		}

		/// <summary>
		/// Gets the state from zip.
		/// </summary>
		public static string GetStateFromZip(string zip, string instance)
		{
			var results = GetPrimaryLocationCodeForZip(zip, instance);
			return results != null ? results.State : "";
		}

		/// <summary>
		/// Gets the city from zip.
		/// </summary>
		public static string GetCityFromZip(string zip, string instance)
		{
			var results = GetPrimaryLocationCodeForZip(zip, instance);
			return results != null ? results.City : "";
		}

		/// <summary>
		/// Gets the state of the zip from city.
		/// </summary>
		public static string GetZipFromCityState(string city, string state, string instance)
		{
			var results = new LocationCodes
			              	{
			              		Instance = instance,
			              		Query =
			              			string.Format(
			              			"select * from LOCATION_CODE where CITY like '{0}%' and STATE = :state", city)
			};

			results.AddParameter("state", state);

			if (results.Execute() && results.Count > 0)
				foreach (LocationCode code in results)
					return code.Zip;

			return "";
		}
	}
}
