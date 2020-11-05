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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/CallRecord.cs 12    7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using DbClassLibrary.ActiveRecords;

namespace DbClassLibrary
{
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(false)]
  public class CallRecords : ActiveRecordSet<CallRecord>
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="CallRecords"/> class.
    /// </summary>
    public CallRecords()
      : base("CallRecord")
    { }

    /// <summary>
    /// Gets the call identifier from claim number.
    /// </summary>
    /// <param name="claimNumber">The claim number.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static public string GetCallIdFromClaimNumber(string claimNumber, string instance)
    {
      var records = new CallRecords
      {
        Instance = instance,
        Query = string.Format("select * from call where claim_number = '{0}'", claimNumber)
      };
      var call = records.Results().FirstOrDefault();

      return call != null ? call.CallId : string.Empty;
    }

  }
  /// <summary>
  /// Encapsulates the CALL table 
  /// </summary>
  [ComVisible(false)]
  public class CallRecord : EncryptedActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="CallRecord"/> class.
    /// </summary>
    public CallRecord()
      : base("CALL")
    {
      columns.Add(new Column("CALL_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("CALLFLOW_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("LOB_CD", String.Empty, "CHAR"));
      columns.Add(new Column("CLIENT_HRCY_STEP_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("USER_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("INPUT_SYSTEM_NAME", String.Empty, "VARCHAR2"));
      columns.Add(new Column("INPUT_TYPE", String.Empty, "VARCHAR2"));
      columns.Add(new Column("SWITCH_CALL_ID", String.Empty, "VARCHAR2"));
      columns.Add(new Column("CALL_START_TIME", String.Empty, "DATE"));
      columns.Add(new Column("LEGACY_CALL_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("ORGINAL_CALL_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("CALL_END_TIME", String.Empty, "DATE"));
      columns.Add(new Column("STATUS", String.Empty, "VARCHAR2"));
      columns.Add(new Column("TYPE", String.Empty, "CHAR"));
      columns.Add(new Column("POLICY_NUMBER", String.Empty, "VARCHAR2"));
      columns.Add(new Column("CLAIM_NUMBER", String.Empty, "VARCHAR2"));
      columns.Add(new Column("CALLER_INFO", String.Empty, "VARCHAR2"));
      columns.Add(new Column("ENTRY_POINT_HRCY_STEP_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("LOCATION", String.Empty, "VARCHAR2"));
      columns.Add(new Column("SERVER_NAME", String.Empty, "VARCHAR2"));
      columns.Add(new Column("ENROLLMENT_STATUS_CD", String.Empty, "CHAR"));
      columns.Add(new Column("ENROLLMENT_STATUS_REASON", String.Empty, "VARCHAR2"));
      columns.Add(new Column("EMAIL_ADDRESS", String.Empty, "VARCHAR2"));
      columns.Add(new Column("ACCESS_CODE", String.Empty, "VARCHAR2"));
      columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
      columns.Add(new Column("LAST_MODIFIED_DT", string.Empty, "DATE"));
    }


    /// <summary>
    /// Initializes a new instance of the <see cref="CallRecord"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public CallRecord(IDataReader reader)
      : base(reader, "CALL")
    {
    }

    //protected override void InitEncryption()
    //{
    //  if (!Instance.StartsWith("SED", StringComparison.InvariantCultureIgnoreCase)) return;
    //  EncryptAttributes.Clear();
    //  EncryptAttributes.Add("CALLER_INFO");
    //}

    #region CallId
    /// <summary>
    /// Gets or sets the call id.
    /// </summary>
    /// <value>The call id.</value>
    public string CallId
    {
      get
      {
        return GetColumnValue("CALL_ID");
      }
      set
      {
        SetColumnValue("CALL_ID", value);
      }
    }
    #endregion
    #region AccntHrcyStepId
    /// <summary>
    /// Gets or sets the accnt hrcy step id.
    /// </summary>
    /// <value>The accnt hrcy step id.</value>
    public string AccntHrcyStepId
    {
      get
      {
        return GetColumnValue("ACCNT_HRCY_STEP_ID");
      }
      set
      {
        SetColumnValue("ACCNT_HRCY_STEP_ID", value);
      }
    }
    #endregion
    #region CallflowId
    /// <summary>
    /// Gets or sets the callflow id.
    /// </summary>
    /// <value>The callflow id.</value>
    public string CallflowId
    {
      get
      {
        return GetColumnValue("CALLFLOW_ID");
      }
      set
      {
        SetColumnValue("CALLFLOW_ID", value);
      }
    }
    #endregion
    #region LobCd
    /// <summary>
    /// Gets or sets the lob cd.
    /// </summary>
    /// <value>The lob cd.</value>
    public string LobCd
    {
      get
      {
        return GetColumnValue("LOB_CD");
      }
      set
      {
        SetColumnValue("LOB_CD", value);
      }
    }
    #endregion
    #region ClientHrcyStepId
    /// <summary>
    /// Gets or sets the client hrcy step id.
    /// </summary>
    /// <value>The client hrcy step id.</value>
    public string ClientHrcyStepId
    {
      get
      {
        return GetColumnValue("CLIENT_HRCY_STEP_ID");
      }
      set
      {
        SetColumnValue("CLIENT_HRCY_STEP_ID", value);
      }
    }
    #endregion
    #region UserId
    /// <summary>
    /// Gets or sets the user id.
    /// </summary>
    /// <value>The user id.</value>
    public string UserId
    {
      get
      {
        return GetColumnValue("USER_ID");
      }
      set
      {
        SetColumnValue("USER_ID", value);
      }
    }
    #endregion
    #region InputSystemName
    /// <summary>
    /// Gets or sets the name of the input system.
    /// </summary>
    /// <value>The name of the input system.</value>
    public string InputSystemName
    {
      get
      {
        return GetColumnValue("INPUT_SYSTEM_NAME");
      }
      set
      {
        SetColumnValue("INPUT_SYSTEM_NAME", value);
      }
    }
    #endregion
    #region InputType
    /// <summary>
    /// Gets or sets the type of the input.
    /// </summary>
    /// <value>The type of the input.</value>
    public string InputType
    {
      get
      {
        return GetColumnValue("INPUT_TYPE");
      }
      set
      {
        SetColumnValue("INPUT_TYPE", value);
      }
    }
    #endregion
    #region SwitchCallId
    /// <summary>
    /// Gets or sets the switch call id.
    /// </summary>
    /// <value>The switch call id.</value>
    public string SwitchCallId
    {
      get
      {
        return GetColumnValue("SWITCH_CALL_ID");
      }
      set
      {
        SetColumnValue("SWITCH_CALL_ID", value);
      }
    }
    #endregion
    #region CallStartTime
    /// <summary>
    /// Gets or sets the call start time.
    /// </summary>
    /// <value>The call start time.</value>
    public string CallStartTime
    {
      get
      {
        return GetColumnValue("CALL_START_TIME");
      }
      set
      {
        SetColumnValue("CALL_START_TIME", value);
      }
    }
    #endregion
    #region LegacyCallId
    /// <summary>
    /// Gets or sets the legacy call id.
    /// </summary>
    /// <value>The legacy call id.</value>
    public string LegacyCallId
    {
      get
      {
        return GetColumnValue("LEGACY_CALL_ID");
      }
      set
      {
        SetColumnValue("LEGACY_CALL_ID", value);
      }
    }
    #endregion
    #region OrginalCallId
    /// <summary>
    /// Gets or sets the orginal call id.
    /// </summary>
    /// <value>The orginal call id.</value>
    public string OrginalCallId
    {
      get
      {
        return GetColumnValue("ORGINAL_CALL_ID");
      }
      set
      {
        SetColumnValue("ORGINAL_CALL_ID", value);
      }
    }
    #endregion
    #region CallEndTime
    /// <summary>
    /// Gets or sets the call end time.
    /// </summary>
    /// <value>The call end time.</value>
    public string CallEndTime
    {
      get
      {
        return GetColumnValue("CALL_END_TIME");
      }
      set
      {
        SetColumnValue("CALL_END_TIME", value);
      }
    }
    #endregion
    #region Status
    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>The status.</value>
    public string Status
    {
      get
      {
        return GetColumnValue("STATUS");
      }
      set
      {
        SetColumnValue("STATUS", value);
      }
    }
    #endregion
    #region Type
    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>The type.</value>
    public string Type
    {
      get
      {
        return GetColumnValue("TYPE");
      }
      set
      {
        SetColumnValue("TYPE", value);
      }
    }
    #endregion
    #region PolicyNumber
    /// <summary>
    /// Gets or sets the policy number.
    /// </summary>
    /// <value>The policy number.</value>
    public string PolicyNumber
    {
      get
      {
        return GetColumnValue("POLICY_NUMBER");
      }
      set
      {
        SetColumnValue("POLICY_NUMBER", value);
      }
    }
    #endregion
    #region ClaimNumber
    /// <summary>
    /// Gets or sets the claim number.
    /// </summary>
    /// <value>The claim number.</value>
    public string ClaimNumber
    {
      get
      {
        return GetColumnValue("CLAIM_NUMBER");
      }
      set
      {
        SetColumnValue("CLAIM_NUMBER", value);
      }
    }
    #endregion
    #region CallerInfo
    /// <summary>
    /// Gets or sets the caller info.
    /// </summary>
    /// <value>The caller info.</value>
    public string CallerInfo
    {
      get
      {
        return GetColumnValue("CALLER_INFO");
      }
      set
      {
        SetColumnValue("CALLER_INFO", value);
      }
    }
    #endregion
    #region EntryPointHrcyStepId
    /// <summary>
    /// Gets or sets the entry point hrcy step id.
    /// </summary>
    /// <value>The entry point hrcy step id.</value>
    public string EntryPointHrcyStepId
    {
      get
      {
        return GetColumnValue("ENTRY_POINT_HRCY_STEP_ID");
      }
      set
      {
        SetColumnValue("ENTRY_POINT_HRCY_STEP_ID", value);
      }
    }
    #endregion
    #region Location
    /// <summary>
    /// Gets or sets the location.
    /// </summary>
    /// <value>The location.</value>
    public string Location
    {
      get
      {
        return GetColumnValue("LOCATION");
      }
      set
      {
        SetColumnValue("LOCATION", value);
      }
    }
    #endregion
    #region ServerName
    /// <summary>
    /// Gets or sets the name of the server.
    /// </summary>
    /// <value>The name of the server.</value>
    public string ServerName
    {
      get
      {
        return GetColumnValue("SERVER_NAME");
      }
      set
      {
        SetColumnValue("SERVER_NAME", value);
      }
    }
    #endregion
    #region EnrollmentStatusCd
    /// <summary>
    /// Gets or sets the enrollment status cd.
    /// </summary>
    /// <value>The enrollment status cd.</value>
    public string EnrollmentStatusCd
    {
      get
      {
        return GetColumnValue("ENROLLMENT_STATUS_CD");
      }
      set
      {
        SetColumnValue("ENROLLMENT_STATUS_CD", value);
      }
    }
    #endregion
    #region EnrollmentStatusReason
    /// <summary>
    /// Gets or sets the enrollment status reason.
    /// </summary>
    /// <value>The enrollment status reason.</value>
    public string EnrollmentStatusReason
    {
      get
      {
        return GetColumnValue("ENROLLMENT_STATUS_REASON");
      }
      set
      {
        SetColumnValue("ENROLLMENT_STATUS_REASON", value);
      }
    }
    #endregion
    #region EmailAddress
    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    /// <value>The email address.</value>
    public string EmailAddress
    {
      get
      {
        return GetColumnValue("EMAIL_ADDRESS");
      }
      set
      {
        SetColumnValue("EMAIL_ADDRESS", value);
      }
    }
    #endregion
    #region AccessCode
    /// <summary>
    /// Gets or sets the access code.
    /// </summary>
    /// <value>The access code.</value>
    public string AccessCode
    {
      get
      {
        return GetColumnValue("ACCESS_CODE");
      }
      set
      {
        SetColumnValue("ACCESS_CODE", value);
      }
    }
    #endregion

    #region CreatedDate
    /// <summary>
    /// CREATED_DT
    /// </summary>
    public DateTime CreatedDate
    {
      get { return GetColumnValueAsDateTime("CREATED_DT") ?? default(DateTime); }
    }
    #endregion

    #region LastModifiedDate
    /// <summary>
    /// LAST_MODIFIED_DT
    /// </summary>
    public DateTime LastModifiedDate
    {
      get { return GetColumnValueAsDateTime("LAST_MODIFIED_DT") ?? default(DateTime); }
    }
    #endregion



    /// <summary>
    /// Generates the update SQL.
    /// </summary>
    /// <returns></returns>
    protected override string GenerateUpdateSql()
    {
      var updateSql = new StringBuilder();

      updateSql.AppendFormat("update CALL set ACCNT_HRCY_STEP_ID = {0}", AccntHrcyStepId);
      // just allow update of these selected columns (for now)
      if (Status.Length > 0)
      {
        updateSql.AppendFormat(",STATUS = '{0}'", Status);
      }
      if (UserId.Length > 0)
      {
        updateSql.AppendFormat(",USER_ID = {0}", UserId);
      }
      if (LobCd.Length > 0)
      {
        updateSql.AppendFormat(",LOB_CD = '{0}'", LobCd);
      }
      if (Type.Length > 0)
      {
        updateSql.AppendFormat(",TYPE = '{0}'", Type);
      }
      if (PolicyNumber.Length > 0)
      {
        updateSql.AppendFormat(",POLICY_NUMBER = '{0}'", PolicyNumber);
      }
      if (ClaimNumber.Length > 0)
      {
        updateSql.AppendFormat(",CLAIM_NUMBER = '{0}'", ClaimNumber);
      }
      if (CallerInfo.Length > 0)
      {
        updateSql.AppendFormat(",CALLER_INFO = '{0}'", CallerInfo);
      }
      if (InputSystemName.Length > 0)
      {
        updateSql.AppendFormat(",INPUT_SYSTEM_NAME = '{0}'", InputSystemName);
      }
      if (CallEndTime.Length > 0)
      {
        updateSql.AppendFormat(",CALL_END_TIME = TO_DATE('{0}','mm/dd/yyyy HH:MI:SS AM')", CallEndTime);
      }
      updateSql.AppendFormat(" where CALL_ID = {0}", CallId);

      return updateSql.ToString();
    }

    /// <summary>
    /// Generates the insert SQL.
    /// </summary>
    /// <returns></returns>
    //protected override string GenerateInsertSql()
    //{
    //  var sql = new StringBuilder("INSERT INTO CALL (CALL_ID, ACCNT_HRCY_STEP_ID, ENTRY_POINT_HRCY_STEP_ID, LOB_CD, ");
    //  sql.Append("CLIENT_HRCY_STEP_ID, CALL_START_TIME, STATUS,USER_ID, ");
    //  sql.Append("INPUT_SYSTEM_NAME, CALLER_INFO, ORGINAL_CALL_ID, SERVER_NAME) VALUES(");
    //  sql.AppendFormat("{0}, {1}, {2}, '{3}', {4}, sysdate, 'INPROC', {5}, 'FNS NET', '{6}', {7}, '{8}')",
    //    CallId, AccntHrcyStepId, ClientHrcyStepId, LobCd, ClientHrcyStepId, UserId, CallerInfo, (OrginalCallId.Length > 0 ? OrginalCallId : "NULL"),ServerName );
    //  return sql.ToString();
    //}

    /// <summary>
    /// Gets the ahs id from call id.
    /// </summary>
    /// <param name="callId">The call id.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    public static string GetAhsIdFromCallId(string callId, string instance)
    {
      var results = string.Empty;
      try
      {
        var record = new CallRecord { Instance = instance, CallId = callId };
        if (record.Execute())
          results = record.AccntHrcyStepId;
        else
          throw new ApplicationException(record.LastError);
      }
      catch (Exception ex)
      {
        GeneralUtility.LogError(ex.Message, "GetAhsIdFromCallId");
      }
      return results;
    }

    public static string GetCallClaimIdFromCallId(string callId, string instance)
    {
      try
      {
        var records = new ActiveRecordSet
        {
          Instance = instance, 
          Query = string.Format("select call_claim_id from call_claim where call_id = {0}",callId)
        };
        if (records.Execute() && records.MoveNext())
        {
          return records[0].ToString();
        }
      }
      catch (Exception ex)
      {
        GeneralUtility.LogError(ex.Message, "GetCallClaimIdFromCallId");
      }
      return string.Empty;
    }

    /// <summary>
    /// Gets the routing record.
    /// </summary>
    public CallRoutingRecord RoutingRecord
    {
      get
      {

        var results = new CallRoutings
        {
          Instance = Instance,
          Query = "select * from call_routing where call_id = :call_id"
        };

        results.AddParameter("call_id", CallId);
        return results.Results().FirstOrDefault();
      }
    }
  }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/CallRecord.cs $
 * 
 * 12    7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 11    5/11/10 7:39p Gwynnj
 * Added Date fields to the call Table (CallRecord class)
 * 
 * 10    4/16/10 5:24p Gwynnj
 * Added support for CallMonitor to manage INPROC calls that are abandoned
 * 
 * 9     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 8     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 7     5/12/09 12:31p John.gwynn
 * updates to coordinate with 1.1 code
 * 
 * 6     1/21/09 3:13p John.gwynn
 * aded InputSystem to the update statement for CallRecord
 * 
 * 5     1/21/09 1:32p John.gwynn
 * fixed SS keyword bug and added UserId to the CallRecord update
 * 
 * 4     11/14/08 3:49p John.gwynn
 * fixed a bug where the call.POLICY_NUMBER field was being updated with
 * the value from STATUS
 * 
 * 3     5/25/08 8:57p John.gwynn
 * added LOB_CD to the update statement for CALL table
 * 
 * 2     4/03/08 7:33p John.gwynn
 * built in support for Call Final Save via CallRouting table
 * 
 * 1     12/04/07 5:30p John.gwynn
 * Added AhsActiveRecord and corresonding recordset , added CallRecord and
 * updates for CallXml (eSurance)
 */
#endregion