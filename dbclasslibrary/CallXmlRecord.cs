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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/CallXmlRecord.cs 12    3/02/12 12:14p Gwynnj $ */
#endregion

using System;
using System.Data;
using System.Globalization;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
  /// <summary>
  /// Encapsulates the CALL_XML table 
  /// </summary>
  [ComVisible(false)]
  public class CallXmlRecord : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="CallXmlRecord"/> class.
    /// </summary>
    public CallXmlRecord()
      : base("CALL_XML")
    {
      // Begin AutoGenerated Column Definitions
      columns.Add(new Column("CALL_ID", String.Empty, "NUMBER"));
      columns.Add(new RawColumn("CALL_XML", String.Empty, "VARCHAR2"));
    }

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
    #region CallXml
    /// <summary>
    /// Gets or sets the call XML.
    /// </summary>
    /// <value>The call XML.</value>
    public string CallXml
    {
      get
      {
        return GetColumnValue("CALL_XML");
      }
      set
      {
        SetColumnValue("CALL_XML", value);
      }
    }

    #endregion
    /// <summary>
    /// Generates the update SQL.
    /// </summary>
    /// <returns></returns>
    protected override string GenerateUpdateSql()
    {
      return string.Format("update CALL_XML set CALL_XML = :call_xml where CALL_ID = {0}", CallId);
    }
    /// <summary>
    /// Generates the insert SQL.
    /// </summary>
    /// <returns></returns>
    protected override string GenerateInsertSql()
    {
      return string.Format("insert into CALL_XML (CALL_ID, CALL_XML) VALUES ({0}, :call_xml )", CallId);
    }
    /// <summary>
    /// Executes the non query.
    /// </summary>
    /// <param name="db">The db.</param>
    /// <param name="commandText">The command text.</param>
    /// <returns></returns>
    protected override bool ExecuteNonQuery(Database db, string commandText)
    {
      bool results;
      try
      {
        var cmd = db.GetSqlStringCommand(commandText);
        if (cmd != null)
        {
          db.AddInParameter(cmd, "call_xml", DbType.AnsiString, CallXml);
          var records = db.ExecuteNonQuery(cmd);
          results = records == 1;
        }
        else
        {
          results = false;
          lastErrorMessage = "Unable to create COMMAND object";
        }
      }
      catch (Exception ex)
      {
        results = false;
        lastErrorMessage = ex.Message;
        GeneralUtility.LogError(lastErrorMessage, Name);
      }
      return results;
    }
    /// <summary>
    /// Inserts the call XML.
    /// </summary>
    /// <param name="callId">The call id.</param>
    /// <param name="callXml">The call XML.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static public bool InsertCallXml(string callId, string callXml, string instance)
    {
      var results = false;
      try
      {
        var record = new CallXmlRecord { CallId = callId, CallXml = callXml, Instance = instance };
        results = record.Insert();
      }
      catch (Exception ex)
      {
        GeneralUtility.LogError(ex.Message, "CallXmlRecord.InsertCallXml");
      }
      return results;
    }
    /// <summary>
    /// Updates the call XML.
    /// </summary>
    /// <param name="callId">The call id.</param>
    /// <param name="callXml">The call XML.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static public bool UpdateCallXml(string callId, string callXml, string instance)
    {
      var results = false;
      try
      {
        var record = new CallXmlRecord { CallId = callId, CallXml = callXml, Instance = instance };
        results = record.Update();
      }
      catch (Exception ex)
      {
        GeneralUtility.LogError(ex.Message, "CallXmlRecord.InsertCallXml");
      }
      return results;
    }

    /// <summary>
    /// Gets the call XML.
    /// </summary>
    /// <param name="callId">The call id.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static public string GetCallXml(string callId, string instance)
    {
      try
      {
        var record = new CallXmlRecord { CallId = callId, Instance = instance };
        if (record.Execute())
          return record.CallXml;
      }
      catch (Exception ex)
      {
        GeneralUtility.LogError(ex.Message, "CallXmlRecord.GetCallXml");
      }
      return "";
    }

    /// <summary>
    /// Gets the call XML.
    /// </summary>
    /// <param name="callId">The call identifier.</param>
    /// <returns></returns>
    static public string GetCallXml(int callId)
    {
      return GetCallXml(callId.ToString(CultureInfo.InvariantCulture), GeneralUtility.GetDbInstanceFromRegistry());
    }

    /// <summary>
    /// Determines whether [has call XML] [the specified call id].
    /// </summary>
    /// <param name="callId">The call id.</param>
    /// <param name="instance">The instance.</param>
    /// <returns>
    /// 	<c>true</c> if [has call XML] [the specified call id]; otherwise, <c>false</c>.
    /// </returns>
    static public bool HasCallXml(string callId, string instance)
    {
      try
      {
        var record = new CallXmlRecord { CallId = callId, Instance = instance };
        return record.Execute();
      }
      catch (Exception ex)
      {
        GeneralUtility.LogError(ex.Message, "CallXmlRecord.GetCallXml");
        return false;
      }
    }
  }
}
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/CallXmlRecord.cs $
 * 
 * 12    3/02/12 12:14p Gwynnj
 * subclassed Calumn to RawCalumn to isolate raw text Value for CallXml
 * 
 * 11    3/02/12 10:49a Gwynnj
 * Call_xml field override uses raw calumn values sans encoding/decoding
 * 
 * 10    7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 9     5/18/10 1:15p Gwynnj
 * log
 */