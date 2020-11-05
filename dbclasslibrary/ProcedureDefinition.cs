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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ProcedureDefinition.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion
using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// retrieves schema definitions for Oracle stored procedures
	/// Usage: set PackageName, ProcedureName and Execute
	/// Notes: Class supports IEnumerable 
	/// </summary>
	[ComVisible(false)]	
	public class ProcedureDefinition : DbAggregate
	{
		/// <summary>
		/// parameter definitions
		/// </summary>
		private enum eParmList
		{
			/// <summary>
			/// Name of Package
			/// </summary>
			PackageName = 0,
			/// <summary>
			/// Name of the Procedure/Function
			/// </summary>
			ProcedureName,
			/// <summary>
			/// ResultSet
			/// </summary>
			Results
		};
		/// <summary>
		/// Resultset definitions
		/// </summary>
		private enum eResultList
		{
			/// <summary>
			/// POSITION
			/// </summary>
			Position = 0,
			/// <summary>
			/// ARGUMENT_NAME
			/// </summary>
			ArgumentName,
			/// <summary>
			/// DATA_TYPE
			/// </summary>
			DataType,
			/// <summary>
			/// IN_OUT
			/// </summary>
			InOut
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="TableDefinition"/> class.
		/// </summary>
		public ProcedureDefinition() :this(String.Empty) {}	
		/// <summary>
		/// Initializes a new instance of the <see cref="TableDefinition"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public ProcedureDefinition(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetProcedureDefinition";

			_parameterNames = new string[]
							{
								"p_packageName",
								"p_procedureName",
								"results" 
			};
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			///// p_packageName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.PackageName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_procedureName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.ProcedureName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// results
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.Results],"",System.Data.DbType.Object);
		}
		#endregion
		#region PackageName
			/// <summary>
			/// Gets or sets the name of the package.
			/// </summary>
			/// <value>The name of the package.</value>
			public string PackageName
		{
			get 
			{
				return GetValue((int)eParmList.PackageName);
			}
			set 
			{
				SetValue((int)eParmList.PackageName,value);
			}
		}
		#endregion
		#region ProcedureName
		/// <summary>
		/// Gets or sets the name of the procedure.
		/// </summary>
		/// <value>The name of the procedure.</value>
		public string ProcedureName
		{
			get 
			{
				return GetValue((int)eParmList.ProcedureName);
			}
			set 
			{
				SetValue((int)eParmList.ProcedureName,value);
			}
		}
		#endregion
		#region Position
		/// <summary>
		/// Gets the position.
		/// </summary>
		/// <value>The position.</value>
		public string Position
		{
			get 
			{
				return GetColumnValue((int)eResultList.Position);
			}
		}
		#endregion
		#region ArgumentName
		/// <summary>
		/// Gets the name of the argument.
		/// </summary>
		/// <value>The name of the argument.</value>
		public string ArgumentName
		{
			get 
			{
				return GetColumnValue((int)eResultList.ArgumentName);
			}
		}
		#endregion
		#region DataType
		/// <summary>
		/// Gets the type of the data.
		/// </summary>
		/// <value>The type of the data.</value>
		public string DataType
		{
			get 
			{
				return GetColumnValue((int)eResultList.DataType);
			}
		}
		#endregion
		#region InOut
		/// <summary>
		/// Gets the in out.
		/// </summary>
		/// <value>The in out.</value>
		public string InOut
		{
			get 
			{
				return GetColumnValue((int)eResultList.InOut);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ProcedureDefinition.cs $
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
 * 1     3/12/07 6:21p John.gwynn
 * added support for ProcedureDefinition stored procedure schema aggregate
 */
#endregion