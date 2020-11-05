using System;
using System.IO;
using System.Net;

namespace FnsUtility
{
	/// <summary>
	/// General utility class for Web services
	/// </summary>
	public class WebUtility
	{
		/// <summary>
		/// Gets a value indicating whether to use a live proxy with credentials.
		/// </summary>
		/// <value><c>true</c> if [use credentials]; otherwise, <c>false</c>.</value>
		public static bool UseCredentials
		{
			get
			{
				return GeneralUtility.GetAppConfigValue("UseNetworkCredentials").Equals("true", StringComparison.InvariantCultureIgnoreCase);
			}
		}

		/// <summary>
		/// Gets the name of the network proxy.
		/// </summary>
		/// <value>The name of the network proxy.</value>
		private static string NetworkProxyName
		{
			get
			{
				return GeneralUtility.GetAppConfigValue("NetworkProxyName");
			}
		}

		/// <summary>
		/// Gets the name of the network user.
		/// </summary>
		/// <value>The name of the user.</value>
		private static string UserName
		{
			get
			{
				return GeneralUtility.GetAppConfigValue("NetworkUsername");
			}
		}

		/// <summary>
		/// Gets the password.
		/// </summary>
		/// <value>The password.</value>
		private static string Password
		{
			get
			{
				return GeneralUtility.GetAppConfigValue("NetworkPassword");
			}
		}

		/// <summary>
		/// Gets the domain.
		/// </summary>
		/// <value>The domain.</value>
		private static string Domain
		{
			get
			{
				return GeneralUtility.GetAppConfigValue("NetworkDomain");
			}
		}

		/// <summary>
		/// creates a WebProxy using the specified settings
		/// </summary>
		/// <returns></returns>
		public static WebProxy GetProxy()
		{
			WebProxy results = null;

			if (UseCredentials)
			{
				results = new WebProxy(NetworkProxyName, true)
				              {
				                  Credentials = new NetworkCredential(UserName, Password, Domain)
				              };
			}
			return results;
		}

        /// <summary>
        /// Check to see if ClaimCapture is up.
        /// </summary>
        /// <param name="uri">The URI: http://[machine].na.tigplc.com.</param>
        /// <returns>true if check.asp returns OK</returns>
        internal static bool CheckServerIsOk(string uri)
        {
            try
            {
                var request = WebRequest.Create(uri + "/check.asp");
                request.Timeout = 30000;
                using (var reader = new StreamReader(request.GetResponse().GetResponseStream()))
                {
                    return reader.ReadToEnd().Contains("Server tested OK");
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether running machine is CC web server and is default web site (IIS 6).
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is web server]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWebServer()
        {
            return CheckServerIsOk("http://" + Environment.MachineName);
        }

        /// <summary>
        /// Determines whether [is opm server].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is opm server]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsOpmServer()
        {
            return CheckOpmServer();
        }

        internal static bool CheckOpmServer()
        {
            try
            {
                using (Impersonate.ImpersonateUser(UserName, Domain, Password))
                {
                    return ServiceManager.GetController("OutcomeStepOPM") != null;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }
	}
}
