using System;
using System.IO;

namespace DbClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ResourceReader
	{

		/// <summary>
		/// Reads the file resource.
		/// </summary>
		/// <param name="assemblyName">Name of the assembly.</param>
		/// <param name="resourceName">Name of the file resource.</param>
		/// <returns></returns>
		public static string ReadFileResource(string assemblyName, string resourceName)
		{
			var stream = GetEmbeddedFile(assemblyName, resourceName);
			if (stream != null)
			{
				using (var reader = new StreamReader(stream))
					return reader.ReadToEnd();

			}
			return "";
		}
		/// <summary>
		/// Extracts an embedded file out of a given assembly.
		/// </summary>
		private static Stream GetEmbeddedFile(string assemblyName, string fileName)
		{
			try
			{
				var a = System.Reflection.Assembly.Load(assemblyName);
				var str = a.GetManifestResourceStream(fileName);

				if (str == null)
					throw new Exception("Could not locate embedded resource '" + fileName + "' in assembly '" + assemblyName + "'");
				return str;
			}
			catch (Exception e)
			{
				throw new Exception(assemblyName + ": " + e.Message);
			}
		}
	}
}
