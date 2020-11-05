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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Interfaces/IActiveRecord.cs 11    9/22/09 11:06a John.gwynn $ */
#endregion

using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary.Interfaces
{
	/// <summary>
	/// COM interface for ActiveRecord
	/// </summary>
	[Guid("0B06710D-087E-48da-8E21-725D0E2A31FB")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IActiveRecord
	{
		/// <summary>
		/// Gets or sets the instance.
		/// </summary>
		/// <value>The instance.</value>
		string Instance		{ get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		string Name				{ get; set; }

		/// <summary>
		/// Gets the last error.
		/// </summary>
		/// <value>The last error.</value>
		string LastError	{ get;}

		/// <summary>
		/// Executes this instance.
		/// </summary>
		/// <returns></returns>
		bool Execute();

		/// <summary>
		/// Inserts this instance.
		/// </summary>
		/// <returns></returns>
		bool Insert();

		/// <summary>
		/// Updates this instance.
		/// </summary>
		/// <returns></returns>
		bool Update();

		/// <summary>
		/// Deletes this instance.
		/// </summary>
		/// <returns></returns>
		bool Delete();

		/// <summary>
		/// Executes the specified db.
		/// </summary>
		/// <param name="db">The db.</param>
		/// <returns></returns>
		[ComVisible(false)]
		bool Execute(Database db);

		/// <summary>
		/// Inserts the specified db.
		/// </summary>
		/// <param name="db">The db.</param>
		/// <returns></returns>
		[ComVisible(false)]
		bool Insert(Database db);

		/// <summary>
		/// Updates the specified db.
		/// </summary>
		/// <param name="db">The db.</param>
		/// <returns></returns>
		[ComVisible(false)]
		bool Update(Database db);

		/// <summary>
		/// Resets this instance.
		/// </summary>
		void Reset();

		/// <summary>
		/// Gets the column value.
		/// </summary>
		/// <param name="columnName">Name of the column.</param>
		/// <returns></returns>
		string GetColumnValue(string columnName);

		/// <summary>
		/// Gets the column value as int.
		/// </summary>
		/// <param name="columnName">Name of the column.</param>
		/// <returns></returns>
		int GetColumnValueAsInt(string columnName);

		/// <summary>
		/// Sets the column value.
		/// </summary>
		/// <param name="colName">Name of the col.</param>
		/// <param name="colValue">The col value.</param>
		/// <returns></returns>
		bool SetColumnValue(string colName, string colValue);

		/// <summary>
		/// Sets the primary key value.
		/// </summary>
		/// <param name="colValue">The col value.</param>
		/// <returns></returns>
		bool SetPrimaryKeyValue(string colValue);

    /// <summary>
    /// To the json.
    /// </summary>
    /// <returns></returns>
	  string ToJson();
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Interfaces/IActiveRecord.cs $
 * 
 * 11    9/22/09 11:06a John.gwynn
 * Import Field updates
 * 
 * 10    5/26/09 7:33p John.gwynn
 * Added GetColumnValueAsInt to the IActiveRecord interface
 * 
 * 9     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 8     4/23/09 3:24p John.gwynn
 * added support for named parameters.  refactored SQL processing to
 * SqlParameterReader class 
 * 
 * 7     4/01/09 7:28p John.gwynn
 * added parameterized SQL to ActiveRecord and beefed up User class for
 * use in VbSecurity
 * 
 * 6     7/10/07 7:26p John.gwynn
 * Start of UnitOfWork generic implementation
 * 
 * 5     7/10/07 4:54p John.gwynn
 * added Interfaces folder, and interfaces for outcome and outcome step.
 * Added support for Insert and Update of active records and
 * GetNextSequence() method to retrieve a primary key prior to insert
 * 
 * 4     6/27/07 6:12p John.gwynn
 * Added support for Insert (for OPM)
 * 
 * 3     4/23/07 6:23p John.gwynn
 * Added interop wrapper classes (work in progress)
 * 
 * 2     4/20/07 5:16p John.gwynn
 * 
 * 1     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 */
#endregion