using System.Data;
using System.Text;

namespace DbClassLibrary.Security
{
  public class UserSession : ActiveRecord
  {
    public UserSession()
      : base("USER_SESSION")
    {
      columns.Add(new Column("USER_SESSION_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("USER_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("SESSION_ID", string.Empty, "VARCHAR2"));
      columns.Add(new Column("SESSION_GUID", string.Empty, "VARCHAR2"));
      columns.Add(new Column("SESSION_START", string.Empty, "DATE"));
      columns.Add(new Column("SESSION_END", string.Empty, "DATE"));
      columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
      columns.Add(new Column("LAST_MODIFIED_DT", string.Empty, "DATE"));
    }

    public UserSession(IDataReader reader)
      : base(reader, "USER_SESSION")
		{}

    #region UserSessionId
    /// <summary>
    /// USER_SESSION_ID
    /// </summary>
    public string UserSessionId
    {

      get { return GetColumnValue("USER_SESSION_ID"); }
      set { SetColumnValue("USER_SESSION_ID", value); }
    }
    #endregion

    #region UserId
    /// <summary>
    /// USER_ID
    /// </summary>
    public string UserId
    {

      get { return GetColumnValue("USER_ID"); }
      set { SetColumnValue("USER_ID", value); }
    }
    #endregion

    #region SessionId
    /// <summary>
    /// SESSION_ID
    /// </summary>
    public string SessionId
    {

      get { return GetColumnValue("SESSION_ID"); }
      set { SetColumnValue("SESSION_ID", value); }
    }
    #endregion

    #region SessionGuId
    /// <summary>
    /// SESSION_GUID
    /// </summary>
    public string SessionGuId
    {

      get { return GetColumnValue("SESSION_GUID"); }
      set { SetColumnValue("SESSION_GUID", value); }
    }
    #endregion

    #region SessionStart
    /// <summary>
    /// SESSION_START
    /// </summary>
    public string SessionStart
    {

      get { return GetColumnValue("SESSION_START"); }
      set { SetColumnValue("SESSION_START", value); }
    }
    #endregion

    #region SessionEnd
    /// <summary>
    /// SESSION_END
    /// </summary>
    public string SessionEnd
    {

      get { return GetColumnValue("SESSION_END"); }
      set { SetColumnValue("SESSION_END", value); }
    }
    #endregion

    #region CreatedDate
    /// <summary>
    /// CREATED_DT
    /// </summary>
    public string CreatedDate
    {

      get { return GetColumnValue("CREATED_DT"); }
      set { SetColumnValue("CREATED_DT", value); }
    }
    #endregion

    #region LastModifiedDate
    /// <summary>
    /// LAST_MODIFIED_DT
    /// </summary>
    public string LastModifiedDate
    {

      get { return GetColumnValue("LAST_MODIFIED_DT"); }
      set { SetColumnValue("LAST_MODIFIED_DT", value); }
    }
    #endregion

    /// <summary>
    /// Generates the insert SQL.
    /// </summary>
    /// <returns></returns>
    protected override string GenerateInsertSql()
    {
      var sql = new StringBuilder();
      sql.AppendFormat("INSERT INTO {0} ( SESSION_ID, SESSION_GUID, SESSION_START) ", Name);
      sql.AppendFormat("VALUES ('{0}', '{1}', sysdate)", SessionId, SessionGuId);
      return sql.ToString();
    }

    /// <summary>
    /// Generates the update SQL.
    /// </summary>
    /// <returns></returns>
    protected override string GenerateUpdateSql()
    {
      return string.Format("update {0} set SESSION_END = sysdate where SESSION_ID = :1", Name);
    }

    /// <summary>
    /// If you use parameters in your update SQL
    /// You must also override this method to add
    /// their corresponding values from properties.
    /// </summary>
    protected override void AddUpdateParameters()
    {
      AddParameter(SessionId);
    }
  }
}
