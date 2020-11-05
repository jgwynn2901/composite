#region Header
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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ClaimSubmissionLog.cs 8     6/20/11 7:14p Gwynnj $ */
#endregion
using System;
using System.Data;
using System.Runtime.InteropServices;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DbClassLibrary
{
  /// <summary>
  /// Summary description for ClaimSubmissionLog.
  /// </summary>
  [ComVisible(false)]
  public class ClaimSubmissionLog
  {
    private string _instance;
    private string _rquId;

    private const string Rqst = "REQUEST";
    private const string Rsps = "RESPONSE";
    private const string Name = "ClaimSubmissionLog";

    /// <summary>
    /// Gets or sets the instance.
    /// </summary>
    /// <value>The instance.</value>
    public string Instance
    {
      get
      {
        return _instance;
      }
      set
      {
        _instance = value;
      }
    }

    /// <summary>
    /// Gets the last error.
    /// </summary>
    /// <value>The last error.</value>
    public string LastErrorMessage { get; private set; }

    /// <summary>
    /// Gets or sets the rqu id.
    /// </summary>
    /// <value>The rqu id.</value>
    public string RquId
    {
      get
      {
        return _rquId;
      }
      set
      {
        _rquId = value;
      }
    }
    /// <summary>
    /// Gets the request.
    /// </summary>
    /// <returns></returns>
    public string GetRequest()
    {
      return GetRecord(Rqst);
    }
    /// <summary>
    /// Gets the response.
    /// </summary>
    /// <returns></returns>
    public string GetResponse()
    {
      return GetRecord(Rsps);
    }
    /// <summary>
    /// Sets the request.
    /// </summary>
    /// <param name="req">The req.</param>
    /// <returns></returns>
    public int SetRequest(string req)
    {
      return SetRecord(Rqst, req);
    }
    /// <summary>
    /// Sets the response.
    /// </summary>
    /// <param name="res">The res.</param>
    /// <returns></returns>
    public int SetResponse(string res)
    {
      return SetRecord(Rsps, res);
    }

    public string TimeStamp { get; set; }

    /// <summary>
    /// Sets the record.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <param name="clob">The clob.</param>
    /// <returns></returns>
    private int SetRecord(string type, string clob)
    {
      var results = -1;

      try
      {
        using (var conn = new OracleConnection(GeneralUtility.GetConnectStringFromInstance(_instance)))
        {
          var command = new OracleCommand("DBCLASSLIBRARY.UpdateClaimSubmissionLog", conn) { CommandType = CommandType.StoredProcedure };

          var oracleParameter1 = new OracleParameter();
          var oracleParameter2 = new OracleParameter();
          var oracleParameter3 = new OracleParameter();
          var oracleParameter4 = new OracleParameter();
          var oracleParameter5 = new OracleParameter();

          oracleParameter1.Direction = ParameterDirection.Output;
          oracleParameter1.OracleDbType = OracleDbType.Decimal;
          oracleParameter1.ParameterName = "P_ID";
          oracleParameter2.OracleDbType = OracleDbType.Varchar2;
          oracleParameter2.ParameterName = "P_RQUID";
          oracleParameter3.OracleDbType = OracleDbType.Varchar2;
          oracleParameter3.ParameterName = "P_REQUESTTYPE";
          oracleParameter4.OracleDbType = OracleDbType.Varchar2;
          oracleParameter4.ParameterName = "P_TIMESTAMP";
          oracleParameter5.OracleDbType = OracleDbType.Clob;
          oracleParameter5.ParameterName = "CLOBDATA";

          command.Parameters.Add(oracleParameter1);
          command.Parameters.Add(oracleParameter2);
          command.Parameters.Add(oracleParameter3);
          command.Parameters.Add(oracleParameter4);
          command.Parameters.Add(oracleParameter5);

          command.Parameters[1].Value = _rquId;
          command.Parameters[2].Value = type;
          command.Parameters[3].Value = TimeStamp;
          command.Parameters[4].Direction = ParameterDirection.Input;
          command.Parameters[4].Size = clob.Length;
          command.Parameters[4].Value = clob;

          conn.Open();
          command.ExecuteNonQuery();

          results = Convert.ToInt32(command.Parameters[0].Value.ToString());
        }
      }
      catch (Exception ex)
      {
        LastErrorMessage = ex.Message;
        GeneralUtility.DebugLog(LastErrorMessage, Name);
      }
      return results;
    }

    /// <summary>
    /// Gets the record.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <returns></returns>
    private string GetRecord(string type)
    {
      var results = String.Empty;

      try
      {
        using (var conn = new OracleConnection(GeneralUtility.GetConnectStringFromInstance(_instance)))
        {
          var command = new OracleCommand("DBCLASSLIBRARY.GetClaimSubLogData", conn) { CommandType = CommandType.StoredProcedure };

          var oracleParameter1 = new OracleParameter();
          var oracleParameter2 = new OracleParameter();
          var oracleParameter3 = new OracleParameter();

          oracleParameter1.OracleDbType = OracleDbType.Varchar2;
          oracleParameter1.ParameterName = "P_RQUID";
          oracleParameter2.OracleDbType = OracleDbType.Varchar2;
          oracleParameter2.ParameterName = "P_REQUESTTYPE";
          oracleParameter3.OracleDbType = OracleDbType.Clob;
          oracleParameter3.ParameterName = "CLOBDATA";

          command.Parameters.Add(oracleParameter1);
          command.Parameters.Add(oracleParameter2);
          command.Parameters.Add(oracleParameter3);

          command.Parameters[0].Value = _rquId;
          command.Parameters[1].Value = type;
          command.Parameters[2].Direction = ParameterDirection.Output;

          conn.Open();
          command.ExecuteNonQuery();

          var clobResults = (OracleClob)command.Parameters[2].Value;
          results = clobResults.Value;
        }
      }
      catch (Exception ex)
      {
        LastErrorMessage = ex.Message;
        GeneralUtility.DebugLog(LastErrorMessage, Name);
      }

      return results;
    }
    /// <summary>
    /// Resets the response.
    /// </summary>
    /// <returns></returns>
    public bool ResetResponse()
    {
      var results = false;
      try
      {
        using (var conn = new OracleConnection(GeneralUtility.GetConnectStringFromInstance(_instance)))
        {
          var command = new OracleCommand("DBCLASSLIBRARY.ResetClaimLogResponse", conn) { CommandType = CommandType.StoredProcedure };

          var oracleParameter1 = new OracleParameter();
          var oracleParameter2 = new OracleParameter();

          oracleParameter1.OracleDbType = OracleDbType.Varchar2;
          oracleParameter1.ParameterName = "P_RQUID";
          oracleParameter2.OracleDbType = OracleDbType.Int32;
          oracleParameter2.ParameterName = "P_RESULTS";

          command.Parameters.Add(oracleParameter1);
          command.Parameters.Add(oracleParameter2);

          command.Parameters[0].Value = _rquId;
          command.Parameters[1].Direction = ParameterDirection.Output;

          conn.Open();
          command.ExecuteNonQuery();

          results = 1 <= Convert.ToInt32(command.Parameters[1].Value);
        }
      }
      catch (Exception ex)
      {
        LastErrorMessage = ex.Message;
        GeneralUtility.DebugLog(LastErrorMessage, Name);
      }
      return results;
    }
  }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ClaimSubmissionLog.cs $
 * 
 * 8     6/20/11 7:14p Gwynnj
 * Modifications to ClaimSubmissionLog to accomodate asynchronous calls
 * with the addition of new timestamps to mark the actual point at witch
 * the request is made.  N.B. this requires a new version of
 * DbClassLibrary to be installed.
 * 
 * 7     10/19/10 5:55p Gwynnj
 * Added EntityResponse store for Affirmative
 * 
 * 6     1/05/10 6:54p Gwynnj
 * 
 * 5     11/02/09 1:40p John.gwynn
 * minor edits
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 2     7/09/06 3:28p John.gwynn
 * added ResetResponse
 * 
 * 1     7/08/06 4:05p John.gwynn
 * Added ClaimSubmissionLog
 */
#endregion
