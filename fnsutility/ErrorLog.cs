#region File Header
/**************************************************************************
* First Notice Systems
* 529 Main Street
* Boston, MA 02129
* (617) 886 2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2006 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/ErrorLog.cs 22    7/18/12 4:30p Pintoa $ */
#endregion

#region References
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using DbClassLibrary;


#endregion


namespace FnsUtility
{
    /// <summary>
    /// ErrorLog provides a managed alternative to the functionality in FNSUtils
    /// </summary>
    public static class ErrorLog
    {
        private const string EventSource = "ClaimCapture";
        private class ErrorPackage
        {
            internal string Component;
            internal string Message;
            internal string Instance;
            internal int Severity;
        }

        /// <summary>
        /// Outputs the debug string.
        /// </summary>
        /// <param name="message">The message.</param>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern void OutputDebugString(string message);


        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        public delegate LogErrorDelegate CurriedLogError(string instance);
        /// <summary>
        /// 
        /// </summary>
        public delegate bool LogErrorDelegate(string error, string component);

        /// <summary>
        /// Users can instantiate an instance of this Delegate with the instance
        /// in order to implement the logging to a specified instance
        /// </summary>
        static public CurriedLogError LogErrorInstance =
            instance => delegate(string error, string component) { return LogError(error, component, instance); };
        /// <summary>
        /// prefix component with originating process
        /// </summary>
        /// <returns></returns>
        public static string GetProcessName()
        {
            var results = String.Empty;
            try
            {
                var oProc = Process.GetCurrentProcess();
                if (oProc.ProcessName != null)
                    results = oProc.ProcessName;
            }
            catch (Exception ex)
            {
                DebugLog(ex.Message, "ErrorLog.GetProcessName");
            }
            return results;
        }
        /// <summary>
        /// LogError
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="component">The component.</param>
        /// <returns></returns>
        public static bool LogError(string error, string component)
        {
            return Log(error, 3, component, string.Empty);
        }
        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="component">The component.</param>
        /// <returns></returns>
        public static bool LogError(string error, CallingMethod component)
        {
            return LogError(error, component, string.Empty);
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <param name="component">The component.</param>
        /// <returns></returns>
        public static bool LogError(Exception ex, CallingMethod component)
        {
            return LogError(ex.GetBaseException().Message, component);
        }
        public static bool LogEvent(Exception ex, CallingMethod component)
        {
            try
            {
                if (EventLog.SourceExists(EventSource))
                {
                    var eventLogger = new EventLog {Source = EventSource};
                    var message = ex.InnerException == null
                                      ? ex.Message
                                      : ex.InnerException.Message;

                    eventLogger.WriteEntry(string.Format("{0} {1}", message, component.Text), EventLogEntryType.Warning);
                }
            }
// ReSharper disable EmptyGeneralCatchClause
            catch
// ReSharper restore EmptyGeneralCatchClause
            {

            }
            return true;
        }
        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="component">The component.</param>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static bool LogError(string error, CallingMethod component, string instance)
        {
            return Log(string.Format("{0} {1}", error, component.Text), 3, component.MethodName, instance);
        }
        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="component">The component.</param>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static bool LogError(string error, string component, string instance)
        {
            return Log(error, 3, component, instance);
        }
        /// <summary>
        /// LogWarning
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="component">The component.</param>
        /// <returns></returns>
        public static bool LogWarning(string error, string component)
        {
            return Log(error, 2, component, string.Empty);
        }
        /// <summary>
        /// Logs the warning.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="component">The component.</param>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static bool LogWarning(string error, string component, string instance)
        {
            return Log(error, 2, component, instance);
        }
        /// <summary>
        /// LogInfo
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="component">The component.</param>
        /// <returns></returns>
        public static bool LogInfo(string error, string component)
        {
            return Log(error, 1, component, string.Empty);
        }
        /// <summary>
        /// Logs the info.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="component">The component.</param>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static bool LogInfo(string error, string component, string instance)
        {
            return Log(error, 1, component, instance);
        }

        /// <summary>
        /// Logs the specified error.
        /// </summary>
        public static bool Log2Instance(string error, int severity, string component, string instance)
        {
            try
            {
                DebugLog(error, component);
                if (null == error || null == component)
                    return false;

                var computerName = Environment.MachineName;
                var processName = GetProcessName() + "." + component;

                if (0 == computerName.Length)
                    computerName = "UNKNOWN";

                // and log if allowed
                if (ApplicationConfiguration.Instance.LogToDatabase > 0 && severity >= ApplicationConfiguration.Instance.LogToDatabase)
                {
                    var myAppLog = new ApplicationLog
                    {
                        Component = processName,
                        CurrentDbInstance = instance,
                        ErrorString = error.Length > 2000 ? error.Substring(0, 2000) : error,
                        Server = computerName,
                        Severity = severity
                    };

                    myAppLog.Execute();
                }

                // now the file
                if (ApplicationConfiguration.Instance.LogToFile > 0 &&
                    severity >= ApplicationConfiguration.Instance.LogToFile &&
                    !string.IsNullOrEmpty(ApplicationConfiguration.Instance.ErrorFile))
                {
                    using (var stream = File.AppendText(ApplicationConfiguration.Instance.ErrorFile))
                    {
                        var formattedErrorMessage =
                            String.Format("{0}\tServer={1}\tSeverity: {2}\tComponent: {3}\tMessage: {4}",
                                          DateTime.Now.ToString("G"),
                                          Environment.MachineName,
                                          severity,
                                          processName,
                                          error);
                        stream.WriteLine(formattedErrorMessage);
                        stream.Flush();
                        stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                LogEvent(ex, new CallingMethod());
            }
            return true;
        }

         static void LogAsychrounously (object stateInfo)
         {
             var package = stateInfo as ErrorPackage;
             if(package == null) return;
             Log2Instance(package.Message, package.Severity, package.Component, package.Instance);
         }


        /// <summary>
        /// Log
        /// </summary>
        public static bool Log(string error, int severity, string component, string instance)
        {
            if (ApplicationConfiguration.Instance.UseAsynchLogging)
                return ThreadPool.QueueUserWorkItem(LogAsychrounously,
                                                    new ErrorPackage
                                                        {
                                                            Component = component,
                                                            Instance = instance,
                                                            Message = error,
                                                            Severity = severity
                                                        });

            return Log2Instance(error, severity, component, instance);
        }
        /// <summary>
        /// Trace output
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="component">The component.</param>
        static public void DebugLog(string message, string component)
        {
            var strOutput = String.Format("[{0}][{1}][{2}]{3}", DateTime.Now, Thread.CurrentThread.ManagedThreadId, component, message);
            OutputDebugString(strOutput);
        }
        #endregion

        /// <summary>
        /// Unwinds the exception message.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <returns></returns>
        public static string UnwindExceptionMessage (Exception ex)
        {
            var results = new StringBuilder();
            var current = ex;
            while (current != null)
            {
                results.AppendLine(ex.Message);
                current = current.InnerException;
            }
            return results.ToString();
        }

        /// <summary>
        /// Dump the whole chain of exception with details
        /// </summary>
        /// <param name="exception">The exception</param>
        /// <returns>The exception message</returns>
        public static string DumpExceptionChain(Exception exception)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Outer Exception: " + exception.GetType().FullName);
            sb.AppendLine("Message: " + exception.Message);
            sb.AppendLine("Source: " + exception.Source);
            sb.AppendLine("StackTrace: " + exception.StackTrace);

            var exInternal = exception.InnerException;
            while (exInternal != null)
            {
                sb.AppendLine();
                sb.AppendLine("Internal Exception: " + exInternal.GetType().FullName);
                sb.AppendLine("Message: " + exInternal.Message);
                sb.AppendLine("Source: " + exInternal.Source);
                sb.AppendLine("StackTrace: " + exInternal.StackTrace);

                exInternal = exInternal.InnerException;
            }
            return sb.ToString();
        }
    }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/FnsUtility/ErrorLog.cs $
 * 
 * 22    7/18/12 4:30p Pintoa
 * added DumpExceptionChain
 * 
 * 21    6/14/12 10:27a Gwynnj
 * added UnwindExceptionMessage
 * 
 * 20    6/12/12 11:31a Gwynnj
 * Now using ex.GetBaseException() on LogError(exception,...)
 * 
 * 19    1/08/12 2:16p Gwynnj
 * Added ErrorLog.LogEvent used in the try catch block of
 * ClaimSubmissionLog and any asynch loggong wich creates a vulnerability
 * for unhandled exceptions when not tied to request or response thread.
 * 
 * 18    9/15/10 1:44p Gwynnj
 * LogError (Exception ex ) will use inner exception over outer
 * 
 * 17    2/16/10 2:19p Gwynnj
 * added asynch logging and removed the NLog dependency and classes
 * 
 * 16    1/15/10 4:13p Gwynnj
 * removed NLog dependency
 * 
 * 15    1/07/10 4:52p Gwynnj
 * Tur off asynch logging - too brittle 
 * 
 * 14    1/06/10 10:23a Gwynnj
 * Fixed file logging when UseAsynchLogging =false
 * 
 * 13    1/04/10 3:20p John.gwynn
 * Minor re-edits and some logging tests
 * 
 * 12    12/28/09 5:43p John.gwynn
 * UseAsychLogging [default is true]  and replaced Trace.WriteLine with
 * win32 OutputDebugString
 * 
 * 11    12/23/09 4:42p John.gwynn
 * TraceLogger is throwing assertion
 * 
 * 10    12/23/09 3:13p John.gwynn
 * implemented Asynch logging
 * 
 * 9     12/02/09 6:44p John.gwynn
 * ExecuteMethod now handles static classes
 * 
 * 8     10/12/09 12:43p John.gwynn
 * Added ApplicationConfiguration singleton for general Fns Registry
 * settings
 * 
 * 7     3/04/09 11:43a John.gwynn
 * fixed severity logic
 * 
 * 6     3/04/09 11:20a John.gwynn
 * Added code to filter ErrorLog 0=none 1=All 2=Warning+Error 3= Error
 * 
 * 5     1/13/09 9:41a Deepika.sharma
 * dms: makeing a function public from private
 * 
 * 4     5/21/08 11:33a Roberto.agit
 * added call to trace facility in logerror
 * 
 * 3     1/09/08 4:13p John.gwynn
 * Added CallingMethod to ErrorLog.LogError
 * 
 * 2     10/11/07 1:37p John.gwynn
 * 
 * 1     1/18/07 2:38p John.gwynn
 * Framework 2.0 upgrade
 * 
 * 11    11/09/06 11:11a John.gwynn
 * added additional checks for those methods that would be called during
 * exception processing.
 * 
 * 10    6/20/06 2:07p John.gwynn
 * moved [assembly: CLSCompliant(true)] to assemblyInfo
 * 
 * 9     5/08/06 6:47p John.gwynn
 * documentation and file formatting
 * 
 * 8     4/20/06 11:54a John.gwynn
 * CLI Compliance modifications
 * 
 * 7     4/10/06 4:41p John.gwynn
 * update references and cleaned variable names
 * 
 * 6     4/10/06 4:12p John.gwynn
 * New version with namespace fixed
 * 
 * 5     3/17/06 5:51p John.gwynn
 * added ProcessName to Componet in Errorlog
 * 
 * 4     3/10/06 10:16a John.gwynn
 * debugLog and GetPolicyNumber fix
 * 
 * 3     2/09/06 6:08p John.gwynn
 * added file output format
 * 
 * 2     1/18/06 2:09p John.gwynn
 * ensure output to errorlog does not exceed 2000 chars
 * 
 * 1     1/16/06 4:50p John.gwynn
 * Added ErrorLog class
 */
#endregion
