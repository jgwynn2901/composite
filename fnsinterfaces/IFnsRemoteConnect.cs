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
/* $Header: /SourceCode/Components/FNS2005/FnsInterfaces/IFnsRemoteConnect.cs 6     12/08/09 1:31p John.gwynn $ */
#endregion

namespace FnsInterfaces
{
	using System.ServiceModel;
	/// <summary>
	/// Summary description for FnsRemoteConnect.
	/// </summary>
	[ServiceContract]
	public interface IFnsRemoteConnect
	{
		/// <summary>
		/// Executes the method.
		/// </summary>
		[OperationContract]
		string ExecuteMethod(string method, string parms);
	}
}


#region History
/*
 * $History: IFnsRemoteConnect.cs $
 * 
 * *****************  Version 6  *****************
 * User: John.gwynn   Date: 12/08/09   Time: 1:31p
 * Updated in $/SourceCode/Components/FNS2005/FnsInterfaces
 * New version to distinguish it from either predecessors
 * 
 * *****************  Version 5  *****************
 * User: John.gwynn   Date: 11/18/09   Time: 6:08p
 * Updated in $/SourceCode/Components/FNS2005/FnsInterfaces
 * added ClaimCapture compiler flag for different builds
 * 
 * *****************  Version 4  *****************
 * User: John.gwynn   Date: 6/27/09    Time: 1:29p
 * Updated in $/SourceCode/Components/FNS2005/FnsInterfaces
 * warning for ClaimCapture definition
 * 
 * *****************  Version 3  *****************
 * User: John.gwynn   Date: 6/27/09    Time: 10:27a
 * Updated in $/SourceCode/Components/FNS2005/FnsInterfaces
 * Added ClaimCapture preprocessing for Win2k builds
 * 
 * *****************  Version 2  *****************
 * User: John.gwynn   Date: 12/06/07   Time: 4:05p
 * Updated in $/SourceCode/Components/FNS2005/FnsInterfaces
 * added Service contract and reference to 3.0 ServiceModel  -NB Must have
 * framework 3.0 to compile
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 5/29/07    Time: 3:06p
 * Created in $/SourceCode/Components/VS.NET2005/FnsInterfaces
 * new 2.0 buiild
 * 
 * *****************  Version 2  *****************
 * User: John.gwynn   Date: 9/26/06    Time: 12:53p
 * Updated in $/SourceCode/Components/VS.NET/FnsInterfaces
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 6/16/06    Time: 9:51p
 * Created in $/SourceCode/Components/VS.NET/FnsInterfaces
 */
#endregion
