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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Interfaces/IUnitOfWork.cs 2     5/26/09 11:07a John.gwynn $ */
#endregion
using System.Runtime.InteropServices;
namespace DbClassLibrary.Interfaces
{
	/// <summary>
	/// Defines the public contract for Unit of Work
	/// All containing members must implelment the IEntityObject interface
	/// starting very basic adding only what is required...
	/// </summary>
	[ComVisible(false)]
	public interface IUnitOfWork
	{
		/// <summary>
		/// Gets the last error.
		/// </summary>
		/// <value>The last error.</value>
		string LastError { get;}

		/// <summary>
		/// Commits this instance.
		/// </summary>
		/// <returns></returns>
		bool Commit();
		/// <summary>
		/// Rollbacks this instance.
		/// </summary>
		/// <returns></returns>
		bool Rollback();
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Interfaces/IUnitOfWork.cs $
 * 
 * 2     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 1     7/10/07 4:54p John.gwynn
 * added Interfaces folder, and interfaces for outcome and outcome step.
 * Added support for Insert and Update of active records and
 * GetNextSequence() method to retrieve a primary key prior to insert
 */
#endregion