using System.Data;

namespace DbClassLibrary.ActiveRecords
{
	/// <summary>
	/// 
	/// </summary>
	public class ClaimSubmission : ActiveRecord
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimSubmission"/> class.
		/// </summary>
		public ClaimSubmission() : base ("CLAIM_SUBMISSION")
		{
			columns.Add(new Column("CLAIM_SUBMISSION_ID", string.Empty, "NUMBER"));
			columns.Add(new Column("CALL_ID", string.Empty, "NUMBER"));
			columns.Add(new Column("RQID", string.Empty, "VARCHAR2"));
			columns.Add(new Column("POLICY_NUMBER", string.Empty, "VARCHAR2"));
			columns.Add(new Column("DATE_OF_LOSS", string.Empty, "VARCHAR2"));
			columns.Add(new Column("FILE_FORMAT_CD", string.Empty, "VARCHAR2"));
			columns.Add(new Column("LOSS_FILE_NUM", string.Empty, "VARCHAR2"));
			columns.Add(new Column("CLAIM_NUMBER", string.Empty, "VARCHAR2"));
			columns.Add(new Column("STATUS", string.Empty, "VARCHAR2"));
			columns.Add(new Column("ERROR_CD", string.Empty, "VARCHAR2"));
			columns.Add(new Column("ERROR_TEXT", string.Empty, "VARCHAR2"));
			columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
			columns.Add(new Column("LAST_MODIFIED_DT", string.Empty, "DATE"));
      _canDelete = true;
    }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimSubmission"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public ClaimSubmission(IDataReader reader)
      : base(reader, "CLAIM_SUBMISSION")
		{
      _canDelete = true;
    }

		#endregion

		#region ClaimSubmissionId
		/// <summary>
		/// CLAIM_SUBMISSION_ID
		/// </summary>
		public string ClaimSubmissionId
		{
			get { return GetColumnValue("CLAIM_SUBMISSION_ID"); }
			set { SetColumnValue("CLAIM_SUBMISSION_ID", value); }
		}
		#endregion

		#region CallId
		/// <summary>
		/// CALL_ID
		/// </summary>
		public string CallId
		{
			get { return GetColumnValue("CALL_ID"); }
			set { SetColumnValue("CALL_ID", value); }
		}
		#endregion

		#region RqId
		/// <summary>
		/// RQID
		/// </summary>
		public string RqId
		{
			get { return GetColumnValue("RQID"); }
			set { SetColumnValue("RQID", value); }
		}
		#endregion

		#region PolicyNumber
		/// <summary>
		/// POLICY_NUMBER
		/// </summary>
		public string PolicyNumber
		{
			get { return GetColumnValue("POLICY_NUMBER"); }
			set { SetColumnValue("POLICY_NUMBER", value); }
		}
		#endregion

		#region DateOfLoss
		/// <summary>
		/// DATE_OF_LOSS
		/// </summary>
		public string DateOfLoss
		{
			get { return GetColumnValue("DATE_OF_LOSS"); }
			set { SetColumnValue("DATE_OF_LOSS", value); }
		}
		#endregion

		#region FileFormatCode
		/// <summary>
		/// FILE_FORMAT_CD
		/// </summary>
		public string FileFormatCode
		{
			get { return GetColumnValue("FILE_FORMAT_CD"); }
			set { SetColumnValue("FILE_FORMAT_CD", value); }
		}
		#endregion

		#region LossFileNum
		/// <summary>
		/// LOSS_FILE_NUM
		/// </summary>
		public string LossFileNum
		{
			get { return GetColumnValue("LOSS_FILE_NUM"); }
			set { SetColumnValue("LOSS_FILE_NUM", value); }
		}
		#endregion

		#region ClaimNumber
		/// <summary>
		/// CLAIM_NUMBER
		/// </summary>
		public string ClaimNumber
		{
			get { return GetColumnValue("CLAIM_NUMBER"); }
			set { SetColumnValue("CLAIM_NUMBER", value); }
		}
		#endregion

		#region Status
		/// <summary>
		/// STATUS
		/// </summary>
		public string Status
		{
			get { return GetColumnValue("STATUS"); }
			set { SetColumnValue("STATUS", value); }
		}
		#endregion

		#region ErrorCode
		/// <summary>
		/// ERROR_CD
		/// </summary>
		public string ErrorCode
		{
			get { return GetColumnValue("ERROR_CD"); }
			set { SetColumnValue("ERROR_CD", value); }
		}
		#endregion

		#region ErrorText
		/// <summary>
		/// ERROR_TEXT
		/// </summary>
		public string ErrorText
		{
			get { return GetColumnValue("ERROR_TEXT"); }
			set { SetColumnValue("ERROR_TEXT", value); }
		}
		#endregion

		#region CreatedDate
		/// <summary>
		/// CREATED_DT
		/// </summary>
		public string CreatedDate
		{
			get { return GetColumnValue("CREATED_DT"); }
			set { SetColumnValue("CREATED_DT", value); }
		}
		#endregion

		#region LastModifiedDate
		/// <summary>
		/// LAST_MODIFIED_DT
		/// </summary>
		public string LastModifiedDate
		{
			get { return GetColumnValue("LAST_MODIFIED_DT"); }
			set { SetColumnValue("LAST_MODIFIED_DT", value); }
		}
		#endregion

		/// <summary>
		/// Tests for an entry by rquid.
		/// </summary>
		public static bool ClaimSubmissionExistsForRquid(string rquId)
		{
			return ClaimSubmissionExistsForRquid(rquId, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Tests for an entry by rquid.
		/// </summary>
		public static bool ClaimSubmissionExistsForRquid(string rquId, string instance)
		{
			var results = new ClaimSubmission {Instance = instance, RqId = rquId, primaryKeyIndex = 2};
			return results.Execute() && results.ClaimSubmissionId.Length > 0;
		}
	}

	
}
