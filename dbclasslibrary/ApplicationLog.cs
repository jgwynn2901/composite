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
/* $Header: /SourceCode/Components/VS.NET2005/DbClassLibrary/ApplicationLog.cs 3     4/19/07 4:36p John.gwynn $ */

#endregion

using System;
using System.Runtime.InteropServices;
using DbClassLibrary.Interfaces;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for APPLICATION_LOG table.
	/// </summary>
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("4475150A-0BE1-428f-B56D-BF4FD1809E6E")]
	public sealed class ApplicationLog : DbBaseClass, IApplicationLog
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApplicationLog"/> class.
		/// </summary>
		public ApplicationLog():this(String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="ApplicationLog"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public ApplicationLog(string instance) :base(instance)
		{
			_name = "FNSUtilsPAK.InsertApplicationLog";
			Initialize();
		}
		#region Parameters
		/// <summary>
		/// Set up parameter definitions here
		/// </summary>
		/// <remarks>
		/// the definitions can be defined externally (configuration) 
		/// and iterated here for maximum flexibility
		/// </remarks>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////p_nAppLogID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_nAppLogID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_Component
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_Component","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nServer
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nServer","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			/////p_nSeverity
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nSeverity","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nErrorString
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nErrorString","",System.Data.DbType.AnsiString);
		}
		#endregion
		#region ApplicationLogID
		/// <summary>
		/// ApplicationLogID property
		/// </summary>
		public int ApplicationLogID 
		{
			get 
			{
				return Convert.ToInt32(GetValue("p_nAppLogID"));
			}
		}
		#endregion
		#region Component
		/// <summary>
		/// Component property
		/// </summary>
		public string Component 
		{
			get 
			{
				return GetValue("p_Component");
			}
			set 
			{
				SetValue("p_Component",value);
			}
		}
		#endregion
		#region Server
		/// <summary>
		/// Server property
		/// </summary>
		public string Server 
		{
			get 
			{
				return GetValue("p_nServer");
			}
			set 
			{
				SetValue("p_nServer",value);
			}
		}
		#endregion
		#region Severity
		/// <summary>
		/// Severity property
		/// </summary>
		public int Severity 
		{
			get 
			{
				return Convert.ToInt32(GetValue("p_nSeverity"));
			}
			set 
			{
				SetValue("p_nSeverity",value.ToString());
			}
		}
		#endregion
		#region ErrorString
		/// <summary>
		/// ErrorString property
		/// </summary>
		public string ErrorString 
		{
			get 
			{
				return GetValue("p_nErrorString");
			}
			set 
			{
				SetValue("p_nErrorString",value);
			}
		}
		#endregion
	}
}
#region History
/*
 * $History: ApplicationLog.cs $
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
 * *****************  Version 5  *****************
 * User: John.gwynn   Date: 11/15/06   Time: 5:32p
 * Updated in $/SourceCode/Components/VS.NET/DbClassLibrary
 * Added or updated comments for NDoc documentation
 * 
 * *****************  Version 4  *****************
 * User: John.gwynn   Date: 11/09/06   Time: 11:08a
 * Updated in $/SourceCode/Components/VS.NET/DbClassLibrary
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * *****************  Version 3  *****************
 * User: John.gwynn   Date: 5/08/06    Time: 6:46p
 * Updated in $/SourceCode/Components/VS.NET/DbClassLibrary
 * Formatting updates and support for SENP and CRAWP utilities
 */
#endregion
