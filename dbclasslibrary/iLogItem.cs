namespace DbClassLibrary
{
    public class IlogItem : DbBaseClass
    {
        /// <summary>
	    /// Initializes a new instance of the <see cref="AccountUser"/> class.
		/// </summary>
        public IlogItem() : base(FNSBA)
		{
            _name = "ILOG_ITEM";

	        _parameterNames = new[] {
								         "p_id",
								         "p_issue",
                                         "p_item",
								         "p_contents"
								    };
			Initialize();
		}
        protected override sealed void Initialize()
		{
			///////////////////////////////////////////////////
            /////p_id
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
			        _parameterNames[0],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
            /////p_issue
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[1],"",System.Data.DbType.String);
			///////////////////////////////////////////////////
            /////p_item
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[2], "", System.Data.DbType.String);
            ///////////////////////////////////////////////////
            /////p_contents
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[3], "", System.Data.DbType.String);
			
		}

        public string IlogId
        {
            get { return GetValue(0); }
        }

        public string Issue
        {
            get { return GetValue(1); }
            set { SetValue(1, value); }
        }

        public string Item
        {
            get { return GetValue(2); }
            set { SetValue(2, value); }
        }

        public string Contents
        {
            get { return GetValue(3); }
            set { SetValue(3, value); }
        }
    }
}
