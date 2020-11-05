#region Header
/**************************************************************************
* Innovation First Notice
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2009 by Innovation First Notice 
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Security/Users.cs 6     3/12/10 3:41p Gwynnj $ */
#endregion

using System.Globalization;
using System.Linq;


namespace DbClassLibrary.Security
{
  /// <summary>
  /// 
  /// </summary>
  [System.Runtime.InteropServices.ComVisible(false)]
  public class Users : ActiveRecordSet<User>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Users"/> class.
    /// </summary>
    public Users()
      : base("User")
    { }

    /// <summary>
    /// Returns userId for a given user
    /// </summary>
    /// <param name="userName"></param>
    /// <returns></returns>
    public static string GetUserIdFromUserName(string userName)
    {
      return GetUserIdFromUserName(userName, ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Returns userId for a given user
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="instance"></param>
    /// <returns></returns>
    public static string GetUserIdFromUserName(string userName, string instance)
    {
      var results = "";
      var users = new Users
                    {
                      Instance = instance,
                      Query = string.Format("select * from USERS_VIEW where NAME = '{0}'", userName)
                    };
      if (users.Execute())
      {
        foreach (var u in users)
        {
          results = u.UserId.ToString(CultureInfo.InvariantCulture);
          break;
        }
      }
      return results;
    }
    /// <summary>
    /// Finds the by id.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    public static User FindById(int id)
    {
      return FindById(id, ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Finds the user by id for a given instance.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    public static User FindById(int id, string instance)
    {
      var user = new User
      {
        Instance = instance,
        UserId = id
      };

      return user.Execute() ? user : default (User);
    }

    /// <summary>
    /// Users the in group.
    /// </summary>
    /// <param name="userId">The user identifier.</param>
    /// <param name="groupName">Name of the group.</param>
    /// <returns></returns>
    public static bool UserInGroup(int userId, string groupName)
    {
      var records = new ActiveRecordSet { Query = "select COUNT(*) AS COUNT from groups G, user_group U where G.GROUP_ID = U.GROUP_ID AND U.USER_ID = :user_id AND G.GROUP_NM = :group_name " };
      records.AddParameter("user_id", userId);
      records.AddParameter("group_name", groupName);
      return records.Execute() && records.GetRecord(0).GetColumnValue("COUNT") != "0";
    }
  }
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Security/Users.cs $
 * 
 * 6     3/12/10 3:41p Gwynnj
 * added Results() to get linq cheap
 * 
 * 5     12/03/09 12:21p John.gwynn
 * SessionCache may be null
 * 
 * 4     10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 3     9/22/09 11:06a John.gwynn
 * Import Field updates
 * 
 * 2     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 1     4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 3     1/21/09 1:32p John.gwynn
 * fixed SS keyword bug and added UserId to the CallRecord update
 */
#endregion