using System;
using System.Globalization;
using System.Net;
using FnsInterfaces;

namespace FnsUtility
{
  /// <summary>
  /// encapsulates web service consumer and provides common behavior
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class BaseService<T> where T : IDisposable, new()
  {
    static BaseService()
    {
      if (ApplicationConfiguration.Instance.UseNetworkCredentials ||
          ApplicationConfiguration.Instance.Fiddler)
        WebRequest.DefaultWebProxy = GetDefaultProxy();
    }
    /// <summary>
    /// constructs the encapsulate service with default constructors
    /// override to articluate endpoint and url parameters
    /// </summary>
    protected virtual T Instance()
    {
      return new T();
    }

    /// <summary>
    /// Gets the ADO result set field names.
    /// </summary>
    protected virtual string[] FieldNames
    {
      get { return new string[] { }; }
    }


    /// <summary>
    /// Initializes a new instance of the <see cref="BaseService&lt;T&gt;"/> class.
    /// </summary>
    protected BaseService()
      : this(new ClaimSubmissionLogger())
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseService&lt;T&gt;"/> class.
    /// </summary>
    /// <param name="logger">inject the request response logger.</param>
    protected BaseService(IMethodLogger logger)
    {
      Logger = logger;
    }

    /// <summary>
    /// Gets or sets the last error.
    /// </summary>
    public string LastError { get; set; }

    /// <summary>
    /// Gets or sets the logger.
    /// </summary>
    /// <value>The logger.</value>
    protected IMethodLogger Logger { get; set; }

    /// <summary>
    /// Logs the request to the claim_submission_log.
    /// </summary>
    protected void LogRequest(object request, string rquId, string instance)
    {
      var data = request is string ? request.ToString() : XmlUtility.GetXmlObjectAsString(request);
      Logger.LogRequest(data, rquId, instance);
    }

    /// <summary>
    /// Logs the response to the claim_submission_log.
    /// </summary>
    protected void LogResponse(object request, string rquId, string instance)
    {
      var data = request is string ? request.ToString() : XmlUtility.GetXmlObjectAsString(request);
      Logger.LogResponse(data, rquId, instance);
    }

    /// <summary>
    /// Gets the WebProxy if UseNetworkCredentials == true.
    /// </summary>
    protected WebProxy Proxy
    {
      get
      {
        return ApplicationConfiguration.Instance.UseNetworkCredentials
        ? GetDefaultProxy()
        : default(WebProxy);
      }
    }

    private static WebProxy GetDefaultProxy()
    {
      if (ApplicationConfiguration.Instance.Fiddler)
        return new WebProxy("127.0.0.1", 8888);

      return new WebProxy(ApplicationConfiguration.Instance.NetworkProxyName, true)
      {
        Credentials = new NetworkCredential(ApplicationConfiguration.Instance.NetworkUsername,
                                            ApplicationConfiguration.Instance.NetworkPassword,
                                            ApplicationConfiguration.Instance.NetworkDomain)
      };
    }

    /// <summary>
    /// Executes the specified request agains the specified service 
    /// encapsulates loging to Claim Submission Log.  
    /// </summary>
    /// <typeparam name="TRequest">The type of the service request.</typeparam>
    /// <typeparam name="TResponse">The return type of the service response.</typeparam>
    /// <returns>web service method response</returns>
    protected TResponse Execute<TRequest, TResponse>(TRequest request, string rquId, string instance, Func<TRequest, TResponse> method)
    {
      LogRequest(request, rquId, instance);
      var response = method(request);
      LogResponse(response, rquId, instance);
      return response;
    }

    /// <summary>
    /// Gets the request rquid from the call if it exists.
    /// Otherwise it creates and sets it.
    /// </summary>
    protected string GetRequestRquId(ICall call)
    {
			return GeneralUtility.GetRequestRquId(call);
    }

    /// <summary>
    /// Saves the entity.
    /// </summary>
    /// <param name="rquId">The rquId identifier.</param>
    /// <param name="data">The entity (serialized) data.</param>
    /// <returns></returns>
    protected static bool SaveEntity(string rquId, string data)
    {
      try
      {
        var entity = new DbClassLibrary.EntityResponse { RquId = rquId };
        entity.SetSource(data);
        return true;
      }
      catch (Exception ex)
      {
        ErrorLog.LogError(ex, new CallingMethod());
      }
      return false;
    }

    /// <summary>
    /// Loads the entity.
    /// </summary>
    /// <param name="rquId">The rquId identifier.</param>
    /// <returns>The data</returns>
    /// <exception cref="System.ApplicationException">Unable to retrieve entity id:  + rquId</exception>
    protected static string LoadEntity(string rquId)
    {
			return GeneralUtility.LoadEntity(rquId);
    }
  }
}
