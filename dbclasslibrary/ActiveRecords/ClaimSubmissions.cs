using System.Linq;

namespace DbClassLibrary.ActiveRecords
{
  public class ClaimSubmissions : ActiveRecordSet<ClaimSubmission>
  {
    public ClaimSubmissions() : base("ClaimSubmission") { Instance = DbBaseClass.SELP; }

    public static ClaimSubmission FindByCallId(string callId)
    {
      var results = new ClaimSubmissions
      {
        Query = "select * from CLAIM_SUBMISSION where CALL_ID = :call_id"
      };
      results.AddParameter("call_id", callId);
      return results.Results().FirstOrDefault();
    }
  }
}
