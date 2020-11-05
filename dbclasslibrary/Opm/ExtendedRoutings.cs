namespace DbClassLibrary.Opm
{
  public class ExtendedRoutings : ActiveRecordSet<ExtendedRouting>
  {
    public ExtendedRoutings()
      : base("ExtendedRouting")
    {}
    public override string Query
    {
      get
      {
        return string.IsNullOrEmpty(base.Query) ?
            "select EXTENDED_ROUTING_ID, ROUTING_PLAN_ID, ENABLED_RULE_ID, (SELECT RULE_TEXT from RULES where RULE_ID = ENABLED_RULE_ID) AS ENABLED_RULE_TEXT from extended_routing order by extended_routing_id" : base.Query;
      }
    }
  }
}
