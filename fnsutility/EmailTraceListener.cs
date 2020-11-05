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
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/EmailTraceListener.cs 6     3/01/11 8:52a Gwynnj $ */
#endregion

using System;
using System.Diagnostics;
using System.Net.Mail;
using System.Text;
using NetMail=System.Net.Mail;


namespace FnsUtility
{
	/// <summary>
	/// Summary description for EmailTraceListener.
	/// </summary>
	public sealed class EmailTraceListener : TraceListener
	{
		private readonly string _mailTo;
		private StringBuilder _message;
		private const string From = "traceListener@sedgwick.com";
		private const string Subject = "TraceListener Alert";
	    private bool _isClosed;

		/// <summary>
		/// Initializes a new instance of the <see cref="EmailTraceListener"/> class.
		/// </summary>
		public EmailTraceListener() :this(String.Empty)
		{
		}

        /// <summary>
		/// Initializes a new instance of the <see cref="EmailTraceListener"/> class.
		/// </summary>
		/// <param name="mailTo">The mail to.</param>
		public EmailTraceListener(string mailTo) 
		{
			try
			{
				_mailTo = MailManager.GetMercuryDestinations(mailTo);
			}
			catch(Exception ex)
			{
				ErrorLog.LogError("EmailTraceListener(): ERROR: " + ex.Message, ToString());
			}
		}
		/// <summary>
		/// When overridden in a derived class, writes the specified
		/// message to the listener you create in the derived class.
		/// </summary>
		/// <param name="message">A message to write.</param>
		public override void Write (string message)
		{
			try
			{
				if (_message == null)
				{
					_message = new StringBuilder(255);
				}
				_message.Append(message);
			}
			catch(Exception ex)
			{
				ErrorLog.LogError("Write(): ERROR: " + ex.Message, ToString());
			}
		}
		/// <summary>
		/// When
		/// overridden in a derived class, writes a message to the listener you create in the derived class,
		/// followed by a line terminator.
		/// </summary>
		/// <param name="message">A message to write.</param>
		public override void WriteLine(string message)
		{
			try
			{
				if (_message == null)
					_message = new StringBuilder(255);

			    _message.Append(message);
			    _message.Append("\r");
			}
			catch(Exception ex)
			{
				ErrorLog.LogError("WriteLine(): ERROR: " + ex.Message, ToString());
			}
		}

		/// <summary>
		/// When overridden in a derived class, closes the
		/// output stream so it no longer receives tracing or debugging output.
		/// </summary>
		public override void Close()
		{
			try
			{
                if (_isClosed) return;

				Flush();
				if(_message != null && !string.IsNullOrEmpty(_mailTo))
				{
					var myMail = new MailMessage(From, _mailTo, Subject, _message.ToString());
					var client = new SmtpClient 
                                    {
					                     DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis
					                };
				    client.Send(myMail);
				}
			    _isClosed = true;
			}
			catch(Exception ex)
			{
				ErrorLog.LogError("Close(): ERROR: " + ex.Message, ToString());
			}
		}

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.Diagnostics.TraceListener"/> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            Close();
        }
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/FnsUtility/EmailTraceListener.cs $
 * 
 * 6     3/01/11 8:52a Gwynnj
 * EmailTraceListener will not try to send if there's nobody defined
 * (MERCURY) to send to.
 * 
 * 5     3/30/10 2:27p Gwynnj
 * Added default Encrypt Decrypt methods using the CallData key
 * 
 * 4     3/23/10 7:19p Gwynnj
 * Added GeneralUtility.GetConstructor<T>() where T is Class and has
 * default public constructor.  Also called Close from Dispose on
 * EmailTraceListener to ensure using semantics does a proper flush.
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
 * 2     10/10/06 11:02a John.gwynn
 * EmailTraceListener integrated with MailManager to use MERCURY
 * destinations.  Modified RegistryKey in GeneralUtility to use Dispose
 * pattern (using).  Added MailManager functionality.  Old MailManager
 * project is now OBSOLETE.
 * 
 * 1     6/24/06 6:36p John.gwynn
 * Added EmailTraceListener
 */
#endregion