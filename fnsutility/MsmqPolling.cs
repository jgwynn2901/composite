using System;
using FnsInterfaces;

namespace FnsUtility
{
	/// <summary>
	/// Summary description for MsmqPolling.
	/// </summary>
	public class MsmqPolling :IMessagePolling
	{
		private string _url;
		//private int _timeOutSeconds;

		/// <summary>
		/// Initializes a new instance of the <see cref="MsmqPolling"/> class.
		/// </summary>
		/// <param name="queue">The queue.</param>
		public MsmqPolling(string queue)
		{
			_url = queue;
			//_timeOutSeconds = 0;
		}

		/// <summary>
		/// Gets the next message.
		/// </summary>
		/// <returns></returns>
		public string GetNextMessage()
		{
			string results = String.Empty;
			try
			{
				Assert.Test(_url.Length > 0, "empty queue name");
				results = MessageQueue.GetNextMessage(_url);
			}
			catch (Exception ex)
			{
				ErrorLog.LogError("GetNextMessage: " + ex.Message, ToString());
			}
			return results;
		}

		/// <summary>
		/// Peeks this instance.
		/// </summary>
		/// <returns></returns>
		public string Peek()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>The URL.</value>
		public string Url
		{
			get { return _url; }
			set { _url = value; }
		}
	}
}
