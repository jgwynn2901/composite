namespace FnsInterfaces
{
	/// <summary>
	/// Defines the common pattern Name Value 
	/// for manipulations i.e. Sort, 
	/// transformations and enumerations.
	/// </summary>
	public interface INameValuePair
	{
		/// <summary>
		/// This is the Name
		/// </summary>
		string Name { get; }

		/// <summary>
		/// this is the Value.
		/// </summary>
		string Value { get; }
	}
}
