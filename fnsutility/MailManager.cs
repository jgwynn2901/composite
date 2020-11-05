/**************************************************************************
 * MailManager.cs : module file for the MailManager class        
 **************************************************************************
 *
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 1993-2004 by First Notice Systems 
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/MailManager.cs 5     3/11/10 4:28p Gwynnj $*/
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using DbClassLibrary;
using NetMail=System.Net.Mail;

namespace FnsUtility
{
	/// <summary>
	/// Summary description for MailManager.
	/// 
	/// This class sends email messages to destination addresses...
	/// </summary>
	public class MailManager
	{
		/// <summary>
		/// This is the component name, BUGBUG: This idiom cam be replaced with ToString()
		/// </summary>
		private const string Component = "MailManager";
        private static readonly bool UseNetworkCredentials;
        private static readonly string Username;
        private static readonly string Password;
        private static readonly string Domain;

        /// <summary>
        /// Initializes the <see cref="MailManager"/> class.
        /// </summary>
        static MailManager()
        {
            UseNetworkCredentials =
                GeneralUtility.GetFnsRegistryKeyString("OutputComponents\\Email", "UseNetworkCredentials")
                    .Equals("true", StringComparison.InvariantCultureIgnoreCase);

            Username =
                GeneralUtility.GetFnsRegistryKeyString("OutputComponents\\Email", "Username");
            Password =
                GeneralUtility.GetFnsRegistryKeyString("OutputComponents\\Email", "Password");
            Domain =
                GeneralUtility.GetFnsRegistryKeyString("OutputComponents\\Email", "Domain");
            

            

        }

		/// <summary>
		/// SendEmail
		/// </summary>
		/// <param name="from">The mail from value.</param>
		/// <param name="subject">The mail subject value.</param>
		/// <param name="body">The mail body text.</param>
		/// <param name="destinations">The mail to destinations.</param>
		public static void SendEmail(string from, string subject, string body, string destinations)
		{
			//Check destination string isn't empty
			//If empty, no need to send anything
			if(destinations.Length == 0)
				return;

			try
			{
				var myMail = new MailMessage(from, destinations, subject, body);
                SendMailMessage(myMail);
            }
			catch(Exception ex)
			{
				ErrorLog.LogError("SendEmailNotifications(): ERROR: " + (ex.InnerException == null ? ex.Message: ex.InnerException.Message), Component);
			}
		}

		/// <summary>
		/// SendEmailWithAttachment
		/// </summary>
		/// <param name="from">The mail from value.</param>
		/// <param name="subject">The mail subject value.</param>
		/// <param name="body">The mail body text.</param>
		/// <param name="destinations">The mail to destinations.</param>
		/// <param name="fullFilePaths">Semicolon delimited strings - file paths, or just one file path</param>
		public static void SendEmailWithAttachment(string from, string subject, string body, string destinations, string fullFilePaths)
		{
			//Check destination string isn't empty
			//If empty, no need to send anything
			if(destinations.Length == 0)
				return;

			try
			{
				var myMail = new MailMessage(from, destinations, subject, body);
				var strAttachments = fullFilePaths.Split(';');
				foreach (var attachment in strAttachments.Select(t => new Attachment(t)))
				{
				  myMail.Attachments.Add(attachment);
				}
                SendMailMessage(myMail);

			}
			catch(Exception ex)
			{
        ErrorLog.LogError("SendEmailNotifications(): ERROR: " + (ex.InnerException == null ? ex.Message : ex.InnerException.Message), Component);
      }
		}

        private static void SendMailMessage(MailMessage message)
        {
            SendMailMessage(null, message, UseNetworkCredentials);
        }

	    /// <summary>
        /// Sends the mail message.
        /// </summary>
        public static void SendMailMessage( string host, MailMessage message, bool useNetworkCredentials)
        {
            try
            {
                var smptHost = string.IsNullOrEmpty(host) ? "127.0.0.1" : host;
                var client = new SmtpClient(smptHost)
                                {
                                     DeliveryMethod = useNetworkCredentials ? 
                                     SmtpDeliveryMethod.Network : SmtpDeliveryMethod.PickupDirectoryFromIis
                                };

                if (useNetworkCredentials)
                    client.Credentials = new NetworkCredential(Username, Password, Domain);

                client.Send(message);

            }
            catch (Exception ex)
            {
              ErrorLog.LogError("SendEmailNotifications(): ERROR: " + (ex.InnerException == null ? ex.Message : ex.InnerException.Message), Component);
            }
        }

		/// <summary>
		/// SendTypeEmail will propagate an email instance to the recipients 
		/// define in the MERCURY table based on type, i.e. EDIFAIL_EMAIL
		/// </summary>
		/// <param name="from">The mail from value.</param>
		/// <param name="subject">The mail subject value.</param>
		/// <param name="body">The mail body text.</param>
		/// <param name="strMercuryType">Type of the mercury recipients.</param>
		public static void SendTypeEmail(string from, string subject, string body, string strMercuryType)
		{
			SendEmail(from, subject, body, GetMercuryDestinations(strMercuryType));
		}

		/// <summary>
		/// SendTypeEmailWithAttachment
		/// </summary>
		/// <param name="from">The mail from value.</param>
		/// <param name="subject">The mail subject value.</param>
		/// <param name="body">The mail body text.</param>
		/// <param name="strMercuryType">Type of the mercury recipients.</param>
		/// <param name="fullFilePaths">Semicolon delimited strings - file paths, or just one file path</param>
		public static void SendTypeEmailWithAttachment(string from, string subject, string body, string strMercuryType, string fullFilePaths)
		{
			SendEmailWithAttachment(from, subject, body, GetMercuryDestinations(strMercuryType), fullFilePaths);
		}

		/// <summary>
		/// GetMercuryDestinations
		/// Returns all email addresses from MERCURY table for type type
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		public static string GetMercuryDestinations(string type)
		{
			var destinations = String.Empty;
			try
			{
				var mercury = new MercuryDestinations {DestinationType = type};

			    Assert.Test(mercury.Execute(),mercury.LastError);
			
				var results = mercury.Results;
				Assert.Test(results != null,"no records returned.");

				DataTable table = null;
				if (results != null)
				{
					table = results.Tables[0];
				}
				if(table != null)
				{
					for (var i=0; i<=table.Rows.Count-1; i++)
					{
						if(destinations.Length > 0)
							destinations += ", ";

						destinations += table.Rows[i][0].ToString();
					}
				}
			}
			catch(Exception ex)
			{
				ErrorLog.LogError("GetMercuryDestinations(): ERROR: " + ex.Message, Component);
			}
			return destinations;
		}
	}
}

/////////////////////////////////////////////////////////////////////////////
// EOF
/////////////////////////////////////////////////////////////////////////////
/*
 * $Log: /SourceCode/Components/FNS2005/FnsUtility/MailManager.cs $
 * 
 * 5     3/11/10 4:28p Gwynnj
 * SMPT mail now can switch to Network with credentials
 * 
 * 4     2/08/10 6:20p Gwynnj
 * Extended MailManager to add SmtpHost and credentials
 * 
 * 3     1/04/10 3:20p John.gwynn
 * Minor re-edits and some logging tests
 * 
 * 2     1/19/07 9:33a John.gwynn
 * added SmtpDeliveryMethod.PickupDirectoryFromIis for email delivery
 * (bugbug move to config)
 * 
 * 1     1/18/07 2:38p John.gwynn
 * Framework 2.0 upgrade
 * 
 * 2     12/19/06 1:26p John.gwynn
 * NDoc comments for technical documentation see:
 * http://cha1saxc/wiki/ndocs/fnsutility/index.html
 * 
 * 1     10/10/06 11:02a John.gwynn
 * EmailTraceListener integrated with MailManager to use MERCURY
 * destinations.  Modified RegistryKey in GeneralUtility to use Dispose
 * pattern (using).  Added MailManager functionality.  Old MailManager
 * project is now OBSOLETE.
 * 
 * 5     6/12/06 1:22p John.gwynn
 * updated versioning
 * 
 * 4     6/05/06 5:25p John.gwynn
 * added strong name key
 * 
 * 3     3/17/05 9:54a Alex.shimberg
 * Added explicit release of a DBPool object
 * 
 * 2     11/17/04 5:08p Alex.shimberg
 * Removed DBConnManager as a source of DB connections.
 * 
 * 1     10/18/04 4:31p Alex.shimberg
*/
