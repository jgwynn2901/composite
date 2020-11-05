using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace DbClassLibrary
{
  public class RulesUsedBy : DbBaseClass, IEnumerable
  {
    private enum eParmList
    {
      RuleId = 0,
      Results
    };

    /// <summary>
    /// enumerates the REF CURSOR result set Columns
    /// </summary>
    public enum ResultList
    {
      /// <summary>
      /// RULE_ID
      /// </summary>
      RuleId = 0,
      /// <summary>
      /// RULE_TYPE
      /// </summary>
      EncryptionType,
      /// <summary>
      /// FRAME_ID
      /// </summary>
      FrameId,
      /// <summary>
      /// Name
      /// </summary>
      Name,
      /// <summary>
      /// UsedInTable
      /// </summary>
      UsedInTable,
      /// <summary>
      /// UsedInField
      /// </summary>
      UsedInField
    };

    /// <summary>
    /// Initializes a new instance of the <see cref="RulesUsedBy"/> class.
		/// </summary>
		public RulesUsedBy():this(String.Empty) {}	
	
		/// <summary>
    /// Initializes a new instance of the <see cref="RulesUsedBy"/> class.
		/// </summary>
		/// <param name="instance"></param>
    public RulesUsedBy(string instance)
      : base(instance)
		{
      _name = "DBCLASSLIBRARY.GetRuleUsedBy";	
			Initialize();
		}

    protected override void Initialize()
    {
      ///////////////////////////////////////////////////
      // p_MatchRuleId
      ///////////////////////////////////////////////////
      AddParm(ParameterDirection.Input, eParmList.RuleId.ToString(), "", DbType.Int32);
      ///////////////////////////////////////////////////
      // Results
      ///////////////////////////////////////////////////
      AddParm(ParameterDirection.Output, eParmList.Results.ToString(), "", DbType.Object);
    }

    public string RuleId
    {
      get
      {
        return GetValue(ResultList.RuleId.ToString());
      }
      set
      {
        SetValue(ResultList.RuleId.ToString(), value);
      }
    }

    public IEnumerator GetEnumerator()
    {
      IEnumerator results = null;

      if (_data != null && _data.Tables.Count > 0)
      {
        DataTable table = _data.Tables[0];
        if (table != null)
        {
          return table.Rows.GetEnumerator();
        }
      }
      return results;
    }

  }
}
