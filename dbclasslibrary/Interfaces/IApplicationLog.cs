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
/* $Header: /SourceCode/Components/VS.NET2005/DbClassLibrary/Interfaces/IApplicationLog.cs 1     4/19/07 4:36p John.gwynn $ */
#endregion

using System.Runtime.InteropServices;

namespace DbClassLibrary.Interfaces
{
	[Guid("B9791A93-1654-4f28-A247-B2ABB52B48AC")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	interface IApplicationLog
	{
		string Component {set; }
		string Server { set; }
		int Severity { set; }
		string ErrorString { set; }
		bool Execute();
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/VS.NET2005/DbClassLibrary/Interfaces/IApplicationLog.cs $
 * 
 * 1     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 */
#endregion