using System.Data;

namespace DbClassLibrary.ActiveRecords
{
  /// <summary>
  /// ActiveRecord Wrapper for DESTINATION_STATUS table data
  /// </summary>
  /// <seealso cref="DbClassLibrary.ActiveRecord" />
  public class DestinationStatus : ActiveRecord
  {
    public static string StopStatus = "STOP";

    /// <summary>
    /// Initializes a new instance of the <see cref="DestinationStatus"/> class.
    /// </summary>
    public DestinationStatus() : base("DESTINATION_STATUS")
    {
      columns.Add(new Column("DESTINATION_STATUS_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("DESTINATION_STRING", string.Empty, "VARCHAR2"));
      columns.Add(new Column("STATUS", string.Empty, "VARCHAR2"));
      columns.Add(new Column("DESCRIPTION", string.Empty, "VARCHAR2"));
      columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
      columns.Add(new Column("LAST_MODIFIED_DT", string.Empty, "DATE"));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DestinationStatus"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public DestinationStatus(IDataReader reader)
      : base(reader, "DESTINATION_STATUS")
    {
    }

    #region DestinationStatusId
    /// <summary>
    /// DESTINATION_STATUS_ID
    /// </summary>
    /// <value>
    /// The destination status identifier PK.
    /// </value>
    public string DestinationStatusId
    {

      get { return GetColumnValue("DESTINATION_STATUS_ID"); }
      set { SetColumnValue("DESTINATION_STATUS_ID", value); }
    }
    #endregion

    #region DestinationString
    /// <summary>
    /// DESTINATION_STRING
    /// </summary>
    /// <value>
    /// The destination string.
    /// </value>
    public string DestinationString
    {

      get { return GetColumnValue("DESTINATION_STRING"); }
      set { SetColumnValue("DESTINATION_STRING", value); }
    }
    #endregion

    #region Status
    /// <summary>
    /// STATUS
    /// </summary>
    /// <value>
    /// The status.
    /// </value>
    public string Status
    {

      get { return GetColumnValue("STATUS"); }
      set { SetColumnValue("STATUS", value); }
    }
    #endregion

    #region Description
    /// <summary>
    /// DESCRIPTION
    /// </summary>
    /// <value>
    /// The description.
    /// </value>
    public string Description
    {

      get { return GetColumnValue("DESCRIPTION"); }
      set { SetColumnValue("DESCRIPTION", value); }
    }
    #endregion

    #region CreatedDate
    /// <summary>
    /// CREATED_DT
    /// </summary>
    /// <value>
    /// The created date.
    /// </value>
    public string CreatedDate
    {

      get { return GetColumnValue("CREATED_DT"); }
    }
    #endregion

    #region LastModifiedDate
    /// <summary>
    /// LAST_MODIFIED_DT
    /// </summary>
    /// <value>
    /// The last modified date.
    /// </value>
    public string LastModifiedDate
    {

      get { return GetColumnValue("LAST_MODIFIED_DT"); }
    }
    #endregion

    /// <summary>
    /// Generates the update SQL.
    /// </summary>
    /// <returns></returns>
    protected override string GenerateUpdateSql()
    {
      return GenerateUpdateSqlForChanges();
    }
  }
}
