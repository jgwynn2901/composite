using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{
    /// <summary>
    /// 
    /// </summary>
    [ComVisible(false)]
    public class Policies : ActiveRecordSet<Policy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Policies"/> class.
        /// </summary>
        public Policies()
            : base("Policy")
        {}
    }
}
