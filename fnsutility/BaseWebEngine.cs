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
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/BaseWebEngine.cs 18    6/14/11 4:19p Gwynnj $ */
#endregion

#region References
using System;
using System.Text.RegularExpressions;
using ICall = FnsInterfaces.ICall;
#endregion

namespace FnsUtility
{
  /// <summary>
  /// BaseWebEngine base class for web service wrapper.
  /// </summary>
  public abstract class BaseWebEngine
  {
    /// <summary>
    /// CallObject REQUEST_RQUID (used to manage lookup requests general/details)
    /// </summary>
    public const string RequestRquidAttribute = "REQUEST_RQUID";
    /// <summary>
    /// constant for logging type Request
    /// </summary>
    public const string Request = "REQUEST";

    /// <summary>
    /// constant for logging type Response
    /// </summary>
    public const string Response = "RESPONSE";

    /// <summary>
    /// (OBSOLETE use ApplicationConfiguration class)
    /// </summary>
    // ReSharper disable InconsistentNaming
    // TODO: refactor protected members to private
    protected bool m_test;

    /// <summary>
    /// (OBSOLETE use ApplicationConfiguration class)
    /// </summary>
    protected bool m_dumpResponse;

    /// <summary>
    /// (OBSOLETE use ApplicationConfiguration class)
    /// </summary>
    protected string m_rqId;

    /// <summary>
    /// (OBSOLETE use ApplicationConfiguration class)
    /// </summary>
    protected int m_webTimeout;

    /// <summary>
    /// OBSOLETE use ToString()
    /// </summary>
    protected string m_serviceName;
    /// <summary>
    /// The one and only Call (can be either interop or .net)
    /// </summary>
    protected ICall m_call;
    /// <summary>
    /// provides support for dll specific config files 
    /// N.B. This is obsolete (use ApplicationConfiguration class)
    /// </summary>
    protected FnsConfigurationMgr m_config;
    // ReSharper restore InconsistentNaming

    /// <summary>
    /// Gets the instance as set by the current call if it exists.
    /// </summary>
    protected string Instance { get; set; }

    /// <summary>
    /// Call Object Attribute for Error info
    /// </summary>
    protected const string ErrorDescriptionNameAttribute = "ERRORSTRING";
    /// <summary>
    /// Call Object Attribute for Notification Type attribute data 
    /// </summary>
    protected const string NotifyTypeNameAttribute = "NOTIFICATION_TYPE";
    /// <summary>
    /// Call Object Attribute for Lookup SQL data
    /// </summary>
    public const string LookupSql = "LU_LOOKUPSQL";

    /// <summary>
    /// stores the extracted policy number
    /// </summary>
    public const string LookupPolicyNumber = "LU_POLICY_NUMBER";

    /// <summary>
    /// stores the extracted date of loss
    /// </summary>
    public const string LookupLossDate = "LU_LOSS_DATE";


    /// <summary>
    /// Lookup attribute
    /// </summary>
    public const string LookupNameFirst = "LU_NAME_FIRST";

    /// <summary>
    /// Lookup attribute
    /// </summary>
    public const string LookupNameLast = "LU_NAME_LAST";

    /// <summary>
    /// Lookup attribute
    /// </summary>
    public const string LookupCompanyName = "LU_COMPANY_NAME";


    /// <summary>
    /// Initializes a new instance of the <see cref="BaseWebEngine"/> class.
    /// </summary>
    [Obsolete]
    protected BaseWebEngine(string name)
    {
      m_serviceName = name;
      m_webTimeout = 30;
      m_call = null;
      m_rqId = String.Empty;
      m_config = null;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseWebEngine"/> class.
    /// </summary>
    [Obsolete]
    protected BaseWebEngine()
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Gets the rqUID.
    /// </summary>
    /// <param name="callId">The call id.</param>
    /// <returns></returns>
    // ReSharper disable InconsistentNaming
    [Obsolete("use FnsUtility.GeneralUtility..GetRquId(callId)")]
    public virtual string GetRqUID(string callId)
    // ReSharper restore InconsistentNaming
    {
      if (m_rqId.Length == 0)
      {
        m_rqId = GeneralUtility.GetRquId(callId);
      }
      return m_rqId;
    }
    /// <summary>
    /// extract the POLICY_NUMBER attribute wherever it may reside...
    /// </summary>
    /// <param name="call"></param>
    /// <returns></returns>
    public static string GetPolicyNumber(ICall call)
    {
      if (null == call) return string.Empty;
      var results = call.GetValue("LU_POLICY_NUMBER").Trim(); // lookup first

      if (!string.IsNullOrEmpty(results)) return results;
      var sql = call.GetValue(LookupSql);
      if (!string.IsNullOrEmpty(sql))
        results = ExtractParmFromLookupFrameSQL(sql, "POLICY_NUMBER").Trim();

      return string.IsNullOrEmpty(results)
              ? call.GetValue("CLAIM:POLICY:POLICY_NUMBER").Trim()
              : results;

    }

    /// <summary>
    /// extract ATTRIBUTE VALUE from lookup frame SQL
    /// Assumes format e.g. WHERE ATTRIBUTE="VALUE"
    /// Checks for unset variables i.e. /* ATTRIBUTE="~CALL_OBJECT_ATTRIBUTE~" */
    /// </summary>
    /// <param name="sql">The SQL.</param>
    /// <param name="attribute">The attribute.</param>
    /// <returns></returns>
    // ReSharper disable InconsistentNaming
    public static string ExtractParmFromLookupFrameSQL(string sql, string attribute)
    // ReSharper restore InconsistentNaming
    {
      var results = String.Empty;
      var parameterLength = attribute.Length;

      if (sql.Length > 0)
      {
        var regex = new Regex(attribute + "[\\s=]");
        var match = regex.Match(sql);
        if (match.Success)
        {
          sql = sql.Substring(match.Index + parameterLength);
          while (sql.Substring(0, 1) == " " || sql.Substring(0, 1) == "=")
            sql = sql.Substring(1);
          //Need to use AND as a delimiter instead of space to accomodate searches for cities like 'WEST CHESTER') A-EVF125
          var nextSpace = sql.ToUpper().IndexOf(" AND ", StringComparison.Ordinal);
          if (nextSpace > -1)
            sql = sql.Substring(0, nextSpace);
          results = sql.Replace("\"", String.Empty).Replace("'", String.Empty).Trim();
        }
      }
      return results;
    }

    /// <summary>
    /// Logs the response body.
    /// </summary>
    [Obsolete("Please see ClaimSubmissonLogger for appropriate logging")]
    protected void LogResponseBody(string document, string prefix, string requestId, bool log2File)
    {
#pragma warning disable 618,612
      LogResponseBody(document.Trim(), prefix, requestId, log2File, Instance);
#pragma warning restore 618,612
    }

    /// <summary>
    /// Logs the response body.
    /// </summary>
    [Obsolete("Please see ClaimSubmissonLogger for appropriate logging")]
    public static void LogResponseBody(string document, string prefix, string requestId, bool log2File, string instance)
    {
      var logType = prefix.Equals("REQUEST", StringComparison.InvariantCultureIgnoreCase)
                      ? ClaimSubmissionLogger.LogType.Request
                      : ClaimSubmissionLogger.LogType.Response;

      ClaimSubmissionLogger.LogResponseBody(document, logType, requestId, instance);
    }


  }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/FnsUtility/BaseWebEngine.cs $
 * 
 * 18    6/14/11 4:19p Gwynnj
 * fixed parsing sql frame parameters
 * 
 * 17    11/01/10 3:42p Gwynnj
 * Refactoring for Selective
 * 
 * 16    9/28/10 2:32p Gwynnj
 * minor build warnings removed
 * 
 * 15    8/17/10 1:06p Gwynnj
 * Moved all ClaimSubmissionLog functionality to ClaimSubmissionLogger and
 * added Asych logging using ThreadPool
 * 
 * 14    5/13/10 6:06p Gwynnj
 * BaseWebEngine is obsolete
 * 
 * 13    5/11/10 2:11p Gwynnj
 * Warnings removed comments and CLSCompliance updates
 * 
 * 12    5/05/10 2:04p Gwynnj
 * minor changes
 * 
 * 11    4/27/10 5:32p Gwynnj
 * expose LogResponseBody as static for new generic base
 * 
 * 10    4/20/10 1:51p Gwynnj
 * Added RequestRquid attribute for CallObject GetSet value calls
 * 
 * 9     4/08/10 6:23p Gwynnj
 * added constants for the insered lookup name_first and name_last
 * 
 * 8     4/08/10 2:25p Gwynnj
 * changed the scope of call object constants to use for testing mostly
 * 
 * 7     1/14/10 2:28p Gwynnj
 * LogResponseBody applies a Trim to remove leading whitespace
 * 
 * 6     1/05/10 11:02a John.gwynn
 * added logging for config settings
 * 
 * 5     1/04/10 6:13p John.gwynn
 * Request and Response constants
 * 
 * 4     1/04/10 3:17p John.gwynn
 * Added Instance property and method: LogResponseBody
 * 
 * 3     6/27/09 2:51p John.gwynn
 * ICall = FnsInterfaces
 * 
 * 2     5/04/09 4:05p John.gwynn
 * replace FnsComposite.ICall with FnsInterfaces.ICall
 * 
 * 1     1/18/07 2:38p John.gwynn
 * Framework 2.0 upgrade
 * 
 * 9     12/19/06 1:26p John.gwynn
 * NDoc comments for technical documentation see:
 * http://cha1saxc/wiki/ndocs/fnsutility/index.html
 * 
 * 8     11/30/06 3:17p John.gwynn
 * Added config member variable for custom appSettings
 * 
 * 7     10/27/06 5:23p John.gwynn
 * fix to extract parms with single or double quotes (BUGBUG use regex)
 * 
 * 6     5/08/06 6:47p John.gwynn
 * documentation and file formatting
 * 
 * 5     4/20/06 11:54a John.gwynn
 * CLI Compliance modifications
 * 
 * 4     4/19/06 11:44a John.gwynn
 * changed from ref parm
 * 
 * 3     4/10/06 4:12p John.gwynn
 * New version with namespace fixed
 * 
 * 2     3/10/06 10:16a John.gwynn
 * debugLog and GetPolicyNumber fix
 * 
 * 1     3/06/06 5:55p John.gwynn
 * here for now 
 */
#endregion
