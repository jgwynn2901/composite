namespace DbClassLibrary
{
    ///<summary>
    ///</summary>
    public class SEDVehicle : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SEDVehicle"/> class.
        /// </summary>
        public SEDVehicle()
        {}

        /// <summary>
        /// Initializes a new instance of the <see cref="SEDVehicle"/> class.
        /// </summary>
        /// <param name="strInstance">The STR instance.</param>
        public SEDVehicle(string strInstance): base(strInstance)
        {
            _name = "DBCLASSLIBRARY.ProcessSEDVehicle";
            Initialize();
        }

        /// <summary>
        /// Set up parameter definitions here
        /// </summary>
        /// <remarks>
        /// the definitions can be defined externally (configuration)
        /// and iterated here for maximum flexibility
        /// </remarks>
        protected new void Initialize()
        {
            AddParm(System.Data.ParameterDirection.Input, "p_nBodyType", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nLocationId", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nLicenseWeight", "", System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Input, "p_nEntityName", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nApportionedFlag", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nDotNumber", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nMileage", "", System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Input, "p_nTitleNumber", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nVehicleType", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nVehicleDesc", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nClientNum", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nArchivedFlag", "N", System.Data.DbType.AnsiString);
        }

        /// <summary>
        /// Gets or sets the type of the body.
        /// </summary>
        /// <value>The type of the body.</value>
        public string BodyType
        {
            get
            {
                return GetValue("p_nBodyType");
            }
            set
            {
                SetValue("p_nBodyType", value);
            }
        }

        /// <summary>
        /// Gets or sets the location id.
        /// </summary>
        /// <value>The location id.</value>
        public string LocationId
        {
            get
            {
                return GetValue("p_nLocationId");
            }
            set
            {
                SetValue("p_nLocationId", value);
            }
        }

        /// <summary>
        /// Gets or sets the license weight.
        /// </summary>
        /// <value>The license weight.</value>
        public string LicenseWeight
        {
            get
            {
                return GetValue("p_nLicenseWeight");
            }
            set
            {
                SetValue("p_nLicenseWeight", value);
            }
        }

        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        public string EntityName
        {
            get
            {
                return GetValue("p_nEntityName");
            }
            set
            {
                SetValue("p_nEntityName", value);
            }
        }

        /// <summary>
        /// Gets or sets the apportioned flag.
        /// </summary>
        /// <value>The apportioned flag.</value>
        public string ApportionedFlag
        {
            get
            {
                return GetValue("p_nApportionedFlag");
            }
            set
            {
                SetValue("p_nApportionedFlag", value);
            }
        }

        /// <summary>
        /// Gets or sets the dot number.
        /// </summary>
        /// <value>The dot number.</value>
        public string DotNumber
        {
            get
            {
                return GetValue("p_nDotNumber");
            }
            set
            {
                SetValue("p_nDotNumber", value);
            }
        }

        /// <summary>
        /// Gets or sets the mileage.
        /// </summary>
        /// <value>The mileage.</value>
        public string Mileage
        {
            get
            {
                return GetValue("p_nMileage");
            }
            set
            {
                SetValue("p_nMileage", value);
            }
        }

        /// <summary>
        /// Gets or sets the title number.
        /// </summary>
        /// <value>The title number.</value>
        public string TitleNumber
        {
            get
            {
                return GetValue("p_nTitleNumber");
            }
            set
            {
                SetValue("p_nTitleNumber", value);
            }
        }

        /// <summary>
        /// Gets or sets the type of the vehicle.
        /// </summary>
        /// <value>The type of the vehicle.</value>
        public string VehicleType
        {
            get
            {
                return GetValue("p_nVehicleType");
            }
            set
            {
                SetValue("p_nVehicleType", value);
            }
        }

        /// <summary>
        /// Gets or sets the vehicle desc.
        /// </summary>
        /// <value>The vehicle desc.</value>
        public string VehicleDesc
        {
            get
            {
                return GetValue("p_nVehicleDesc");
            }
            set
            {
                SetValue("p_nVehicleDesc", value);
            }
        }

        /// <summary>
        /// Gets or sets the client num.
        /// </summary>
        /// <value>The client num.</value>
        public string ClientNum
        {
            get
            {
                return GetValue("p_nClientNum");
            }
            set
            {
                SetValue("p_nClientNum", value);
            }
        }

        /// <summary>
        /// Gets or sets the archived flag.
        /// </summary>
        /// <value>The archived flag.</value>
        public string ArchivedFlag
        {
            get
            {
                return GetValue("p_nArchivedFlag");
            }
            set
            {
                SetValue("p_nArchivedFlag", value);
            }
        }
    }
}
