using System.Runtime.InteropServices;
namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	[InterfaceType(ComInterfaceType.InterfaceIsDual),
	Guid(@"368AE9AD-66B2-4aac-BDE8-B2C65AF33F06")]
	public interface ICallData
	{
		/// <summary>
		/// Gets or sets the call id.
		/// </summary>
		/// <value>The call id.</value>
		int CallId { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
		[ComVisible(false)]
		byte[] Data { get; set; }

		/// <summary>
		/// Saves the specified length.
		/// </summary>
		/// <param name="length">The length.</param>
		/// <param name="buffer">The buffer.</param>
		/// <returns></returns>
		bool Save(int length, byte[] buffer);

		
		/// <summary>
		/// Loads the specified results.
		/// </summary>
		bool Load(out byte[] results);
 
	}
}
