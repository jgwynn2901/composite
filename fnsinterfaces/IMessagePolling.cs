#region Header
/**************************************************************************
* First Notice Systems
* 529 Main Street
* Boston, MA 02129
* (617) 886 2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/VS.NET2005/FnsInterfaces/IMessagePolling.cs 1     5/29/07 3:06p John.gwynn $ */
#endregion

namespace FnsInterfaces
{
	/// <summary>
	/// Summary description for IMessagePolling.
	/// </summary>
	public interface IMessagePolling
	{
		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>The URL.</value>
		string Url
		{
			get; set;
		}
		/// <summary>
		/// Gets the next message.
		/// </summary>
		/// <returns></returns>
		string GetNextMessage();
		/// <summary>
		/// Peeks at the next message.
		/// </summary>
		/// <returns></returns>
		string Peek();
		
	}
}
#region History
/*
 * $History: IMessagePolling.cs $
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 5/29/07    Time: 3:06p
 * Created in $/SourceCode/Components/VS.NET2005/FnsInterfaces
 * new 2.0 buiild
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 1/25/07    Time: 2:02p
 * Created in $/SourceCode/Components/VS.NET/FnsInterfaces
 * added messagePolling interface
 */
#endregion
