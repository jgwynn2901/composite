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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ResetProviderFollowup.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion


using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for ResetProvider.
	/// </summary>
	[ComVisible(false)]	
	public sealed class ResetProviderFollowup :ResetProvider
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ResetProvider"/> class.
		/// </summary>
		public ResetProviderFollowup() :this(String.Empty)
		{}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="ResetProvider"/> class.
		/// </summary>
		/// <param name="strInstance">The STR instance.</param>
		public ResetProviderFollowup(string strInstance)
		{
			_name = "DBCLASSLIBRARY.UnlockProviderFollowup";
			if(strInstance.Length > 0)
			{
				_databaseInstance = strInstance;
			}
		}
		/// <summary>
		/// Gets the provider id.
		/// </summary>
		/// <value>The provider id.</value>
		public string ProviderFollowupId
		{
			get
			{
				return GetValue("p_providerID");	
			}
		}
	}
}
#region History
/*
 * $History: ResetProviderFollowup.cs $
 * 
 * *****************  Version 4  *****************
 * User: John.gwynn   Date: 5/26/09    Time: 11:05a
 * Updated in $/SourceCode/Components/FNS2005/DbClassLibrary
 * Added interop definitions
 * 
 * *****************  Version 3  *****************
 * User: John.gwynn   Date: 4/19/07    Time: 4:36p
 * Updated in $/SourceCode/Components/VS.NET2005/DbClassLibrary
 * Added COM Interop support and begun work on Callflow data access
 * 
 * *****************  Version 2  *****************
 * User: John.gwynn   Date: 4/17/07    Time: 4:52p
 * Updated in $/SourceCode/Components/VS.NET2005/DbClassLibrary
 * Update from 1.1 version
 * 
 * *****************  Version 2  *****************
 * User: Deepika.sharma Date: 10/24/06   Time: 6:53p
 * Updated in $/SourceCode/Components/VS.NET/DbClassLibrary
 * MID-935 : Need to update resetprovider class for provider_followup
 * 
 * *****************  Version 1  *****************
 * User: Deepika.sharma Date: 9/29/06    Time: 11:23a
 * Created in $/SourceCode/Components/VS.NET/DbClassLibrary
 * dms: adding for BEECH - provider Followup
 * 
 * *****************  Version 2  *****************
 * User: John.gwynn   Date: 7/20/06    Time: 4:44p
 * Updated in $/SourceCode/Components/VS.NET/DbClassLibrary
 * fixed resetProvider to correct SP
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 7/20/06    Time: 3:25p
 * Created in $/SourceCode/Components/VS.NET/DbClassLibrary
 * Beech update for non COMPLETED calls
 */
#endregion
