using System;
using Microsoft.Win32;

namespace DbClassLibrary
{
  /// <summary>
  /// encapsulate all named instance and connection string conversions
  /// </summary>
  public static class DatabaseInstance
  {
    private static readonly object SynchLock = new object();

    // ReSharper disable InconsistentNaming
    /// <summary>
    /// FNSP database instance
    /// </summary>
    public static string FNSP = "FNSP";
    /// <summary>
    /// FNSBA database instance
    /// </summary>
    public static string FNSBA = "FNSBA";
    /// <summary>
    /// FNQA database instance
    /// </summary>
    public static string FNSQA = "FNSQA";

    /// <summary>
    /// AMEBA database instance
    /// </summary>
    public static string AMEBA = "AMEBA";
    /// <summary>
    /// AMEQA database instance
    /// </summary>
    public static string AMEQA = "AMEQA";
    /// <summary>
    /// AMEPP database instance
    /// </summary>
    public static string AMEPP = "AMEPP";
    /// <summary>
    /// AMEP database instance
    /// </summary>
    public static string AMEP = "AMEP";
    /// <summary>
    /// ESUBA database instance
    /// </summary>
    public static string ESUBA = "ESUBA";
    /// <summary>
    /// ESUQA database instance
    /// </summary>
    public static string ESUQA = "ESUQA";
    /// <summary>
    /// ESUPP database instance
    /// </summary>
    public static string ESUPP = "ESUPP";
    /// <summary>
    /// ESUP database instance
    /// </summary>
    public static string ESUP = "ESUP";

    /// <summary>
    /// SEDBA database instance
    /// </summary>
    public static string SEDBA = "SEDBA";
    /// <summary>
    /// SEDQA database instance
    /// </summary>
    public static string SEDQA = "SEDQA";
    /// <summary>
    /// SEDPP database instance
    /// </summary>
    public static string SEDPP = "SEDPP";
    /// <summary>
    /// SEDP database instance
    /// </summary>
    public static string SEDP = "SEDP";

    /// <summary>
    /// SELBA database instance
    /// </summary>
    public static string SELBA = "SELBA";
    /// <summary>
    /// SELQA database instance
    /// </summary>
    public static string SELQA = "SELQA";
    /// <summary>
    /// SELPP database instance
    /// </summary>
    public static string SELPP = "SELPP";
    /// <summary>
    /// SELP database instance
    /// </summary>
    public static string SELP = "SELP";

    /// <summary>
    /// SENBA database instance
    /// </summary>
    public static string SENBA = "SENBA";
    /// <summary>
    /// SENQA database instance
    /// </summary>
    public static string SENQA = "SENQA";
    /// <summary>
    /// SENPP database instance
    /// </summary>
    public static string SENPP = "SENPP";
    /// <summary>
    /// SENP database instance
    /// </summary>
    public static string SENP = "SENP";
    /// <summary>
    /// SENBA database instance
    /// </summary>
    public static string TOWBA = "TOWBA";
    /// <summary>
    /// SENQA database instance
    /// </summary>
    public static string TOWQA = "TOWQA";
    /// <summary>
    /// SENPP database instance
    /// </summary>
    public static string TOWPP = "TOWPP";
    /// <summary>
    /// SENP database instance
    /// </summary>
    public static string TOWP = "TOWP";
    // ReSharper restore InconsistentNaming

    private static string _instanceFromRegistry;

    /// <summary>
    /// use this to pass dates parms as strings for stored procs
    /// unless you want to write the datetime conversions to oracle
    /// which shouldn't be hard but are we not tired of hand rolled orms yet?
    /// </summary>
    public static string DatabaseDateFormat = "yyyyMMdd HH:mm:ss";

    /// <summary>
    /// Instances from registry.
    /// </summary>
    /// <returns></returns>
    public static string InstanceFromRegistry()
    {
      return InstanceFromRegistry(true);
    }

    private static string InstanceFromRegistry(bool useCache)
    {
      GeneralUtility.DebugLog("InstanceFromRegistry entered.", "DatabaseInstance");
      if (useCache && !string.IsNullOrEmpty(_instanceFromRegistry))
        return _instanceFromRegistry;
      using (var rkFns = Registry.LocalMachine.OpenSubKey("Software\\Edgewater\\FNS\\"))
      {
        lock (SynchLock)
        {
          OdbcDsn dsn = null;
          if (rkFns == null) return string.Empty;
          var results = rkFns.GetValue("ConnectString").ToString();
          GeneralUtility.DebugLog("results = " + results, "DatabaseInstance");
          try
          {
            dsn = OdbcDsn.CreateFromEncypted(results);
          }
          catch (Exception ex)
          {
            GeneralUtility.DebugLog("Error: " + ex.Message, "InstanceFromRegistry");
          }
          if (dsn == null)
          {
            GeneralUtility.LogError(string.Format("Error decrypting registry value={0}", results),
              "InstanceFromRegistry");
            return results.Length == 0
              ? results
              : new OdbcDsn(results).Server;
          }
          GeneralUtility.DebugLog("Decrypted results = " + dsn.ToDisplayString(), "DatabaseInstance");
          var instance = dsn.Server;
          if (useCache)
            _instanceFromRegistry = instance;
          return instance;
        }
      }
    }
  }
}
