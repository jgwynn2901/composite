using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(false), TableDefinition(TableName = "FNSOWNER.EMPLOYEE")]
  public class Employee : EncryptedActiveRecord
  {
    private Dictionary<string, string> _lazyExtensionAttributes;

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Employee"/> class.
    /// </summary>
    public Employee()
      : base("EMPLOYEE")
    {
      _lazyExtensionAttributes = null;

      columns.Add(new Column("EMPLOYEE_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("SSN", string.Empty, "CHAR"));
      columns.Add(new Column("NAME_FIRST", string.Empty, "VARCHAR2"));
      columns.Add(new Column("NAME_LAST", string.Empty, "VARCHAR2"));
      columns.Add(new Column("NAME_MID", string.Empty, "CHAR"));
      columns.Add(new Column("TITLE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ADDRESS1", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ADDRESS2", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CITY", string.Empty, "VARCHAR2"));
      columns.Add(new Column("STATE", string.Empty, "CHAR"));
      columns.Add(new Column("ZIP", string.Empty, "VARCHAR2"));
      columns.Add(new Column("COUNTRY", string.Empty, "VARCHAR2"));
      columns.Add(new Column("PHONE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CLIENT_NUMBER", string.Empty, "VARCHAR2"));
      columns.Add(new Column("FILING_STATE", string.Empty, "CHAR"));
      columns.Add(new Column("TOTAL_DEPENDENTS", string.Empty, "NUMBER"));
      columns.Add(new Column("DEPENDENTS_18_UNDER", string.Empty, "NUMBER"));
      columns.Add(new Column("DATE_OF_BIRTH", string.Empty, "DATE"));
      columns.Add(new Column("GENDER", string.Empty, "CHAR"));
      columns.Add(new Column("MARITAL_STATUS", string.Empty, "CHAR"));
      columns.Add(new Column("REPORTING_UNIT", string.Empty, "VARCHAR2"));
      columns.Add(new Column("DEPARTMENT", string.Empty, "VARCHAR2"));
      columns.Add(new Column("STATUS", string.Empty, "VARCHAR2"));
      columns.Add(new Column("DATE_OF_HIRE", string.Empty, "DATE"));
      columns.Add(new Column("JOB_CODE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("JOB_TITLE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("EMPLOYEE_CODE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("WAGE_FREQUENCY", string.Empty, "CHAR"));
      columns.Add(new Column("UNION_CODE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("UPLOAD_KEY", string.Empty, "VARCHAR2"));
      columns.Add(new Column("TEST_FLG", string.Empty, "CHAR"));
      columns.Add(new Column("SUPERVISOR_NAME_FIRST", string.Empty, "VARCHAR2"));
      columns.Add(new Column("SUPERVISOR_NAME_LAST", string.Empty, "VARCHAR2"));
      columns.Add(new Column("SUPERVISOR_PHONE_WORK", string.Empty, "VARCHAR2"));
      columns.Add(new Column("NCCI_JOBCLASS", string.Empty, "CHAR"));
      columns.Add(new Column("HOURLY_WAGE", string.Empty, "NUMBER"));
      columns.Add(new Column("ANNUAL_SALARY", string.Empty, "NUMBER"));
      columns.Add(new Column("MONTHLY_WAGE", string.Empty, "NUMBER"));
      columns.Add(new Column("DAILY_WAGE", string.Empty, "NUMBER"));
      columns.Add(new Column("PAID_FOR_OVERTIME_FLG", string.Empty, "CHAR"));
      columns.Add(new Column("DATE_OF_TERMINATION", string.Empty, "DATE"));
      columns.Add(new Column("PHONE_WORK", string.Empty, "VARCHAR2"));
      columns.Add(new Column("COST_CENTER_ID", string.Empty, "VARCHAR2"));
      columns.Add(new Column("EMPLOYMENT_STATUS", string.Empty, "VARCHAR2"));
      columns.Add(new Column("SPECIAL_ID", string.Empty, "VARCHAR2"));
      columns.Add(new Column("FILE_TRANSMISSION_LOG_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("TELECOMMUTER_FLG", string.Empty, "CHAR"));
      columns.Add(new Column("SUPERVISOR_EMAIL_ADDRESS", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CLOSE_DATE", string.Empty, "DATE"));
      columns.Add(new Column("FLSA_STATUS", string.Empty, "CHAR"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Employee"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public Employee(IDataReader reader)
      : base(reader, "EMPLOYEE")
    {
      _lazyExtensionAttributes = null;
    }

    protected override void InitEncryption()
    {
      if (!Instance.StartsWith("SED",StringComparison.InvariantCultureIgnoreCase)) return;
      EncryptAttributes.Clear();
      EncryptAttributes.Add("SSN");
      EncryptAttributes.Add("NAME_FIRST");
      EncryptAttributes.Add("NAME_MID");
      EncryptAttributes.Add("NAME_LAST");
      EncryptAttributes.Add("EMPLOYEE_CODE");
      EncryptAttributes.Add("ADDRESS1");
      EncryptAttributes.Add("ADDRESS2");
      EncryptAttributes.Add("CITY");
      EncryptAttributes.Add("STATE");
      EncryptAttributes.Add("ZIP");
      EncryptAttributes.Add("PHONE");
      EncryptAttributes.Add("SUPERVISOR_NAME_FIRST");
      EncryptAttributes.Add("SUPERVISOR_NAME_LAST");
      EncryptAttributes.Add("PHONE_WORK");
      EncryptAttributes.Add("SPECIAL_ID");
    }

    #endregion

    #region EmployeeId
    /// <summary>
    /// EMPLOYEE_ID
    /// </summary>
    [FieldDefintion(FieldName = "EMPLOYEE_ID")]
    public string EmployeeId
    {
      get { return GetColumnValue("EMPLOYEE_ID"); }
      set { SetColumnValue("EMPLOYEE_ID", value); }
    }
    #endregion

    #region AccntHrcyStepId
    /// <summary>
    /// ACCNT_HRCY_STEP_ID
    /// </summary>
    [FieldDefintion(FieldName = "ACCNT_HRCY_STEP_ID")]
    public string AccntHrcyStepId
    {
      get { return GetColumnValue("ACCNT_HRCY_STEP_ID"); }
      set { SetColumnValue("ACCNT_HRCY_STEP_ID", value); }
    }
    #endregion

    #region Ssn
    /// <summary>
    /// SSN
    /// </summary>
    [FieldDefintion]
    public string Ssn
    {
      get { return GetColumnValue("SSN"); }
      set { SetColumnValue("SSN", value); }
    }
    #endregion

    #region NameFirst
    /// <summary>
    /// NAME_FIRST
    /// </summary>
    [FieldDefintion(FieldName = "NAME_FIRST")]
    public string NameFirst
    {
      get { return GetColumnValue("NAME_FIRST"); }
      set { SetColumnValue("NAME_FIRST", value); }
    }
    #endregion

    #region NameLast
    /// <summary>
    /// NAME_LAST
    /// </summary>
    [FieldDefintion(FieldName = "NAME_LAST")]
    public string NameLast
    {
      get { return GetColumnValue("NAME_LAST"); }
      set { SetColumnValue("NAME_LAST", value); }
    }
    #endregion

    #region NameMid
    /// <summary>
    /// NAME_MID
    /// </summary>
    [FieldDefintion(FieldName = "NAME_MID")]
    public string NameMid
    {
      get { return GetColumnValue("NAME_MID"); }
      set { SetColumnValue("NAME_MID", value); }
    }
    #endregion

    #region Title
    /// <summary>
    /// TITLE
    /// </summary>
    [FieldDefintion]
    public string Title
    {
      get { return GetColumnValue("TITLE"); }
      set { SetColumnValue("TITLE", value); }
    }
    #endregion

    #region Address1
    /// <summary>
    /// ADDRESS1
    /// </summary>
    [FieldDefintion]
    public string Address1
    {
      get { return GetColumnValue("ADDRESS1"); }
      set { SetColumnValue("ADDRESS1", value); }
    }
    #endregion

    #region Address2
    /// <summary>
    /// ADDRESS2
    /// </summary>
    [FieldDefintion]
    public string Address2
    {
      get { return GetColumnValue("ADDRESS2"); }
      set { SetColumnValue("ADDRESS2", value); }
    }
    #endregion

    #region City
    /// <summary>
    /// CITY
    /// </summary>
    [FieldDefintion]
    public string City
    {
      get { return GetColumnValue("CITY"); }
      set { SetColumnValue("CITY", value); }
    }
    #endregion

    #region State
    /// <summary>
    /// STATE
    /// </summary>
    [FieldDefintion]
    public string State
    {
      get { return GetColumnValue("STATE"); }
      set { SetColumnValue("STATE", value); }
    }
    #endregion

    #region Zip
    /// <summary>
    /// ZIP
    /// </summary>
    [FieldDefintion]
    public string Zip
    {
      get { return GetColumnValue("ZIP"); }
      set { SetColumnValue("ZIP", value); }
    }
    #endregion

    #region Country
    /// <summary>
    /// COUNTRY
    /// </summary>
    [FieldDefintion]
    public string Country
    {
      get { return GetColumnValue("COUNTRY"); }
      set { SetColumnValue("COUNTRY", value); }
    }
    #endregion

    #region Phone
    /// <summary>
    /// PHONE
    /// </summary>
    [FieldDefintion]
    public string Phone
    {
      get { return GetColumnValue("PHONE"); }
      set { SetColumnValue("PHONE", value); }
    }
    #endregion

    #region ClientNumber
    /// <summary>
    /// CLIENT_NUMBER
    /// </summary>
    [FieldDefintion(FieldName = "CLIENT_NUMBER")]
    public string ClientNumber
    {
      get { return GetColumnValue("CLIENT_NUMBER"); }
      set { SetColumnValue("CLIENT_NUMBER", value); }
    }
    #endregion

    #region FilingState
    /// <summary>
    /// FILING_STATE
    /// </summary>
    [FieldDefintion(FieldName = "FILING_STATE")]
    public string FilingState
    {
      get { return GetColumnValue("FILING_STATE"); }
      set { SetColumnValue("FILING_STATE", value); }
    }
    #endregion

    #region TotalDependents
    /// <summary>
    /// TOTAL_DEPENDENTS
    /// </summary>
    [FieldDefintion(FieldName = "TOTAL_DEPENDENTS")]
    public string TotalDependents
    {
      get { return GetColumnValue("TOTAL_DEPENDENTS"); }
      set { SetColumnValue("TOTAL_DEPENDENTS", value); }
    }
    #endregion

    #region Dependents18Under
    /// <summary>
    /// DEPENDENTS_18_UNDER
    /// </summary>
    public string Dependents18Under
    {
      get { return GetColumnValue("DEPENDENTS_18_UNDER"); }
      set { SetColumnValue("DEPENDENTS_18_UNDER", value); }
    }
    #endregion

    #region DateOfBirth
    /// <summary>
    /// DATE_OF_BIRTH
    /// </summary>
    public string DateOfBirth
    {
      get { return GetColumnValue("DATE_OF_BIRTH"); }
      set { SetColumnValue("DATE_OF_BIRTH", value); }
    }
    #endregion

    #region Gender
    /// <summary>
    /// GENDER
    /// </summary>
    public string Gender
    {
      get { return GetColumnValue("GENDER"); }
      set { SetColumnValue("GENDER", value); }
    }
    #endregion

    #region MaritalStatus
    /// <summary>
    /// MARITAL_STATUS
    /// </summary>
    public string MaritalStatus
    {
      get { return GetColumnValue("MARITAL_STATUS"); }
      set { SetColumnValue("MARITAL_STATUS", value); }
    }
    #endregion

    #region ReportingUnit
    /// <summary>
    /// REPORTING_UNIT
    /// </summary>
    public string ReportingUnit
    {
      get { return GetColumnValue("REPORTING_UNIT"); }
      set { SetColumnValue("REPORTING_UNIT", value); }
    }
    #endregion

    #region Department
    /// <summary>
    /// DEPARTMENT
    /// </summary>
    public string Department
    {
      get { return GetColumnValue("DEPARTMENT"); }
      set { SetColumnValue("DEPARTMENT", value); }
    }
    #endregion

    #region Status
    /// <summary>
    /// STATUS
    /// </summary>
    public string Status
    {
      get { return GetColumnValue("STATUS"); }
      set { SetColumnValue("STATUS", value); }
    }
    #endregion

    #region DateOfHire
    /// <summary>
    /// DATE_OF_HIRE
    /// </summary>
    public string DateOfHire
    {
      get { return GetColumnValue("DATE_OF_HIRE"); }
      set { SetColumnValue("DATE_OF_HIRE", value); }
    }
    #endregion

    #region JobCode
    /// <summary>
    /// JOB_CODE
    /// </summary>
    public string JobCode
    {
      get { return GetColumnValue("JOB_CODE"); }
      set { SetColumnValue("JOB_CODE", value); }
    }
    #endregion

    #region JobTitle
    /// <summary>
    /// JOB_TITLE
    /// </summary>
    public string JobTitle
    {
      get { return GetColumnValue("JOB_TITLE"); }
      set { SetColumnValue("JOB_TITLE", value); }
    }
    #endregion

    #region EmployeeCode
    /// <summary>
    /// EMPLOYEE_CODE
    /// </summary>
    public string EmployeeCode
    {
      get { return GetColumnValue("EMPLOYEE_CODE"); }
      set { SetColumnValue("EMPLOYEE_CODE", value); }
    }
    #endregion

    #region WageFrequency
    /// <summary>
    /// WAGE_FREQUENCY
    /// </summary>
    public string WageFrequency
    {
      get { return GetColumnValue("WAGE_FREQUENCY"); }
      set { SetColumnValue("WAGE_FREQUENCY", value); }
    }
    #endregion

    #region UnionCode
    /// <summary>
    /// UNION_CODE
    /// </summary>
    public string UnionCode
    {
      get { return GetColumnValue("UNION_CODE"); }
      set { SetColumnValue("UNION_CODE", value); }
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

    #region TestFlag
    /// <summary>
    /// TEST_FLG
    /// </summary>
    public string TestFlag
    {
      get { return GetColumnValue("TEST_FLG"); }
      set { SetColumnValue("TEST_FLG", value); }
    }
    #endregion

    #region SupervisorNameFirst
    /// <summary>
    /// SUPERVISOR_NAME_FIRST
    /// </summary>
    public string SupervisorNameFirst
    {
      get { return GetColumnValue("SUPERVISOR_NAME_FIRST"); }
      set { SetColumnValue("SUPERVISOR_NAME_FIRST", value); }
    }
    #endregion

    #region SupervisorNameLast
    /// <summary>
    /// SUPERVISOR_NAME_LAST
    /// </summary>
    public string SupervisorNameLast
    {
      get { return GetColumnValue("SUPERVISOR_NAME_LAST"); }
      set { SetColumnValue("SUPERVISOR_NAME_LAST", value); }
    }
    #endregion

    #region SupervisorPhoneWork
    /// <summary>
    /// SUPERVISOR_PHONE_WORK
    /// </summary>
    public string SupervisorPhoneWork
    {
      get { return GetColumnValue("SUPERVISOR_PHONE_WORK"); }
      set { SetColumnValue("SUPERVISOR_PHONE_WORK", value); }
    }
    #endregion

    #region NcciJobclass
    /// <summary>
    /// NCCI_JOBCLASS
    /// </summary>
    public string NcciJobclass
    {
      get { return GetColumnValue("NCCI_JOBCLASS"); }
      set { SetColumnValue("NCCI_JOBCLASS", value); }
    }
    #endregion

    #region HourlyWage
    /// <summary>
    /// HOURLY_WAGE
    /// </summary>
    public string HourlyWage
    {
      get { return GetColumnValue("HOURLY_WAGE"); }
      set { SetColumnValue("HOURLY_WAGE", value); }
    }
    #endregion

    #region AnnualSalary
    /// <summary>
    /// ANNUAL_SALARY
    /// </summary>
    public string AnnualSalary
    {
      get { return GetColumnValue("ANNUAL_SALARY"); }
      set { SetColumnValue("ANNUAL_SALARY", value); }
    }
    #endregion

    #region MonthlyWage
    /// <summary>
    /// MONTHLY_WAGE
    /// </summary>
    public string MonthlyWage
    {
      get { return GetColumnValue("MONTHLY_WAGE"); }
      set { SetColumnValue("MONTHLY_WAGE", value); }
    }
    #endregion

    #region DailyWage
    /// <summary>
    /// DAILY_WAGE
    /// </summary>
    public string DailyWage
    {
      get { return GetColumnValue("DAILY_WAGE"); }
      set { SetColumnValue("DAILY_WAGE", value); }
    }
    #endregion

    #region PaidForOvertimeFlag
    /// <summary>
    /// PAID_FOR_OVERTIME_FLG
    /// </summary>
    public string PaidForOvertimeFlag
    {
      get { return GetColumnValue("PAID_FOR_OVERTIME_FLG"); }
      set { SetColumnValue("PAID_FOR_OVERTIME_FLG", value); }
    }
    #endregion

    #region DateOfTermination
    /// <summary>
    /// DATE_OF_TERMINATION
    /// </summary>
    public string DateOfTermination
    {
      get { return GetColumnValue("DATE_OF_TERMINATION"); }
      set { SetColumnValue("DATE_OF_TERMINATION", value); }
    }
    #endregion

    #region PhoneWork
    /// <summary>
    /// PHONE_WORK
    /// </summary>
    public string PhoneWork
    {
      get { return GetColumnValue("PHONE_WORK"); }
      set { SetColumnValue("PHONE_WORK", value); }
    }
    #endregion

    #region CostCenterId
    /// <summary>
    /// COST_CENTER_ID
    /// </summary>
    public string CostCenterId
    {
      get { return GetColumnValue("COST_CENTER_ID"); }
      set { SetColumnValue("COST_CENTER_ID", value); }
    }
    #endregion

    #region EmploymentStatus
    /// <summary>
    /// EMPLOYMENT_STATUS
    /// </summary>
    public string EmploymentStatus
    {
      get { return GetColumnValue("EMPLOYMENT_STATUS"); }
      set { SetColumnValue("EMPLOYMENT_STATUS", value); }
    }
    #endregion

    #region SpecialId
    /// <summary>
    /// SPECIAL_ID
    /// </summary>
    public string SpecialId
    {
      get { return GetColumnValue("SPECIAL_ID"); }
      set { SetColumnValue("SPECIAL_ID", value); }
    }
    #endregion

    #region FileTransmissionLogId
    /// <summary>
    /// FILE_TRANSMISSION_LOG_ID
    /// </summary>
    public string FileTransmissionLogId
    {
      get { return GetColumnValue("FILE_TRANSMISSION_LOG_ID"); }
      set { SetColumnValue("FILE_TRANSMISSION_LOG_ID", value); }
    }
    #endregion

    #region TelecommuterFlag
    /// <summary>
    /// TELECOMMUTER_FLG
    /// </summary>
    public string TelecommuterFlag
    {
      get { return GetColumnValue("TELECOMMUTER_FLG"); }
      set { SetColumnValue("TELECOMMUTER_FLG", value); }
    }
    #endregion

    #region SupervisorEmailAddress
    /// <summary>
    /// SUPERVISOR_EMAIL_ADDRESS
    /// </summary>
    public string SupervisorEmailAddress
    {
      get { return GetColumnValue("SUPERVISOR_EMAIL_ADDRESS"); }
      set { SetColumnValue("SUPERVISOR_EMAIL_ADDRESS", value); }
    }
    #endregion

    #region CloseDate
    /// <summary>
    /// CLOSE_DATE
    /// </summary>
    public string CloseDate
    {
      get { return GetColumnValue("CLOSE_DATE"); }
      set { SetColumnValue("CLOSE_DATE", value); }
    }
    #endregion

    #region FlsaStatus
    /// <summary>
    /// FLSA_STATUS
    /// </summary>
    public string FlsaStatus
    {
      get { return GetColumnValue("FLSA_STATUS"); }
      set { SetColumnValue("FLSA_STATUS", value); }
    }
    #endregion

    /// <summary>
    /// Gets the extension attributes if any.  
    /// Returns an empty dictionary if either 
    /// the record has not been executed or 
    /// there are none.
    /// </summary>
    public Dictionary<string, string> ExtensionAttributes
    {
      get
      {
        if (_lazyExtensionAttributes == null)
          InitializeExtensionAttributes();

        return _lazyExtensionAttributes;
      }
    }

    /// <summary>
    /// Initializes the extension attributes.
    /// </summary>
    private void InitializeExtensionAttributes()
    {
      if (_lazyExtensionAttributes == null)
        _lazyExtensionAttributes = new Dictionary<string, string>();
      else
        _lazyExtensionAttributes.Clear();

      var results = new ActiveRecordSet
                      {
                        Instance = Instance,
                        Query = "select * from employee_ext where employee_id = :employee_id",
                      };

      results.AddParameter(":employee_id", EmployeeId);
      if (results.Execute())
        foreach (ActiveRecord record in results)
          _lazyExtensionAttributes.Add(record.GetColumnValue("FIELD_NAME"), record.GetColumnValue("FIELD_VALUE"));

    }
    /// <summary>
    /// Gets the employee by SSN.
    /// </summary>
    /// <param name="ssn">The SSN.</param>
    /// <returns></returns>
    public static Employee GetEmployeeBySsn(string ssn)
    {
      return GetEmployeeBySsn(ApplicationConfiguration.Instance.DefaultInstance, ssn );
    }  
   
    /// <summary>
    /// Gets the employee by SSN.
    /// </summary>
    /// <param name="ssn">The SSN.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    public static Employee GetEmployeeBySsn(string instance, string ssn)
    {
      var results = new Employee { Instance = instance, Ssn = ssn, primaryKeyIndex = 2 };
      results.Execute();
      return results;
    }

    /// <summary>
    /// Generates the update SQL.
    /// </summary>
    protected override string GenerateUpdateSql()
    {
      return GenerateUpdateSqlForChanges();
    }

    /// <summary>
    /// Gets the employee by client number and employee code.
    /// </summary>
    public static Employee GetEmployeeByClientNumberAndEmployeeCode(string instance, string client, string code)
    {
      var empRecord = new Employee {Instance = instance};
      var employees = new Employees
      {
        Instance = instance,
        Query = string.Format("{0} where CLIENT_NUMBER = :client_number and RECORD_ACTIVE = 'Y' and EMPLOYEE_CODE = {1}", empRecord.GenerateSelectFrom(),
        instance.StartsWith("SED",StringComparison.InvariantCultureIgnoreCase) ? "GEN_ENCR.encrypt('" + code + "')" : "'" + code + "'")
      };
      employees.AddParameter("client_number", client);

      if (!employees.Execute()) return null;
      foreach (var employee in employees)
        return employee;

      return null;
    }

    /// <summary>
    /// Gets the name of the employee by client number and.
    /// </summary>
    /// <param name="instance">The instance.</param>
    /// <param name="client">The client.</param>
    /// <param name="lastName">The last name.</param>
    /// <param name="firstName">The first name.</param>
    /// <returns></returns>
    public static IEnumerable<Employee> GetEmployeeByClientNumberAndName(string instance, string client, string lastName,
      string firstName)
    {
      const string nameLast = "NAME_LAST";
      const string nameFirst = "NAME_FIRST";

      var empRecord = new Employee { Instance = instance, ClientNumber = client, NameLast = lastName, NameFirst = firstName};
      var results = new Employees
      {
        Instance = instance,
        Query = string.Format("{0} where CLIENT_NUMBER = :client_number and {1} LIKE '{2}%' and rownum <= 100",
        empRecord.GenerateSelectFrom(), empRecord.GetColumnFilterName(nameLast), lastName)
      };
      if (!string.IsNullOrEmpty(firstName))
      {
        results.Query += string.Format(" AND {0} LIKE '{1}%'", empRecord.GetColumnFilterName(nameFirst), firstName);
      }
      results.AddParameter("client_number", client);
      return results.Results();
    }

  }
}
