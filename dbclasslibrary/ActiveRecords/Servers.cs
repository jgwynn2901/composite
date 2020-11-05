using System.Text;

namespace DbClassLibrary.ActiveRecords
{
	public class Servers : ActiveRecordSet<Server>
	{
		public Servers()
			: base("Server")
		{
      Instance = DbBaseClass.SEDBA;
		}

		public string Filter { get; set; }
		public string Order { get; set; }

		public override string Query
		{
			get
			{
				var sql = new StringBuilder("select * from servers");
				if (!string.IsNullOrEmpty(Filter))
				{
					sql.Append(" where ");
					sql.Append(Filter);
				}
				if (!string.IsNullOrEmpty(Order))
				{
					sql.Append(" order by ");
					sql.Append(Order);
				}
				else
					sql.Append(" order by server_name");

				return sql.ToString();
			}	
		}
	}
}
