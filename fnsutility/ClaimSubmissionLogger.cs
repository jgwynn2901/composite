using System.Threading;
using System;

namespace FnsUtility
{
  /// <summary>
  /// Exposing the original logging functionality 
  /// via dependency injection to reduce coupling
  /// </summary>
  public class ClaimSubmissionLogger : IMethodLogger
  {
    /// <summary>
    /// 
    /// </summary>
    public enum LogType
    {
      /// <summary>
      /// 
      /// </summary>
      Request,
      /// <summary>
      /// 
      /// </summary>
      Response
    };

    internal class LoggerPackage
    {
      internal string Document;
      internal LogType Prefix;
      internal string RquId;
      internal string Instance;
      internal DateTime TimeStamp;
    }
    /// <summary>
    /// Logs the web method request.
    /// </summary>
    /// <param name="request">The request as text.</param>
    /// <param name="rquId">The rquid.</param>
    /// <param name="instance">The database instance.</param>
    public void LogRequest(string request, string rquId, string instance)
    {
      Log(new LoggerPackage
      {
        Document = request,
        Prefix = LogType.Request,
        RquId = rquId,
        Instance = instance,
        TimeStamp = DateTime.Now
      });
    }

    /// <summary>
    /// Logs the response.
    /// </summary>
    /// <param name="response">The response as text.</param>
    /// <param name="rquId">The rquid.</param>
    /// <param name="instance">The database instance.</param>
    public void LogResponse(string response, string rquId, string instance)
    {
      Log(new LoggerPackage
      {
        Document = response,
        Prefix = LogType.Response,
        RquId = rquId,
        Instance = instance,
        TimeStamp = DateTime.Now
      });
    }

    private static void Log(LoggerPackage package)
    {
      if (ApplicationConfiguration.Instance.UseAsynchLogging)
      {
        ThreadPool.QueueUserWorkItem(LogAsychrounously, package);
        return;
      }
      LogAsychrounously(package);
    }

    /// <summary>
    /// Logs the response body.
    /// </summary>
    public static void LogResponseBody(string document, LogType prefix, string requestId, string instance)
    {
      ExecuteLog(new LoggerPackage { Document = document, Prefix = prefix, RquId = requestId, Instance = instance, TimeStamp = DateTime.Now });
    }

    private static void LogAsychrounously(object stateInfo)
    {
      var package = stateInfo as LoggerPackage;
      if (package == null) return;
      ExecuteLog(package);
    }

    private static void ExecuteLog(LoggerPackage package)
    {
      try
      {
        XmlUtility.Log2ClaimSubmissionLog(package);
        if (ApplicationConfiguration.Instance.Log2File)
          XmlUtility.DumpResponseBody(package.Document, package.Prefix.ToString().ToUpper(), package.RquId);

      }
      catch (Exception ex)
      {
        ErrorLog.LogEvent(ex, new CallingMethod());
      }
    }
  }
}
