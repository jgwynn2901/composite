using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace FnsUtility
{
    /// <summary>
    /// 
    /// </summary>
    public static class CertificateValidationCallback
    {
        private static bool _callbackSet;
        /// <summary>
        /// Sets the cert policy.
        /// </summary>
        public static void SetCertificatePolicy()
        {
            if (!_callbackSet)
            ServicePointManager.ServerCertificateValidationCallback
                       += RemoteCertificateValidate;
            _callbackSet = true;
        }

        /// <summary>
        /// Remotes the certificate validate.
        /// </summary>
        private static bool RemoteCertificateValidate(
           object sender, X509Certificate cert,
            X509Chain chain, SslPolicyErrors error)
        {
            ErrorLog.DebugLog(string.Format("ServerCertificateValidationCallback sender: {0}, error: {1}",
                                sender, error), "CertificateValidationCallback");
            // trust any certificate!!!
            return true;
        }

    }
}
