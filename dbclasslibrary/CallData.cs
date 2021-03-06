﻿using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	[ClassInterface(ClassInterfaceType.None)]
	public class CallData : ActiveRecord, ICallData
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CallData"/> class.
		/// </summary>
		public CallData() : this("CALL_DATA")
		{}

		/// <summary>
		/// Initializes a new instance of the <see cref="CallData"/> class.
		/// </summary>
		public CallData(string tableName)
			: base(tableName)
		{
			// Begin AutoGenerated Column Definitions
			columns.Add(new Column("CALL_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CALL_DATA", String.Empty, "LONG RAW"));
		}

		#region CallId
		/// <summary>
		/// Gets or sets the call id.
		/// </summary>
		/// <value>The call id.</value>
		public int CallId
		{
			get
			{
				return GetColumnValueAsInt("CALL_ID") ?? 0;
			}
			set
			{
				this.SetColumnValue("CALL_ID", value.ToString());
			}
		}

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
		public byte[] Data
		{
			get
			{
				return Columns[1].Data;
			}
			set
			{
				Columns[1].Data = value;
			}
		}
		#endregion

		/// <summary>
		/// Generates the update SQL.
		/// </summary>
		/// <returns></returns>
		protected override string GenerateUpdateSql()
		{
			return string.Format("update {0} set CALL_DATA = :call_data where CALL_ID = {1}", Name, CallId);
		}
		/// <summary>
		/// Generates the insert SQL.
		/// </summary>
		/// <returns></returns>
		protected override string GenerateInsertSql()
		{
			return string.Format("insert into {0} (CALL_ID, CALL_DATA) VALUES ({1}, :call_data )", Name, CallId);
		}

		/// <summary>
		/// If you use parameters in your update SQL
		/// You must also override this method to add
		/// their corresponding values from properties.
		/// </summary>
		protected override void AddUpdateParameters()
		{
			AddParameter("call_data", Data);
		}

		#region ICallData Members


		/// <summary>
		/// Creates or updates the blob
		/// Set CallId required before calling this method.
		/// </summary>
		public bool Save(int length, [MarshalAs(UnmanagedType.SafeArray)] byte[] buffer)
		{
			bool results = false;

			try
			{
				if (CallId > 0)
				{
					Data = buffer;
					results = CallIdExists(CallId, Instance, Name) ? Update() : Insert();
				}
			}
			catch (Exception ex)
			{
				GeneralUtility.LogError(ex.Message, Name);
			}
			return results;
		}

		/// <summary>
		/// Loads the specified results.
		/// </summary>
		public bool Load(out byte[] buffer)
		{
			try
			{
				if (Execute())
				{
					buffer = Data;
					return true;
				}
			}
			catch (Exception ex)
			{
				GeneralUtility.LogError(ex.Message, Name);
			}
			buffer = new byte[0];
			return false;
		}

		#endregion

		private static bool CallIdExists(int callId, string instance, string name)
		{
			CallData record = name.Equals("CALL_DATAB", StringComparison.InvariantCultureIgnoreCase) ?
				new CallDataB () : new  CallData();
			record.Instance = instance;
			record.CallId = callId;
			return record.Execute() && record.Data.Length > 0;
		}
	}


	/// <summary>
	/// CALL_DATA as BLOB nt LONG RAW
	/// </summary>
	[ClassInterface(ClassInterfaceType.None)]
	public class CallDataB : CallData
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CallDataB"/> class.
		/// </summary>
		public CallDataB()
			: base("CALL_DATAB")
		{
			columns.Clear();
			// reset column definitions for BLOB
			columns.Add(new Column("CALL_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CALL_DATA", String.Empty, "BLOB"));
		}
	}
}
