#region File Header
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
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/GeneralUtility.cs 59    10/14/11 11:31a Gwynnj $ */
#endregion
#region References
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using DbClassLibrary;
using FnsComposite.Monads;
using System.Collections.Generic;
using System.Globalization;

#endregion

[assembly: ComVisible(false)]
namespace FnsUtility
{
  /// <summary>
  /// Summary description for GeneralUtility.
  /// </summary>
  public static class GeneralUtility
  {
    private const string Source = "GeneralUtility";
    // ReSharper disable InconsistentNaming
    private static string binDir = "";
    // ReSharper restore InconsistentNaming
    ///<summary>
    /// Delegate for the EncrpytValue/DecryptValue method to use 
    ///</summary>
    public delegate string EncryptMethod(string symmProvider, string value);


    #region static public string InstanceFromRegistry
    /// <summary>
    /// return the database instance configuration name 
    /// from the old registry settings
    /// </summary>
    /// <returns></returns>
    static public string InstanceFromRegistry
    {
      get
      {
        return DatabaseInstance.InstanceFromRegistry();
      }
    }

    static public string ExtractInstanceFromConnectString(string instance)
    {
      return DbClassLibrary.GeneralUtility.ExtractInstanceFromConnectString(instance);
    }

    static public string ProductionInstanceFromRegistry
    {
      get
      {
        return DbClassLibrary.GeneralUtility.ProductionInstanceFromRegistry;
      }
    }

    #endregion

    /// <summary>
    /// returns the default conenction string in the registry
    /// </summary>
    static public string ConnectString
    {
      get
      {
        return GetFnsRegistryKeyString("", "ConnectString");
      }
    }

    /// <summary>
    /// Gets the Fns bin directory.
    /// </summary>
    /// <value>The bin dir.</value>
    static public string BinDir
    {
      get
      {
        if (binDir.Length == 0)
          binDir = GetFnsRegistryKeyString("", "FnsBinDir");
        return binDir;
      }
    }

    #region static public string GetDsnFromInstance
    /// <summary>
    /// Gets the DSN from instance.
    /// </summary>
    /// <returns></returns>
    static public string GetDsnFromInstance()
    {
      return GetDsnFromInstance(InstanceFromRegistry);
    }

    /// <summary>
    /// Gets the DSN from instance.
    /// </summary>
    /// <param name="request">the requested instance</param>
    /// <returns></returns>
    static public string GetDsnFromInstance(string request)
    {
      var instance = request.ToUpper();
      var results = String.Format("DSN={0};UID=FNSOWNER;PWD={1};SERVER={2}", instance,
                          GetPasswordFromInstance(instance), instance);
      ErrorLog.DebugLog(String.Format("GetDsnFromInstance returning {0}", results), Source);
      return results;
    }
    #endregion

    #region static public string GetFormattedConnectStringFromRegistry
    /// <summary>
    /// Gets the formatted connect string from registry.
    /// </summary>
    /// <returns></returns>
    static public string GetFormattedConnectStringFromRegistry()
    {
      var results = String.Empty;
      var instance = InstanceFromRegistry;

      if (!string.IsNullOrEmpty(instance))
      {
        results = String.Format("Data Source={0};User Id={1};password={2}",
            instance, "FNSOWNER", GetPasswordFromInstance(instance));
      }
      return results;
    }
    #endregion

    #region static public string GetFnsRegistryKeyString
    /// <summary>
    /// Gets the FNS registry key string.
    /// </summary>
    /// <param name="subKey">The sub key.</param>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public string GetFnsRegistryKeyString(string subKey, string value)
    {
      var results = DbClassLibrary.GeneralUtility.GetFnsRegistryKeyString(subKey, value);
      if (string.IsNullOrEmpty(subKey) && value.Equals("ConnectString", StringComparison.InvariantCultureIgnoreCase))
        return EncryptConnectStringPassword(results, InternalDecryptValue);
      return results;
    }

    /// <summary>
    /// does the registry key exist?
    /// </summary>
    public static bool SubkeyExists(string subkey)
    {
      return DbClassLibrary.GeneralUtility.SubkeyExists(subkey);
    }

    /// <summary>
    /// Encrypts/Decrypts the connect string password.
    /// </summary>
    public static string EncryptConnectStringPassword(string results, EncryptMethod method)
    {
      var parameters = results.Split(";".ToCharArray(), 4, StringSplitOptions.RemoveEmptyEntries);
      foreach (var s in parameters)
      {
        var password = s.Split("=".ToCharArray());
        if (!password[0].Equals("PWD", StringComparison.InvariantCultureIgnoreCase)) continue;
        var validPassword = new Regex("^ctown_", RegexOptions.IgnoreCase);
        if (!validPassword.IsMatch(password[1]))
          return string.Format("{0};{1};PWD={2};{3}",
              parameters[0],
              parameters[1],
              method(DbClassLibrary.GeneralUtility.SymmProvider, password[1]), parameters[3]);
      }
      return results;
    }
    #endregion

    #region static public string SetFnsRegistryKeyString
    /// <summary>
    /// Sets the FNS registry key string.
    /// </summary>
    static public bool SetFnsRegistryKeyString(string subKeyName, string value)
    {
      return DbClassLibrary.GeneralUtility.SetFnsRegistryKeyString(subKeyName, value);
    }
    #endregion

    #region static public string MachineName
    /// <summary>
    /// Gets the name of the this machine.
    /// </summary>
    /// <returns></returns>
    static public string MachineName
    {
      get
      {
        return Environment.MachineName;
      }
    }

    #endregion

    #region static public string GetRquId
    /// <summary>
    /// Gets the rqUID.
    /// </summary>
    /// <param name="callId">The call id.</param>
    /// <returns></returns>
    static public string GetRquId(string callId)
    {
      var results = new StringBuilder();
      results.Append(Guid.NewGuid().ToString().Substring(0, 24).ToUpper());
      if (callId.Length < 12)
        results.Append(callId.PadLeft(12, '0'));

      return results.ToString();
    }
    #endregion

		/// <summary>
		/// Gets the request rquid from the call if it exists.
		/// Otherwise it creates and sets it.
		/// </summary>
		static public string GetRequestRquId(FnsInterfaces.ICall call)
		{
			var results = call.GetValue(BaseWebEngine.RequestRquidAttribute);
			if (!string.IsNullOrEmpty(results)) return results;
			results = GetRquId(call.lCallId.ToString(CultureInfo.InvariantCulture));
			call.SetValue(BaseWebEngine.RequestRquidAttribute, results);
			return results;
		}

    #region static public string ExecuteMethod
    /// <summary>
    /// Executes the method.
    /// </summary>
    /// <param name="method">The method.</param>
    /// <param name="parms">The parms.</param>
    /// <returns></returns>
    static public string ExecuteMethod(string method, string parms)
    {
      var results = String.Empty;

      try
      {
        const string delimiter = ".";
        var program = method.Split(delimiter.ToCharArray(), 6, StringSplitOptions.RemoveEmptyEntries);
        object[] requestedParameters = { parms };

        try
        {
          ErrorLog.DebugLog(String.Format("ExecuteMethod entered for {0}", method), Source);
          if (program.Length < 3)
            throw new ArgumentException(String.Format("ExecuteMethod requires Assemby.Class.Method format: {0},", method));

          var requestedAssembly = Assembly.Load(program[0]);
          Assert.Test(requestedAssembly != null, string.Format("could not locate assembly: {0},", program[0]));

          ErrorLog.DebugLog(String.Format("Assembly loaded: {0}", program[0]), Source);
          var typeName = new StringBuilder();
          for (var i = 0; i < (program.Length - 1); ++i)
          {
            if (i > 0)
              typeName.Append(".");

            typeName.Append(program[i]);
          }
          if (requestedAssembly != null)
          {
            var requestedType = requestedAssembly.GetType(typeName.ToString());
            Assert.Test(requestedType != null, string.Format("could not locate assembly type: {0},", typeName));

            ErrorLog.DebugLog(String.Format("Type loaded: {0}", typeName), Source);
            const BindingFlags bf = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |
                                    BindingFlags.Static | BindingFlags.ExactBinding;

            if (requestedType != null)
            {
              var requestedConstructor = requestedType.GetConstructor(Type.EmptyTypes);
              object request = null;
              if (requestedConstructor != null)
              {
                request = requestedConstructor.Invoke(null);
                Assert.Test(request != null, string.Format("could not Invoke: {0},", typeName));

              }
              var methodIndex = program.Length - 1;
              ErrorLog.DebugLog(String.Format("Constructor Invoked: {0}", typeName), Source);

              var classType = request == null ? requestedType : request.GetType();
              var methInfo = classType.GetMethod(program[methodIndex], bf, null, new[] { typeof(string) }, null);

              Assert.Test(methInfo != null,
                          string.Format("could not find method: {0} for type: {1},", program[methodIndex], typeName));

              ErrorLog.DebugLog(String.Format("Method {0} retrieved.", program[methodIndex]), Source);
              if (methInfo != null)
              {
                var returnObject = methInfo.Invoke(request, requestedParameters);
                ErrorLog.DebugLog(String.Format("Method {0} Invoked.", program[methodIndex]), Source);

                if (returnObject != null)
                  results = returnObject as string;
              }
            }
          }
        }
        catch (TargetInvocationException ex)
        {
          throw ex.InnerException;
        }
      }
      catch (Exception ex)
      {
        var errorMessage = ex.Message.Substring(0, Math.Min(ex.Message.Length, 255));
        results = String.Format("<ERROR>{0}</ERROR>", errorMessage);
        ErrorLog.LogError(String.Format("Error in ExecuteMethod({0}): {1}", method, errorMessage), Source);
      }
      return results;
    }
    #endregion

    #region static public byte[] ConvertStringToUTF8ByteArray
    /// <summary>
    /// Converts the string to UTF8 byte array.
    /// </summary>
    /// <param name="stringToConvert">The string to convert.</param>
    /// <returns></returns>
    // ReSharper disable InconsistentNaming
    public static byte[] ConvertStringToUTF8ByteArray(string stringToConvert)
    // ReSharper restore InconsistentNaming
    {
      var encoder = new UTF8Encoding();
      return encoder.GetBytes(stringToConvert);
    }
    #endregion

    #region static public byte[] ConvertStringToByteArray
    /// <summary>
    /// Converts the string to byte array.
    /// </summary>
    /// <param name="stringToConvert">The string to convert.</param>
    /// <returns></returns>
    public static byte[] ConvertStringToByteArray(string stringToConvert)
    {
      var encoder = new UnicodeEncoding();
      return encoder.GetBytes(stringToConvert);
    }
    #endregion

    static public string ConvertDateStringFromTo(string from, string to, string date)
    {
      if (!string.IsNullOrEmpty(date))
      {
        DateTime result;

        if (DateTime.TryParseExact(date, from, new CultureInfo("en-US"), DateTimeStyles.None, out result))
          return result.ToString(to);
      }
      return date;
    }

    #region IsClientProperties

    #region IsSelective
    /// <summary>
    /// Determines whether this instance is selective.
    /// </summary>
    /// <returns>
    /// 	<c>true</c> if this instance is selective; otherwise, <c>false</c>.
    /// </returns>
    static public bool IsSelective
    {
      get
      {
        return InstanceFromRegistry.StartsWith("SEL", StringComparison.InvariantCultureIgnoreCase);
      }
    }
    #endregion

    #region IsAmeriprise
    /// <summary>
    /// Determines whether this instance is selective.
    /// </summary>
    /// <returns>
    /// 	<c>true</c> if this instance is selective; otherwise, <c>false</c>.
    /// </returns>
    static public bool IsAmeriprise
    {
      get
      {
        return false;
      }
    }
    #endregion

    #region IsCISG

    /// <summary>
    /// Determines whether the registered instance is a CISG instance.
    /// </summary>
    // ReSharper disable InconsistentNaming
    static public bool IsCISG
    // ReSharper restore InconsistentNaming
    {
      get
      {
        return false;
      }
    }
    #endregion


    #region IsCrawford

    /// <summary>
    /// Determines whether the registered instance is a Crawford instance.
    /// </summary>
    static public bool IsCrawford
    {
      get
      {
        return false;
      }
    }
    #endregion

    #region IsSentry

    /// <summary>
    /// Determines whether the registered instance is a Sentry instance.
    /// </summary>
    static public bool IsSentry
    {
      get
      {
        return InstanceFromRegistry.StartsWith("SEN", StringComparison.InvariantCultureIgnoreCase);
      }
    }
    #endregion

    #region IsSedgewick

    /// <summary>
    /// Determines whether the registered instance is an Sedgewick instance.
    /// </summary>
    static public bool IsSedgewick
    {
      get
      {
        return InstanceFromRegistry.StartsWith("SED", StringComparison.InvariantCultureIgnoreCase);
      }
    }
    #endregion

    #region IsEsurance

    /// <summary>
    /// Determines whether the registered instance is an Esurance instance.
    /// </summary>
    static public bool IsEsurance
    {
      get
      {
        return false;
      }
    }
    #endregion

    #region IsTower

    /// <summary>
    /// Determines whether the registered instance is a Tower instance.
    /// </summary>
    static public bool IsTower
    {
      get
      {
        return InstanceFromRegistry.StartsWith("TOW", StringComparison.InvariantCultureIgnoreCase);
      }
    }
    #endregion
    #endregion

    #region IsProduction
    /// <summary>
    /// Gets a value indicating whether this instance is production.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is production; otherwise, <c>false</c>.
    /// </value>
    static public bool IsProduction
    {
      get
      {
        return PasswordFromRegistry.Equals("ctown_prod");
      }
    }
    /// <summary>
    /// Gets the password from instance.
    /// </summary>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static private string GetPasswordFromInstance(string instance)
    {
      return new ConnectString(DbClassLibrary.GeneralUtility.GetConnectStringFromInstance(instance)).Password;
    }
    #endregion

    static public string GetMachineRedirect()
    {
        var result = ConfigurationReader.GetGlobalAppConfigValue("MachineName");
        return string.IsNullOrEmpty(result) ? MachineName : result;
    }

    /// <summary>
    /// Decrypts the value using the default FNS key.
    /// </summary>
    static public string DecryptValue(string value)
    {
      try
      {
        return DbClassLibrary.GeneralUtility.DecryptValue(value);
      }
      catch (Exception ex)
      {
        ErrorLog.LogInfo("VALUE=" + value + " " + ex.Message, "DecryptValue");
      }
      return value;
    }

    /// <summary>
    /// Encrypts the value using the default FNS key.
    /// </summary>
    static public string EncryptValue(string value)
    {
      try
      {
        if (!string.IsNullOrEmpty(value))
          return DbClassLibrary.GeneralUtility.EncryptValue(value);
      }
      catch (Exception ex)
      {
        ErrorLog.LogInfo("VALUE=" + value + " " + ex.Message, "EncryptValue");
      }
      return value;
    }

    /// <summary>
    /// Encrypts the value.
    /// </summary>
    /// <param name="provider">The provider.</param>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public string EncryptValue(string provider, string value)
    {
      try
      {
        if (!string.IsNullOrEmpty(value))
          return DbClassLibrary.GeneralUtility.EncryptValue(provider, value);
      }
      catch (Exception ex)
      {
        ErrorLog.LogInfo("VALUE=" + value + " " + ex.Message, "EncryptValue");
      }
      return value;
    }

    /// <summary>
    /// Decrypts the value.
    /// </summary>
    /// <param name="provider">The provider.</param>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public string DecryptValue(string provider, string value)
    {
      return DbClassLibrary.GeneralUtility.DecryptValue(provider, value);
    }

    /// <summary>
    /// Internals the decrypt value.
    /// </summary>
    /// <param name="provider">The provider.</param>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public string InternalDecryptValue(string provider, string value)
    {
      return DbClassLibrary.GeneralUtility.InternalDecryptValue(provider, value);
    }
    /// <summary>
    /// Internals the encrypt value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public string InternalEncryptValue(string value)
    {
      return DbClassLibrary.GeneralUtility.InternalEncryptValue(value);
    }

    /// <summary>
    /// Gets the app config value.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns></returns>
    public static string GetAppConfigValue(string name)
    {
      return ConfigurationReader.GetAppConfigValue(name);
    }

    /// <summary>
    /// Gets the app config value int.
    /// </summary>
    public static int? GetAppConfigValueInt(string key)
    {
      int results;
      if (int.TryParse(GetAppConfigValue(key), out results))
        return results;
      return null;
    }

    /// <summary>
    /// 
    /// </summary>
    static public string PasswordFromRegistry
    {
      get
      {
        var results = String.Empty;
        var dsn = GetFnsRegistryKeyString("", "ConnectString");
        var parms = dsn.Split(new[] { ';' });

        return parms.Length > 3 ? parms[2].Split(new[] { '=' })[1].ToLower() : results;
      }
    }

    /// <summary>
    /// Converts the string to int or null.
    /// </summary>
    public static int? ConvertStringToIntOrNull(string val)
    {
      int results;

      if (int.TryParse(val, out results))
        return results;
      return null;
    }

    /// <summary>
    /// HTMLs the encode char.
    /// </summary>
    public static string HtmlEncodeChar(char c)
    {
      var val = (int)c;

      if (val > 31 && val < 128)
        return string.Format("&#{0};", val);

      return c.ToString(CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// HTMLs the decode char.
    /// </summary>
    public static string HtmlDecodeChar(string pattern)
    {
      var start = pattern.IndexOf(";", StringComparison.Ordinal);
      if (start > -1)
      {
        var ascii = pattern.Substring(2, pattern.Length - 3);
        int results;
        if (int.TryParse(ascii, out results))
          return ((char)results).ToString(CultureInfo.InvariantCulture);
      }
      return "";
    }

    /// <summary>
    /// Adds the range.
    /// </summary>
    public static NameValueCollection AddRange(this NameValueCollection dest, NameValueCollection source)
    {
      foreach (string s in source.Keys)
        dest.Set(s, source[s]);
      return dest;
    }

    /// <summary>
    /// Gets the constructor delegate of type T 
    /// where T is a class and has default constructor.
    /// </summary>
    public static Func<T> GetConstructor<T>() where T : class, new()
    {
      var constructorInfo = typeof(T).GetConstructor(new Type[0]);
      if (constructorInfo != null)
        return Expression.Lambda<Func<T>>(Expression.New(constructorInfo))
          .Compile();
      return null;
    }

    /// <summary>
    /// Gets the configuration properties for the current set 
    /// of loaded assemblies.
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<Tuple<string, string>> GetConfigurationProperties()
    {
      return ConfigurationReader.GetConfigurationProperties();
    }

    public static bool IsSystemEnhancementDay(int startMonth, int monthInterval, string dayofweek, int numdayofweek)
    {
      var isSystemEnhancementDay = false;
      try
      {
        var currentDayofweek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayofweek);
        var numDayofweek = numdayofweek;
        var monthToday = DateTime.Now.Month;
        if ((monthToday - startMonth) % monthInterval == 0) // if every other mnth , it should be even since start month is even
        {
          var d = DateTime.Today.Day;
          isSystemEnhancementDay = DateTime.Today.DayOfWeek == currentDayofweek && (d / 7 == numDayofweek || (d / 7 == (numDayofweek - 1) && d % 7 > 0));
        }
        return isSystemEnhancementDay;
      }
      catch (Exception ex)
      {
        ErrorLog.LogError("IsSystemEnhancementDay " + ex.Message, new CallingMethod());
        return isSystemEnhancementDay;
      }

    }

    public static byte[] GetBytes(string str)
    {
      var bytes = new byte[str.Length * sizeof(char)];
      Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
      return bytes;
    }

    public static string GetString(byte[] bytes)
    {
      var chars = new char[bytes.Length / sizeof(char)];
      Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
      return new string(chars);
    }
    /// <summary>
    /// Determines whether [is between maintenance time] [the specified dayofweek].
    /// N.B. really should not be here...JJG
    /// </summary>
    /// <param name="dayofweek">The dayofweek.</param>
    /// <param name="starttime">The starttime.</param>
    /// <param name="endtime">The endtime.</param>
    /// <returns></returns>
    public static bool IsBetweenMaintenanceTime(string dayofweek, string starttime, string endtime)
    {
      // Get the current server time since the zone conversion logic, first converts it to UTC and then to desired time zone.
      var currentUtcDateTime = DateTime.UtcNow.ToUniversalTime();
      DateTime? rentalBranchTimeZone = currentUtcDateTime.ToLocalTime();
      //Central
      rentalBranchTimeZone = TimeZoneInformation.ConvertDateTimeToTimeZone("u", rentalBranchTimeZone.ToString(), "Central Standard Time");
      ErrorLog.DebugLog("IsBetweenMaintenanceTime RentalBranchTime: " + rentalBranchTimeZone + "starttime: " + starttime + " end times: " + endtime, "test");

      // Current day of the week:
      //DayOfWeek day = RentalBranchTimeZone.Value.DayOfWeek;
      if (rentalBranchTimeZone != null && rentalBranchTimeZone.Value.DayOfWeek.Equals((DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayofweek)))
      {
        TimeSpan startinterval;
        TimeSpan endinterval;

        if ((TimeSpan.TryParse(starttime, out startinterval)) && TimeSpan.TryParse(endtime, out endinterval))
        {
          if (endinterval == startinterval)
            return true;
          if (endinterval < startinterval)
          {
            return rentalBranchTimeZone.Value.TimeOfDay <= endinterval && rentalBranchTimeZone.Value.TimeOfDay >= startinterval;
          }
          return rentalBranchTimeZone.Value.TimeOfDay >= startinterval && rentalBranchTimeZone.Value.TimeOfDay <= endinterval;
        }
      }
      return false;
    }

    /// <summary>
    /// Determines whether [is numeric string] [the specified values].
    /// </summary>
    /// <param name="values">The value to test.</param>
    /// <returns></returns>
    static public bool IsNumeric(string values)
    {
      var isNumeric = false;
      foreach (var value in values)
      {
        isNumeric = ((value >= '0' && value <= '9'));
        if (!isNumeric) break;
      }
      return isNumeric;
    }

    /// <summary>
    /// Determines whether [is encrypt raw] [the specified value].
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public bool IsEncryptRaw(string value)
    {
      // if just numeric not necessarily hex -must have A-F values typical for encryption
      // N.B. Canadian postal codes can pass this test as can other data
      // so use with caution...
      return !IsNumeric(value) && IsHex(value);
    }
    /// <summary>
    /// Determines whether values [is hexadecimal string] [the specified string].
    /// </summary>
    /// <param name="values">The value to test.</param>
    /// <returns></returns>
    static public bool IsHex(string values)
    {
      // hex values must be in bytes
      if (values.Length % 2 != 0)
        return false;

      var isHex = false;
      foreach (var value in values)
      {
        isHex = ((value >= '0' && value <= '9') ||
                 (value >= 'a' && value <= 'f') ||
                 (value >= 'A' && value <= 'F'));

        if (!isHex) break;
      }
      return isHex;
    }

    /// <summary>
    /// Convert string contents to the title case.
    /// </summary>
    /// <param name="contents">The contents.</param>
    /// <returns></returns>
    public static string ToTitleCase(string contents)
    {
      return DbClassLibrary.GeneralUtility.ToTitleCase(contents);
    }

    /// <summary>
    /// Determines whether [is valid email] [the specified email].
    /// </summary>
    /// <param name="email">The email.</param>
    /// <returns>
    ///   <c>true</c> if [is valid email] [the specified email]; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsValidEmail(string email)
    {
      try
      {
        if (string.IsNullOrEmpty(email)) return false;
        // ReSharper disable once UnusedVariable
        var addr = new System.Net.Mail.MailAddress(email);
        return true;
      }
      catch
      {
        return false;
      }
    }
    /// <summary>
    /// Determines whether [is valid phone] [the specified phone].
    /// </summary>
    /// <param name="phone">The phone.</param>
    /// <returns>
    ///   <c>true</c> if [is valid phone] [the specified phone]; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsValidPhone(string phone)
    {
      try
      {
        if (string.IsNullOrEmpty(phone))
          return false;
        var r = new Regex(@"((?:\(?[2-9](?(?=1)1[02-9]|(?(?=0)0[1-9]|\d{2}))\)?\D{0,3})(?:\(?[2-9](?(?=1)1[02-9]|\d{2})\)?\D{0,3})\d{4})");
        return r.IsMatch(phone);

      }
      catch (Exception ex)
      {
        ErrorLog.LogWarning(ex.Message, "IsValidPhone");
        return false;
      }
    }

    public static string GetConfigNameValuePair(string name, string key)
    {
      try
      {
        using (var settings = new DbClassLibrary.ActiveRecords.ConfigSettings
        {
          Query = "select * from config_settings where APPLICATION = :app and KEY = :key"
        })
        {
          settings.AddParameter("app", name);
          settings.AddParameter("key", key);
          var setting = settings.Results().FirstOrDefault();
          if (setting != null) return setting.ConfigValue;
        }
      }
      catch (Exception ex)
      {
        ErrorLog.DebugLog(ex.Message, "GetAppConfigValue");
      }
      return default(string);
    }

    public static string Prepend(string val, char leadingChar, int size)
    {
      var results = val;
      while (results.Length < size)
      {
        results = leadingChar + results;
      }
      return results;
    }

		public static string LoadEntity(string rquId)
		{
			try
			{
				var entity = new DbClassLibrary.EntityResponse { RquId = rquId };
				var data = entity.GetSource();
				if (string.IsNullOrEmpty(data)) throw new ApplicationException("Unable to retrieve entity id: " + rquId);
				return data;
			}
			catch (Exception ex)
			{
				ErrorLog.LogError(ex, new CallingMethod());
				throw;
			}
		}

		public static string PrepareAdoResultsFromException(Exception response)
		{
			return XmlUtility.GetXmlFromAdoRecordset(XmlUtility.CreateRecordSet(new string[] { "ERROR_MESSAGE" }));
		}
  }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/FnsUtility/GeneralUtility.cs $
 * 
 * 59    10/14/11 11:31a Gwynnj
 * EcecuteMethod error reports method on error.
 * 
 * 58    6/02/11 2:17p Gwynnj
 * added ConvertDateStringFromTo to switch formatting on date strings
 * 
 * 57    5/10/11 4:00p Deepika.sharma
 * efig-0148
 * 
 * 56    5/02/11 12:16p Deepika.sharma
 * efig-0148
 * 
 * 55    4/07/11 1:42p Gwynnj
 * Moved ProductionInstanceFromRegistry to DbClassLibrary
 * 
 * 54    2/23/11 10:35a Deepika.sharma
 * 
 * 53    2/18/11 4:20p Deepika.sharma
 * dms:
 * 
 * 52    2/09/11 3:15p Deepika.sharma
 * 
 * 51    2/09/11 3:11p Deepika.sharma
 * JCER-0255
 * 
 * 50    1/25/11 4:29p Gwynnj
 * Added GeneralUtility.ProductionInstanceFromRegistry
 * 
 * 49    1/19/11 11:41a Gwynnj
 * Added Tower and GB constants
 * 
 * 48    8/10/10 3:53p Gwynnj
 * Updated Tuple to FnsComposite.Monads namespace
 * 
 * 47    8/03/10 1:20p Gwynnj
 * configuration reader tess and removed Tuple to FnsComposite (data
 * structure)
 * 
 * 46    7/26/10 6:30p Gwynnj
 * Logging removed
 * 
 * 45    7/26/10 6:04p Gwynnj
 * temporary logging
 * 
 * 44    6/24/10 10:39a Gwynnj
 * added HasInstance to avoid errors on  ApplicationConfiguration
 * constructor where we may Decrypt and generate logging.
 * 
 * 43    6/14/10 1:23p Gwynnj
 * Moved configuration methods  to ConfigurationReader class for
 * consolidation.  Also removed unit tests to TestUtilities project
 * 
 * 42    6/10/10 4:49p Gwynnj
 * Added GetConfigurationProperties for dumps
 * 
 * 41    6/02/10 12:43p Gwynnj
 * ensconsed Decrypt parms in Try/catch in case we get in a bad looping
 * situation
 * 
 * 40    5/04/10 6:43p Gwynnj
 * Appsettings bug fixed
 * 
 * 39    5/04/10 5:36p Gwynnj
 * extended GetSettingFromDatabase to use machine name which is of higher
 * precedence than app name
 * 
 * 38    4/28/10 6:01p Gwynnj
 * modified GetAppConfig settings to use ActiveRecord for reduced db round
 * trips.
 * 
 * 37    4/01/10 4:04p Deepika.sharma
 * dms: Additional app config value so that phase 2 can invoke machine
 * specific remoteconnect url 
 * 
 * 36    3/30/10 2:27p Gwynnj
 * Added default Encrypt Decrypt methods using the CallData key
 * 
 * 35    3/23/10 7:19p Gwynnj
 * Added GeneralUtility.GetConstructor<T>() where T is Class and has
 * default public constructor.  Also called Close from Dispose on
 * EmailTraceListener to ensure using semantics does a proper flush.
 * 
 * 34    3/09/10 3:15p Gwynnj
 * Subkey comparison (REGISTRY) is now case insensitive.  N.B. the
 * attribute is still case sensitive.
 * 
 * 33    2/17/10 3:08p Gwynnj
 * Set for AddRange to eliminate dups
 * 
 * 32    2/08/10 3:43p Gwynnj
 * added checking for subkeys existence prior to trying to open them...
 * 
 * 31    2/04/10 5:59p Gwynnj
 * added NameValueCollection.AddRange extension method
 * 
 * 30    1/05/10 11:02a John.gwynn
 * added logging for config settings
 * 
 * 29    12/14/09 5:34p John.gwynn
 * Added GetAppConfigValueInt for integer conversions N.B. returns type
 * int?
 * 
 * 28    12/03/09 11:48a John.gwynn
 * Modified ExecuteMethod to overcome ambiguous methods with exact binding
 * of string method(string parm) signature.  Also ignored context
 * sensitive tests
 * 
 * 27    12/02/09 6:44p John.gwynn
 * ExecuteMethod now handles static classes
 * 
 * 26    12/01/09 6:03p John.gwynn
 * All attemtps to read or write the ConnectString registry value will
 * encrypt/decrypt the PWD= parameter if it is encrypted.
 * 
 * 25    12/01/09 3:24p John.gwynn
 * ConnectString is automagically decrypted
 * 
 * 24    11/30/09 3:29p John.gwynn
 * Fixed a reflection bug on split where max was 3 broke nested namespaces
 * ie. folders.
 * 
 * 23    11/21/09 12:26p John.gwynn
 * Enhanced Encrypt/Decrypt value checks for empty/null
 * 
 * 22    11/21/09 12:15p John.gwynn
 * Added stricter code in ExecuteMethod
 * 
 * 21    11/14/09 8:04a John.gwynn
 * added try catch for GetRegistryKey to allow for keys that are not
 * present.  This wil now only generate a warning in the application log.
 * 
 * 20    10/22/09 1:51p John.gwynn
 * Added HtmlEncode for parsing
 * 
 * 19    10/12/09 12:43p John.gwynn
 * Added ApplicationConfiguration singleton for general Fns Registry
 * settings
 * 
 * 18    9/28/09 5:42p John.gwynn
 * added ExtractInstanceFromConnectString (for policy load servers on
 * multi-client support)
 * 
 * 17    7/27/09 9:39a John.gwynn
 * update app.config and modified Encrypt/Decrypt to preserve original
 * value if there are problems.
 * 
 * 16    5/12/09 1:38p John.gwynn
 * added instance checks
 * 
 * 15    5/04/09 6:56p John.gwynn
 * Added BinDir property
 * 
 * 14    1/27/09 3:41p John.gwynn
 * added TargetInvocationException to ExecuteMethod to cature inner
 * exception return from remoting app
 * 
 * 13    1/22/09 10:36a John.gwynn
 * IsProduction not using regular expressions.
 * 
 * 12    1/20/09 2:11p John.gwynn
 * added GeneralUtility.ConnectString
 * 
 * 11    1/15/09 2:07p John.gwynn
 * return results if no db setting.
 * 
 * 10    1/13/09 2:26p John.gwynn
 * DebugLog for GetAppConfig value in non-Prod db checks
 * 
 * 9     1/08/09 12:53p Deepika.sharma
 * DSHA-0005: Config file will have prod. settings. for non prod env. read
 * from DB
 * 
 * 8     11/17/08 5:24p John.gwynn
 * modified ExecuteMethod to accept static methods
 * 
 * 7     5/20/08 11:21a Patrick.demasco
 * Added missing StringFormat to exception message
 * 
 * 6     3/13/08 2:55p John.gwynn
 * added GetAppConfigValue
 * 
 * 5     2/06/08 7:34p John.gwynn
 * Added Serialize utilities and aability to handle multi-level namespaces
 * in the GeneralUtility.ExecuteMethod
 * 
 * 4     2/04/08 6:54p John.gwynn
 * added EncryptValue/DecryptValue, XmlUtility.FormatCallDate
 * 
 * 3     9/26/07 3:05p John.gwynn
 * modified GenDsn utility method to use Regexp
 * 
 * 2     7/17/07 4:44p John.gwynn
 * updated GeneralUtility
 * 
 * 1     1/18/07 2:38p John.gwynn
 * Framework 2.0 upgrade
 * 
 * 13    11/09/06 11:11a John.gwynn
 * added additional checks for those methods that would be called during
 * exception processing.
 * 
 * 12    10/10/06 11:02a John.gwynn
 * EmailTraceListener integrated with MailManager to use MERCURY
 * destinations.  Modified RegistryKey in GeneralUtility to use Dispose
 * pattern (using).  Added MailManager functionality.  Old MailManager
 * project is now OBSOLETE.
 * 
 * 11    9/17/06 7:24p John.gwynn
 * added GeneralUtility.GetDsnFromInstance() and overload (string
 * instance) returns a formatted DSN entry for ODBC and ADO connections.
 * The option without parameter retrieves the instance frrom the machine
 * registry.
 * 
 * 10    7/26/06 6:07p John.gwynn
 * added Vehicle lookup (ADO)
 * 
 * 9     6/23/06 5:56p John.gwynn
 * refactored ExecuteMethod
 * 
 * 8     5/13/06 1:49p John.gwynn
 * GlassPlus implementation support
 * 
 * 7     5/08/06 6:47p John.gwynn
 * documentation and file formatting
 * 
 * 6     4/10/06 4:41p John.gwynn
 * update references and cleaned variable names
 * 
 * 5     4/10/06 4:12p John.gwynn
 * New version with namespace fixed
 * 
 * 4     3/30/06 11:22a John.gwynn
 * general fixes and refinements
 * 
 * 3     3/13/06 9:45a John.gwynn
 * GetInstance added 
 * 
 * 2     3/06/06 5:56p John.gwynn
 * added baseWebEngine
 * 
 * 1     3/04/06 5:28p John.gwynn
 */
#endregion