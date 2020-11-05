using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace DbClassLibrary.ActiveRecords
{
	public class MiamiDadeClaimArchives : ActiveRecordSet<MiamiDadeClaimArchive>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Employees"/> class.
		/// </summary>
		public MiamiDadeClaimArchives()
			: base("MiamiDadeClaimArchive")
		{
			Instance = DbBaseClass.FNSP; 
		}

		public string ClaimantTaxId { get; set; }

		public override string Query
		{
			get
			{
				var newquery = new StringBuilder();
				newquery.AppendLine(new MiamiDadeClaimArchive().GenerateSelectFrom());
				if (!string.IsNullOrEmpty(ClaimantTaxId))
					newquery.AppendFormat("WHERE CLAIMANT_TAX_ID = '{0}' ", ClaimantTaxId);

				newquery.Append("ORDER BY ACCIDENT_DT");
				return newquery.ToString();
			}
			set
			{
				base.Query = value;
			}
		}
	}

	[ComVisible(false), TableDefinition(TableName = "FNSOWNER.MIAMIDADE_CLAIM_ARCHIVE")]
	public class MiamiDadeClaimArchive : ActiveRecord
	{
		public MiamiDadeClaimArchive()
			: base("MIAMIDADE_CLAIM_ARCHIVE")
		{
			columns.Add(new Column("MDCLAIM_ARCHIVE_ID", string.Empty, "NUMBER"));
			columns.Add(new Column("MD_CLAIM_NUMBER", string.Empty, "VARCHAR2"));
			columns.Add(new Column("CLAIMANT_TAX_ID", string.Empty, "VARCHAR2"));
			columns.Add(new Column("CLAIMANT_FULLNAME", string.Empty, "VARCHAR2"));
			columns.Add(new Column("ACCIDENT_DT", string.Empty, "SHORTDATE"));
			columns.Add(new Column("UPLOAD_KEY", string.Empty, "VARCHAR2"));
			columns.Add(new Column("FILE_TRANSMISSION_LOG_ID", string.Empty, "NUMBER"));
			columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
			columns.Add(new Column("MODIFIED_DT", string.Empty, "DATE"));
		}

		public MiamiDadeClaimArchive(IDataReader reader)
			: base(reader, "MIAMIDADE_CLAIM_ARCHIVE")
		{ }

		#region Id
		/// <summary>
		/// MDCLAIM_ARCHIVE_ID
		/// </summary>
		public string Id
		{
			get { return GetColumnValue("MDCLAIM_ARCHIVE_ID"); }
			set { SetColumnValue("MDCLAIM_ARCHIVE_ID", value); }
		}
		#endregion

		#region ClaimNumber
		/// <summary>
		/// MD_CLAIM_NUMBER
		/// </summary>
		public string ClaimNumber
		{
			get { return GetColumnValue("MD_CLAIM_NUMBER"); }
			set { SetColumnValue("MD_CLAIM_NUMBER", value); }
		}
		#endregion

		#region ClaimantTaxId
		/// <summary>
		/// CLAIMANT_TAX_ID
		/// </summary>
		public string ClaimantTaxId
		{
			get { return GetColumnValue("CLAIMANT_TAX_ID"); }
			set { SetColumnValue("CLAIMANT_TAX_ID", value); }
		}
		#endregion

		#region ClaimantFullname
		/// <summary>
		/// CLAIMANT_FULLNAME
		/// </summary>
		public string ClaimantFullname
		{
			get { return GetColumnValue("CLAIMANT_FULLNAME"); }
			set { SetColumnValue("CLAIMANT_FULLNAME", value); }
		}
		#endregion

		#region AccidentDate
		/// <summary>
		/// ACCIDENT_DT
		/// </summary>
		public string AccidentDate
		{
			get { return GetColumnValue("ACCIDENT_DT"); }
			set { SetColumnValue("ACCIDENT_DT", value); }
		}
		#endregion

		#region UploadKey
		/// <summary>
		/// UPLOAD_KEY
		/// </summary>
		public string UploadKey
		{
			get { return GetColumnValue("UPLOAD_KEY"); }
		}
		#endregion

		#region FileTransmissionLogId
		/// <summary>
		/// FILE_TRANSMISSION_LOG_ID
		/// </summary>
		public string FileTransmissionLogId
		{
			get { return GetColumnValue("FILE_TRANSMISSION_LOG_ID"); }
		}
		#endregion

		#region CreatedDate
		/// <summary>
		/// CREATED_DT
		/// </summary>
		public string CreatedDate
		{
			get { return GetColumnValue("CREATED_DT"); }
		}
		#endregion

		#region ModifiedDate
		/// <summary>
		/// MODIFIED_DT
		/// </summary>
		public string ModifiedDate
		{
			get { return GetColumnValue("MODIFIED_DT"); }
		}
		#endregion
	}
}
