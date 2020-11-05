#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 1993-2005 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ProviderFollowup.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion
using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates stored procedure to update PROVIDER_FOLLOWUP table 
	/// </summary>
	[ComVisible(false)]	
	public sealed class ProviderFollowup : Provider
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="Provider"/> class.
		/// </summary>
		public ProviderFollowup() :this(String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="Provider"/> class.
		/// </summary>
		/// <param name="strInstance">The STR instance.</param>
		public ProviderFollowup(string strInstance)
		{
			_name = "DBCLASSLIBRARY.UpdateProviderFollowupStatus";
			if(strInstance.Length > 0)
			{
				_databaseInstance = strInstance;
			}
			//Initialize();
		}
		#endregion
		#region ProviderFollowupId
		/// <summary>
		/// Gets the provider followup id.
		/// </summary>
		/// <value>The provider followup id.</value>
		public string ProviderFollowupId
		{
			get
			{
				return GetValue("p_providerID");	
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ProviderFollowup.cs $
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 2     11/15/06 5:33p John.gwynn
 * Added or updated comments for NDoc documentation
 */
#endregion