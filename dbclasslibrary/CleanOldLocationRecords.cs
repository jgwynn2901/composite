#region File Header
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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/CleanOldLocationRecords.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for CleanOldLocationRecords.
	/// </summary>
	[ComVisible(false)]	
	public sealed class CleanOldLocationRecords :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="CleanOldLocationRecords"/> class.
		/// </summary>
		public CleanOldLocationRecords():this("SENP") // SENTRY only
		{	}
		/// <summary>
		/// Initializes a new instance of the <see cref="CleanOldLocationRecords"/> class.
		/// </summary>
		/// <param name="instance">The database instance.</param>
		public CleanOldLocationRecords(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.CleanOldLocationRecords";

			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance parameters.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////recordCount
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"recordCount","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////lastUsedLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"lastUsedLogId","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// fileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"fileTranLogId","",System.Data.DbType.Int32);
		}
		#endregion
		#region Public Properties
		/// <summary>
		/// Gets the record count.
		/// </summary>
		/// <value>The record count.</value>
		public string RecordCount 
		{
			get 
			{
				return GetValue("recordCount");
			}
		}
		/// <summary>
		/// Gets the last used log id.
		/// </summary>
		/// <value>The last used log id.</value>
		public string LastUsedLogId 
		{
			get 
			{
				return GetValue("lastUsedLogId");
			}
		}
		/// <summary>
		/// Gets or sets the file tran log id.
		/// </summary>
		/// <value>The file tran log id.</value>
		public string FileTranLogId 
		{
			get 
			{
				return GetValue("fileTranLogId");
			}
			set 
			{
				SetValue("fileTranLogId",value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/CleanOldLocationRecords.cs $
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
 * 3     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 2     5/08/06 6:46p John.gwynn
 * Formatting updates and support for SENP and CRAWP utilities
 * 
 * 1     4/13/06 1:26p John.gwynn
 * added CleanOldLocationRecords (CRA)
 */
#endregion
