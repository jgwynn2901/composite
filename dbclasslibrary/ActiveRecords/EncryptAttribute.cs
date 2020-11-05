using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{
  [ComVisible(false), TableDefinition(TableName = "FNSOWNER.ENCRYPT_ATTRIBUTE")]
  public class EncryptAttribute : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigSetting"/> class.
    /// </summary>
    public EncryptAttribute()
      : base("ENCRYPT_ATTRIBUTE")
    {
      columns.Add(new Column("ENCRYPT_ATTRIBUTE_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ATTRIBUTE_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ENCRYPT_TYPE", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
      columns.Add(new Column("LAST_MODIFIED_DT", string.Empty, "DATE"));
      columns.Add(new Column("LOB_CD", string.Empty, "CHAR"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigSetting"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public EncryptAttribute(IDataReader reader)
      : base(reader, "ENCRYPT_ATTRIBUTE")
    { }

    #region EncryptAttributeId
    /// <summary>
    /// ENCRYPT_ATTRIBUTE_ID
    /// </summary>
    public string EncryptAttributeId
    {

      get { return GetColumnValue("ENCRYPT_ATTRIBUTE_ID"); }
      set { SetColumnValue("ENCRYPT_ATTRIBUTE_ID", value); }
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

    #region AttributeName
    /// <summary>
    /// ATTRIBUTE_NAME
    /// </summary>
    public string AttributeName
    {

      get { return GetColumnValue("ATTRIBUTE_NAME"); }
      set { SetColumnValue("ATTRIBUTE_NAME", value); }
    }
    #endregion

    #region EncryptType
    /// <summary>
    /// ENCRYPT_TYPE
    /// </summary>
    public string EncryptType
    {

      get { return GetColumnValue("ENCRYPT_TYPE"); }
      set { SetColumnValue("ENCRYPT_TYPE", value); }
    }
    #endregion

    #region CreatedDate
    /// <summary>
    /// CREATED_DT
    /// </summary>
    public string CreatedDate
    {

      get { return GetColumnValue("CREATED_DT"); }
      set { SetColumnValue("CREATED_DT", value); }
    }
    #endregion

    #region LastModifiedDate
    /// <summary>
    /// LAST_MODIFIED_DT
    /// </summary>
    public string LastModifiedDate
    {

      get { return GetColumnValue("LAST_MODIFIED_DT"); }
      set { SetColumnValue("LAST_MODIFIED_DT", value); }
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
  }
}
