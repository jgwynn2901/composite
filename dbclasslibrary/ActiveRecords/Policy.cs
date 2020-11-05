using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;

namespace DbClassLibrary.ActiveRecords
{
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(false)]
  public class Policy : ActiveRecord
  {
    private Agent _lazyAgent;
    private List<AhsActiveRecord> _lazyRiskLocations;
    private AhsActiveRecord _lazyAccount;
    private AhsActiveRecord _lazyInsured;

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Policy"/> class.
    /// </summary>
    public Policy()
      : base("POLICY")
    {
      columns.Add(new Column("POLICY_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("LOB_CD", string.Empty, "CHAR"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("CARRIER_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("AGENT_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("COMPANY_CODE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("POLICY_NUMBER", string.Empty, "VARCHAR2"));
      columns.Add(new Column("EFFECTIVE_DATE", string.Empty, "DATE"));
      columns.Add(new Column("ORIGINAL_EFFECTIVE_DATE", string.Empty, "DATE"));
      columns.Add(new Column("POLICY_DESC", string.Empty, "VARCHAR2"));
      columns.Add(new Column("EXPIRATION_DATE", string.Empty, "DATE"));
      columns.Add(new Column("CHANGE_DATE", string.Empty, "DATE"));
      columns.Add(new Column("LOAD_DATE", string.Empty, "DATE"));
      columns.Add(new Column("CANCELLATION_DATE", string.Empty, "DATE"));
      columns.Add(new Column("SELF_INSURED", string.Empty, "CHAR"));
      columns.Add(new Column("MANAGED_CARE_TYPE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ADDITIONAL_DELIVERIES", string.Empty, "VARCHAR2"));
      columns.Add(new Column("DIVISION_CD", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ACTIVE_START_DT", string.Empty, "DATE"));
      columns.Add(new Column("ACTIVE_END_DT", string.Empty, "DATE"));
      columns.Add(new Column("UPLOAD_KEY", string.Empty, "VARCHAR2"));
      columns.Add(new Column("FILE_TRAN_LOG_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("POLICY_COV_CODES", string.Empty, "VARCHAR2"));
      columns.Add(new Column("POLICY_TYPE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("TPA_ID", string.Empty, "NUMBER"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LocationCode"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public Policy(IDataReader reader)
      : base(reader, "POLICY")
    {
    }

    #endregion

    #region PolicyId
    /// <summary>
    /// POLICY_ID
    /// </summary>
    public string PolicyId
    {
      get { return GetColumnValue("POLICY_ID"); }
      set { SetColumnValue("POLICY_ID", value); }
    }
    #endregion

    #region LobCode
    /// <summary>
    /// LOB_CD
    /// </summary>
    public string LobCode
    {
      get { return GetColumnValue("LOB_CD"); }
      set { SetColumnValue("LOB_CD", value); }
    }
    #endregion

    #region AccntHrcyStepId
    /// <summary>
    /// ACCNT_HRCY_STEP_ID
    /// </summary>
    public string AccntHrcyStepId
    {
      get { return GetColumnValue("ACCNT_HRCY_STEP_ID"); }
      set { SetColumnValue("ACCNT_HRCY_STEP_ID", value); }
    }
    #endregion

    #region CarrierId
    /// <summary>
    /// CARRIER_ID
    /// </summary>
    public string CarrierId
    {
      get { return GetColumnValue("CARRIER_ID"); }
      set { SetColumnValue("CARRIER_ID", value); }
    }
    #endregion

    #region AgentId
    /// <summary>
    /// AGENT_ID
    /// </summary>
    public string AgentId
    {
      get { return GetColumnValue("AGENT_ID"); }
      set { SetColumnValue("AGENT_ID", value); }
    }
    #endregion

    #region CompanyCode
    /// <summary>
    /// COMPANY_CODE
    /// </summary>
    public string CompanyCode
    {
      get { return GetColumnValue("COMPANY_CODE"); }
      set { SetColumnValue("COMPANY_CODE", value); }
    }
    #endregion

    #region PolicyNumber
    /// <summary>
    /// POLICY_NUMBER
    /// </summary>
    public string PolicyNumber
    {
      get { return GetColumnValue("POLICY_NUMBER"); }
      set { SetColumnValue("POLICY_NUMBER", value); }
    }
    #endregion

    #region EffectiveDate
    /// <summary>
    /// EFFECTIVE_DATE
    /// </summary>
    public DateTime EffectiveDate
    {
      get { return GetColumnValueAsDateTime("EFFECTIVE_DATE") ?? default(DateTime); }
      set { SetColumnValue("EFFECTIVE_DATE", value.ToShortDateString()); }
    }
    #endregion

    #region OriginalEffectiveDate
    /// <summary>
    /// ORIGINAL_EFFECTIVE_DATE
    /// </summary>
    public string OriginalEffectiveDate
    {
      get { return GetColumnValue("ORIGINAL_EFFECTIVE_DATE"); }
      set { SetColumnValue("ORIGINAL_EFFECTIVE_DATE", value); }
    }
    #endregion

    #region PolicyDecription
    /// <summary>
    /// POLICY_DESC
    /// </summary>
    public string PolicyDecription
    {
      get { return GetColumnValue("POLICY_DESC"); }
      set { SetColumnValue("POLICY_DESC", value); }
    }
    #endregion

    #region ExpirationDate
    /// <summary>
    /// EXPIRATION_DATE
    /// </summary>
    public DateTime ExpirationDate
    {
      get { return GetColumnValueAsDateTime("EXPIRATION_DATE") ?? default(DateTime); }
      set { SetColumnValue("EXPIRATION_DATE", value.ToShortDateString()); }
    }
    #endregion

    #region ChangeDate
    /// <summary>
    /// CHANGE_DATE
    /// </summary>
    public string ChangeDate
    {
      get { return GetColumnValue("CHANGE_DATE"); }
      set { SetColumnValue("CHANGE_DATE", value); }
    }
    #endregion

    #region LoadDate
    /// <summary>
    /// LOAD_DATE
    /// </summary>
    public string LoadDate
    {
      get { return GetColumnValue("LOAD_DATE"); }
      set { SetColumnValue("LOAD_DATE", value); }
    }
    #endregion

    #region CancellationDate
    /// <summary>
    /// CANCELLATION_DATE
    /// </summary>
    public string CancellationDate
    {
      get { return GetColumnValue("CANCELLATION_DATE"); }
      set { SetColumnValue("CANCELLATION_DATE", value); }
    }
    #endregion

    #region SelfInsured
    /// <summary>
    /// SELF_INSURED
    /// </summary>
    public string SelfInsured
    {
      get { return GetColumnValue("SELF_INSURED"); }
      set { SetColumnValue("SELF_INSURED", value); }
    }
    #endregion

    #region ManagedCareType
    /// <summary>
    /// MANAGED_CARE_TYPE
    /// </summary>
    public string ManagedCareType
    {
      get { return GetColumnValue("MANAGED_CARE_TYPE"); }
      set { SetColumnValue("MANAGED_CARE_TYPE", value); }
    }
    #endregion

    #region AdditionalDeliveries
    /// <summary>
    /// ADDITIONAL_DELIVERIES
    /// </summary>
    public string AdditionalDeliveries
    {
      get { return GetColumnValue("ADDITIONAL_DELIVERIES"); }
      set { SetColumnValue("ADDITIONAL_DELIVERIES", value); }
    }
    #endregion

    #region DivisionCode
    /// <summary>
    /// DIVISION_CD
    /// </summary>
    public string DivisionCode
    {
      get { return GetColumnValue("DIVISION_CD"); }
      set { SetColumnValue("DIVISION_CD", value); }
    }
    #endregion

    #region ActiveStartDate
    /// <summary>
    /// ACTIVE_START_DT
    /// </summary>
    public string ActiveStartDate
    {
      get { return GetColumnValue("ACTIVE_START_DT"); }
      set { SetColumnValue("ACTIVE_START_DT", value); }
    }
    #endregion

    #region ActiveEndDate
    /// <summary>
    /// ACTIVE_END_DT
    /// </summary>
    public string ActiveEndDate
    {
      get { return GetColumnValue("ACTIVE_END_DT"); }
      set { SetColumnValue("ACTIVE_END_DT", value); }
    }
    #endregion

    #region UploadKey
    /// <summary>
    /// UPLOAD_KEY
    /// </summary>
    public string UploadKey
    {
      get { return GetColumnValue("UPLOAD_KEY"); }
      set { SetColumnValue("UPLOAD_KEY", value); }
    }
    #endregion

    #region FileTranLogId
    /// <summary>
    /// FILE_TRAN_LOG_ID
    /// </summary>
    public string FileTranLogId
    {
      get { return GetColumnValue("FILE_TRAN_LOG_ID"); }
      set { SetColumnValue("FILE_TRAN_LOG_ID", value); }
    }
    #endregion

    #region PolicyCovCodes
    /// <summary>
    /// POLICY_COV_CODES
    /// </summary>
    public string PolicyCovCodes
    {
      get { return GetColumnValue("POLICY_COV_CODES"); }
      set { SetColumnValue("POLICY_COV_CODES", value); }
    }
    #endregion

    #region PolicyType
    /// <summary>
    /// POLICY_TYPE
    /// </summary>
    public string PolicyType
    {
      get { return GetColumnValue("POLICY_TYPE"); }
      set { SetColumnValue("POLICY_TYPE", value); }
    }
    #endregion

    #region TpaId
    /// <summary>
    /// TPA_ID
    /// </summary>
    public string TpaId
    {
      get { return GetColumnValue("TPA_ID"); }
      set { SetColumnValue("TPA_ID", value); }
    }
    #endregion

    /// <summary>
    /// Gets the agent.
    /// </summary>
    public Agent Agent
    {
      get
      {
        if (AgentId.Length > 0 && _lazyAgent == null)
          _lazyAgent = GetAgent();
        return _lazyAgent;

      }
    }

    /// <summary>
    /// Gets the risk locations.  
    /// </summary>
    public IEnumerable<AhsActiveRecord> RiskLocations
    {
      get { return _lazyRiskLocations ?? (_lazyRiskLocations = GetLocations()); }
    }

    /// <summary>
    /// Gets the account.
    /// </summary>
    /// <value>
    /// The account.
    /// </value>
    public AhsActiveRecord Account
    {
      get
      {
        if (_lazyAccount == null)
        {
          _lazyAccount = GetAccount();
        }
        return _lazyAccount;
      }
    }

    /// <summary>
    /// Gets the insured.
    /// </summary>
    /// <value>
    /// The insured.
    /// </value>
    public AhsActiveRecord Insured
    {
      get
      {
        if (_lazyInsured == null)
        {
          _lazyInsured = GetInsured();
        }
        return _lazyInsured;
      }
    }

    /// <summary>
    /// Gets the risk location.
    /// </summary>
    /// <value>
    /// The risk location.
    /// </value>
    public AhsActiveRecord RiskLocation
    {
      get
      {
       return RiskLocations.FirstOrDefault();
      }
    }
    /// <summary>
    /// Gets the locations.
    /// </summary>
    /// <returns></returns>
    private List<AhsActiveRecord> GetLocations()
    {
      var location = new AhsActiveRecordSet
      {
        Instance = Instance,
        Query = string.Format(
        "Select * from ACCOUNT_HIERARCHY_STEP A where TYPE = 'RISK LOCATION' and ACTIVE_STATUS = 'ACTIVE' " +
        "START WITH A.ACCNT_HRCY_STEP_ID in (select ACCNT_HRCY_STEP_ID from AHS_POLICY where POLICY_ID = {0}) " +
        "CONNECT BY PRIOR ACCNT_HRCY_STEP_ID = PARENT_NODE_ID", PolicyId)
      };
      // location.AddParameter("policyId", PolicyId);
      return location.Results().ToList();
    }

    private AhsActiveRecord GetAccount()
    {
      var location = new AhsActiveRecordSet
      {
        Instance = Instance,
        Query = string.Format(
        "Select * from ACCOUNT_HIERARCHY_STEP A where TYPE = 'ACCOUNT' and ACTIVE_STATUS = 'ACTIVE' " +
        "START WITH A.ACCNT_HRCY_STEP_ID in (select ACCNT_HRCY_STEP_ID from AHS_POLICY where POLICY_ID = {0}) " +
        "CONNECT BY PRIOR PARENT_NODE_ID = ACCNT_HRCY_STEP_ID", PolicyId)
      };
      // location.AddParameter("policyId", PolicyId);
      return location.Results().ToList().FirstOrDefault();
    }

    private AhsActiveRecord GetInsured()
    {
      var location = new AhsActiveRecordSet
      {
        Instance = Instance,
        Query = string.Format(
        "Select * from ACCOUNT_HIERARCHY_STEP A where TYPE = 'INSURED' and ACTIVE_STATUS = 'ACTIVE' " +
        "START WITH A.ACCNT_HRCY_STEP_ID in (select ACCNT_HRCY_STEP_ID from AHS_POLICY where POLICY_ID = {0}) " +
        "CONNECT BY PRIOR PARENT_NODE_ID = ACCNT_HRCY_STEP_ID", PolicyId)
      };
      // location.AddParameter("policyId", PolicyId);
      return location.Results().ToList().FirstOrDefault();
    }

    private Agent GetAgent()
    {
      var agent = new Agent { Instance = Instance, AgentId = AgentId };
      return agent.Execute() ? agent : null;
    }

    /// <summary>
    /// Gets the active policies.
    /// </summary>
    /// <param name="client">The client AhsId.</param>
    /// <param name="lobCd">The line of business.</param>
    /// <param name="policyNumber">The policy number.</param>
    /// <param name="dateOfLoss">The date of loss.</param>
    /// <returns>All qualified policies</returns>
    public static IEnumerable<Policy> GetActivePolicies(int client, string lobCd, string policyNumber, string dateOfLoss)
    {
      return GetActivePolicies(client, lobCd, policyNumber, dateOfLoss,
                               ApplicationConfiguration.Instance.DefaultInstance);
    }
    /// <summary>
    /// Gets the active policies.
    /// </summary>
    /// <param name="client">The client AhsId.</param>
    /// <param name="lobCd">The line of business.</param>
    /// <param name="policyNumber">The policy number.</param>
    /// <param name="dateOfLoss">The date of loss.</param>
    /// <param name="instance">The database instance.</param>
    /// <returns>All qualified policies</returns>
    public static IEnumerable<Policy> GetActivePolicies(int client, string lobCd, string policyNumber, string dateOfLoss, string instance)
    {
      var results = new Policies
                        {
                          Instance = instance,
                          Query = string.Format(
                              "select P.POLICY_ID, AP.LOB_CD, AP.ACCNT_HRCY_STEP_ID, AGENT_ID, POLICY_NUMBER, EFFECTIVE_DATE,EXPIRATION_DATE " +
                              "from POLICY P, AHS_POLICY AP, ACCOUNT_HIERARCHY_STEP A where P.POLICY_ID = AP.POLICY_ID " +
                              "and AP.ACCNT_HRCY_STEP_ID = A.ACCNT_HRCY_STEP_ID and A.CLIENT_NODE_ID = {0} " +
                              "and A.ACTIVE_STATUS = 'ACTIVE' and AP.LOB_CD = '{1}' " +
                              "and P.POLICY_NUMBER = '{2}'", client, lobCd, policyNumber)

                        };

      //results.AddParameter("client", client);
      //results.AddParameter("lobCd", lobCd);
      //results.AddParameter("policyNumber", policyNumber);

      DateTime lossDate;
      if (!string.IsNullOrEmpty(dateOfLoss) && DateTime.TryParse(dateOfLoss, out lossDate))
        return results.Results().Where(a => a.EffectiveDate <= lossDate && a.ExpirationDate >= lossDate);
      return results.Results();
    }

    /// <summary>
    /// Gets the active policies from tree.
    /// </summary>
    public static IEnumerable<Policy> GetActivePoliciesFromTree(string ahsId, string lobCd, string instance)
    {
      var results = new Policies
      {
        Instance = instance,
        Query = string.Format(
            "select P.POLICY_ID, AP.LOB_CD, AP.ACCNT_HRCY_STEP_ID, AGENT_ID, POLICY_NUMBER, EFFECTIVE_DATE,EXPIRATION_DATE " +
            "from POLICY P, AHS_POLICY AP, ACCOUNT_HIERARCHY_STEP A where P.POLICY_ID = AP.POLICY_ID " +
            "and AP.ACCNT_HRCY_STEP_ID = A.ACCNT_HRCY_STEP_ID and A.ACTIVE_STATUS = 'ACTIVE' and AP.LOB_CD = '{0}' " +
            "and A.accnt_hrcy_step_id in (select accnt_hrcy_Step_id from account_hierarchy_step " +
            "connect by prior accnt_hrcy_step_id = parent_node_id start with accnt_hrcy_Step_id = {1})", lobCd, ahsId)

      };
      return results.Results();
    }

    /// <summary>
    /// Gets the policy extension attributes.
    /// </summary>
    /// <value>The extensions.</value>
    public IEnumerable<PolicyExtension> Extensions
    {
      get
      {
        var extensions = new PolicyExtensions
                             {

                               Instance = Instance,
                               Query = "select * from policy_extension where policy_id = " + PolicyId
                             };
        //extensions.AddParameter("policy_id", PolicyId);
        return extensions.Results();
      }
    }
  }
}
