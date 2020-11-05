using System.Collections.Generic;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// centralizes paremeterized SQL interface 
	/// </summary>
	[Guid("74B746BC-10B9-4a48-B20A-0066F15434FD")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ISqlParameterReader
	{
		/// <summary>
		/// Adds a parameter if using parameterized SQL 
		/// using the default idiom of :1, :2 ... :n
		/// </summary>
		/// <param name="parm">The parm.</param>
		/// <returns></returns>
		void AddParameter(object parm);

		/// <summary>
		/// Adds a named parameter to the parameters collection.
		/// </summary>
		void AddParameter(string name, object parm);

		/// <summary>
		/// Gets the parameters collection.
		/// </summary>
		/// <value>The lazy parameters.</value>
		[ComVisible(false)]
		Dictionary<string, object> LazyParameters { get; }

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="db">The database (connection).</param>
		/// <param name="query">The SQL query.</param>
		/// <returns></returns>
		[ComVisible(false)]
		IDataReader ExecuteReader(Database db, string query);

		/// <summary>
		/// Executes the SQL command.
		/// </summary>
		/// <param name="db">The database.</param>
		/// <param name="command">The SQL command.</param>
		/// <returns>The number of rows affected by the command.</returns>
		[ComVisible(false)]
		int ExecuteNonQuery(Database db, string command);

		/// <summary>
		/// Resets the parameters.
		/// </summary>
		void ResetParameters();
	}
}
