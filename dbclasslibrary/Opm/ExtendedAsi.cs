namespace DbClassLibrary.Opm
{
  public class ExtendedAsiRecord : ActiveRecord
  {
    public ExtendedAsiRecord()
      : base("EXTENDED_ASI")
    {
      columns.Add(new Column("EXTENDED_ASI_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("LOB_CD", string.Empty, "CHAR"));
      columns.Add(new Column("ATTRIBUTE_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("FIELD_NAME", string.Empty, "VARCHAR2"));
      columns.Add(new Column("FIELD_ID", string.Empty, "VARCHAR2"));
      columns.Add(new Column("QUESTION", string.Empty, "VARCHAR2"));
    }

    #region ExtendedAsiId
    /// <summary>
    /// EXTENDED_ASI_ID
    /// </summary>
    public string ExtendedAsiId
    {
      get { return GetColumnValue("EXTENDED_ASI_ID"); }
      set { SetColumnValue("EXTENDED_ASI_ID", value); }
    }
    #endregion
    #region AhsId
    /// <summary>
    /// ACCNT_HRCY_STEP_ID
    /// </summary>
    public string AhsId
    {
      get { return GetColumnValue("ACCNT_HRCY_STEP_ID"); }
      set { SetColumnValue("ACCNT_HRCY_STEP_ID", value); }
    }
    #endregion
    #region LobCd
    /// <summary>
    /// LOB_CD
    /// </summary>
    public string LobCd
    {
      get { return GetColumnValue("LOB_CD"); }
      set { SetColumnValue("LOB_CD", value); }
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
    #region FieldName
    /// <summary>
    /// FIELD_NAME
    /// </summary>
    public string FieldName
    {
      get { return GetColumnValue("FIELD_NAME"); }
      set { SetColumnValue("FIELD_NAME", value); }
    }
    #endregion
    #region FieldId
    /// <summary>
    /// FIELD_ID
    /// </summary>
    public string FieldId
    {
      get { return GetColumnValue("FIELD_ID"); }
      set { SetColumnValue("FIELD_ID", value); }
    }
    #endregion
    #region Question
    /// <summary>
    /// QUESTION
    /// </summary>
    public string Question
    {
      get { return GetColumnValue("QUESTION"); }
      set { SetColumnValue("QUESTION", value); }
    }
    #endregion
  }

  public class ExtendedAsiRecords : ActiveRecordSet<ExtendedAsiRecord>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="CallRoutings"/> class.
    /// </summary>
    public ExtendedAsiRecords()
      : base("ExtendedAsiRecord") { }

    
  }
}
