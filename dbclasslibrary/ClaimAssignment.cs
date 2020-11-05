using System;

namespace DbClassLibrary
{
  public class ClaimAssignment : DbBaseClass
  {
    public ClaimAssignment() : this(GeneralUtility.GetDbInstanceFromRegistry()) { }

    public ClaimAssignment(string instance)
      : base(instance)
		{
      _name = "DBCLASSLIBRARY.LockClaimNumber";

			_parameterNames = new[]
				{
					"pin_ruleId",
          "pin_maximum",          
					"pin_claim_number"
				};

      ///////////////////////////////////////////////////
      //// pin_numClaimID
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        _parameterNames[0], "", System.Data.DbType.Int32);
      ///////////////////////////////////////////////////
      //// pin_numMax
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        _parameterNames[1], "", System.Data.DbType.Int32);
      ///////////////////////////////////////////////////
      ///// City
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Output,
        _parameterNames[2], "", System.Data.DbType.Int32);
		}

    public string ClaimNumberAssignmentRuleId
    {
      get
      {
        return GetValue("pin_ruleId");
      }
      set
      {
        SetValue("pin_ruleId", value);
      }
    }

    public string Maximum
    {
      get
      {
        return GetValue("pin_maximum");
      }
      set
      {
        SetValue("pin_maximum", value);
      }
    }

    public int ClaimNumber
    {
      get
      {
        int result;
        if (int.TryParse(GetValue("pin_claim_number"), out result))
          return result;
        return 0;
      }
    }

    /// <summary>
    /// Gets the next claim number.
    /// </summary>
    /// <param name="ruleId">The rule identifier.</param>
    /// <param name="max">The maximum.</param>
    /// <returns></returns>
    public static int GetNextClaimNumber(string ruleId, string max)
    {
      try
      {
        var claimAssignment = new ClaimAssignment
        {
          ClaimNumberAssignmentRuleId = ruleId,
          Maximum = max
        };
        if (claimAssignment.Execute())
        {
          return claimAssignment.ClaimNumber;
        }
      }
      catch (Exception ex)
      {
        GeneralUtility.DebugLog(ex.Message, "GetNextClaimNumber");
      }
      return 0;
    }
  }
}
