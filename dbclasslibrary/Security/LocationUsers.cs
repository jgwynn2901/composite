namespace DbClassLibrary.Security
{
  public class LocationUsers : ActiveRecordSet<LocationsUser>
  {
    public LocationUsers()
      : base("LocationsUser")
		{}
  }
}
