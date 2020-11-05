using System.Data;

namespace DbClassLibrary.ActiveRecords
{
  public class AutoMakeModel : ActiveRecord
  {
    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ClaimSubmission"/> class.
    /// </summary>
    public AutoMakeModel()
      : base("AUTO_MAKE_MODEL")
    {
      columns.Add(new Column("AUTO_MAKE_MODEL_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("YEAR", string.Empty, "CHAR"));
      columns.Add(new Column("MAKE", string.Empty, "CHAR"));
      columns.Add(new Column("MODEL", string.Empty, "VARCHAR2"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LocationCode"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public AutoMakeModel(IDataReader reader)
      : base(reader, "AUTO_MAKE_MODEL")
    {
    }

    #endregion

    #region AutoMakeModelId
    /// <summary>
    /// AUTO_MAKE_MODEL_ID
    /// </summary>
    public string AutoMakeModelId
    {

      get { return GetColumnValue("AUTO_MAKE_MODEL_ID"); }
      set { SetColumnValue("AUTO_MAKE_MODEL_ID", value); }
    }
    #endregion

    #region Year
    /// <summary>
    /// YEAR
    /// </summary>
    public string Year
    {

      get { return GetColumnValue("YEAR"); }
      set { SetColumnValue("YEAR", value); }
    }
    #endregion

    #region Make
    /// <summary>
    /// MAKE
    /// </summary>
    public string Make
    {

      get { return GetColumnValue("MAKE"); }
      set { SetColumnValue("MAKE", value); }
    }
    #endregion

    #region Model
    /// <summary>
    /// MODEL
    /// </summary>
    public string Model
    {

      get { return GetColumnValue("MODEL"); }
      set { SetColumnValue("MODEL", value); }
    }
    #endregion
  }
}
