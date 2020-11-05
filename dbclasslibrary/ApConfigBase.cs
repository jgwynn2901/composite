using System;

namespace DbClassLibrary
{
  public class ApConfigBase
  {
    private static bool _initialized;

    public ApConfigBase()
    {
      InitializeConfiguration();
    }

    public static void InitializeConfiguration()
    {
      if (_initialized) return;
      _initialized = true;
      var appConfig = GeneralUtility.GetFnsRegistryKeyString("", "FnsBinDir") + "app.config";
      var current = AppDomain.CurrentDomain.GetData("APP_CONFIG_FILE");
      if (current != null && AppDomain.CurrentDomain.BaseDirectory.ToLower().Contains("fnsnet\\bin"))
      {
        GeneralUtility.DebugLog("configuration data for: " + AppDomain.CurrentDomain.FriendlyName + " at " + AppDomain.CurrentDomain.BaseDirectory, "FNSDispatch.ApplicationConfiguration");
        return;
      }
      GeneralUtility.DebugLog("Setting configuration data to " + appConfig, "ApConfigBase.ApplicationConfiguration");
      AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", appConfig);
    }

  }
}
