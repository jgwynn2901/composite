using System;
using System.Linq;
using System.ServiceProcess;
using System.Threading;

namespace FnsUtility
{
    /// <summary>
    /// Service management utilities
    /// </summary>
    public static class ServiceManager
    {
        /// <summary>
        /// Starts the service.
        /// </summary>
        public static bool StartService(ServiceController service)
        {
            service.Start();
            var timeout = new TimeSpan(0, 0, 0, 6, 0); // 3 sec
            service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            return service.Status == ServiceControllerStatus.Running;
        }

        /// <summary>
        /// Stops the service.
        /// </summary>
        public static bool StopService(ServiceController service)
        {
            service.Stop();
            var timeout = new TimeSpan(0, 0, 0, 6, 0); // 3 sec
            service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            return service.Status == ServiceControllerStatus.Stopped;
        }

        /// <summary>
        /// Restarts the service.
        /// </summary>
        public static bool RestartService(ServiceController service)
        {
            if (service.Status == ServiceControllerStatus.Running && StopService(service))
            {
                Thread.Sleep(30000);  // wait 30 seconds
                return StartService(service);
            }
            return false;
        }

        /// <summary>
        /// Gets the controller.
        /// </summary>
        public static ServiceController GetController(string serviceName)
        {
            return GetController(".", serviceName);
        }

        /// <summary>
        /// Gets the controller from specified machine.
        /// </summary>
        public static ServiceController GetController(string machineName, string serviceName)
        {
            return (from controller in ServiceController.GetServices(machineName)
                    where controller.ServiceName.Equals(serviceName, StringComparison.InvariantCultureIgnoreCase)
                    select controller).FirstOrDefault();
        }
    }
}
