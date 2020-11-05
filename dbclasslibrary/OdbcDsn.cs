namespace DbClassLibrary
{
  /// <summary>
  /// Manage Odbc Connection String DSN.
  /// </summary>
  public class OdbcDsn
  {
    public string Name { get; private set; }
    public string User { get; private set; }
    public string Password { get; private set; }
    public string Server { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OdbcDsn"/> class.
    /// </summary>
    /// <param name="dsn">The DSN.</param>
    public OdbcDsn(string dsn)
    {
      if (string.IsNullOrEmpty(dsn)) return;
      var parms = dsn.Split(';');
      if (parms.Length != 4) return;
      Name = parms[0].Split('=')[1];
      User = parms[1].Split('=')[1];
      Password = parms[2].Split('=')[1];
      Server = parms[3].Split('=')[1];
    }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      return string.Format("DSN={0};UID={1};PWD={2};SERVER={3}", Name, User, Password, Server);
    }

    /// <summary>
    /// output To the display string for logging.
    /// </summary>
    /// <returns></returns>
    public string ToDisplayString()
    {
      return string.Format("DSN={0};UID={1};PWD=*******;SERVER={2}", Name, User, Server);
      
    }

    /// <summary>
    /// Creates OdbcDsn from encypted ConnectString.
    /// </summary>
    /// <param name="encrypted">The encrypted ConnectString.</param>
    static public OdbcDsn CreateFromEncypted(string encrypted)
    {
      return string.IsNullOrEmpty(encrypted) 
        ? null 
        : new OdbcDsn(GeneralUtility.InternalDecryptValue(GeneralUtility.SymmProvider, encrypted));
    }
  }
}
