using System.Data;

namespace DbClassLibrary.Opm
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.InteropServices.ComVisible(false)]
    public class CallRouting : ActiveRecord
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CallRouting"/> class.
        /// </summary>
        public CallRouting()
            : base("CALL_ROUTING")
        {
            columns.Add(new Column("CALL_ROUTING_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("CALL_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("FINAL_SAVE_STATUS", string.Empty, "VARCHAR2"));
            columns.Add(new Column("ROUTING_STATUS", string.Empty, "VARCHAR2"));
            columns.Add(new Column("USER_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
            columns.Add(new Column("LAST_MODIFIED_DT", string.Empty, "DATE"));
            columns.Add(new Column("LAST_MESSAGE", string.Empty, "VARCHAR2"));
            columns.Add(new Column("SERVER_NAME", string.Empty, "VARCHAR2"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallRouting"/> class.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public CallRouting(IDataReader reader)
            : base(reader, "CALL_ROUTING")
		{ }

        #endregion

        #region CallRoutingId
        /// <summary>
        /// CALL_ROUTING_ID
        /// </summary>
        public int CallRoutingId
        {
            get { return GetColumnValueAsInt("CALL_ROUTING_ID") ?? 0; }
            set { SetColumnValue("CALL_ROUTING_ID", value.ToString()); }
        }
        #endregion

        #region CallId
        /// <summary>
        /// CALL_ID
        /// </summary>
        public int CallId
        {
            get { return GetColumnValueAsInt("CALL_ID") ?? 0; }
            set { SetColumnValue("CALL_ID", value.ToString()); }
        }
        #endregion

        #region FinalSaveStatus
        /// <summary>
        /// FINAL_SAVE_STATUS
        /// </summary>
        public string FinalSaveStatus
        {
            get { return GetColumnValue("FINAL_SAVE_STATUS"); }
            set { SetColumnValue("FINAL_SAVE_STATUS", value); }
        }
        #endregion

        #region RoutingStatus
        /// <summary>
        /// ROUTING_STATUS
        /// </summary>
        public string RoutingStatus
        {
            get { return GetColumnValue("ROUTING_STATUS"); }
            set { SetColumnValue("ROUTING_STATUS", value); }
        }
        #endregion

        #region UserId
        /// <summary>
        /// USER_ID
        /// </summary>
        public string UserId
        {
            get { return GetColumnValue("USER_ID"); }
            set { SetColumnValue("USER_ID", value); }
        }
        #endregion

        #region CreatedDate
        /// <summary>
        /// CREATED_DT
        /// </summary>
        public string CreatedDate
        {
            get { return GetColumnValue("CREATED_DT"); }
        }
        #endregion

        #region LastModifiedDate
        /// <summary>
        /// LAST_MODIFIED_DT
        /// </summary>
        public string LastModifiedDate
        {
            get { return GetColumnValue("LAST_MODIFIED_DT"); }
        }
        #endregion

        #region LastMessage
        /// <summary>
        /// LAST_MESSAGE
        /// </summary>
        public string LastMessage
        {
            get { return GetColumnValue("LAST_MESSAGE"); }
            set { SetColumnValue("LAST_MESSAGE", value); }
        }
        #endregion

        #region ServerName
        /// <summary>
        /// SERVER_NAME
        /// </summary>
        public string ServerName
        {
            get { return GetColumnValue("SERVER_NAME"); }
            set { SetColumnValue("SERVER_NAME", value); }
        }
        #endregion
    }
}
