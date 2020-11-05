using System.Data;
using System.Globalization;

namespace DbClassLibrary.Opm
{
  public class ExtendedRouting : ActiveRecord
  {
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="CallRouting"/> class.
    /// </summary>
    public ExtendedRouting()
      : base("EXTENDED_ROUTING")
    {
      columns.Add(new Column("EXTENDED_ROUTING_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ROUTING_PLAN_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ENABLED_RULE_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ENABLED_RULE_TEXT", string.Empty, "VARCHAR"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CallRouting"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public ExtendedRouting(IDataReader reader)
      : base(reader, "EXTENDED_ROUTING")
    { }
    #endregion

    #region ExtendedRoutingId
    /// <summary>
    /// EXTENDED_ROUTING_ID
    /// </summary>
    public int ExtendedRoutingId
    {
      get { return GetColumnValueAsInt("EXTENDED_ROUTING_ID") ?? 0; }
      set { SetColumnValue("EXTENDED_ROUTING_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region RoutingPlanId
    /// <summary>
    /// ROUTING_PLAN_ID
    /// </summary>
    public int RoutingPlanId
    {
      get { return GetColumnValueAsInt("ROUTING_PLAN_ID") ?? 0; }
      set { SetColumnValue("ROUTING_PLAN_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region EnabledRuleId
    /// <summary>
    /// ENABLED_RULE_ID
    /// </summary>
    public int EnabledRuleId
    {
      get { return GetColumnValueAsInt("ENABLED_RULE_ID") ?? 0; }
      set { SetColumnValue("ENABLED_RULE_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region EnabledRuleText
    /// <summary>
    /// ENABLED_RULE_TEXT
    /// </summary>
    public string EnabledRuleText
    {
      get { return GetColumnValue("ENABLED_RULE_TEXT"); }
      set { SetColumnValue("ENABLED_RULE_TEXT", value); }
    }
    #endregion


  }
}
