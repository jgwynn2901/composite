using System;
using System.Data;
using System.Globalization;

namespace DbClassLibrary.Security
{
  public class Identity : ActiveRecord
  {
    private readonly User _user = null;

    /// <summary>
    /// Gets the identity identifier.
    /// </summary>
    /// <value>
    /// The identity identifier.
    /// </value>
    public string IdentityId
    {
      get
      {
        return GetColumnValue("USERID");
      }
    }


    /// <summary>
    /// Gets or sets the name of the identity.
    /// </summary>
    /// <value>
    /// The name of the identity.
    /// </value>
    public string IdentityName
    {
      get
      {
        return GetColumnValue("USERNAME");
      }
      set
      {
        SetColumnValue("USERNAME", value);
      }
    }

    /// <summary>
    /// Gets or sets the name of the lowered identity user name.
    /// </summary>
    /// <value>
    /// The user name of the lowered identity.
    /// </value>
    public string LoweredIdentityName
    {
      get
      {
        return GetColumnValue("LOWEREDUSERNAME");
      }
      set
      {
        SetColumnValue("LOWEREDUSERNAME", value);
      }

    }

    /// <summary>
    /// Gets the application identifier.
    /// </summary>
    /// <value>
    /// The application identifier.
    /// </value>
    public string ApplicationId
    {
      get
      {
        return GetColumnValue("APPLICATIONID");
      }
    }

    /// <summary>
    /// Gets the last activity date.
    /// </summary>
    /// <value>
    /// The last activity date.
    /// </value>
    public string LastActivityDate
    {
      get
      {
        return GetColumnValue("LASTACTIVITYDATE");
      }
    }

    /// <summary>
    /// Gets or sets the FNS user id.
    /// </summary>
    /// <value>
    /// The FNS user id.
    /// </value>
    public long FnsUserId
    {
      get
      {
        return GetColumnValueAsInt("FNS_USER_ID") ?? -1;
      }
      set
      {
        SetColumnValue("FNS_USER_ID", value.ToString(CultureInfo.InvariantCulture));
      }
    }

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Identity"/> class.
    /// </summary>
    public Identity()
      : base("ORA_ASPNET_USERS")
    {
      columns.Add(new RawColumn("APPLICATIONID", String.Empty, "RAW"));
      columns.Add(new RawColumn("USERID", String.Empty, "RAW"));
      columns.Add(new Column("USERNAME", String.Empty, "VARCHAR2"));
      columns.Add(new Column("LOWEREDUSERNAME", String.Empty, "VARCHAR2"));
      columns.Add(new Column("MOBILEALIAS", String.Empty, "VARCHAR2"));
      columns.Add(new Column("ISANONYMOUS", String.Empty, "VARCHAR2"));
      columns.Add(new Column("LASTACTIVITYDATE", String.Empty, "DATE"));
      columns.Add(new Column("ISANONYMOUS", String.Empty, "INTEGER"));
      columns.Add(new Column("FNS_USER_ID", String.Empty, "NUMBER"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Identity"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public Identity(IDataReader reader)
      : base(reader, "USERS")
    { }

    #endregion

    /// <summary>
    /// Gets the FNS user record if it exists.
    /// </summary>
    /// <value>
    /// The FNS user.
    /// </value>
    public User FnsUser
    {
      get
      {
        if (_user != null)
        {
          return _user;
        }
        return FnsUserId == -1 
          ? default(User) 
          : Users.FindById((int)FnsUserId);
      }
    }
  }
}
