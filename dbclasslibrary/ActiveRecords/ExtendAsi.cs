using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace DbClassLibrary.ActiveRecords
{
  public class ExtendAsiRecords : ActiveRecordSet<ExtendAsi>
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="CallRecords"/> class.
    /// </summary>
    public ExtendAsiRecords()
      : base("ExtendAsi")
    {
    }

    /// <summary>
    /// Gets the records by lob cd.
    /// </summary>
    /// <param name="lobCd">The lob cd.</param>
    /// <returns></returns>
    static public IEnumerable<ExtendAsi> GetRecordsByLobCd(string lobCd)
    {
      var records = new ExtendAsiRecords
      {
        Query = "select * from EXTENDED_ASI where ACCNT_HRCY_STEP_ID = 18 and LOB_CD = :lobCd"
      };
      records.AddParameter("lobCd", lobCd);
      return records.Results();
    }

  }

  public class ExtendAsi : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ExtendAsi"/> class.
    /// </summary>
    public ExtendAsi()
      : base("EXTENDED_ASI")
    {
      columns.Add(new Column("EXTENDED_ASI_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("ACCNT_HRCY_STEP_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("LOB_CD", String.Empty, "CHAR"));
      columns.Add(new Column("ATTRIBUTE_NAME", String.Empty, "VARCHAR2"));
      columns.Add(new Column("FIELD_NAME", String.Empty, "VARCHAR2"));
      columns.Add(new Column("FIELD_ID", String.Empty, "VARCHAR2"));
      columns.Add(new Column("QUESTION", String.Empty, "VARCHAR2"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExtendAsi"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public ExtendAsi(IDataReader reader)
      : base(reader, "EXTENDED_ASI")
    {
    }

    #region ExtendedAsiId
    /// <summary>
    /// Gets or sets the extended asi identifier.
    /// </summary>
    /// <value>
    /// The extended asi identifier.
    /// </value>
    public int ExtendedAsiId
    {
      get
      {
        return GetColumnValueAsInt("EXTENDED_ASI_ID") ?? -1;
      }
      set
      {
        SetColumnValue("EXTENDED_ASI_ID", value.ToString(CultureInfo.InvariantCulture));
      }
    }
    #endregion

    #region AccntHrcyStepId
    /// <summary>
    /// Gets or sets the accnt hrcy step identifier.
    /// </summary>
    /// <value>
    /// The accnt hrcy step identifier.
    /// </value>
    public int AccntHrcyStepId
    {
      get
      {
        return GetColumnValueAsInt("ACCNT_HRCY_STEP_ID") ?? -1;
      }
      set
      {
        SetColumnValue("ACCNT_HRCY_STEP_ID", value.ToString(CultureInfo.InvariantCulture));
      }
    }
    #endregion

    #region LobCd
    /// <summary>
    /// Gets or sets the lob cd.
    /// </summary>
    /// <value>
    /// The lob cd.
    /// </value>
    public string LobCd
    {
      get
      {
        return GetColumnValue("LOB_CD");
      }
      set
      {
        SetColumnValue("LOB_CD", value);
      }
    }
    #endregion

    #region AttributeName
    /// <summary>
    /// Gets or sets the name of the attribute.
    /// </summary>
    /// <value>
    /// The name of the attribute.
    /// </value>
     public string AttributeName
    {
      get
      {
        return GetColumnValue("ATTRIBUTE_NAME");
      }
      set
      {
        SetColumnValue("ATTRIBUTE_NAME", value);
      }
    }
    #endregion

    #region FieldName
     /// <summary>
     /// Gets or sets the name of the field.
     /// </summary>
     /// <value>
     /// The name of the field.
     /// </value>
     public string FieldName
    {
      get
      {
        return GetColumnValue("FIELD_NAME");
      }
      set
      {
        SetColumnValue("FIELD_NAME", value);
      }
    }
    #endregion

    #region FieldId

     /// <summary>
     /// Gets or sets the field identifier.
     /// </summary>
     /// <value>
     /// The field identifier.
     /// </value>
    public string FieldId
    {
      get
      {
        return GetColumnValue("FIELD_ID");
      }
      set
      {
        SetColumnValue("FIELD_ID", value);
      }
    }
    #endregion

    #region Question
    /// <summary>
    /// Gets or sets the question.
    /// </summary>
    /// <value>
    /// The question.
    /// </value>
    public string Question
    {
      get
      {
        return GetColumnValue("QUESTION");
      }
      set
      {
        SetColumnValue("QUESTION", value);
      }
    }
    #endregion
  }
}
