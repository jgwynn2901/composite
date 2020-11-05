using System.Runtime.Serialization;

namespace FnsInterfaces
{
    /// <summary>
    /// general data contract For CallRouting work.
    /// </summary>
    [DataContract, KnownType(typeof(CallRoutingWork))]
    public class CallRoutingWork : ICallRoutingWork
    {
        /// <summary>
        /// The database instance.
        /// </summary>
        [DataMember]
        public string Instance { get; set; }

        /// <summary>
        /// the current callRoutingId
        /// </summary>
        /// <value>The id.</value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The affected CallId
        /// </summary>
        /// <value>The call id.</value>
        [DataMember]
        public int CallId { get; set; }

        /// <summary>
        /// Gets or sets the call's final status.
        /// </summary>
        [DataMember]
        public string FinalSaveStatus { get; set; }

        /// <summary>
        /// Gets or sets the records routing status.
        /// </summary>
        [DataMember]
        public string Status { get; set; }
    }
}
