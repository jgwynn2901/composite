using System;
using System.Data;
using System.Globalization;

namespace DbClassLibrary.ActiveRecords
{
	public class Server : ActiveRecord
	{
		#region Constructors 

		public Server():base ("SERVERS")
		{
			columns.Add(new Column("SERVER_ID", string.Empty, "NUMBER"));
			columns.Add(new Column("SERVER_NAME", string.Empty, "VARCHAR2"));
			columns.Add(new Column("INSTANCE", string.Empty, "VARCHAR2"));
			columns.Add(new Column("URI", string.Empty, "VARCHAR2"));
			columns.Add(new Column("IP_ADDRESS", string.Empty, "VARCHAR2"));
			columns.Add(new Column("ROLE", string.Empty, "VARCHAR2"));
			columns.Add(new Column("HOST", string.Empty, "VARCHAR2"));
			columns.Add(new Column("LOCATION", string.Empty, "VARCHAR2"));
			columns.Add(new Column("DESCRIPTION", string.Empty, "VARCHAR2"));
			dbInstance = DbBaseClass.SEDBA;
		  _canDelete = true;
		}

		public Server(IDataReader reader)
			: base(reader, "SERVERS")
		{
      dbInstance = DbBaseClass.SEDBA;
		  _canDelete = true;
		}

        #endregion

		protected override string GenerateDeleteSql()
		{
			if(ServerId == 0) throw new InvalidOperationException("ServerId is required!");
			return string.Format("delete from {0} where server_id = {1}", tableName, ServerId);
		}

		protected override string GenerateUpdateSql()
		{
			return
				"update SERVERS set SERVER_NAME = :name, INSTANCE = :instance, URI = :uri," +
				"IP_ADDRESS = :ipaddress, ROLE = :role, HOST = :host, DESCRIPTION = :description " +
				"where SERVER_ID = :id";

		}

		/// <summary>
		/// If you use parameters in your update SQL
		/// You must also override this method to add
		/// their corresponding values from properties.
		/// </summary>
		protected override void AddUpdateParameters()
		{
			AddParameter("name", ServerName);
			AddParameter("instance", DatabaseInstance);
			AddParameter("uri", Uri);
			AddParameter("ipaddress", IpAddress);
			AddParameter("role", Role);
			AddParameter("host", Host);
			AddParameter("description", Description);
			AddParameter("id", ServerId);
		}

		#region ServerId
		/// <summary>
		/// SERVER_ID
		/// </summary>
		public int ServerId
		{
			get { return GetColumnValueAsInt("SERVER_ID") ?? 0; }
			set { SetColumnValue("SERVER_ID", value.ToString(CultureInfo.InvariantCulture)); }
		}
		#endregion

		#region ServerName
		/// <summary>
		/// SERVER_NAME
		/// </summary>
		public string ServerName
		{
			get { return GetColumnValue("SERVER_NAME"); }
			set { SetColumnValue("SERVER_NAME", value); }
		}
		#endregion

		#region DatabaseInstance
		/// <summary>
		/// INSTANCE
		/// </summary>
		public string DatabaseInstance
		{
			get { return GetColumnValue("INSTANCE"); }
			set { SetColumnValue("INSTANCE", value); }
		}
		#endregion

		#region Uri
		/// <summary>
		/// URI
		/// </summary>
		public string Uri
		{
			get { return GetColumnValue("URI"); }
			set { SetColumnValue("URI", value); }
		}
		#endregion

		#region IpAddress
		/// <summary>
		/// IP_ADDRESS
		/// </summary>
		public string IpAddress
		{
			get { return GetColumnValue("IP_ADDRESS"); }
			set { SetColumnValue("IP_ADDRESS", value); }
		}
		#endregion

		#region Role
		/// <summary>
		/// ROLE
		/// </summary>
		public string Role
		{
			get { return GetColumnValue("ROLE"); }
			set { SetColumnValue("ROLE", value); }
		}
		#endregion

		#region Host
		/// <summary>
		/// HOST
		/// </summary>
		public string Host
		{
			get { return GetColumnValue("HOST"); }
			set { SetColumnValue("HOST", value); }
		}
		#endregion

		#region Location
		/// <summary>
		/// LOCATION
		/// </summary>
		public string Location
		{
			get { return GetColumnValue("LOCATION"); }
			set { SetColumnValue("LOCATION", value); }
		}
		#endregion

		#region Description
		/// <summary>
		/// DESCRIPTION
		/// </summary>
		public string Description
		{
			get { return GetColumnValue("DESCRIPTION"); }
			set { SetColumnValue("DESCRIPTION", value); }
		}
		#endregion
	}
}
