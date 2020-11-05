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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/TableDefinition.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Retrieves the schema for a given tableName
	/// Usage: set TableName and Execute
	/// Notes: Class supports IEnumerable 
	/// </summary>
	[ComVisible(false)]	
	public class TableDefinition : DbAggregate
	{
		/// <summary>
		/// parameter definitions
		/// </summary>
		private enum eParmList
		{
			/// <summary>
			/// Name of Package
			/// </summary>
			TableName = 0,
			/// <summary>
			/// ResultSet
			/// </summary>
			Results
		};
		/// <summary>
		/// Enumerates the resultset columns
		/// </summary>
		private enum eResultList
		{
			/// <summary>
			/// COLUMN_ID
			/// </summary>
			ColumnId = 0,
			/// <summary>
			/// COLUMN_NAME
			/// </summary>
			ColumnName,
			/// <summary>
			/// DATA_TYPE
			/// </summary>
			DataType,
			/// <summary>
			/// DATA_LENGTH
			/// </summary>
			DataLength,
			/// <summary>
			/// DATA_PRECISION
			/// </summary>
			DataPrecision,
			/// <summary>
			/// DATA_SCALE
			/// </summary>
			DataScale,
			/// <summary>
			/// NULLABLE
			/// </summary>
			Nullable,
			/// <summary>
			/// DATA_DEFAULT
			/// </summary>
			DataDefault
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="TableDefinition"/> class.
		/// </summary>
		public TableDefinition() :this(String.Empty) {}	
		/// <summary>
		/// Initializes a new instance of the <see cref="TableDefinition"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public TableDefinition(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetTableDefinition";

			_parameterNames = new string[]
				{
					"p_tableName",
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
			///// p_tableName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.TableName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// results
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.Results],"",System.Data.DbType.Object);
		}
		#endregion
		#region TableName
		/// <summary>
		/// Gets or sets the name of the table.
		/// </summary>
		/// <value>The name of the table.</value>
		public string TableName
		{
			get 
			{
				return GetValue((int)eParmList.TableName);
			}
			set 
			{
				SetValue((int)eParmList.TableName,value);
			}
		}
		#endregion
		#region ColumnId
		/// <summary>
		/// Gets the column id.
		/// </summary>
		/// <value>The column id.</value>
		public string ColumnId
		{
			get 
			{
				return GetColumnValue((int)eResultList.ColumnId);
			}
		}
		#endregion
		#region ColumnName
		/// <summary>
		/// Gets the name of the column.
		/// </summary>
		/// <value>The name of the column.</value>
		public string ColumnName
		{
			get 
			{
				return GetColumnValue((int)eResultList.ColumnName);
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
		#region DataLength
		/// <summary>
		/// Gets the length of the data.
		/// </summary>
		/// <value>The length of the data.</value>
		public string DataLength
		{
			get 
			{
				return GetColumnValue((int)eResultList.DataLength);
			}
		}
		#endregion
		#region DataPrecision
		/// <summary>
		/// Gets the data precision.
		/// </summary>
		/// <value>The data precision.</value>
		public string DataPrecision
		{
			get 
			{
				return GetColumnValue((int)eResultList.DataPrecision);
			}
		}
		#endregion
		#region DataScale
		/// <summary>
		/// Gets the data scale.
		/// </summary>
		/// <value>The data scale.</value>
		public string DataScale
		{
			get 
			{
				return GetColumnValue((int)eResultList.DataScale);
			}
		}
		#endregion
		#region Nullable
		/// <summary>
		/// Gets the nullable.
		/// </summary>
		/// <value>The nullable.</value>
		public string Nullable
		{
			get 
			{
				return GetColumnValue((int)eResultList.Nullable);
			}
		}
		#endregion
		#region DataDefault
		/// <summary>
		/// Gets the data default.
		/// </summary>
		/// <value>The data default.</value>
		public string DataDefault
		{
			get 
			{
				return GetColumnValue((int)eResultList.DataDefault);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/TableDefinition.cs $
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
 * 2     3/12/07 6:21p John.gwynn
 * added support for ProcedureDefinition stored procedure schema aggregate
 * 
 * 1     3/07/07 7:16p John.gwynn
 * added aggregate subclass to implement IEnumerable for result sets.
 * Table definition procedure wrapper is first class implemented in terms
 * of the new aggregate base and will be used for code generation tools.
 */
#endregion
