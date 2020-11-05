using System;
namespace FnsUtility
{
    public interface IPerformanceMonitor : IDisposable
    {
        int CallId { get; set; }
        string Component { get; set; }
        string Frame { get; set; }
        int Id { get; }
        string Method { get; set; }
        bool Start();
        bool Stop();
        int UserId { get; set; }
    }
}
