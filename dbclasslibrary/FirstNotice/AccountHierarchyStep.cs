using System.Linq;

namespace DbClassLibrary.FirstNotice
{
    /// <summary>
    /// static helper and repository methods
    /// </summary>
    public partial class AccountHierarchyStep
    {
        /// <summary>
        /// Ahses the record from id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static AccountHierarchyStep AhsRecordFromId(long id, string instance)
        {
            var db = new Database(instance);
            return db.Accounthierarchystep
                .Where(a => a.AccntHrcyStepId == id)
                .SingleOrDefault();
        }
    }
}
