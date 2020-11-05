using System.Linq;

namespace DbClassLibrary.Security
{
  public class Identities : ActiveRecordSet<Identity>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Identities"/> class.
    /// </summary>
    public Identities()
      : base("Identity")
    {

    }

    /// <summary>
    /// Finds the user by name.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns></returns>
    static public Identity FindByName(string name)
    {
      return FindByName(name, DbBaseClass.FNSBA);
    }
    /// <summary>
    /// Finds the user by name & instance.
    /// </summary>
    /// <param name="name">The user name.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static public Identity FindByName(string name, string instance)
    {
      var users = new Identities
                    {
                      Instance = instance,
                      Query = string.Format("select * from ORA_ASPNET_USERS where USERNAME = '{0}'", name)
                    };
      return users.Results().FirstOrDefault();
    }
  }
}
