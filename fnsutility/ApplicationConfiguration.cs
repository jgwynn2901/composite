using System;
using DbClassLibrary;
using FnsUtility.Annotations;

namespace FnsUtility
{
    /// <summary>
    /// 
    /// </summary>
  public class ApplicationConfiguration : ApConfigBase
    {
        private static ApplicationConfiguration _singletonInstance;

        /// <summary>
        /// Gets a value indicating whether this instance has instance.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance has instance; otherwise, <c>false</c>.
        /// </value>
        public static bool HasInstance { get; private set; }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static ApplicationConfiguration Instance
        {
            get
            {
                if (_singletonInstance == null)
                    _singletonInstance = new ApplicationConfiguration();
                HasInstance = true;
                return _singletonInstance;
            }

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationConfiguration"/> class.
        /// </summary>
        protected ApplicationConfiguration()
        {
            LogToDatabase = GeneralUtility.ConvertStringToIntOrNull(GeneralUtility.GetFnsRegistryKeyString("", "LogToDatabase")) ?? 0;
            LogToFile = GeneralUtility.ConvertStringToIntOrNull(GeneralUtility.GetFnsRegistryKeyString("", "LogToFile")) ?? 0;
            ErrorFile = GeneralUtility.GetFnsRegistryKeyString("", "ErrorFile");
            FnsBinDir = GeneralUtility.GetFnsRegistryKeyString("", "FNSBinDir");
            ConnectString = GeneralUtility.GetFnsRegistryKeyString("", "ConnectString");
            CallDataFile = GeneralUtility.GetFnsRegistryKeyString("", "CallDataFile");
            DataDir = GeneralUtility.GetFnsRegistryKeyString("", "DataDir");
            Log2File = (GeneralUtility.GetAppConfigValue("Log2File").Equals("True", StringComparison.CurrentCultureIgnoreCase));
            MonitorPerformance = ConfigurationReader.GetAppConfigValue("MonitorPerformance").Equals("true", StringComparison.InvariantCultureIgnoreCase);
            // default to true unless otherwise secified in config file
            UseAsynchLogging = (GeneralUtility.GetAppConfigValue("UseAsynchLogging").Equals("true", StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// encapsulates the LogToDatabase registry value.
        /// </summary>
        public int LogToDatabase { get; set; }

        /// <summary>
        /// encapsulates the LogToFile registry value.
        /// </summary>
        public int LogToFile { get; set; }

        /// <summary>
        /// encapsulates the ErrorFile registry value.
        /// </summary>
        public string ErrorFile { get; set; }

        /// <summary>
        /// encapsulates the FnsBinDir registry value.
        /// </summary>
        public string FnsBinDir { get; set; }

        /// <summary>
        /// encapsulates the ConnectString registry value.
        /// </summary>
        public string ConnectString { get; set; }

        /// <summary>
        /// encapsulates the CallDataFile registry value.
        /// </summary>
        public string CallDataFile { get; set; }

        /// <summary>
        /// encapsulates the DataDir registry value.
        /// </summary>
        public string DataDir { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether we use asych logging.
        /// </summary>
        public bool UseAsynchLogging { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [log2 file].
        /// </summary>
        /// <value><c>true</c> if [log2 file]; otherwise, <c>false</c>.</value>
        public bool Log2File { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use network credentials].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [use network credentials]; otherwise, <c>false</c>.
        /// </value>
        public bool UseNetworkCredentials { get; set; }

        /// <summary>
        /// Gets or sets the name of the network proxy.
        /// </summary>
        /// <value>The name of the network proxy.</value>
        public string NetworkProxyName { get; set; }

        /// <summary>
        /// Gets or sets the network username.
        /// </summary>
        /// <value>The network username.</value>
        public string NetworkUsername { get; set; }

        /// <summary>
        /// Gets or sets the network password.
        /// </summary>
        /// <value>The network password.</value>
        public string NetworkPassword { get; set; }

        /// <summary>
        /// Gets or sets the network domain.
        /// </summary>
        /// <value>The network domain.</value>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ApplicationConfiguration"/> is fiddler.
        /// </summary>
        /// <value><c>true</c> if fiddler; otherwise, <c>false</c>.</value>
        public bool Fiddler { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to monitor performance logging.
        /// </summary>
        public bool MonitorPerformance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use remote fnsconnect.
        /// </summary>
        public bool UseRemoteConnect { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is opm server.
        /// </summary>
        public bool IsOpmServer { get; [UsedImplicitly] private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is CC server.
        /// </summary>
        public bool IsWebServer { get; [UsedImplicitly] private set; }
    }
}
