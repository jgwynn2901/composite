using System.Linq;

namespace DbClassLibrary.Callflow
{
  public class UserRecordSet : ActiveRecordSet<UserRecord>
  {
    public UserRecordSet()
      : base("UserRecord")
    {}

    /// <summary>
    /// Gets the user by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    static public UserRecord GetUserById(int id)
    {
      return GetUserById(ApplicationConfiguration.Instance.DefaultInstance, id);
    }

    /// <summary>
    /// Gets the user by identifier.
    /// </summary>
    /// <param name="instance">The instance.</param>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    static public UserRecord GetUserById(string instance, int id)
    {
      var user = new UserRecord {Instance = instance};
      return new UserRecordSet
      {
        Instance = instance,
        Query = string.Format("{0} WHERE USER_ID = {1}", user.GenerateSelectFrom(), id)
      }.Results().FirstOrDefault();
    }
  }
}
