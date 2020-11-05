namespace DbClassLibrary.Opm
{
  /// <summary>
  /// ChangeCallRoutingStatusOCI version in OutputFunctions package
  /// </summary>
  public class ChangeCallRoutingStatus : DbBaseClass
  {
    private enum ParmList
    {
      CallRoutingId = 0,
      OldStatus,
      NewStatus,
      ServerName,
      Result
    };

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="ChangeTransOutcomeStatus"/> class.
    /// </summary>
    public ChangeCallRoutingStatus() :
      this(ApplicationConfiguration.Instance.DefaultInstance)
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChangeTransOutcomeStatus"/> class.
    /// </summary>
    /// <param name="instance"></param>
    public ChangeCallRoutingStatus(string instance)
      : base(instance)
    {
      _name = "OUTPUTFUNCTIONS.ChangeCallRoutingStatusOCI";

      _parameterNames = new[] {
					"inCallRouting_id",
					"inOldStatus",
					"inNewStatus",
          "inServerName",
					"outResult" 
				};

      Initialize();
    }

    #endregion

    #region Initialize

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    protected override sealed void Initialize()
    {
      AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)ParmList.CallRoutingId], "", System.Data.DbType.Int32);
      AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)ParmList.OldStatus], "", System.Data.DbType.AnsiString);
      AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)ParmList.NewStatus], "", System.Data.DbType.AnsiString);
      AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)ParmList.ServerName], "", System.Data.DbType.AnsiString);
      AddParm(System.Data.ParameterDirection.Output, _parameterNames[(int)ParmList.Result], "", System.Data.DbType.Int32);
    }

    #endregion

    #region Properties

    #region NewStatus

    /// <summary>
    /// Gets or sets the innewstatus.
    /// </summary>
    public string NewStatus
    {
      get { return GetValue((int)ParmList.NewStatus); }
      set { SetValue((int)ParmList.NewStatus, value); }
    }
    #endregion

    #region OldStatus
    /// <summary>
    /// Gets or sets the old status.
    /// </summary>
    public string OldStatus
    {
      get { return GetValue((int)ParmList.OldStatus); }
      set { SetValue((int)ParmList.OldStatus, value); }
    }
    #endregion

    #region CallRoutingId
    /// <summary>
    /// Gets or sets the CallRoutingId
    /// </summary>
    public string CallRoutingId
    {
      get { return GetValue((int)ParmList.CallRoutingId); }
      set { SetValue((int)ParmList.CallRoutingId, value); }
    }

    #endregion

    #region ServerName
    /// <summary>
    /// Gets or sets the ServerName
    /// </summary>
    public string ServerName
    {
      get { return GetValue((int)ParmList.ServerName); }
      set { SetValue((int)ParmList.ServerName, value); }
    }

    #endregion

    #region Result
    /// <summary>
    /// Gets (readonly) the result.
    /// </summary>
    public bool Result
    {
      get { return GetValue((int)ParmList.Result).Equals("1"); }
    }
    #endregion

    #endregion
  }
}
