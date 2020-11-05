using System.Linq;

namespace DbClassLibrary.Callflow
{
  public class RoutingAddresses : ActiveRecordSet<RoutingAddress>
  {
    public RoutingAddresses() : base("RoutingAddress")
    {}

    public static RoutingAddress Find(int id)
    {
      var records = new RoutingAddresses
      {
        Query = "select * from ROUTINGADDRESS where ROUTINGADDRESS_ID	= :routing_id"
      };

      records.AddParameter("routing_id", id);
      return records.Results().FirstOrDefault();
    }
  }
}
