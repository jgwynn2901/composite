namespace DbClassLibrary
{
  public class ConnectString
  {
    public string User { get; private set; }
    public string Password { get; private set; }
    public string DataSource { get; private set; }

    public ConnectString(string dsn)
    {
      if (string.IsNullOrEmpty(dsn)) return;
      var parms = dsn.Split(';');
      if (parms.Length < 3) return;
      DataSource = parms[0].Split('=')[1];
      User = parms[1].Split('=')[1];
      Password = parms[2].Split('=')[1];
    }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      return string.Format("Data Source={0};User Id={1};Password={2};", DataSource, User, Password);
    }

    /// <summary>
    /// output To the display string for logging.
    /// </summary>
    /// <returns></returns>
    public string ToDisplayString()
    {
      return string.Format("Data Source={0};User Id={1};Password=*********;", DataSource, User);

    }
  }
}
