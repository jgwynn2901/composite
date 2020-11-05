namespace DbClassLibrary.Opm
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.InteropServices.ComVisible(false)]
    public class CallRoutings : ActiveRecordSet<CallRouting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRoutings"/> class.
        /// </summary>
        public CallRoutings()
			: base("CallRouting"){}

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>The query.</value>
        public override string Query
        {
            get
            {
                return string.IsNullOrEmpty(base.Query) ? 
                    "select * from call_routing where routing_status = 'UNPROCESSED'" : base.Query;
            }
        }
    }
}
