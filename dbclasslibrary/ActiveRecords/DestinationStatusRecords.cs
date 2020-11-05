namespace DbClassLibrary.ActiveRecords
{
  /// <summary>
  /// 
  /// </summary>
  /// <seealso cref="DbClassLibrary.ActiveRecordSet{DestinationStatus}" />
  public class DestinationStatusRecords : ActiveRecordSet<DestinationStatus>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="DestinationStatusRecords"/> class.
    /// </summary>
    public DestinationStatusRecords() : base("DestinationStatus")
    {}

    /// <summary>
    /// Gets or sets the destination string.
    /// </summary>
    /// <value>
    /// The destination string.
    /// </value>
    public string DestinationString { get; set; }

    /// <summary>
    /// Adds the query parameters.
    /// </summary>
    protected override void AddQueryParameters()
    {
      if (!string.IsNullOrEmpty(DestinationString))
        AddParameter("destination", DestinationString);
    }

    /// <summary>
    /// Gets or sets the query.
    /// </summary>
    /// <value>
    /// The query.
    /// </value>
    public override string Query
    {
      get
      {
        return query.Length > 0 ? query :
          "select * from DESTINATION_STATUS where DESTINATION_STRING like :destination ";
      }
      //set { query = value; }
    }
  }
}
