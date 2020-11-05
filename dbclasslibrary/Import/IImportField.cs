namespace DbClassLibrary.Import
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public interface IImportField
	{
		/// <summary>
		/// Gets the filed name (which could be a composite in some cases.)
		/// </summary>
		string FullName { get; }

		/// <summary>
		/// Gets the value if set.
		/// </summary>
		string Value { get; }

		/// <summary>
		/// Gets the corresponding field index or start position.
		/// </summary>
		int Index { get; }
	}
}
