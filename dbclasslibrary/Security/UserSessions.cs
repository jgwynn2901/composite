using System.Linq;

namespace DbClassLibrary.Security
{
  public class UserSessions : ActiveRecordSet<UserSession>
  {
    public UserSessions()
      : base("UserSession")
		{}

    /// <summary>
    /// Gets the user identifier for session unique identifier.
    /// </summary>
    /// <param name="sessionGuid">The session unique identifier.</param>
    /// <returns></returns>
    public static string GetUserIdForSessionGuid(string sessionGuid)
    {
      var results = new UserSessions
      {
        Query = "select * from USER_SESSION where SESSION_GUID = :session_guid "
      };
      results.AddParameter("session_guid", sessionGuid);  
      var session = results.Results().FirstOrDefault();
      var userId = session == default(UserSession) ? string.Empty : session.UserId;
      return userId;
    }

    public static bool CheckUserAccountBySessionGuid(string sessionGuid, string account)
    {
      var userId = GetUserIdForSessionGuid(sessionGuid);
      if (string.IsNullOrEmpty(userId)) return false;
      var records = new LocationUsers {Query = "select * from LOCATIONS_USER where ACCOUNT_USER_ID = :user_id"};
      records.AddParameter("user_id", userId);
      var results = records.Results().ToList();
      return !results.Any() || results.Select(a => a.AccountLocationCode == account).Any();
    }
  }
}
