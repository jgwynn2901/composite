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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AhsActiveRecordSet.cs 6     10/29/09 12:18p John.gwynn $ */
#endregion

using System.Linq;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(false)]
  public class AhsActiveRecordSet : ActiveRecordSet<AhsActiveRecord>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AhsActiveRecordSet"/> class.
    /// </summary>
    public AhsActiveRecordSet()
      : base("AhsActiveRecord")
    {
    }

    /// <summary>
    /// Gets the active ahs record by type and location code.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <param name="locationCode">The location code.</param>
    /// <returns></returns>
    static public AhsActiveRecord GetActiveAhsByTypeAndLocationCode(string type, string locationCode)
    {
      var set = new AhsActiveRecordSet
      {
        Query = string.Format(
          "select * from ACCOUNT_HIERARCHY_STEP where ACTIVE_STATUS = 'ACTIVE' AND TYPE = '{0}' AND LOCATION_CODE = '{1}'",
          type, locationCode)
      };
      return set.Results().FirstOrDefault();
    }

    static public AhsActiveRecord Find(string id)
    {
      var set = new AhsActiveRecordSet
      {
        Query = "select * from ACCOUNT_HIERARCHY_STEP where ACTIVE_STATUS = 'ACTIVE' AND ACCNT_HRCY_STEP_ID = :ahsId "
      };
      set.AddParameter("ahsId", id);
      return set.Results().FirstOrDefault();
    }

    /// <summary>
    /// Gets the active ahs id by type and location code.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <param name="locationCode">The location code.</param>
    /// <returns></returns>
    static public string GetActiveAhsIdByTypeAndLocationCode(string type, string locationCode)
    {
      var results = GetActiveAhsByTypeAndLocationCode(type, locationCode);
      return results == null ? "" : results.AccntHrcyStepId;
    }


    /// <summary>
    /// Gets the risk location by account identifier insured location.
    /// </summary>
    /// <param name="accountId">The account identifier.</param>
    /// <param name="insured">The insured.</param>
    /// <param name="location">The location.</param>
    /// <returns></returns>
    static public string GetRiskLocationByAccountIdInsuredLocation(string accountId, string insured, string location)
    {
      var results = GetRiskLocationByAccountIdInsured(accountId, insured, location);
      return results == null ? "" : results.AccntHrcyStepId;
    }
    static public AhsActiveRecord GetRiskLocationByAccountIdInsured(string accountId, string insured, string location)
    {
        var set = new AhsActiveRecordSet
        {
            Query = string.Format(
              "select * from ACCOUNT_HIERARCHY_STEP AHS where AHS.ACTIVE_STATUS = 'ACTIVE' AND AHS.TYPE = 'RISK LOCATION' AND AHS.LOCATION_CODE = '{0}' and parent_node_id = (",
              location)
        };
        set.Query +=
          "select INS.ACCNT_HRCY_STEP_ID from ACCOUNT_HIERARCHY_STEP INS where INS.ACTIVE_STATUS = 'ACTIVE' AND INS.TYPE = 'INSURED' ";
        set.Query += string.Format("AND INS.LOCATION_CODE = '{0}' AND INS.parent_node_id = {1})", insured, accountId);
        return set.Results().FirstOrDefault();
    }
  }
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AhsActiveRecordSet.cs $
 * 
 * 6     10/29/09 12:18p John.gwynn
 * added AhsActiveRecord.GetAhsActiveRecordByUploadKey
 * 
 * 5     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 4     2/17/09 6:47p John.gwynn
 * added Callflow.Attributes
 * 
 * 3     1/21/09 1:32p John.gwynn
 * fixed SS keyword bug and added UserId to the CallRecord update
 */
#endregion