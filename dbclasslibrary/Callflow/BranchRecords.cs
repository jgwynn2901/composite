using System.Linq;

namespace DbClassLibrary.Callflow
{
  public class BranchRecords : ActiveRecordSet<BranchRecord>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="BranchRecords"/> class.
    /// </summary>
    public BranchRecords() : base("BranchRecord")
    {
      //Instance = GeneralUtility.IsSedgwick() ? DbBaseClass.SEDP : DbBaseClass.SELP;
    }

    /// <summary>
    /// Finds the specified record by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    public static BranchRecord Find(int id)
    {
      var records = new BranchRecords
      {
        Query = string.Format("select * from BRANCH where BRANCH_ID = :branch_id", id)
      };

      records.AddParameter("branch_id", id);
      return records.Results().FirstOrDefault();
    }
  }

   
}
