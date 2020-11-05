using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace FnsUtility
{

    public static class Impersonate
    {
        // obtains user token
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool LogonUser(string pszUsername, string pszDomain, string pszPassword,
            int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

        // closes open handes returned by LogonUser
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public extern static bool CloseHandle(IntPtr handle);

        // ReSharper disable InconsistentNaming
        // creates duplicate token handle
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public extern static bool DuplicateToken(IntPtr ExistingTokenHandle,
            int SECURITY_IMPERSONATION_LEVEL, ref IntPtr DuplicateTokenHandle);

        // group type enum
        public enum SECURITY_IMPERSONATION_LEVEL
        {
            SecurityAnonymous = 0,
            SecurityIdentification = 1,
            SecurityImpersonation = 2,
            SecurityDelegation = 3
        }
        // ReSharper restore InconsistentNaming


        public static WindowsImpersonationContext ImpersonateUser(string username, string domain, string password)
        {
            // initialize tokens
            var pExistingTokenHandle = IntPtr.Zero;
            var pDuplicateTokenHandle = IntPtr.Zero;

            // if domain name was blank, assume local machine
            if (domain == "")
                domain = Environment.MachineName;

            try
            {
                // ReSharper disable InconsistentNaming
                const int LOGON32_PROVIDER_DEFAULT = 0;
                // create token
                const int LOGON32_LOGON_INTERACTIVE = 2;
                //const int SecurityImpersonation = 2;
                // ReSharper restore InconsistentNaming

                // get handle to token
                var impersonated = LogonUser(username, domain, password,
                    LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, ref pExistingTokenHandle);

                // did impersonation fail?
                if (!impersonated)
                    throw new ApplicationException(
                        string.Format("LogonUser({0},{1},{2}) failed with error code: {3}",
                        username, domain, password, Marshal.GetLastWin32Error()));

                var results = DuplicateToken(pExistingTokenHandle,
                                            (int)SECURITY_IMPERSONATION_LEVEL.SecurityImpersonation,
                                            ref pDuplicateTokenHandle);

                // did DuplicateToken fail?
                if (!results)
                    throw new ApplicationException("DuplicateToken() failed with error code: " + Marshal.GetLastWin32Error());

                // create new identity using new primary token
                var newId = new WindowsIdentity(pDuplicateTokenHandle);
                var impersonatedUser = newId.Impersonate();
                return impersonatedUser;
            }
            finally
            {
                // close handle(s)
                if (pExistingTokenHandle != IntPtr.Zero)
                    CloseHandle(pExistingTokenHandle);
                if (pDuplicateTokenHandle != IntPtr.Zero)
                    CloseHandle(pDuplicateTokenHandle);
            }
        }

    }
}
