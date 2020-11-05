using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{
    /// <summary>
    /// 
    /// </summary>
    [ComVisible(false)]
    public class DedicatedWebServers : ActiveRecordSet<DedicatedWebServer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedWebServers"/> class.
        /// </summary>
        public DedicatedWebServers()
            : base("DedicatedWebServer")
        { }
    }

    /// <summary>
    /// 
    /// </summary>
    [ComVisible(false)]
    public class DedicatedWebServer : ActiveRecord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedWebServer"/> class.
        /// </summary>
        public DedicatedWebServer()
            : base("DEDICATED_WEBSERVERS")
        {
            columns.Add(new Column("CLIENTCODE", string.Empty, "VARCHAR2"));
            columns.Add(new Column("CLIENTNAME", string.Empty, "VARCHAR2"));
            columns.Add(new Column("SERVER", string.Empty, "VARCHAR2"));
            columns.Add(new Column("SSO_LOB_CODES", string.Empty, "VARCHAR2"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigSetting"/> class.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public DedicatedWebServer(IDataReader reader)
            : base(reader, "DEDICATED_WEBSERVERS")
        { }

        #region ClientCode
        /// <summary>
        /// CLIENTCODE
        /// </summary>
        public string ClientCode
        {
            get { return GetColumnValue("CLIENTCODE"); }
            set { SetColumnValue("CLIENTCODE", value); }
        }
        #endregion

        #region ClientName
        /// <summary>
        /// CLIENTNAME
        /// </summary>
        public string ClientName
        {
            get { return GetColumnValue("CLIENTNAME"); }
            set { SetColumnValue("CLIENTNAME", value); }
        }
        #endregion

        #region Server
        /// <summary>
        /// SERVER
        /// </summary>
        public string Server
        {
            get { return GetColumnValue("SERVER"); }
            set { SetColumnValue("SERVER", value); }
        }
        #endregion

        #region SsoLobCodes
        /// <summary>
        /// SSOLOBCODES
        /// </summary>
        public string SsoLobCodes
        {
            get { return GetColumnValue("SSO_LOB_CODES"); }
            set { SetColumnValue("SSO_LOB_CODES", value); }
        }
        #endregion
    }
}
