using System.Data;
using System.Globalization;

namespace DbClassLibrary.Callflow
{
  public class BranchRecord : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="BranchRecord"/> class.
    /// </summary>
    public BranchRecord() : base("BRANCH")
    {
      columns.Add(new Column("BRANCH_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("BRANCH_NUMBER", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ACCOUNT_HIERARCHY_LOAD_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("OFFICE_NUMBER", string.Empty, "VARCHAR2"));
      columns.Add(new Column("STATUS", string.Empty, "VARCHAR2"));
      columns.Add(new Column("OFFICE_TYPE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("OFFICE_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ADDRESS_1", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CITY", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ADDRESS_2", string.Empty, "VARCHAR2"));
      columns.Add(new Column("STATE", string.Empty, "CHAR"));
      columns.Add(new Column("ZIP", string.Empty, "VARCHAR2"));
      columns.Add(new Column("PHONE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("FOREIGN_ZIP", string.Empty, "VARCHAR2"));
      columns.Add(new Column("FAX", string.Empty, "VARCHAR2"));
      columns.Add(new Column("COUNTRY", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CONTACT_F_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ALT_PHONE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("LAT", string.Empty, "FLOAT"));
      columns.Add(new Column("CONTACT_L_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("LON", string.Empty, "FLOAT"));
      columns.Add(new Column("OVERNIGHT_ADDRESS_CITY", string.Empty, "VARCHAR2"));
      columns.Add(new Column("BACKUP_FAX", string.Empty, "VARCHAR2"));
      columns.Add(new Column("OVERNIGHT_ADDRESS_STATE", string.Empty, "CHAR"));
      columns.Add(new Column("CONTACT_TITLE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("OVERNIGHT_ADDRESS1", string.Empty, "VARCHAR2"));
      columns.Add(new Column("OVERNIGHT_ADDRESS2", string.Empty, "VARCHAR2"));
      columns.Add(new Column("OVERNIGHT_ADDRESS_ZIP", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ALT_CONTACT_F_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ALT_CONTACT_L_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("NOTES", string.Empty, "VARCHAR2"));
      columns.Add(new Column("BRANCH_TYPE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("EMAIL_ADDRESS", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ALT_PHONE1", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ALT_PHONE2", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ADJ_PHONE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ADDRESS_3", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CONTACT_M_NAME", string.Empty, "CHAR"));
      columns.Add(new Column("BUSINESS_CODE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("FEIN", string.Empty, "VARCHAR2"));
      columns.Add(new Column("OFFICE_HOURS", string.Empty, "VARCHAR2")); 
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BranchRecord"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public BranchRecord(IDataReader reader)
      : base(reader, "BRANCH")
		{ }

    #region BranchId
    /// <summary>
    /// BRANCH_ID
    /// </summary>
    public int BranchId
    {

      get { return GetColumnValueAsInt("BRANCH_ID") ?? 0; }
      set { SetColumnValue("BRANCH_ID", value.ToString(CultureInfo.InvariantCulture)); }
    }
    #endregion

    #region BranchNumber
    /// <summary>
    /// BRANCH_NUMBER
    /// </summary>
    public string BranchNumber
    {

      get { return GetColumnValue("BRANCH_NUMBER"); }
      set { SetColumnValue("BRANCH_NUMBER", value); }
    }
    #endregion

    #region AccountHierarchyLoadId
    /// <summary>
    /// ACCOUNT_HIERARCHY_LOAD_ID
    /// </summary>
    public string AccountHierarchyLoadId
    {

      get { return GetColumnValue("ACCOUNT_HIERARCHY_LOAD_ID"); }
      set { SetColumnValue("ACCOUNT_HIERARCHY_LOAD_ID", value); }
    }
    #endregion

    #region OfficeNumber
    /// <summary>
    /// OFFICE_NUMBER
    /// </summary>
    public string OfficeNumber
    {

      get { return GetColumnValue("OFFICE_NUMBER"); }
      set { SetColumnValue("OFFICE_NUMBER", value); }
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

    #region OfficeType
    /// <summary>
    /// OFFICE_TYPE
    /// </summary>
    public string OfficeType
    {

      get { return GetColumnValue("OFFICE_TYPE"); }
      set { SetColumnValue("OFFICE_TYPE", value); }
    }
    #endregion

    #region OfficeName
    /// <summary>
    /// OFFICE_NAME
    /// </summary>
    public string OfficeName
    {

      get { return GetColumnValue("OFFICE_NAME"); }
      set { SetColumnValue("OFFICE_NAME", value); }
    }
    #endregion

    #region Address1
    /// <summary>
    /// ADDRESS_1
    /// </summary>
    public string Address1
    {

      get { return GetColumnValue("ADDRESS_1"); }
      set { SetColumnValue("ADDRESS_1", value); }
    }
    #endregion

    #region City
    /// <summary>
    /// CITY
    /// </summary>
    public string City
    {

      get { return GetColumnValue("CITY"); }
      set { SetColumnValue("CITY", value); }
    }
    #endregion

    #region Address2
    /// <summary>
    /// ADDRESS_2
    /// </summary>
    public string Address2
    {

      get { return GetColumnValue("ADDRESS_2"); }
      set { SetColumnValue("ADDRESS_2", value); }
    }
    #endregion

    #region State
    /// <summary>
    /// STATE
    /// </summary>
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
    public string Zip
    {

      get { return GetColumnValue("ZIP"); }
      set { SetColumnValue("ZIP", value); }
    }
    #endregion

    #region Phone
    /// <summary>
    /// PHONE
    /// </summary>
    public string Phone
    {

      get { return GetColumnValue("PHONE"); }
      set { SetColumnValue("PHONE", value); }
    }
    #endregion

    #region ForeignZip
    /// <summary>
    /// FOREIGN_ZIP
    /// </summary>
    public string ForeignZip
    {

      get { return GetColumnValue("FOREIGN_ZIP"); }
      set { SetColumnValue("FOREIGN_ZIP", value); }
    }
    #endregion

    #region Fax
    /// <summary>
    /// FAX
    /// </summary>
    public string Fax
    {

      get { return GetColumnValue("FAX"); }
      set { SetColumnValue("FAX", value); }
    }
    #endregion

    #region Country
    /// <summary>
    /// COUNTRY
    /// </summary>
    public string Country
    {

      get { return GetColumnValue("COUNTRY"); }
      set { SetColumnValue("COUNTRY", value); }
    }
    #endregion

    #region ContactFName
    /// <summary>
    /// CONTACT_F_NAME
    /// </summary>
    public string ContactFName
    {

      get { return GetColumnValue("CONTACT_F_NAME"); }
      set { SetColumnValue("CONTACT_F_NAME", value); }
    }
    #endregion

    #region AltPhone
    /// <summary>
    /// ALT_PHONE
    /// </summary>
    public string AltPhone
    {

      get { return GetColumnValue("ALT_PHONE"); }
      set { SetColumnValue("ALT_PHONE", value); }
    }
    #endregion

    #region Lat
    /// <summary>
    /// LAT
    /// </summary>
    public string Lat
    {

      get { return GetColumnValue("LAT"); }
      set { SetColumnValue("LAT", value); }
    }
    #endregion

    #region ContactLName
    /// <summary>
    /// CONTACT_L_NAME
    /// </summary>
    public string ContactLName
    {

      get { return GetColumnValue("CONTACT_L_NAME"); }
      set { SetColumnValue("CONTACT_L_NAME", value); }
    }
    #endregion

    #region Lon
    /// <summary>
    /// LON
    /// </summary>
    public string Lon
    {

      get { return GetColumnValue("LON"); }
      set { SetColumnValue("LON", value); }
    }
    #endregion

    #region OvernightAddressCity
    /// <summary>
    /// OVERNIGHT_ADDRESS_CITY
    /// </summary>
    public string OvernightAddressCity
    {

      get { return GetColumnValue("OVERNIGHT_ADDRESS_CITY"); }
      set { SetColumnValue("OVERNIGHT_ADDRESS_CITY", value); }
    }
    #endregion

    #region BackupFax
    /// <summary>
    /// BACKUP_FAX
    /// </summary>
    public string BackupFax
    {

      get { return GetColumnValue("BACKUP_FAX"); }
      set { SetColumnValue("BACKUP_FAX", value); }
    }
    #endregion

    #region OvernightAddressState
    /// <summary>
    /// OVERNIGHT_ADDRESS_STATE
    /// </summary>
    public string OvernightAddressState
    {

      get { return GetColumnValue("OVERNIGHT_ADDRESS_STATE"); }
      set { SetColumnValue("OVERNIGHT_ADDRESS_STATE", value); }
    }
    #endregion

    #region ContactTitle
    /// <summary>
    /// CONTACT_TITLE
    /// </summary>
    public string ContactTitle
    {

      get { return GetColumnValue("CONTACT_TITLE"); }
      set { SetColumnValue("CONTACT_TITLE", value); }
    }
    #endregion

    #region OvernightAddress1
    /// <summary>
    /// OVERNIGHT_ADDRESS1
    /// </summary>
    public string OvernightAddress1
    {

      get { return GetColumnValue("OVERNIGHT_ADDRESS1"); }
      set { SetColumnValue("OVERNIGHT_ADDRESS1", value); }
    }
    #endregion

    #region OvernightAddress2
    /// <summary>
    /// OVERNIGHT_ADDRESS2
    /// </summary>
    public string OvernightAddress2
    {

      get { return GetColumnValue("OVERNIGHT_ADDRESS2"); }
      set { SetColumnValue("OVERNIGHT_ADDRESS2", value); }
    }
    #endregion

    #region OvernightAddressZip
    /// <summary>
    /// OVERNIGHT_ADDRESS_ZIP
    /// </summary>
    public string OvernightAddressZip
    {

      get { return GetColumnValue("OVERNIGHT_ADDRESS_ZIP"); }
      set { SetColumnValue("OVERNIGHT_ADDRESS_ZIP", value); }
    }
    #endregion

    #region AltContactFName
    /// <summary>
    /// ALT_CONTACT_F_NAME
    /// </summary>
    public string AltContactFName
    {

      get { return GetColumnValue("ALT_CONTACT_F_NAME"); }
      set { SetColumnValue("ALT_CONTACT_F_NAME", value); }
    }
    #endregion

    #region AltContactLName
    /// <summary>
    /// ALT_CONTACT_L_NAME
    /// </summary>
    public string AltContactLName
    {

      get { return GetColumnValue("ALT_CONTACT_L_NAME"); }
      set { SetColumnValue("ALT_CONTACT_L_NAME", value); }
    }
    #endregion

    #region Notes
    /// <summary>
    /// NOTES
    /// </summary>
    public string Notes
    {

      get { return GetColumnValue("NOTES"); }
      set { SetColumnValue("NOTES", value); }
    }
    #endregion

    #region BranchType
    /// <summary>
    /// BRANCH_TYPE
    /// </summary>
    public string BranchType
    {

      get { return GetColumnValue("BRANCH_TYPE"); }
      set { SetColumnValue("BRANCH_TYPE", value); }
    }
    #endregion

    #region EmailAddress
    /// <summary>
    /// EMAIL_ADDRESS
    /// </summary>
    public string EmailAddress
    {

      get { return GetColumnValue("EMAIL_ADDRESS"); }
      set { SetColumnValue("EMAIL_ADDRESS", value); }
    }
    #endregion

    #region AltPhone1
    /// <summary>
    /// ALT_PHONE1
    /// </summary>
    public string AltPhone1
    {

      get { return GetColumnValue("ALT_PHONE1"); }
      set { SetColumnValue("ALT_PHONE1", value); }
    }
    #endregion

    #region AltPhone2
    /// <summary>
    /// ALT_PHONE2
    /// </summary>
    public string AltPhone2
    {

      get { return GetColumnValue("ALT_PHONE2"); }
      set { SetColumnValue("ALT_PHONE2", value); }
    }
    #endregion

    #region AdjPhone
    /// <summary>
    /// ADJ_PHONE
    /// </summary>
    public string AdjPhone
    {

      get { return GetColumnValue("ADJ_PHONE"); }
      set { SetColumnValue("ADJ_PHONE", value); }
    }
    #endregion

    #region Address3
    /// <summary>
    /// ADDRESS_3
    /// </summary>
    public string Address3
    {

      get { return GetColumnValue("ADDRESS_3"); }
      set { SetColumnValue("ADDRESS_3", value); }
    }
    #endregion

    #region ContactMName
    /// <summary>
    /// CONTACT_M_NAME
    /// </summary>
    public string ContactMName
    {

      get { return GetColumnValue("CONTACT_M_NAME"); }
      set { SetColumnValue("CONTACT_M_NAME", value); }
    }
    #endregion

    #region BusinessCode
    /// <summary>
    /// BUSINESS_CODE
    /// </summary>
    public string BusinessCode
    {

      get { return GetColumnValue("BUSINESS_CODE"); }
      set { SetColumnValue("BUSINESS_CODE", value); }
    }
    #endregion

    #region Fein
    /// <summary>
    /// FEIN
    /// </summary>
    public string Fein
    {

      get { return GetColumnValue("FEIN"); }
      set { SetColumnValue("FEIN", value); }
    }
    #endregion

    #region OfficeHours
    /// <summary>
    /// OFFICE_HOURS
    /// </summary>
    public string OfficeHours
    {

      get { return GetColumnValue("OFFICE_HOURS"); }
      set { SetColumnValue("OFFICE_HOURS", value); }
    }
    #endregion
  }
}
