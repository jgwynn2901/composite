using System.Data;

namespace DbClassLibrary
{
    public class DriverTower : DriverExtended
    {
        public DriverTower()
            : base(DbBaseClass.TOWP)
        { }

        protected override void Initialize()
        {
            base.Initialize();
            ///////////////////////////////////////////////////
            ///// Type
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Input,
                "p_nLicenseState", "", DbType.AnsiString);
        }

        public string LicenseState
        {
            get
            {
                return GetValue("p_nLicenseState");
            }
            set
            {
                SetValue("p_nLicenseState", value);
            }
        }
    }
    public class DriverExtended : Driver
    {
        public DriverExtended():this(GeneralUtility.ProductionInstanceFromRegistry)
		{}
		
		///<summary>
		///</summary>
		///<param name="instance"></param>
        public DriverExtended(string instance)
            : base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessDriverExtended";

		}

        /// <summary>
        /// Set up parameter definitions here
        /// </summary>
        /// <remarks>
        /// the definitions can be defined externally (configuration)
        /// and iterated here for maximum flexibility
        /// </remarks>
        protected override void Initialize()
        {
            base.Initialize();
            ///////////////////////////////////////////////////
            ///// Type
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Input,
                "p_nType", "", DbType.AnsiString);
            AddParm(ParameterDirection.Input,
                "p_nNameMi", "", DbType.AnsiString);
            AddParm(ParameterDirection.Input,
                "p_nMaritalStatus", "", DbType.AnsiString);
            AddParm(ParameterDirection.Input,
                "p_nEmailAddress", "", DbType.AnsiString);
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type
        {
            get
            {
                return GetValue("p_nType");
            }
            set
            {
                SetValue("p_nType", value);
            }
        }
        /// <summary>
        /// Gets or sets the name mi.
        /// </summary>
        /// <value>The name mi.</value>
        public string NameMi
        {
            get
            {
                return GetValue("p_nNameMi");
            }
            set
            {
                SetValue("p_nNameMi", value);
            }
        }
        /// <summary>
        /// Gets or sets the marital status.
        /// </summary>
        /// <value>The marital status.</value>
        public string MaritalStatus
        {
            get
            {
                return GetValue("p_nMaritalStatus");
            }
            set
            {
                SetValue("p_nMaritalStatus", value);
            }
        }
        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>
        public string EmailAddress
        {
            get
            {
                return GetValue("p_nEmailAddress");
            }
            set
            {
                SetValue("p_nEmailAddress", value);
            }
        }
    }
}
