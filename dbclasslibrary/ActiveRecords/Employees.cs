using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{
	/// <summary>
	/// 
	/// </summary>
	[ComVisible(false)]
	public class Employees : ActiveRecordSet<Employee>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Employees"/> class.
		/// </summary>
		public Employees()
			: base("Employee")
		{}
	}
}
