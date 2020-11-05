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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SentryLastLocation.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary 
{
	/// <summary>
	/// Summary description for SentryLastLocation.
	/// </summary>
	[ComVisible(false)]	
	public class SentryLastLocation :DbBaseClass
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SentryLastLocation"/> class.
		/// </summary>
		public SentryLastLocation():this("SENP") // SENTRY only
		{	}
		/// <summary>
		/// Initializes a new instance of the <see cref="SentryLastLocation"/> class.
		/// </summary>
		/// <param name="instance">The database instance.</param>
		public SentryLastLocation(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.SetOrGetSentryLastLocation";

			Initialize();
		}
		#region Parameters
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////inputLogId
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				"inputLogId","",DbType.Int32);
			///////////////////////////////////////////////////
			/////outputLogId
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Output,
				"outputLogId","",DbType.Int32);
		}
		#endregion
		#region Public Properties
		/// <summary>
		/// Gets the output log id.
		/// </summary>
		/// <value>The output log id.</value>
		public string OutputLogId 
		{
			get 
			{
				return GetValue("outputLogId");
			}
		}
		/// <summary>
		/// Gets or sets the input log id.
		/// </summary>
		/// <value>The input log id.</value>
		public string InputLogId 
		{
			get 
			{
				return GetValue("inputLogId");
			}
			set
			{
				SetValue("inputLogId",value);
			}
		}
		#endregion
	}
}
#region History
/*
 * $History: SentryLastLocation.cs $
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
 * User: John.gwynn   Date: 11/09/06   Time: 11:08a
 * Updated in $/SourceCode/Components/VS.NET/DbClassLibrary
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 5/08/06    Time: 6:46p
 * Created in $/SourceCode/Components/VS.NET/DbClassLibrary
 * Formatting updates and support for SENP and CRAWP utilities
 */
#endregion