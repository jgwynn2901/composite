#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2006 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/CsaaDriver.cs 5     5/26/09 11:05a John.gwynn $ */
#endregion

using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD for DRIVER table with ENCRYPTION.
	/// </summary>
	[ComVisible(false)]	
	public sealed class CsaaDriver :Driver
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="CsaaDriver"/> class.
		/// </summary>
		public CsaaDriver()
			: this(DbBaseClass.FNSP)
		{
		}
		/// <summary>
		/// user can name db instance
		/// </summary>
		/// <param name="instance"></param>
		public CsaaDriver(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessDriver";
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/CsaaDriver.cs $
 * 
 * 5     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 4     4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 1     11/29/06 3:39p John.gwynn
 * Encapsulates specific encrypted DRIVER attributes (for CSAA)
 */
#endregion