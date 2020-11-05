using System.Collections.Generic;

namespace DbClassLibrary.Security
{
	/// <summary>
	/// encapsulate access rights lookup
	/// TODO: This is a group by collection perhaps we can 
	/// make it generic as it is a useful pattern.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class AccessListManager : Dictionary<string, List<string>>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AccessListManager"/> class.
		/// </summary>
		/// <param name="data">The data.</param>
		public AccessListManager(string data)
		{
			if (!string.IsNullOrEmpty(data))
				ParseData(data);
		}

		/// <summary>
		/// Checks if the access type for the given function exists in the collection.
		/// </summary>
		/// <param name="function">The function.</param>
		/// <param name="accessType">Type of access.</param>
		/// <returns></returns>
		public bool CheckAccessType(string function, string accessType)
		{
			return ContainsKey(function) && this[function].Contains(accessType);
		}


		private void ParseData(string data)
		{
			var elements = data.Split(new[] { ';' });
			foreach (var element in elements)
			{
			    if (string.IsNullOrEmpty(element)) continue;
			    var fields = element.Split(new[] { '~' });
			    if (fields.Length == 2)
			        AddAccess(fields[0], fields[1]);
			}
		}

		private void AddAccess(string function, string accessType)
		{
			if (ContainsKey(function))
				this[function].Add(accessType);
			else
			{
				var list = new List<string> {accessType};
			    Add(function, list);
			}
		}
	}
}
