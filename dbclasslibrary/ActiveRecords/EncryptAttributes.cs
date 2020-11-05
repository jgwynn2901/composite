using System;

namespace DbClassLibrary.ActiveRecords
{
  public class EncryptAttributes : ActiveRecordSet<EncryptAttribute>
  {
    public EncryptAttributes() : base("EncryptAttribute")
    { }

    /// <summary>
    /// Gets or sets the ahs identifier.
    /// </summary>
    /// <value>
    /// The ahs identifier.
    /// </value>
    public long AhsId { get; set; }

    /// <summary>
    /// Gets or sets the lob cd.
    /// </summary>
    /// <value>
    /// The lob cd.
    /// </value>
    public string LobCd { get; set; }

    /// <summary>
    /// Gets or sets the type of the encrypt.
    /// </summary>
    /// <value>
    /// The type of the encrypt.
    /// </value>
    public string EncryptType { get; set; }

    /// <summary>
    /// Adds the query parameters.
    /// </summary>
    protected override void AddQueryParameters()
    {
      AddParameter("ahs_id", AhsId);
      AddParameter("lob", LobCd);
      AddParameter("type", EncryptType);
    }

    /// <summary>
    /// Gets or sets the query.
    /// </summary>
    /// <value>
    /// The query.
    /// </value>
    /// <exception cref="System.NotImplementedException"></exception>
    public override string Query
    {
      get
      {
        return
          "select * from ENCRYPT_ATTRIBUTE where ACCNT_HRCY_STEP_ID = :ahs_id and TRIM(LOB_CD) = :lob and ENCRYPT_TYPE = :type ORDER BY ATTRIBUTE_NAME";
      }
      set
      {
        throw new NotImplementedException();
      }
    }

  }
}
