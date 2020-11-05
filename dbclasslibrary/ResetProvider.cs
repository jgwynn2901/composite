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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ResetProvider.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion


using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for ResetProvider.
	/// </summary>
	[ComVisible(false)]
	public class ResetProvider : DbBaseClass
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ResetProvider"/> class.
		/// </summary>
		public ResetProvider() :this(String.Empty)
		{}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="ResetProvider"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public ResetProvider(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.UnlockProvider";
			Initialize();
		}
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			///// p_providerID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_providerID","",System.Data.DbType.Int32 );
			///////////////////////////////////////////////////
			///// p_uID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_uID","",System.Data.DbType.AnsiString );			
		}
		/// <summary>
		/// Gets the provider id.
		/// </summary>
		/// <value>The provider id.</value>
		public string ProviderId
		{
			get
			{
				return GetValue("p_providerID");	
			}
		}
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		/// <value>The id.</value>
		public string Id
		{
			get
			{
				return GetValue("p_uID");
			}
			set
			{
				SetValue("p_uID", value);
			}
		}
	}
}
#region History
/*
 * $History: ResetProvider.cs $
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
 * *****************  Version 4  *****************
 * User: John.gwynn   Date: 11/09/06   Time: 11:08a
 * Updated in $/SourceCode/Components/VS.NET/DbClassLibrary
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * *****************  Version 3  *****************
 * User: Deepika.sharma Date: 10/24/06   Time: 6:53p
 * Updated in $/SourceCode/Components/VS.NET/DbClassLibrary
 * MID-935 : Need to update resetprovider class for provider_followup
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
