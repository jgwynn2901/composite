namespace DbClassLibrary.ActiveRecords
{
  public class PolicyLookupSet : ActiveRecordSet<PolicyLookup>
  {
    public PolicyLookupSet()
      : base("PolicyLookup")
		{}
  }
}
