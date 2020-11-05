using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace FnsUtility
{
    /// <summary>
    /// aggregation all current configuration tasks here
    /// to provide consistency across all applications.
    /// </summary>
    public static class ConfigurationReader
    {

        /// <summary>
        /// Gets the configuration properties.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<FnsComposite.Monads.Tuple<string, string>> GetConfigurationProperties()
        {
            var configurationTypes = from a in AppDomain.CurrentDomain.GetAssemblies()
                                     from t in a.GetTypes()
                                     where t.Name.Contains("ApplicationConfiguration")
                                     select t;

            return from t in configurationTypes
                   select t.GetProperty("Instance", BindingFlags.Static | BindingFlags.Public) into instanceProperty
                   where instanceProperty != null
                   select instanceProperty.GetGetMethod() into results
                   where results != null
                   select results.Invoke(null, null) into instance
                   where instance != null
                   let properties = (from p in instance.GetType().GetProperties()
                                     where p.Name != "Instance"
                                     select p)
                   from p in properties
                   let getMethod = p.GetGetMethod()
                   where getMethod != null
                   select new FnsComposite.Monads.Tuple<string, string>(p.Name, getMethod.Invoke(instance, null).ToString());
        }

        /// <summary>
        /// Gets the global app config value for the current instance.
        /// Use this to get a config setting to override
        /// production instance filter. (OPM)
        /// </summary>
        public static string GetGlobalAppConfigValue(string name)
        {
            return GetGlobalAppConfigValue(name, GeneralUtility.InstanceFromRegistry);
        }

        /// <summary>
        /// Gets the global app config value.
        /// Use this to get a config setting regardless 
        /// of whether or not it is a production instance. (OPM)
        /// </summary>
        /// <returns></returns>
        public static string GetGlobalAppConfigValue(string name, string instance)
        {
            var results =
                GetSettingFromDatabase(name, instance) ?? GetSetting(name);
            ErrorLog.DebugLog(string.Format("Retrieving {0} = {1} from {2}", name, results, instance), "GetGlobalAppConfigValue");
            return results;
        }


        /// <summary>
        /// Gets the app config value.
        /// </summary>
        public static string GetAppConfigValue(string name)
        {
            var results =
                GetSettingFromNonProductionDatabase(name) ?? GetSetting(name);
            ErrorLog.DebugLog(string.Format("Retrieving {0} = {1}", name, results), "GetAppConfigValue");
            return results;
        }

        private static string GetSetting(string key)
        {
            return string.IsNullOrEmpty(ConfigurationManager.AppSettings[key]) ?
               string.Empty : ConfigurationManager.AppSettings[key];
        }

        private static string GetSettingFromNonProductionDatabase(string key)
        {
            return GeneralUtility.IsProduction
                ? default(string)
                : GetSettingFromDatabase(key, GeneralUtility.InstanceFromRegistry);
        }


        private static string GetSettingFromDatabase(string key, string instance)
        {
            try
            {
                using (var settings = new DbClassLibrary.ActiveRecords.ConfigSettings
                {
                    Instance = instance,
                    Query = "select * from config_settings where KEY = :key"
                })
                {
                    settings.AddParameter("key", key);

                    var weakKey = ErrorLog.GetProcessName().ToUpper();
                    var machineKey = Environment.MachineName.ToUpper();
                    var strongKey = machineKey + "." + weakKey;

                    var listResults =
                      settings.Results().Where(a => a.Application.ToUpper().Contains(weakKey) ||
                                                    a.Application.ToUpper().Contains(machineKey)).ToList();

                    if (listResults.Count == 0) return default(string);

                    return
                      listResults
                        .Where(a => a.Application.ToUpper() == strongKey)
                        .Select(a => a.ConfigValue).FirstOrDefault() ??
                      listResults
                        .Where(a => a.Application.ToUpper() == machineKey)
                        .Select(a => a.ConfigValue).FirstOrDefault() ??
                      listResults
                        .Where(a => a.Application.ToUpper() == weakKey)
                        .Select(a => a.ConfigValue).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                ErrorLog.DebugLog(ex.Message, "GetAppConfigValue");
                return default(string);
            }
        }
    }
}
