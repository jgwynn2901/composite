using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace FnsUtility
{
	public class WebApiRequest
	{
		private string Url { get; set; }

		public WebApiRequest()
			: this(string.Format("http://{0}/ClaimCaptureService", GeneralUtility.GetMachineRedirect()))
		{ }

		public WebApiRequest(string uri)
		{
			Url = uri;
		}

		public string ExecuteRequest(string method, string endpoint, string callXml, bool isXml)
		{
			var results = string.Empty;
			var prepared = callXml;

			Assert.IsNotEmpty(Url, "WebApiRequest.ExecuteRequest called with empty Url");
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(Url + endpoint));
			if (isXml)
			{
				request.ContentType = "application/xml; charset=utf-8";
				//prepared = string.Format("\"{0}\"", callXml);
			}
			else
			{
				request.ContentType = "application/json; charset=utf-8";
			}
			request.Method = method;

			if (!string.IsNullOrEmpty(callXml))
			{
				byte[] bytes = Encoding.UTF8.GetBytes(prepared);
				using (Stream stream = request.GetRequestStream())
				{
					stream.Write(bytes, 0, bytes.Length);
					stream.Close();
				}
			}
			using (HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse())
			{
				using (Stream stream = httpResponse.GetResponseStream())
				{
					results = (new StreamReader(stream)).ReadToEnd();
				}
			}
			return results;
		}
	}
}
