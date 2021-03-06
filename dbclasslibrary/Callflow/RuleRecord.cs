#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/RuleRecord.cs 9     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using DbClassLibrary.ActiveRecords;

namespace DbClassLibrary.Callflow
{
  /// <summary>
  /// Encapsulates the RULES table record
  /// </summary>
  [System.Runtime.InteropServices.ComVisible(false), TableDefinition(TableName = "FNSOWNER.RULES")]
  public class RuleRecord : ActiveRecord
  {
    private static readonly Dictionary<int, string> RuleCache = new Dictionary<int, string>();
    private static readonly object SessionCache = new object();
    /// <summary>
    /// Initializes a new instance of the <see cref="RuleRecord"/> class.
    /// </summary>
    public RuleRecord()
      : base("RULES")
    {
      // Begin AutoGenerated Column Definitions
      columns.Add(new Column("RULE_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("RULE_TEXT", String.Empty, "VARCHAR2"));
      columns.Add(new Column("TYPE", String.Empty, "VARCHAR2"));
      columns.Add(new Column("USER_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("LANGUAGE_TYPE_CD", String.Empty, "VARCHAR2"));
      columns.Add(new Column("COMMENTS", String.Empty, "VARCHAR2"));
      columns.Add(new Column("CREATED_DT", String.Empty, "DATE"));
      columns.Add(new Column("LAST_MODIFIED_DT", String.Empty, "DATE"));
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="RuleRecord"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public RuleRecord(IDataReader reader)
      : base(reader, "RULES")
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="RuleRecord"/> class.
    /// This constructor is required for typesafe cloning.
    /// </summary>
    /// <param name="source">The source.</param>
    public RuleRecord(ActiveRecord source)
      : base(source)
    { }
    /// <summary>
    /// Gets the rule id.
    /// </summary>
    /// <value>The rule id.</value>
    [FieldDefintion(FieldName = "RULE_ID")]
    public string RuleId
    {
      get { return GetColumnValue("RULE_ID"); }
      set { SetColumnValue("RULE_ID", value); }
    }
    /// <summary>
    /// Gets the rule text.
    /// </summary>
    /// <value>The rule text.</value>
    [FieldDefintion(FieldName = "RULE_TEXT")]
    public string RuleText
    {
      get { return GetColumnValue("RULE_TEXT"); }
    }
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    /// <value>The type of the rule.</value>
    public string RuleType
    {
      get { return GetColumnValue("TYPE"); }
    }
    /// <summary>
    /// Gets the user id.
    /// </summary>
    /// <value>The user id.</value>
    [FieldDefintion(FieldName = "USER_ID")]
    public string UserId
    {
      get { return GetColumnValue("USER_ID"); }
    }
    /// <summary>
    /// Gets the language type code.
    /// </summary>
    /// <value>The language type code.</value>
    [FieldDefintion(FieldName = "LANGUAGE_TYPE_CD")]
    public string LanguageTypeCode
    {
      get { return GetColumnValue("LANGUAGE_TYPE_CD"); }
    }
    /// <summary>
    /// Gets the comments.
    /// </summary>
    /// <value>The comments.</value>
    public string Comments
    {
      get { return GetColumnValue("COMMENTS"); }
    }
    /// <summary>
    /// Gets the created date.
    /// </summary>
    /// <value>The created date.</value>
    [FieldDefintion(FieldName = "CREATED_DT")]
    public string CreatedDate
    {
      get { return GetColumnValue("CREATED_DT"); }
    }
    /// <summary>
    /// Gets the last modified date.
    /// </summary>
    /// <value>The last modified date.</value>
    [FieldDefintion(FieldName = "LAST_MODIFIED_DT")]
    public string LastModifiedDate
    {
      get { return GetColumnValue("LAST_MODIFIED_DT"); }
    }

    /// <summary>
    /// Gets the rule text for rule id.
    /// </summary>
    public static string GetRuleText(int ruleId)
    {
      if (RuleCache.ContainsKey(ruleId))
      {
        return RuleCache[ruleId];
      }
      var ruleText = GetRuleTextForRuleId(ruleId.ToString(CultureInfo.InvariantCulture), ApplicationConfiguration.Instance.DefaultInstance);
      if (string.IsNullOrEmpty(ruleText)) return ruleText;
      lock (SessionCache)
      {
        RuleCache.Add(ruleId, ruleText);
      }
      return ruleText;
    }
    /// <summary>
    /// Gets the rule text for rule id.
    /// </summary>
    /// <param name="ruleId">The rule id.</param>
    /// <returns></returns>
    public static string GetRuleTextForRuleId(string ruleId)
    {
      return GetRuleTextForRuleId(ruleId, ApplicationConfiguration.Instance.DefaultInstance);
    }
    /// <summary>
    /// Gets the rule text for rule id overload instance.
    /// </summary>
    /// <param name="ruleId">The rule id.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    public static string GetRuleTextForRuleId(string ruleId, string instance)
    {
      var results = string.Empty;

      var record = new RuleRecord { Instance = instance, RuleId = ruleId };
      if (record.Execute())
      {
        results = record.RuleText;
      }
      return results;
    }
  }
}
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/RuleRecord.cs $
 * 
 * 9     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 8     2/23/10 2:53p Gwynnj
 * Added CallRouting support
 * 
 * 7     12/03/09 12:21p John.gwynn
 * SessionCache may be null
 * 
 * 6     10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 5     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 4     5/26/09 7:03p John.gwynn
 * Added deep cloning and ToArray, ToList support (ToArray is for interop
 * ToList is because we have no LINQ today)
 * 
 * 3     5/26/09 11:06a John.gwynn
 * Added interop definitions
 * 
 * 2     3/03/09 11:25a John.gwynn
 * added GetRuleText(long)
 * 
 * 1     10/30/07 7:14p John.gwynn
 * ActiveRecordSet now sets instance on record instantiation.  Added
 * support for Evaluation of dynamic Business rules (see RuleRecordSet)
 * and added UsStates for eSurance dropdowns
 */