using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbClassLibrary.ActiveRecords;
using FnsUtility;

namespace FnsUtility
{
    public class PerformanceMonitor : IPerformanceMonitor
    {
        public int Id { get; private set; }
        public int CallId { get; set; }
        public int UserId { get; set; }
        public string Component { get; set; }
        public string Method { get; set; }
        public string Frame { get; set; }
        private bool _stopped = false;

        public virtual bool Start()
        {
            try
            {
                var performance = new PerformanceData
                {
                    CallId = CallId,
                    UserId = UserId,
                    Server = Environment.MachineName,
                    Component = Component,
                    Method = Method,
                    FrameName = Frame
                };
                performance.Insert();
               Id = performance.Id;
               return true;

            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex, new CallingMethod());
                Id = 0;
                return false;
            }
        }
        
        public virtual bool Stop()
        {
            if (!_stopped && Id > 0)
            {
                _stopped = true;
                return PerformanceData.Touch(Id);
            }
            return false;
        }

        static public IPerformanceMonitor PerformanceMonitorFactory(int callId, int userId, string component, string method, string frame)
        { 
            IPerformanceMonitor result;
            if (ApplicationConfiguration.Instance.MonitorPerformance)
                result = new PerformanceMonitor
                    {
                        CallId = callId,
                        UserId = userId,
                        Component = component,
                        Method = method,
                        Frame = frame
                    };
            else
                result = new PerfomanceMonitorMock
                    {
                        CallId = callId,
                        UserId = userId,
                        Component = component,
                        Method = method,
                        Frame = frame
                    };
            result.Start();
            return result;
        }

        #region IDisposable Members

        public void Dispose()
        {
            Stop();
        }

        #endregion
    }

    public class PerfomanceMonitorMock : PerformanceMonitor, IPerformanceMonitor
    {
        public override bool Start()
        {
            ErrorLog.DebugLog("PerformanceMonitor Start called.", "IPerformanceMonitor");
            return true;
        }

        public override bool Stop()
        {
            ErrorLog.DebugLog("PerformanceMonitor Stop called.", "IPerformanceMonitor");
            return true;
        }
    }
}
