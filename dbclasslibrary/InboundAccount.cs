using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DbClassLibrary
{
    public class InboundAccounts : ActiveRecordSet<InboundAccount>
    {
        private const string SqlSelect =
            "SELECT DISTINCT  AHS.FNS_CLIENT_CD || ' - ' || AHS.NAME || ' - '|| IC.PHONENUMBER AS ACCOUNT_NAME," +
            "AHS.ACCNT_HRCY_STEP_ID AS AHSID,GREETING,L.LOB_CD || ' - ' || L.LOB_NAME AS LOB_DESC " +
            "FROM " +
            "INBOUNDCALL IC,ACCOUNT_HIERARCHY_STEP AHS,ACCOUNT_CALLFLOW AC,LOB L " +
            "WHERE " +
            "AC.ACCNT_HRCY_STEP_ID=IC.ACCNT_HRCY_STEP_ID AND " +
            "AC.ACCNT_HRCY_STEP_ID=AHS.ACCNT_HRCY_STEP_ID AND " +
            "AC.LOB_CD=L.LOB_CD";

        private const string SqlUserSelect =
           "SELECT DISTINCT  AHS.FNS_CLIENT_CD || ' - ' || AHS.NAME || ' - '|| IC.PHONENUMBER AS ACCOUNT_NAME," +
           "AHS.ACCNT_HRCY_STEP_ID AS AHSID,GREETING,L.LOB_CD || ' - ' || L.LOB_NAME AS LOB_DESC " +
           "FROM " +
           "INBOUNDCALL IC, ACCOUNT_HIERARCHY_STEP AHS, ACCOUNT_CALLFLOW AC, LOB L," +
           "ACCOUNT_USER AU, USERS U " +
           "WHERE " +
           "AC.ACCNT_HRCY_STEP_ID=IC.ACCNT_HRCY_STEP_ID AND " +
           "AC.ACCNT_HRCY_STEP_ID=AHS.ACCNT_HRCY_STEP_ID AND " +
           "AC.LOB_CD=L.LOB_CD AND " +
           "AC.ACCNT_HRCY_STEP_ID = AU.ACCNT_HRCY_STEP_ID AND AU.USER_ID = U.USER_ID";

        private const string SqlNodeSelect =
            "SELECT DISTINCT  LU.FNS_CLIENT_CD || ' - ' || LU.NAME || ' - '|| LU.PHONENUMBER AS ACCOUNT_NAME," +
            "AU.ACCNT_HRCY_STEP_ID AS AHSID," +
            "LU.GREETING," +
            "LU.LOB_CD || ' - ' || L.LOB_NAME AS LOB_DESC " +
            "FROM " +
            "LOCATIONS_USER LU,ACCOUNT_CALLFLOW AC," +
            "LOB L, ACCOUNT_USER AU, USERS U, ACCOUNT_HIERARCHY_STEP AHS " +
            "WHERE " +
            "LU.LOB_CD = L.LOB_CD AND " +
            "AHS.ACCNT_HRCY_STEP_ID = LU.ACCNT_HRCY_STEP_ID AND " +
            "LU.ACCOUNT_USER_ID=AU.USER_ID AND " +
            "AC.LOB_CD=L.LOB_CD AND AU.USER_ID = U.USER_ID";

        const string SqlOrderBy = "ORDER BY ACCOUNT_NAME, LOB_DESC";

        public InboundAccounts()
            : base("InboundAccount")
        { }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use node query].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use node query]; otherwise, <c>false</c>.
        /// </value>
        public bool UseNodeQuery { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has user.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has user; otherwise, <c>false</c>.
        /// </value>
        private bool HasUser
        {
            get
            {
                return !string.IsNullOrEmpty(UserId);
            }
        }

        private string ResolveQuerySelect()
        {
            if (UseNodeQuery)
                return SqlNodeSelect;
            if (HasUser)
                return SqlUserSelect;
            return SqlSelect;
        }

        private string GetUserIdConstraint()
        {
            return string.IsNullOrEmpty(UserId)
                ? string.Empty
                : " AND U.USER_ID = :user_id";
        }
        protected override void AddQueryParameters()
        {
            if (!string.IsNullOrEmpty(UserId))
                AddParameter("user_id", UserId);
        }

        public override string Query
        {
            get
            {
                return string.Format("{0}{1} {2}",
                    (ResolveQuerySelect()), GetUserIdConstraint(), SqlOrderBy);
            }
            set
            {

            }
        }

        /// <summary>
        /// Returns an aggregated list of accounts and their corresponding
        /// line of business codes for consumption/conversion to json.
        /// N.B. I've had to use an anonymous type to serialize since
        /// ActiveRecord is ISerializable and not compatible with the json
        /// serializer.
        /// </summary>
        /// <param name="userId">The userId or empty string for all.</param>
        /// <param name="useNode">if set to <c>true</c> [use node].</param>
        /// <returns></returns>
        static public IEnumerable<InboundAccount> GetAccounts(string userId, bool useNode)
        {
            var source = new InboundAccounts { UserId = userId, UseNodeQuery = useNode }.Results().ToList();
            var accounts = (from r in source
                            select r.AhsId).Distinct();
            var q =
                from c in accounts
                join p in source on c equals p.AhsId into ps
                select new { Id = c, LobCodes = ps };

            var results = new List<InboundAccount>();

            foreach (var v in q)
            {
                var lobCodes = new List<string>();
                InboundAccount current = null;
                foreach (var p in v.LobCodes)
                {
                    if (current == null)
                        current = p;
                    lobCodes.Add(p.LobDescription);
                }
                if (current == null) continue;
                current.LobCodes = lobCodes.ToArray();
                results.Add(current);
            }
            foreach (var item in results)
            {
                yield return item;
            }
        }
    }

    public class InboundAccount : ActiveRecord
    {
        public InboundAccount()
            : base("InboundAccount")
        {
            columns.Add(new Column("ACCOUNT_NAME", string.Empty, "VARCHAR2"));
            columns.Add(new Column("AHSID", string.Empty, "NUMBER"));
            columns.Add(new Column("GREETING", string.Empty, "VARCHAR2"));
            columns.Add(new Column("LOB_DESC", string.Empty, "VARCHAR2"));
        }

        public InboundAccount(IDataReader reader)
            : base(reader, "InboundAccount")
        { }

        public string AccountName
        {
            get { return GetColumnValue("ACCOUNT_NAME"); }
            set { SetColumnValue("ACCOUNT_NAME", value); }
        }

        public int AhsId
        {
            get { return GetColumnValueAsInt("AHSID") ?? -1; }
            set { SetColumnValue("AHSID", value.ToString()); }
        }

        public string Greeting
        {
            get { return GetColumnValue("GREETING"); }
            set { SetColumnValue("GREETING", value); }
        }

        public string LobDescription
        {
            get { return GetColumnValue("LOB_DESC"); }
            set { SetColumnValue("LOB_DESC", value); }
        }

        public string[] LobCodes { get; set; }

        /// <summary>
        /// Equals the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns></returns>
        public bool Equals(InboundAccount other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            if (AhsId != other.AhsId) return false;
            return LobDescription == other.LobDescription;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                {
                    var key = string.Format("{0}{1}", AhsId, LobDescription);
                    return key.GetHashCode();
                }
            }
        }
    }
}
