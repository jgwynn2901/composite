using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DbClassLibrary.Security
{
  public class UserSso : ActiveRecord
  {
    public UserSso() : base("USERS_SSO")
    {
      columns.Add(new Column("USERS_SSO_ID", string.Empty,"NUMBER"));
      columns.Add(new Column("USER_NAME", string.Empty,"VARCHAR2"));
      columns.Add(new Column("EMAIL_ADDRESS", string.Empty,"VARCHAR2"));
      columns.Add(new Column("SOURCE", string.Empty,"VARCHAR2"));
      columns.Add(new Column("STATUS", string.Empty,"VARCHAR2"));
      columns.Add(new Column("RESPONSE", string.Empty,"VARCHAR2"));
      columns.Add(new Column("CREATED_DT", string.Empty,"DATE"));
      columns.Add(new Column("LAST_MODIFIED_DT", string.Empty,"DATE"));
    }

    public UserSso(IDataReader reader) : base(reader, "USERS_SSO") {}

    #region UsersSsoId
    /// <summary>
    /// USERS_SSO_ID
    /// </summary>
    public string UsersSsoId
    {

      get { return GetColumnValue("USERS_SSO_ID"); }
      set { SetColumnValue("USERS_SSO_ID", value); }
    }
    #endregion

    #region UserName
    /// <summary>
    /// USER_NAME
    /// </summary>
    public string UserName
    {

      get { return GetColumnValue("USER_NAME"); }
      set { SetColumnValue("USER_NAME", value); }
    }
    #endregion

    #region EmailAddress
    /// <summary>
    /// EMAIL_ADDRESS
    /// </summary>
    public string EmailAddress
    {

      get { return GetColumnValue("EMAIL_ADDRESS"); }
      set { SetColumnValue("EMAIL_ADDRESS", value); }
    }
    #endregion

    #region Source
    /// <summary>
    /// SOURCE
    /// </summary>
    public string Source
    {

      get { return GetColumnValue("SOURCE"); }
      set { SetColumnValue("SOURCE", value); }
    }
    #endregion

    #region Status
    /// <summary>
    /// STATUS
    /// </summary>
    public string Status
    {

      get { return GetColumnValue("STATUS"); }
      set { SetColumnValue("STATUS", value); }
    }
    #endregion

    #region Response
    /// <summary>
    /// RESPONSE
    /// </summary>
    public string Response
    {

      get { return GetColumnValue("RESPONSE"); }
      set { SetColumnValue("RESPONSE", value); }
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
  }

}
