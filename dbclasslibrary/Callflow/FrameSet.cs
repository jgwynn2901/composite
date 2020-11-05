namespace DbClassLibrary.Callflow
{
  /// <summary>
  /// 
  /// </summary>
  public class FrameSet : ActiveRecordSet<Frame>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="FrameSet"/> class.
    /// </summary>
    public FrameSet()
      : base("Frame")
    {
      CallStartFlag = "N";
    }

    /// <summary>
    /// required field
    /// </summary>
    public int AhsId { get; set; }

    /// <summary>
    /// required field
    /// </summary>
    public string LineOfBusiness { get; set; }

    /// <summary>
    /// Either this or top 2 required.
    /// </summary>
    public int FrameId { get; set; }
    public string FrameName { get; set; }
    public int CallflowId { get; set; }
    public string CallStartFlag { get; set; }

    /// <summary>
    /// return by AHS_ID and LOB_CD
    /// </summary>
    public override string Query
    {
      get
      {
        return string.IsNullOrEmpty(query)
                  ? string.Format("select * from CALLFLOW_VIEW where {0} order by sequence", BuildWhereClause())
                  : query;
      }
    }

    private string BuildWhereClause()
    {
      if (CallflowId > 0)
      {
        return string.Format(" callflow_id = {0} ", CallflowId);
      }
      if (!string.IsNullOrEmpty(FrameName))
      {
        return string.Format(" accnt_hrcy_step_id = {0} and LOB_CD = '{1}' and FRAME_NAME = '{2}'", AhsId, LineOfBusiness, FrameName);
      }
      return FrameId > 0 ? string.Format(" frame_id = {0} ", FrameId) : string.Format(" accnt_hrcy_step_id = {0} and LOB_CD = '{1}' and call_start_flg = '{2}'", AhsId, LineOfBusiness, CallStartFlag);
    }
  }
}
