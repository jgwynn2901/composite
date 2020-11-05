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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Utility.cs 25    12/05/11 2:46p Gwynnj $ */

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Practices.EnterpriseLibrary.Data.Oracle;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using Microsoft.Win32;
using ADODB;
using Stream = ADODB.Stream;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace DbClassLibrary
{
  /// <summary>
  /// Summary description for GeneralUtilities for this assembly
  /// </summary>
  [ComVisible(false)]
  public class GeneralUtility
  {
    private static List<ConnectionStringSettings> _lazyConnectionStringCollection;
    public const string SymmProvider = "CallDataKey";
    private const string FnsRegistryKey = @"Software\Edgewater\FNS\";

    static GeneralUtility()
    {
      ApConfigBase.InitializeConfiguration();
    }
    private GeneralUtility()
    {
      //
      // we never want real instances
      //
    }
    /// <summary>
    /// return the database instance configuration name 
    /// from the old registry settings
    /// </summary>
    /// <returns></returns>
    static internal string GetDbInstanceFromRegistry()
    {
      return DatabaseInstance.InstanceFromRegistry();
    }

    static public string ProductionInstanceFromRegistry
    {
      get
      {
        return string.Format("{0}P", GetDbInstanceFromRegistry().Substring(0, 3));
      }
    }
    /// <summary>
    /// Gets the connect string from instance.
    /// </summary>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static public string GetConnectStringFromInstance(string instance)
    {
      if (string.IsNullOrEmpty(instance))
        instance = ApplicationConfiguration.Instance.DefaultInstance;

      return !string.IsNullOrEmpty(instance)
        ? GetNamedConnectionStringValue(instance)
        : "";
    }

    private static string GetNamedConnectionStringValue(string name)
    {
      if (_lazyConnectionStringCollection == null)
        _lazyConnectionStringCollection = GetConnectionStrings();

      var results = _lazyConnectionStringCollection.SingleOrDefault(s => s.Name == name);

      return results == null
          ? null
          : results.ConnectionString;
    }

    public static List<ConnectionStringSettings> GetConnectionStrings()
    {
      var list = new List<ConnectionStringSettings>();
      var settings = ConfigurationManager.GetSection("connectionStrings") as ConnectionStringsSection;

      if (settings != null)
        list.AddRange(settings.ConnectionStrings.Cast<ConnectionStringSettings>());
      return list;
    }
    /// <summary>
    /// Gets the ADO connect string from instance.
    /// </summary>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static internal string GetAdoConnectStringFromInstance(string instance)
    {
      return String.Format("Provider=MSDAORA.1;{0}", GetConnectStringFromInstance(instance));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="strMsg"></param>
    /// <param name="strComponent"></param>
    static internal void DebugLog(string strMsg, string strComponent)
    {
      var strOutput = String.Format("[{0}][{1}][{2}]{3}", DateTime.Now, Thread.CurrentThread.ManagedThreadId, strComponent, strMsg);
      Trace.WriteLine(strOutput);
    }
    /// <summary>
    /// converts date formats to MM/DD/YYYY for conversion to DbType
    /// </summary>
    /// <param name="strDate"></param>
    /// <param name="strFormat"></param>
    /// <returns></returns>
    static public string ConvertDatetoDbFormat(string strDate, string strFormat)
    {
      var strResults = String.Empty;

      strFormat = strFormat.ToUpper();

      if (strFormat.Length < 8) return strResults;
      var iMonthIndex = strFormat.IndexOf("M", StringComparison.Ordinal);
      var iYearIndex = strFormat.IndexOf("Y", StringComparison.Ordinal);
      var iDayIndex = strFormat.IndexOf("D", StringComparison.Ordinal);
      if (iMonthIndex > -1 && iYearIndex > -1 && iDayIndex > -1)
      {
        strResults = String.Format("{0}/{1}/{2}",
          strDate.Substring(iMonthIndex, 2),
          strDate.Substring(iDayIndex, 2),
          strDate.Substring(iYearIndex, 4));
      }
      return strResults;
    }
    /// <summary>
    /// Camels the name of the case parm.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns></returns>
    public static string CamelCaseParmName(string name)
    {
      var results = PascalCase(StripPrefix("m_", StripPrefix("p_", name.ToLower())));

      return results;
    }

    /// <summary>
    /// 
    /// </summary>
    public static bool ExecuteNonQuery(string commandText)
    {
      return ExecuteNonQuery(commandText, ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    ///  ExecuteNonQuery for a give SQL command
    /// </summary>
    /// <param name="commandText">SQL command to execute</param>
    /// <param name="instance">Database instance</param>
    /// <returns></returns>
    public static bool ExecuteNonQuery(string commandText, string instance)
    {
      bool results;
      try
      {
        DebugLog("Execute entered", "ExecuteNonQuery");
        if (instance.Length == 0)
          instance = ApplicationConfiguration.Instance.DefaultInstance;

        var db = new OracleDatabase(GetConnectStringFromInstance(instance));
        results = (db.ExecuteNonQuery(CommandType.Text, commandText) > 0);
      }
      catch (Exception ex)
      {
        results = false;
        LogError(ex.Message, "ExecuteNonQuery");
      }
      return results;
    }

    static public bool ExecuteNonQueryWithParms(string commandSql, string dbInstance, IDictionary<string, object> parms)
    {
      try
      {
        var instance = dbInstance;

        if (string.IsNullOrEmpty(instance))
          instance = ApplicationConfiguration.Instance.DefaultInstance;

        var db = new OracleDatabase(GetConnectStringFromInstance(instance));

        var reader = new SqlParameterReader();

        foreach (var key in parms.Keys)
        {
          reader.AddParameter(key, parms[key]);
        }

        return reader.ExecuteNonQuery(db, commandSql) > 0;
      }
      catch (Exception ex)
      {
        LogError(ex.Message, "ExecuteNonQueryWithParms");
        return false;
      }
    }

    /// <summary>
    /// Executes the reader.
    /// </summary>
    /// <param name="commandSql">The command SQL.</param>
    /// <returns></returns>
    static public IDataReader ExecuteReader(string commandSql)
    {
      return ExecuteReader(commandSql, ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Executes the reader.
    /// </summary>
    /// <param name="commandSql">The command SQL.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static public IDataReader ExecuteReader(string commandSql, string instance)
    {
      return ExecuteReader(commandSql, instance, null);
    }

    /// <summary>
    /// Executes the reader.
    /// </summary>
    /// <param name="commandSql">The command SQL.</param>
    /// <param name="parms">The parms.</param>
    /// <returns></returns>
    static public IDataReader ExecuteReader(string commandSql, IEnumerable parms)
    {
      return ExecuteReader(commandSql, ApplicationConfiguration.Instance.DefaultInstance, parms);
    }

    /// <summary>
    /// Executes the reader from SQL.
    /// </summary>
    /// <param name="commandSql">The command SQL.</param>
    /// <param name="parms">The parameters if any.</param>
    /// <returns></returns>
    static public IDataReader ExecuteReader(string commandSql, IDictionary<string, object> parms)
    {
      return ExecuteReader(commandSql, ApplicationConfiguration.Instance.DefaultInstance, parms);
    }
    /// <summary>
    /// Executes the reader for parameterized sql.
    /// </summary>
    /// <param name="commandSql">The convention for parameters is to use
    /// the Oracle syntax with consecutive numbers starting with 1 i.e. :1, :2, :3</param>
    /// <param name="dbInstance">The db instance.</param>
    /// <param name="parms">The parameters collection (value types will be boxed)</param>
    /// <returns></returns>
    static public IDataReader ExecuteReader(string commandSql, string dbInstance, IEnumerable parms)
    {

      var parameters = new Dictionary<string, object>();

      if (parms != null)
      {
        var defaultParmName = 1;

        foreach (var parm in parms)
        {
          parameters.Add(defaultParmName.ToString(CultureInfo.InvariantCulture), parm);
          defaultParmName++;
        }
      }
      return ExecuteReader(commandSql, dbInstance, parameters);
    }

    /// <summary>
    /// Executes a database reader for parameterized sql.
    /// </summary>
    /// <param name="commandSql">The command SQL.</param>
    /// <param name="dbInstance">The database instance.</param>
    /// <param name="parms">The parameters collection as a dictionary.</param>
    /// <returns></returns>
    static public IDataReader ExecuteReader(string commandSql, string dbInstance, IDictionary<string, object> parms)
    {
      try
      {
        var instance = dbInstance;

        if (string.IsNullOrEmpty(instance))
          instance = ApplicationConfiguration.Instance.DefaultInstance;

        var db = new OracleDatabase(GetConnectStringFromInstance(instance));

        var reader = new SqlParameterReader();

        foreach (var key in parms.Keys)
        {
          reader.AddParameter(key, parms[key]);
        }

        return reader.ExecuteReader(db, commandSql);
      }
      catch (Exception ex)
      {
        LogError(ex.Message, "ExecuteReader");
        throw;
      }
    }

    public static Boolean ExecuteStoredProc(string storedProcedureName)
    {
      bool results;
      try
      {
        string instance = ApplicationConfiguration.Instance.DefaultInstance;

        var db = new OracleDatabase(GetConnectStringFromInstance(instance));

        System.Data.Common.DbCommand cmd = db.GetStoredProcCommand(storedProcedureName);
        if (cmd != null)
        {
          var records = db.ExecuteNonQuery(cmd);
          results = records == 1;
        }
        else
        {
          results = false;
        }
      }
      catch (Exception ex)
      {
        results = false;
        LogError(ex.Message, "ExecuteStoredProc");
      }
      return results;
    }

    /// <summary>
    /// Strips the prefix.
    /// </summary>
    /// <param name="prefix">The prefix.</param>
    /// <param name="parameter">The parameter.</param>
    /// <returns></returns>
    private static string StripPrefix(string prefix, string parameter)
    {
      var results = parameter;
      var index = results.IndexOf(prefix, StringComparison.Ordinal);

      if (index > -1)
      {
        results = results.Substring(index + 2);
      }
      return results;
    }
    /// <summary>
    /// Camels the case.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <returns></returns>
    public static string PascalCase(string source)
    {
      var results = source.ToLower();
      if (results.Length > 0)
      {
        return String.Format("{0}{1}", results.Substring(0, 1).ToUpper(), CheckForKeywords(RemoveUnderscore(results.Substring(1))));
      }
      return results;
    }
    /// <summary>
    /// Translates the type of the oracle.
    /// </summary>
    /// <param name="dataType">Type of the data.</param>
    /// <returns></returns>
    public static string TranslateOracleType(string dataType)
    {
      var results = String.Empty;

      switch (dataType)
      {
        case "VARCHAR2":
          results = "string";
          break;
        case "NUMBER":
          results = "int";
          break;
        case "DATETIME":
          results = "DateTime";
          break;
      }

      return results;
    }
    /// <summary>
    /// Checks for keywords.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <returns></returns>
    private static string CheckForKeywords(string source)
    {
      var id = new Regex("id$");
      var code = new Regex("[cC]d$");
      var desc = new Regex("[Dd]esc$");
      var dt = new Regex("[Dd]t$");
      var results = id.Replace(source, "Id");
      results = code.Replace(results, "Code");
      results = desc.Replace(results, "Decription");
      results = dt.Replace(results, "Date");
      return results.Replace("first", "First")
        .Replace("last", "Last").Replace("Flg", "Flag")
        .Replace("valid", "Valid").Replace("rule", "Rule");
    }
    /// <summary>
    /// Removes the underscore.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <returns></returns>
    private static string RemoveUnderscore(string source)
    {
      var index = source.IndexOf("_", StringComparison.Ordinal);
      if (index > -1)
      {
        return
          String.Format("{0}{1}{2}", source.Substring(0, index), source.Substring(index + 1, 1).ToUpper(),
                        RemoveUnderscore(source.Substring(index + 2)));
      }
      return source;
    }
    /// <summary>
    /// Logs the error.
    /// </summary>
    /// <param name="error">The error.</param>
    /// <param name="processName">Name of the process.</param>
    public static void LogError(string error, string processName)
    {
      // retrieve machine settings
      using (var localMachineKey = Registry.LocalMachine)
      {
        var errorFile = "";
        using (var fnsKey = localMachineKey.OpenSubKey("Software\\Edgewater\\FNS\\"))
        {
          if (fnsKey != null) errorFile = fnsKey.GetValue("ErrorFile").ToString();
        }
        if (errorFile.Length > 0)
        {
          try
          {

            if (0 == errorFile.Length)
            {
              errorFile = "c:\\FNSError.txt";
            }
            var stream = File.AppendText(errorFile);
            var formattedErrorMessage = String.Format("{0}\tServer={1}\tSeverity: {2}\tComponent: {3}\tMessage: {4}",
                                                         DateTime.Now.ToString("G"),
                                                         Environment.MachineName,
                                                         "3",
                                                         processName,
                                                         error);
            stream.WriteLine(formattedErrorMessage);
            stream.Flush();
            stream.Close();
          }
          catch
          {
            DebugLog("Error writing to errorlog!", "GeneralUtility");
          }
        }
      }
    }

    /// <summary>
    /// Gets the sysdate as string.
    /// </summary>
    /// <returns></returns>
    static public string GetSysdateAsString()
    {
      return GetSysdateAsString(ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Gets the formatted sysdate.
    /// </summary>
    /// <param name="format">The format.</param>
    /// <returns></returns>
    static public string GetFormattedSysdate(string format)
    {
      try
      {
        var sysdateSet = new ActiveRecordSet { Query = "Select TO_CHAR(sysdate,'" + format + "') as CurrentDate FROM dual" };
        if (sysdateSet.Execute() && sysdateSet.MoveNext())
          return sysdateSet["CurrentDate"].ToString();
      }
      catch (Exception ex)
      {
        LogError(ex.Message, "GetFormattedSysdate");
      }
      return string.Empty;

    }
    /// <summary>
    /// Gets the sysdate as string.
    /// </summary>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static public string GetSysdateAsString(string instance)
    {
      try
      {
        var sysdateSet = new ActiveRecordSet(instance) { Query = "Select SYSDATE from dual" };
        if (sysdateSet.Execute() && sysdateSet.MoveNext())
          return sysdateSet["SYSDATE"].ToString();
      }
      catch (Exception ex)
      {
        LogError(ex.Message, "GetSysdateAsString");
      }
      return string.Empty;
    }

    #region GetXmlFromAdoRecordset
    /// <summary>
    /// Another pattern that is refactored here
    /// Given ADODB.Recordset return a string of its xml
    /// </summary>
    /// <param name="record">The record.</param>
    /// <returns></returns>
    static internal string GetXmlFromAdoRecordset(_Recordset record)
    {
      var results = String.Empty;
      _Stream stream = null;
      try
      {
        if (null != record)
        {
          stream = new Stream();
          record.Save(stream, PersistFormatEnum.adPersistXML);
          results = stream.ReadText(-1);
        }
      }
      catch (Exception ex)
      {
        LogError("GetXmlFromAdoRecordset(): Error " + ex.Message, "GetXmlFromAdoRecordset");
      }
      finally
      {
        if (stream != null)
          Marshal.ReleaseComObject(stream);
      }
      return results;
    }
    #endregion

    /// <summary>
    /// Tries to parse input into valid zip code for location_code search.
    /// </summary>
    public static bool TryParseZipCode(string source, out string result)
    {
      var usa = new Regex("^\\d{5}");
      var match = usa.Match(source);
      if (!match.Success)
      {
        // is it Canada?
        var canada = new Regex("^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$");
        match = canada.Match(source.ToUpper());
      }

      if (match.Success)
      {
        result = match.Value;
        return true;
      }

      result = "";
      return false;
    }

    /// <summary>
    /// validates xml input to as numeric.
    /// </summary>
    /// <param name="val">The xml input value.</param>
    /// <returns></returns>
    public static string AsNumeric(string val)
    {
      double result;
      return double.TryParse(val, out result) ? val : "";
    }

    /// <summary>
    /// Removes zipcode format masks.
    /// </summary>
    public static string RemoveSpaceAndDash(string val)
    {
      return val.Replace(" ", "").Replace("-", "");
    }

    /// <summary>
    /// Removes phone format masks.
    /// </summary>
    public static string AsPhone(string val)
    {
      return RemoveSpaceAndDash(val).Replace("(", "").Replace(")", "");
    }
    /// <summary>
    /// Extracts the instance from connect string.
    /// </summary>
    /// <param name="dsn">The DSN (ConnectString).</param>
    /// <returns></returns>
    public static string ExtractInstanceFromConnectString(string dsn)
    {
      if (dsn.Length <= 0)
        return "";

      var iServerStart = dsn.ToUpper().IndexOf("SERVER=", StringComparison.Ordinal);
      return iServerStart > -1 ? dsn.Substring(iServerStart + 7).ToUpper() : "ERROR";
    }

    /// <summary>
    /// Determines whether this instance is sedgwick.
    /// </summary>
    /// <returns>
    ///   <c>true</c> if this instance is sedgwick; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsSedgwick()
    {
      return ApplicationConfiguration.Instance.DefaultInstance.StartsWith("SED");
    }

    /// <summary>
    /// Decrypts the value.
    /// </summary>
    static public string DecryptValue(string value)
    {
      try
      {
        if (string.IsNullOrEmpty(value)) return value;
        var results = OracleDecryptString(value);
        return results == value ? DecryptValue(SymmProvider, value) : results;

      }
      catch (Exception ex)
      {
        DebugLog(ex.Message, "DecryptValue");
        return value;
      }
    }

    private static string OracleDecryptString(string parm)
    {
      try
      {
        var decrypt = new Decryption { Value = parm };
        if (decrypt.Execute())
        {
            return CleanString(decrypt.Encrypt);
        }
      }
      catch (Exception ex)
      {
        DebugLog(ex.Message, "OracleDecryptString");
      }
      return parm;
    }

    public static string CleanString(string source)
    {
        var results = "";

        for (var i = 0; i < source.Length; ++i)
        {
            var current = (int)source[i];
            if (current > 0)
            {
                results += (char)current;
            }
            else
            {
                break;
            }
        }
        return results;
    }
    /// <summary>
    /// Encryption provided by Oracle's DBMS_CRYPTO package.
    /// </summary>
    /// <param name="parm">The string to encrypt.</param>
    /// <returns></returns>
    public static string OracleEncryptString(string parm)
    {
      try
      {
        var encrypt = new Encryption { Value = parm };
        if (encrypt.Execute())
          return encrypt.Encrypt;
      }
      catch (Exception ex)
      {
        DebugLog(ex.Message, "OracleEncryptString");
      }
      return parm;
    }

    /// <summary>
    /// Encrypts the value using the default FNS key.
    /// </summary>
    static public string EncryptValue(string value)
    {
      return string.IsNullOrEmpty(value) ? value : OracleEncryptString(value);
    }

    /// <summary>
    /// Internals the encrypt value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public string InternalEncryptValue(string value)
    {
      return EncryptValue(SymmProvider, value);
    }
    /// <summary>
    /// Decrypts the value. Preserves the original value if there are problems.
    /// </summary>
    static public string DecryptValue(string symmProvider, string value)
    {
      return InternalDecryptValue(symmProvider, value);
    }

    static public string InternalDecryptValue(string symmProvider, string value)
    {
      try
      {
        var result = !string.IsNullOrEmpty(value) ? Cryptographer.DecryptSymmetric(symmProvider, value) : value;
        return result;
      }
      catch (Exception ex)
      {
        DebugLog(ex.Message + " " + value, "InternalDecryptValue");
        return value;
      }

    }

    /// <summary>
    /// Encrypts the value. Preserves the original value if there are problems.
    /// </summary>
    static public string EncryptValue(string symmProvider, string value)
    {
      return !string.IsNullOrEmpty(value) ? Cryptographer.EncryptSymmetric(symmProvider, value) : value;
    }

    /// <summary>
    /// Gets the hexadecimal string of byte array.
    /// </summary>
    /// <param name="bytes">The byte array.</param>
    /// <returns></returns>
    public static string GetHexString(byte[] bytes)
    {
      var results = BitConverter.ToString(bytes);
      return results.Replace("-", "");
    }

    /// <summary>
    /// To the title case.
    /// </summary>
    /// <param name="contents">The contents.</param>
    /// <returns></returns>
    public static string ToTitleCase(string contents)
    {
      var cultureInfo = Thread.CurrentThread.CurrentCulture;
      var textInfo = cultureInfo.TextInfo;
      return textInfo.ToTitleCase(contents.ToLower());
    }

    /// <summary>
    /// Gets the FNS registry key string.
    /// </summary>
    /// <param name="subKey">The sub key.</param>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public string GetFnsRegistryKeyString(string subKey, string value)
    {
      var results = String.Empty;
      var fullRegKey = FnsRegistryKey + subKey;

      try
      {
        using (var localMachineKey = Registry.LocalMachine)
        {
          if (null != localMachineKey && SubkeyExists(subKey))
          {
            using (var fnsKey = localMachineKey.OpenSubKey(fullRegKey))
            {
              if (null != fnsKey)
                results = fnsKey.GetValue(value).ToString();
            }
          }
        }
      }
      catch (Exception)
      {
        LogError(string.Format("Attempt to retrieve registry key={0} value={1} failed.", fullRegKey, value), "GetFnsRegistryKeyString");
      }
      return results;
    }

    /// <summary>
    /// Sets the FNS registry key.
    /// </summary>
    /// <param name="subKeyName">Name of the sub key.</param>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public bool SetFnsRegistryKeyString(string subKeyName, string value)
    {
      using (var localMachineKey = Registry.LocalMachine)
      {
        if (null == localMachineKey) return false;
        using (var subkey = localMachineKey.OpenSubKey(FnsRegistryKey, true))
        {
          if (subkey == null) return false;
          subkey.SetValue(subKeyName,
            subKeyName.Equals("ConnectString", StringComparison.InvariantCultureIgnoreCase)
              ? EncryptValue(SymmProvider, value)
              : value);
        }
      }
      return true;
    }
    /// <summary>
    /// does the registry key exist?
    /// </summary>
    public static bool SubkeyExists(string subkey)
    {
      var results = false;
      if (string.IsNullOrEmpty(subkey)) return true;
      var keys = subkey.Split("\\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      using (var regKey = Registry.LocalMachine.OpenSubKey(FnsRegistryKey))
      {
        var current = regKey;
        foreach (var key in keys)
        {
          results = SubkeyExists(current, key);
          if (current == null) break;
          current = current.OpenSubKey(key);
        }
      }
      return results;
    }

    /// <summary>
    /// Sets the general purpose entity text.
    /// </summary>
    /// <param name="guid">The unique identifier.</param>
    /// <param name="data">The data.</param>
    /// <returns></returns>
    public static bool SetEntity(string guid, string data)
    {
      return EntityResponse.SetEntityResponse(guid, data);
    }

    /// <summary>
    /// Gets the general purpose entity text.
    /// </summary>
    /// <param name="guid">The unique identifier.</param>
    /// <returns></returns>
    public static string GetEntity(string guid)
    {
      return EntityResponse.GetEntityResponse(guid);
    }

    /// <summary>
    /// does the Subkey exist?
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="subkey">The subkey.</param>
    /// <returns></returns>
    private static bool SubkeyExists(RegistryKey key, string subkey)
    {
      if (string.IsNullOrEmpty(subkey)) return true;

      return (from k in key.GetSubKeyNames()
              where k.Equals(subkey, StringComparison.InvariantCultureIgnoreCase)
              select k).Count() == 1;
    }
  }
}
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Utility.cs $
 * 
 * 25    12/05/11 2:46p Gwynnj
 * added I_LOG table suuport for items from notes iLog database
 * 
 * 24    9/20/11 1:49p Gwynnj
 * added functions to strip out mask chars for data fields phones and
 * postal codes etc.
 * 
 * 23    9/19/11 1:35p Gwynnj
 * added AsNumeric
 * 
 * 22    4/07/11 1:03p Gwynnj
 * Added DriverExtesded for the newfields TODO need to make this common
 * across al instances
 * 
 * 21    8/10/10 6:30p Gwynnj
 * created DatabaseInstance to manage all connection string code logic
 * 
 * 20    7/26/10 4:46p Gwynnj
 * Added DbLinq FirstNotice Linq to SQL support.
 * 
 * 19    10/15/09 11:22a John.gwynn
 * Added GeneralUtility.TryParseZipCode to parse and extract only the usa
 * (first 5) or ca zipcode element that we will use in the location_code
 * search parameters.  
 * 
 * 18    5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 17    4/24/09 7:26a John.gwynn
 * 
 * 16    4/03/09 2:55p John.gwynn
 * minor updates
 * 
 * 15    4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 14    4/01/09 7:28p John.gwynn
 * added parameterized SQL to ActiveRecord and beefed up User class for
 * use in VbSecurity
 * 
 * 13    3/31/09 5:43p John.gwynn
 * added executeReader with support for parameterized SQL
 * 
 * 12    3/11/09 1:33p John.gwynn
 * added comments to public members
 * 
 * 11    3/11/09 12:24p John.gwynn
 * added GeneralUtility.ExecuteReader(sql) to return reader for a given
 * query 
 * 
 * 10    2/18/09 6:37p John.gwynn
 * added callflow frames
 * 
 * 9     1/20/09 6:05p John.gwynn
 * Added Users/USer ActiveRecords
 * 
 * 8     1/13/09 3:42p John.gwynn
 * Added GeneralUtility/ExecuteNonQuery
 * 
 * 7     11/21/08 5:14p John.gwynn
 * Created config_settings table and procedure
 * 
 * 6     7/29/08 7:35p John.gwynn
 * Lets go to the registry each time in case it changes...
 * 
 * 5     7/19/07 5:43p John.gwynn
 * UnitOfWork enhancements
 * 
 * 4     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 3     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 9     4/09/07 4:47p John.gwynn
 * made ConvertDatetoDbFormat public
 * 
 * 8     4/03/07 6:49p John.gwynn
 * ActiveRecordBase changed to ActiveRecord.  EsisPolicyLookup nullADODB
 * parms fixed.
 * 
 * 7     3/29/07 6:43p John.gwynn
 * Building up the infrastructure for policy lookups via stored procedures
 * using ADODB primary interop assembly - first cut for ESIS prototype
 * 
 * 6     3/14/07 5:07p John.gwynn
 * added CamelCase for testing table attribute generation
 * 
 * 5     11/14/06 10:24a John.gwynn
 * GetDbInstanceFromRegistry fixed logic was inverse on instance check
 * 
 * 4     11/09/06 11:07a John.gwynn
 * Cache the instance parameter
 * 
 * 3     7/08/06 4:05p John.gwynn
 * Added ClaimSubmissionLog
 * 
 * 2     3/15/06 6:31p John.gwynn
 * support for CSAAWeb deployment
 * 
 * 1     3/06/06 6:07p John.gwynn
 */