#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2008 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SessionKey.cs 8     8/10/10 6:30p Gwynnj $ */
#endregion

using System;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(false)]
  public class SessionKeys : ActiveRecordSet<SessionKey>
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="SessionKeys"/> class.
    /// </summary>
    public SessionKeys()
      : base("SessionKey")
    { }
  }
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(false)]
  public class SessionKey : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="SessionKey"/> class.
    /// </summary>
    public SessionKey(string key)
      : base("SESSION_KEY")
    {
      columns.Add(new Column("CALL_ID", key.Length <= 10 ? key : String.Empty, "NUMBER"));
      columns.Add(new Column("SESSION_KEY", key.Length > 10 ? key : String.Empty, "VARCHAR2"));
      columns.Add(new Column("SERVER_NAME", String.Empty, "VARCHAR2"));
      columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
      columns.Add(new Column("LAST_MODIFIED_DT", string.Empty, "DATE"));
      _canDelete = true;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SessionKey"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public SessionKey(IDataReader reader)
      : base(reader, "SESSION_KEY")
    {
      _canDelete = true;
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

    #region Key
    /// <summary>
    /// Gets or sets the session key.
    /// </summary>
    /// <value>The session key.</value>
    public string Key
    {
      get
      {
        return GetColumnValue("SESSION_KEY");
      }
      set
      {
        SetColumnValue("SESSION_KEY", value);
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
      return "update session_key set last_modified_dt = sysdate where session_key = :session_key and call_id = :call_id";
    }

    /// <summary>
    /// If you use parameters in your update SQL
    /// You must also override this method to add
    /// their corresponding values from properties.
    /// </summary>
    protected override void AddUpdateParameters()
    {
      AddParameter("session_key", Key);
      AddParameter("call_id", CallId);
    }


    /// <summary>
    /// Generates the where clause.
    /// </summary>
    /// <returns></returns>
    protected override string GenerateWhereClause()
    {
      if (CallId.Length == 0 && Key.Length > 0)
        primaryKeyIndex = 1;

      return GeneratePrimaryKeyWhereClause();
    }

    /// <summary>
    /// Generates the delete SQL
    /// subclasses must implement this explicitely
    /// for delete to work.  Carefully we presume...
    /// </summary>
    /// <returns></returns>
    protected override string GenerateDeleteSql()
    {
      var filter = GenerateWhereClause();
      if (string.IsNullOrEmpty(filter))
        throw new ApplicationException(string.Format("Attempt to delete with no primary key."));

      return string.Format("DELETE from {0} {1}", Name, filter);
    }

    /// <summary>
    /// Gets the call id from session.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <returns></returns>
    public static string GetCallIdFromSession(string key)
    {
      var results = new SessionKey(key);
      return results.Execute() ? results.CallId : string.Empty;
    }

    /// <summary>
    /// Gets the machine from session.
    /// </summary>
    public static SessionKey GetSession(string key)
    {
      return GetSession(key, ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Gets the session.
    /// </summary>
    public static SessionKey GetSession(string key, string instance)
    {
      var results = new SessionKey(key) { Instance = instance };
      return results.Execute()
          ? results
          : default(SessionKey);
    }

    /// <summary>
    /// Inserts the session key.
    /// </summary>
    public static bool InsertSessionKey(string callId, string key)
    {
      return InsertSessionKey(callId, key, ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Inserts the session key.
    /// </summary>
    public static bool InsertSessionKey(string callId, string key, string instance)
    {
      var results = new SessionKey(callId) { Instance = instance, Key = key, ServerName = Environment.MachineName };
      return results.Insert();
    }

    /// <summary>
    /// Determines whether the specified current is dirty.
    /// </summary>
    /// <param name="current">The current.</param>
    /// <returns>
    /// 	<c>true</c> if the specified current is dirty; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsDirty(SessionKey current)
    {
      var lastSession = GetSession(current.Key);
      if (lastSession == null) return false;
      return current.ServerName != lastSession.ServerName ||
             current.LastModifiedDate < lastSession.LastModifiedDate;
    }

  }
}
