namespace DbClassLibrary.Callflow
{
  public class RoutingAddressRules : ActiveRecordSet<RoutingAddressRule>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingAddressRules"/> class.
    /// </summary>
    public RoutingAddressRules() : base ("RoutingAddressRule")
    {}
  }
}
