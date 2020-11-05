using System;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// Encapsulates the LU_CODE table record
	/// </summary>
	[ClassInterface(ClassInterfaceType.None)]
	public class LookupCode : ActiveRecord, ILookupCode
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="LookupCode"/> class.
		/// </summary>
		public LookupCode()
			: base("LU_CODE")
		{
			columns.Add(new Column("LU_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("LU_TYPE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("VALUE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CODE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SEQUENCE", String.Empty, "NUMBER"));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LookupCode"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public LookupCode(IDataReader reader)
			: base(reader, "LU_CODE")
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="LookupCode"/> class.
		/// This constructor is required for typesafe cloning.
		/// </summary>
		/// <param name="source">The source.</param>
		public LookupCode(ActiveRecord source)
			: base(source)
		{ }

		#endregion

		#region Properties

		#region Id
		/// <summary>
		/// LU_ID
		/// </summary>
		public int Id
		{

			get { return GetColumnValueAsInt("LU_ID") ?? 0; }
			set { SetColumnValue("LU_ID", value.ToString()); }
		}
		#endregion

		#region LuTypeId
		/// <summary>
		/// LU_TYPE_ID
		/// </summary>
		public int LuTypeId
		{

			get { return GetColumnValueAsInt("LU_TYPE_ID") ?? 0; }
			set { SetColumnValue("LU_TYPE_ID", value.ToString()); }
		}
		#endregion

		#region LookupValue
		/// <summary>
		/// VALUE
		/// </summary>
		public string LookupValue
		{

			get { return GetColumnValue("VALUE"); }
			set { SetColumnValue("VALUE", value); }
		}
		#endregion

		#region Code
		/// <summary>
		/// CODE
		/// </summary>
		public string Code
		{

			get { return GetColumnValue("CODE"); }
			set { SetColumnValue("CODE", value); }
		}
		#endregion

		#region Sequence
		/// <summary>
		/// SEQUENCE
		/// </summary>
		public int Sequence
		{

			get { return GetColumnValueAsInt("SEQUENCE") ?? 0; }
			set { SetColumnValue("SEQUENCE", value.ToString()); }
		}
		#endregion

		#endregion
	}
}
