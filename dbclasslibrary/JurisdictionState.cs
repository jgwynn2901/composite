using System.Runtime.InteropServices;

namespace DbClassLibrary
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Jurisdiction state. </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [ComVisible(false)]
    public class JurisdictionState : DbBaseClass
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public JurisdictionState()
            : base(string.Empty)
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <param name="instance"> The instance. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public JurisdictionState(string instance)
            : base(instance)
        {
            _name = "UIFSEGMENT.ProcessJurisdictionState";
            Initialize();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Initializes this object. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        protected override void Initialize()
        {
            AddParm(System.Data.ParameterDirection.Output, "p_nStatus", string.Empty, System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Input, "p_nPolicyID", string.Empty, System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Input, "p_nState", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nFileTranLogId", string.Empty, System.Data.DbType.Int32);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the status. </summary>
        ///
        /// <value> The status. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Status
        {
            get { return GetValue("p_nStatus"); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   FileTranLogId property. </summary>
        ///
        /// <value> The identifier of the file tran log. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string FileTranLogId
        {
            get { return GetValue("p_nFileTranLogId"); }
            set { SetValue("p_nFileTranLogId", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   PolicyID property. </summary>
        ///
        /// <value> The identifier of the policy. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string PolicyID
        {
            get { return GetValue("p_nPolicyID"); }
            set { SetValue("p_nPolicyID", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   VIN property. </summary>
        ///
        /// <value> The state. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string State
        {
            get { return GetValue("p_nState"); }
            set { SetValue("p_nState", value); }
        }
    }
}