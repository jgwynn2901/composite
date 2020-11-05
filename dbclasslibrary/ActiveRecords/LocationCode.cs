using System.Data;

namespace DbClassLibrary.ActiveRecords
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class LocationCode : ActiveRecord
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimSubmission"/> class.
		/// </summary>
		public LocationCode()
			: base("LOCATION_CODE")
		{
			columns.Add(new Column("LOCATION_CODE_ID", string.Empty, "NUMBER"));
			columns.Add(new Column("STATE", string.Empty, "CHAR"));
			columns.Add(new Column("FIPS", string.Empty, "CHAR"));
			columns.Add(new Column("CITY", string.Empty, "VARCHAR2"));
			columns.Add(new Column("ZIP", string.Empty, "VARCHAR2"));
			columns.Add(new Column("COUNTY", string.Empty, "VARCHAR2"));
			columns.Add(new Column("LON", string.Empty, "FLOAT"));
			columns.Add(new Column("LAT", string.Empty, "FLOAT"));
			columns.Add(new Column("PRIMARY_LOC", string.Empty, "VARCHAR2"));
			columns.Add(new Column("COUNTRY", string.Empty, "VARCHAR2"));
			columns.Add(new Column("SEQ", string.Empty, "NUMBER"));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LocationCode"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public LocationCode(IDataReader reader)
            : base(reader, "LOCATION_CODE")
		{
		}

		#endregion

		#region LocationCodeId
		/// <summary>
		/// LOCATION_CODE_ID
		/// </summary>
		public string LocationCodeId
		{
			get { return GetColumnValue("LOCATION_CODE_ID"); }
			set { SetColumnValue("LOCATION_CODE_ID", value); }
		}
		#endregion

		#region State
		/// <summary>
		/// STATE
		/// </summary>
		public string State
		{
			get { return GetColumnValue("STATE"); }
			set { SetColumnValue("STATE", value); }
		}
		#endregion

		#region Fips
		/// <summary>
		/// FIPS
		/// </summary>
		public string Fips
		{
			get { return GetColumnValue("FIPS"); }
			set { SetColumnValue("FIPS", value); }
		}
		#endregion

		#region City
		/// <summary>
		/// CITY
		/// </summary>
		public string City
		{
			get { return GetColumnValue("CITY"); }
			set { SetColumnValue("CITY", value); }
		}
		#endregion

		#region Zip
		/// <summary>
		/// ZIP
		/// </summary>
		public string Zip
		{
			get { return GetColumnValue("ZIP"); }
			set { SetColumnValue("ZIP", value); }
		}
		#endregion

		#region County
		/// <summary>
		/// COUNTY
		/// </summary>
		public string County
		{
			get { return GetColumnValue("COUNTY"); }
			set { SetColumnValue("COUNTY", value); }
		}
		#endregion

		#region Lon
		/// <summary>
		/// LON
		/// </summary>
		public string Lon
		{
			get { return GetColumnValue("LON"); }
			set { SetColumnValue("LON", value); }
		}
		#endregion

		#region Lat
		/// <summary>
		/// LAT
		/// </summary>
		public string Lat
		{
			get { return GetColumnValue("LAT"); }
			set { SetColumnValue("LAT", value); }
		}
		#endregion

		#region PrimaryLoc
		/// <summary>
		/// PRIMARY_LOC
		/// </summary>
		public string PrimaryLoc
		{
			get { return GetColumnValue("PRIMARY_LOC"); }
			set { SetColumnValue("PRIMARY_LOC", value); }
		}
		#endregion

		#region Country
		/// <summary>
		/// COUNTRY
		/// </summary>
		public string Country
		{
			get { return GetColumnValue("COUNTRY"); }
			set { SetColumnValue("COUNTRY", value); }
		}
		#endregion

		#region Seq
		/// <summary>
		/// SEQ
		/// </summary>
		public string Seq
		{
			get { return GetColumnValue("SEQ"); }
			set { SetColumnValue("SEQ", value); }
		}
		#endregion
	}
}
