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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/FileTranLogDef.cs 5     9/25/09 5:19p John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates select stored procedure for FILE_TRANSMISSION_DEF table.
	/// </summary>
	[ComVisible(false)]	
	public class FileTranLogDef :DbBaseClass
	{
		private enum ParmList 
		{
			AhsId = 0,
			Server,
			Type,
			Results
		};
		/// <summary>
		/// enumerates the REF CURSOR result set Columns
		/// </summary>
		public enum ResultList
		{
			/// <summary>
			/// FILE_TRANSMISSION_DEF_ID
			/// </summary>
			FileTranLogDefId = 0,
			/// <summary>
			/// DIRECTORY
			/// </summary>
			Directory,
			/// <summary>
			/// LAST_LOAD_SEQUENCE
			/// </summary>
			LastLoadSequence,
			/// <summary>
			/// FILE_NAME_PATTERN
			/// </summary>
			FileNamePattern,
			/// <summary>
			/// LOCATION_IDENTIFIER
			/// </summary>
			LocationIdentifier,
			/// <summary>
			/// DESCRIPTION
			/// </summary>
			Description,
			/// <summary>
			/// SEQUENCE
			/// </summary>
			Sequence,
			/// <summary>
			/// SOURCE_LOCATION
			/// </summary>
			SourceLocation,
			/// <summary>
			/// DESTINATION_UIF_LOCATION
			/// </summary>
			Destination,

			/// <summary>
			/// FROI_IMP_RECORD_ID
			/// </summary>
			ImportRecordTypeId
		};
			
				
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="FileTranLogDef"/> class.
		/// </summary>
		public FileTranLogDef():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="FileTranLogDef"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public FileTranLogDef(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetFileTranDefSet";

			_parameterNames = new[] {
																			 "p_accntHrcyStepId",
																			 "p_Server",
																			 "p_Type",
																			 "results" };
			Initialize();
		}
		#endregion
		
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override sealed void Initialize()
		{
			///////////////////////////////////////////////////
			/////p_accntHrcyStepId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.AhsId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_Server
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.Server],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_Type
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.Type],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// results
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)ParmList.Results],"",System.Data.DbType.Object);
		}
		#endregion
		
		#region AhsId
		/// <summary>
		/// Gets or sets the accnt_hrcy_step_id.
		/// </summary>
		/// <value>The ahsId.</value>
		public string AhsId
		{
			get 
			{
				return GetValue((int)ParmList.AhsId);
			}
			set 
			{
				SetValue((int)ParmList.AhsId,value);
			}
		}
		#endregion
		#region Server
		/// <summary>
		/// Gets or sets the server.
		/// </summary>
		/// <value>The server.</value>
		public string Server
		{
			get 
			{
				return GetValue((int)ParmList.Server);
			}
			set 
			{
				SetValue((int)ParmList.Server,value);
			}
		}
		#endregion
		#region Type
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string Type
		{
			get 
			{
				return GetValue((int)ParmList.Type);
			}
			set 
			{
				SetValue((int)ParmList.Type,value);
			}
		}
		#endregion
		
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/FileTranLogDef.cs $
 * 
 * 5     9/25/09 5:19p John.gwynn
 * Added FroiImportMapType to FileTranDef
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
 * 4     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 3     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 2     10/12/06 3:05p John.gwynn
 * added enums to aid in resultset navigation
 */
#endregion

