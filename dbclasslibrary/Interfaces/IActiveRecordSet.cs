#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Interfaces/IActiveRecordSet.cs 11    9/25/09 2:37p John.gwynn $ */
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DbClassLibrary.Interfaces
{
	/// <summary>
	/// COM interface for ActiveRecordSet
	/// </summary>
	[Guid("0F0B5419-FC22-4983-9161-7D71F07804C3")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IActiveRecordSet : ISqlParameterReader
	{
		/// <summary>
		/// Gets or sets the instance.
		/// </summary>
		/// <value>The instance.</value>
		string Instance { get; set; }

		/// <summary>
		/// Gets or sets the query.
		/// </summary>
		/// <value>The query.</value>
		string Query { get; set; }

		/// <summary>
		/// Gets the last error.
		/// </summary>
		/// <value>The last error.</value>
		string LastError { get;}

		/// <summary>
		/// Executes this instance.
		/// </summary>
		/// <returns></returns>
		bool Execute();

		/// <summary>
		/// return results as array for interop
		/// </summary>
		/// <returns></returns>
		[ComVisible(false)]
		ArrayList ToArray();

		/// <summary>
		/// creates a typesafe cloned list
		/// </summary>
		/// <returns></returns>
		[ComVisible(false)]
		List<IActiveRecord> ToList();

	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Interfaces/IActiveRecordSet.cs $
 * 
 * 11    9/25/09 2:37p John.gwynn
 * Added ActiveRecordSet<T> to achieve covariance with respect to the
 * IEnumerable<ActiveRecord> base implementation for articulating strongly
 * typed repositories.
 * 
 * 10    6/05/09 7:28p John.gwynn
 * added CallData with ActiveRecord support for LONG RAW (only call_data
 * parameter at this point)
 * 
 * 9     6/03/09 4:59p John.gwynn
 * 
 * 8     5/26/09 7:03p John.gwynn
 * Added deep cloning and ToArray, ToList support (ToArray is for interop
 * ToList is because we have no LINQ today)
 * 
 * 7     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 6     4/23/09 3:24p John.gwynn
 * added support for named parameters.  refactored SQL processing to
 * SqlParameterReader class 
 * 
 * 5     4/01/09 7:28p John.gwynn
 * added parameterized SQL to ActiveRecord and beefed up User class for
 * use in VbSecurity
 * 
 * 4     2/18/09 6:37p John.gwynn
 * added callflow frames
 * 
 * 3     7/10/07 4:54p John.gwynn
 * added Interfaces folder, and interfaces for outcome and outcome step.
 * Added support for Insert and Update of active records and
 * GetNextSequence() method to retrieve a primary key prior to insert
 * 
 * 2     4/23/07 6:23p John.gwynn
 * Added interop wrapper classes (work in progress)
 * 
 * 1     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 */
#endregion