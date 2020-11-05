using System.Data;
using System.Globalization;

namespace DbClassLibrary.Callflow
{
  public class RoutingAddress : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingAddress"/> class.
    /// </summary>
    public RoutingAddress() : base("ROUTINGADDRESS")
    {
      columns.Add(new Column("ROUTINGADDRESS_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("DESCRIPTION", string.Empty, "VARCHAR2"));
      columns.Add(new Column("STATE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("FIPS", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ZIP", string.Empty, "VARCHAR2"));
    }

    public RoutingAddress(IDataReader reader)
      : base(reader, "ROUTINGADDRESS")
		{ }

    #region RoutingaddressId
    /// <summary>
    /// ROUTINGADDRESS_ID
    /// </summary>
    public int RoutingaddressId
    {

      get { return GetColumnValueAsInt("ROUTINGADDRESS_ID") ?? 0; }
      set { SetColumnValue("ROUTINGADDRESS_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region Description
    /// <summary>
    /// DESCRIPTION
    /// </summary>
    public string Description
    {

      get { return GetColumnValue("DESCRIPTION"); }
      set { SetColumnValue("DESCRIPTION", value); }
    }
    #endregion

    #region State
    /// <summary>
    /// STATE
    /// </summary>
    public string State
    {

      get { return GetColumnValue("STATE"); }
      set { SetColumnValue("STATE", value); }
    }
    #endregion

    #region Fips
    /// <summary>
    /// FIPS
    /// </summary>
    public string Fips
    {

      get { return GetColumnValue("FIPS"); }
      set { SetColumnValue("FIPS", value); }
    }
    #endregion

    #region Zip
    /// <summary>
    /// ZIP
    /// </summary>
    public string Zip
    {

      get { return GetColumnValue("ZIP"); }
      set { SetColumnValue("ZIP", value); }
    }
    #endregion
  }
}
