using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Oracle.DataAccess.Client;
using OracleDatabase = Microsoft.Practices.EnterpriseLibrary.Data.Oracle.OracleDatabase;

namespace DbClassLibrary
{
	/// <summary>
	/// refactored parameterized SQL and Execution code
	/// shared between ActiveRecord and ActiveRecordSet 
	/// classes.
	/// </summary>
	[ComVisible(false)]
	public class SqlParameterReader : ISqlParameterReader
	{
		private const string LongRawColumnParms = "call_data";  
		/// <summary>
		/// parameters collection
		/// </summary>
		private Dictionary<string, object> _lazyParameters;

		#region ISqlParameter Members

		/// <summary>
		/// Adds a parameter if using parameterized SQL.
		/// </summary>
		/// <param name="parm">The parm.</param>
		public void AddParameter(object parm)
		{
			int namedParm = LazyParameters.Count + 1;
			AddParameter(namedParm.ToString(CultureInfo.InvariantCulture), parm);
		}


		/// <summary>
		/// Adds an oracle named parameter.
		/// </summary>
		public void AddParameter(string name, object parm)
		{
			LazyParameters.Add(name, parm);
		}

		/// <summary>
		/// Gets the parameters collection.
		/// </summary>
		[ComVisible(false)]
		public Dictionary<string, object> LazyParameters
		{
			get { return _lazyParameters ?? (_lazyParameters = new Dictionary<string, object>()); }
		}

		/// <summary>
		/// creates and submits (parameterzed) sql to the database returning the reader.
		/// </summary>
		public IDataReader ExecuteReader(Database db, string query)
		{
			var oracleDb = db as OracleDatabase;

			if (oracleDb == null)
				throw new ApplicationException("SqlParameter.ExecuteReader failed to cast connection!");

			var cmd = (OracleCommand)db.GetSqlStringCommand(query);

		  if (_lazyParameters == null) return oracleDb.ExecuteReader(cmd);
		  foreach (var key in _lazyParameters.Keys)
		  {
		    cmd.Parameters.Add(key.IndexOf(LongRawColumnParms, StringComparison.Ordinal) > -1
		      ? CreateLongRawParameter(key, (byte[]) _lazyParameters[key])
		      : new OracleParameter(key, _lazyParameters[key]));
		  }
		  ResetParameters();
		  return oracleDb.ExecuteReader(cmd);
		}

		/// <summary>
		/// Creates the long raw parameter.
		/// </summary>
		static private OracleParameter CreateLongRawParameter(string key, ICollection<byte> buffer)
		{
			var parm = new OracleParameter
			           	{
                    OracleDbType = OracleDbType.LongRaw,
			           		DbType = DbType.Binary,
			           		ParameterName = key,
			           		Value = buffer,
			           		Size = buffer.Count
			           	};

			return parm;

		}

		/// <summary>
		/// Resets the parameters.
		/// </summary>
		public void ResetParameters()
		{
			if (_lazyParameters != null)
				_lazyParameters.Clear();
		}


		/// <summary>
		/// Executes the SQL command.
		/// </summary>
		/// <param name="db">The database.</param>
		/// <param name="command">The SQL command.</param>
		/// <returns>
		/// The number of rows affected by the command.
		/// </returns>
		public int ExecuteNonQuery(Database db, string command)
		{
			var oracleDb = db as OracleDatabase;
			if (oracleDb == null)
				throw new ApplicationException("ActiveRecordBase.ExecuteReader failed to cast connection!");

			var cmd = (OracleCommand)db.GetSqlStringCommand(command);

			if (_lazyParameters != null)
			{
				foreach (string key in _lazyParameters.Keys)
				{
				  cmd.Parameters.Add(key.IndexOf(LongRawColumnParms, StringComparison.Ordinal) > -1
				    ? CreateLongRawParameter(key, (byte[]) _lazyParameters[key])
				    : new OracleParameter(key, _lazyParameters[key]));
				}
				ResetParameters();
			}
			return db.ExecuteNonQuery(cmd);
		}

		#endregion
	}
}
