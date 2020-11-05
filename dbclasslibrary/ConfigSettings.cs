using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates GetAppSetting method that returns a value
	/// given an application and key (for instance level parameters)
	/// </summary>
	[ComVisible(false)]
	public class ConfigSettings : DbBaseClass
	{
		private enum ParmList
		{
			Application = 0,
			Key,
			Value
		};

	    /// <summary>
		/// Initializes a new instance of the <see cref="ConfigSettings"/> class.
		/// </summary>
		public ConfigSettings() : this(String.Empty)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="GetCountyFromZip"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public ConfigSettings(string instance) : base(instance)
		{
			_name = "DBClassLibrary.GetAppSetting";

			_parameterNames = new[] {
				"p_Application",
				"p_Key",
				"p_Results"
			};

			Initialize();
		}

		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override sealed void Initialize()
		{
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)ParmList.Application], "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)ParmList.Key], "", System.Data.DbType.AnsiString);
			AddParm(System.Data.ParameterDirection.Output, _parameterNames[(int)ParmList.Value], "", System.Data.DbType.AnsiString);
		}

		/// <summary>
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
		public string Application
		{
			get { return GetValue((int)ParmList.Application); }
			set { SetValue((int)ParmList.Application, value); }
		}

		/// <summary>
		/// Gets or sets the key.
		/// </summary>
		/// <value>The key.</value>
		public string Key
		{
			get { return GetValue((int)ParmList.Key); }
			set { SetValue((int)ParmList.Key, value); }
		}

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <value>The value.</value>
		public string Value
		{
			get { return GetValue((int)ParmList.Value); }
		}

		/// <summary>
		/// Gets the config setting.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="application">The application.</param>
		/// <param name="key">The key.</param>
		/// <returns></returns>
		public static string GetConfigSetting(string instance, string application, string key)
		{
			var results = String.Empty;
			try
			{
                GeneralUtility.DebugLog(string.Format("Retrieving {0} for {1}", key, instance), "GetConfigSetting");
                var config = new ConfigSettings(instance) { Application = application, Key = key };
			    if (config.Execute())
				{
					results = config.Value;
				}
			}
			catch (Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message, "GetConfigSetting");
			}
			return results;
		}

		/// <summary>
		/// Gets the config setting.
		/// </summary>
		/// <param name="application">The application.</param>
		/// <param name="key">The key.</param>
		/// <returns></returns>
		public static string GetConfigSetting(string application, string key)
		{
			return GetConfigSetting(ApplicationConfiguration.Instance.DefaultInstance, application, key);
		}
	}
}
