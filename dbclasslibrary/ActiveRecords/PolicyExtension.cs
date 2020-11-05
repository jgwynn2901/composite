using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{

    /// <summary>
    /// 
    /// </summary>
    [ComVisible(false)]
    public class PolicyExtensions : ActiveRecordSet<PolicyExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Policies"/> class.
        /// </summary>
        public PolicyExtensions()
            : base("PolicyExtension")
        { }
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed class PolicyExtension : ActiveRecord
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyExtension"/> class.
        /// </summary>
        public PolicyExtension()
            : base("POLICY_EXTENSION")
        {
            columns.Add(new Column("POLICY_EXTENSION_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("POLICY_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("NAME", string.Empty, "VARCHAR2"));
            columns.Add(new Column("VALUE", string.Empty, "VARCHAR2"));
            columns.Add(new Column("UPLOAD_KEY", string.Empty, "VARCHAR2"));
            columns.Add(new Column("FILE_TRANSMISSION_LOG_ID", string.Empty, "NUMBER"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyExtension"/> class.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public PolicyExtension(IDataReader reader)
            : base(reader, "POLICY_EXTENSION")
        {
        }

        #region PolicyExtensionId
        /// <summary>
        /// POLICY_EXTENSION_ID
        /// </summary>
        public string PolicyExtensionId
        {
            get { return GetColumnValue("POLICY_EXTENSION_ID"); }
            set { SetColumnValue("POLICY_EXTENSION_ID", value); }
        }
        #endregion

        #region PolicyId
        /// <summary>
        /// POLICY_ID
        /// </summary>
        public string PolicyId
        {
            get { return GetColumnValue("POLICY_ID"); }
            set { SetColumnValue("POLICY_ID", value); }
        }
        #endregion

        #region FieldName
        /// <summary>
        /// NAME
        /// </summary>
        public string FieldName
        {
            get { return GetColumnValue("NAME"); }
            set { SetColumnValue("NAME", value); }
        }
        #endregion

        #region FieldValue
        /// <summary>
        /// VALUE
        /// </summary>
        public string FieldValue
        {
            get { return GetColumnValue("VALUE"); }
            set { SetColumnValue("VALUE", value); }
        }
        #endregion

        #region UploadKey
        /// <summary>
        /// UPLOAD_KEY
        /// </summary>
        public string UploadKey
        {
            get { return GetColumnValue("UPLOAD_KEY"); }
            set { SetColumnValue("UPLOAD_KEY", value); }
        }
        #endregion

        #region FileTransmissionLogId
        /// <summary>
        /// FILE_TRANSMISSION_LOG_ID
        /// </summary>
        public string FileTransmissionLogId
        {
            get { return GetColumnValue("FILE_TRANSMISSION_LOG_ID"); }
            set { SetColumnValue("FILE_TRANSMISSION_LOG_ID", value); }
        }
        #endregion


    }
}
