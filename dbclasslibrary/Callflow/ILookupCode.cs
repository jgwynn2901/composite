using DbClassLibrary.Interfaces;
namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// represents a dto record from the LU_CODE table
	/// </summary>
	public interface ILookupCode : IActiveRecord
	{
		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		/// <value>The lookup code.</value>
		string Code { get; set; }

		/// <summary>
		/// Gets or sets the lookup value.
		/// </summary>
		/// <value>The lookup value.</value>
		string LookupValue { get; set; }

		/// <summary>
		/// Gets or sets the sequence.
		/// </summary>
		/// <value>The sequence.</value>
		int  Sequence { get; set; }
	}
}
