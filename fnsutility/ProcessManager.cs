using System;
using System.Diagnostics;
using System.Linq;

namespace FnsUtility
{
    /// <summary>
    /// Some helpful Process related functions
    /// </summary>
    public static class ProcessManager
    {
        /// <summary>
        /// Determines whether the specified process name is running.
        /// </summary>
        /// <param name="processName">Name of the process.</param>
        /// <returns>
        /// 	<c>true</c> if the specified process name is running; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsRunning(string processName)
        {
            return CurrentlyRunning(processName) != null;
        }
        /// <summary>
        /// Returns Process if the Process is currently running. 
        /// </summary>
        public static Process CurrentlyRunning(string processName)
        {
            return CurrentlyRunning(Environment.MachineName, processName);
        }

        /// <summary>
        /// Returns Process if the Process is currently running 
        /// on the given machine.
        /// </summary>
        public static Process CurrentlyRunning(string machine, string processName)
        {
            //get a list of all running processes on current system
            return (from p in Process.GetProcesses(machine)
                    where p.ProcessName.Equals(processName, StringComparison.InvariantCultureIgnoreCase)
                    select p).FirstOrDefault();

        }

        /// <summary>
        /// Gets the process by pid.
        /// </summary>
        public static Process GetProcessById(int id)
        {
            return GetProcessById(Environment.MachineName, id);
        }

        /// <summary>
        /// Gets the process by pid from the specified machine.
        /// </summary>
        public static Process GetProcessById(string machine, int id)
        {
            //get a list of all running processes on current system
            return (from p in Process.GetProcesses(machine)
                    where p.Id == id
                    select p).FirstOrDefault();

        }
    }
}
