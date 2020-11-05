using System.Data;

namespace DbClassLibrary.ActiveRecords
{
  /// <summary>
  /// 
  /// </summary>
  public class PolicyLookup : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyLookup"/> class.
    /// </summary>
    public PolicyLookup()
      : base("RISK_LOCATIONS_VIEW")
    {
      columns.Add(new Column("NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("POLICY_ID", string.Empty, "NUMBER")); 
      columns.Add(new Column("POLICY_NUMBER", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("LOCATION_CODE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ADDRESS_1", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CITY", string.Empty, "VARCHAR2"));
      columns.Add(new Column("STATE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ZIP", string.Empty, "VARCHAR2"));
      columns.Add(new Column("TYPE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ACCOUNT_NUMBER", string.Empty, "VARCHAR2"));
      columns.Add(new Column("INSURED_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("DBA_NAME", string.Empty, "VARCHAR2"));
    }

    public PolicyLookup(IDataReader reader)
      : base(reader, "RISK_LOCATIONS_VIEW")
		{
		}
    /// <summary>
    /// Gets or sets the name of the location.
    /// </summary>
    /// <value>
    /// The name of the location.
    /// </value>
    [FieldDefintion(FieldName = "NAME")]
    public string LocationName
    {
      get { return GetColumnValue("NAME"); }
      set { SetColumnValue("NAME", value); }
    }

    /// <summary>
    /// Gets or sets the policy identifier.
    /// </summary>
    /// <value>
    /// The policy identifier.
    /// </value>
    [FieldDefintion(FieldName = "POLICY_ID")]
    public string PolicyId
    {
      get { return GetColumnValue("POLICY_ID"); }
      set { SetColumnValue("POLICY_ID", value); }
    }

    /// <summary>
    /// Gets or sets the policy number.
    /// </summary>
    /// <value>
    /// The policy number.
    /// </value>
    [FieldDefintion(FieldName = "POLICY_NUMBER")]
    public string PolicyNumber
    {
      get { return GetColumnValue("POLICY_NUMBER"); }
      set { SetColumnValue("POLICY_NUMBER", value); }
    }

    /// <summary>
    /// Gets or sets the accnt hrcy step identifier.
    /// </summary>
    /// <value>
    /// The accnt hrcy step identifier.
    /// </value>
    [FieldDefintion(FieldName = "ACCNT_HRCY_STEP_ID")]
    public string AccntHrcyStepId
    {
      get { return GetColumnValue("ACCNT_HRCY_STEP_ID"); }
      set { SetColumnValue("ACCNT_HRCY_STEP_ID", value); }
    }

    /// <summary>
    /// Gets or sets the location code.
    /// </summary>
    /// <value>
    /// The location code.
    /// </value>
    [FieldDefintion(FieldName = "LOCATION_CODE")]
    public string LocationCode
    {
      get { return GetColumnValue("LOCATION_CODE"); }
      set { SetColumnValue("LOCATION_CODE", value); }
    }

    /// <summary>
    /// Gets or sets the address1.
    /// </summary>
    /// <value>
    /// The address1.
    /// </value>
    [FieldDefintion(FieldName = "ADDRESS1")]
    public string Address1
    {
      get { return GetColumnValue("ADDRESS_1"); }
      set { SetColumnValue("ADDRESS_1", value); }
    }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    /// <value>
    /// The city.
    /// </value>
    [FieldDefintion(FieldName = "CITY")]
    public string City
    {
      get { return GetColumnValue("CITY"); }
      set { SetColumnValue("CITY", value); }
    }

    /// <summary>
    /// Gets or sets the state.
    /// </summary>
    /// <value>
    /// The state.
    /// </value>
    [FieldDefintion(FieldName = "STATE")]
    public string State
    {
      get { return GetColumnValue("STATE"); }
      set { SetColumnValue("STATE", value); }
    }

    /// <summary>
    /// Gets or sets the zip.
    /// </summary>
    /// <value>
    /// The zip.
    /// </value>
    [FieldDefintion(FieldName = "ZIP")]
    public string Zip
    {
      get { return GetColumnValue("ZIP"); }
      set { SetColumnValue("ZIP", value); }
    }

    /// <summary>
    /// Gets or sets the account number.
    /// </summary>
    /// <value>
    /// The account number.
    /// </value>
    [FieldDefintion(FieldName = "ACCOUNT_NUMBER")]
    public string AccountNumber
    {
      get { return GetColumnValue("ACCOUNT_NUMBER"); }
      set { SetColumnValue("ACCOUNT_NUMBER", value); }
    }
    /// <summary>
    /// Gets or sets the name of the insured.
    /// </summary>
    /// <value>
    /// The name of the insured.
    /// </value>
    [FieldDefintion(FieldName = "INSURED_NAME")]
    public string InsuredName
    {
      get { return GetColumnValue("INSURED_NAME"); }
      set { SetColumnValue("INSURED_NAME", value); }
    }

    /// <summary>
    /// Gets or sets the name of the dba.
    /// </summary>
    /// <value>
    /// The name of the dba.
    /// </value>
    [FieldDefintion(FieldName = "DBA_NAME")]
    public string DbaName
    {
      get { return GetColumnValue("DBA_NAME"); }
      set { SetColumnValue("DBA_NAME", value); }
    }

  }
}
