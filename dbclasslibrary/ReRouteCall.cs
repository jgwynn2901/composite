using System;

namespace DbClassLibrary
{
  public sealed class ReRouteCall : DbBaseClass
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ReRouteCall"/> class.
    /// </summary>
    /// <param name="instance"></param>
    public ReRouteCall(string instance) : base(instance)
    {
      _name = "SP_REROUTE_CALL";
      Initialize();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ReRouteCall"/> class.
    /// </summary>
    public ReRouteCall() : this(String.Empty)
    {
    }

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    protected override void Initialize()
    {
      ///////////////////////////////////////////////////
      ///// inCallID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
        "inCallID", "", System.Data.DbType.Int32);
    }

    /// <summary>
    /// Gets or sets the call identifier.
    /// </summary>
    /// <value>
    /// The call identifier.
    /// </value>
    public string CallId
    {
      get
      {
        return GetValue("inCallID");
      }
      set
      {
        SetValue("inCallID", value);
      }
    }
  }
}
