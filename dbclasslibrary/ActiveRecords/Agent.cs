using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{
    /// <summary>
    /// 
    /// </summary>
     [ComVisible(false)]
    public class Agent : ActiveRecord
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Agent"/> class.
        /// </summary>
         public Agent() : base("AGENT")
         {
             columns.Add(new Column("AGENT_ID", string.Empty, "NUMBER"));
             columns.Add(new Column("BRANCH_ID", string.Empty, "NUMBER"));
             columns.Add(new Column("AGENT_BRANCHNUM", string.Empty, "VARCHAR2"));
             columns.Add(new Column("AGENT_NUMBER", string.Empty, "VARCHAR2"));
             columns.Add(new Column("STATUS", string.Empty, "CHAR"));
             columns.Add(new Column("TYPECD", string.Empty, "CHAR"));
             columns.Add(new Column("NAME", string.Empty, "VARCHAR2"));
             columns.Add(new Column("ADDRESS", string.Empty, "VARCHAR2"));
             columns.Add(new Column("CITY", string.Empty, "VARCHAR2"));
             columns.Add(new Column("STATE", string.Empty, "VARCHAR2"));
             columns.Add(new Column("ZIPCODE", string.Empty, "VARCHAR2"));
             columns.Add(new Column("PHONE", string.Empty, "VARCHAR2"));
             columns.Add(new Column("FAX", string.Empty, "VARCHAR2"));
             columns.Add(new Column("FAXCD", string.Empty, "VARCHAR2"));
             columns.Add(new Column("LAT", string.Empty, "NUMBER"));
             columns.Add(new Column("LON", string.Empty, "NUMBER"));
             columns.Add(new Column("FILE_TRANSMISSION_LOG_ID", string.Empty, "NUMBER"));
             columns.Add(new Column("UPLOAD_KEY", string.Empty, "VARCHAR2"));
             columns.Add(new Column("EMAIL_ADDRESS", string.Empty, "VARCHAR2"));
             columns.Add(new Column("CONTACT_TYPE", string.Empty, "VARCHAR2"));
             columns.Add(new Column("NAME_FIRST", string.Empty, "VARCHAR2"));
             columns.Add(new Column("NAME_MI", string.Empty, "CHAR"));
             columns.Add(new Column("NAME_LAST", string.Empty, "VARCHAR2"));
             columns.Add(new Column("PHONE_EXT", string.Empty, "VARCHAR2"));
             columns.Add(new Column("PREF_IND", string.Empty, "CHAR"));
             columns.Add(new Column("GAT_CODE", string.Empty, "VARCHAR2"));
         }

        #endregion

         #region AgentId
         /// <summary>
         /// AGENT_ID
         /// </summary>
         public string AgentId
         {
             get { return GetColumnValue("AGENT_ID"); }
             set { SetColumnValue("AGENT_ID", value); }
         }
         #endregion

         #region BranchId
         /// <summary>
         /// BRANCH_ID
         /// </summary>
         public string BranchId
         {
             get { return GetColumnValue("BRANCH_ID"); }
             set { SetColumnValue("BRANCH_ID", value); }
         }
         #endregion

         #region AgentBranchnum
         /// <summary>
         /// AGENT_BRANCHNUM
         /// </summary>
         public string AgentBranchnum
         {
             get { return GetColumnValue("AGENT_BRANCHNUM"); }
             set { SetColumnValue("AGENT_BRANCHNUM", value); }
         }
         #endregion

         #region AgentNumber
         /// <summary>
         /// AGENT_NUMBER
         /// </summary>
         public string AgentNumber
         {
             get { return GetColumnValue("AGENT_NUMBER"); }
             set { SetColumnValue("AGENT_NUMBER", value); }
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

         #region TypeCode
         /// <summary>
         /// TYPECD
         /// </summary>
         public string TypeCode
         {
             get { return GetColumnValue("TYPECD"); }
             set { SetColumnValue("TYPECD", value); }
         }
         #endregion

         #region AgentName
         /// <summary>
         /// NAME
         /// </summary>
         public string AgentName
         {
             get { return GetColumnValue("NAME"); }
             set { SetColumnValue("NAME", value); }
         }
         #endregion

         #region Address1
         /// <summary>
         /// ADDRESS
         /// </summary>
         public string Address1
         {
             get { return GetColumnValue("ADDRESS"); }
             set { SetColumnValue("ADDRESS", value); }
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

         #region Zipcode
         /// <summary>
         /// ZIPCODE
         /// </summary>
         public string Zipcode
         {
             get { return GetColumnValue("ZIPCODE"); }
             set { SetColumnValue("ZIPCODE", value); }
         }
         #endregion

         #region Phone
         /// <summary>
         /// PHONE
         /// </summary>
         public string Phone
         {
             get { return GetColumnValue("PHONE"); }
             set { SetColumnValue("PHONE", value); }
         }
         #endregion

         #region Fax
         /// <summary>
         /// FAX
         /// </summary>
         public string Fax
         {
             get { return GetColumnValue("FAX"); }
             set { SetColumnValue("FAX", value); }
         }
         #endregion

         #region FaxCode
         /// <summary>
         /// FAXCD
         /// </summary>
         public string FaxCode
         {
             get { return GetColumnValue("FAXCD"); }
             set { SetColumnValue("FAXCD", value); }
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

         #region FileTransmissionLogId
         /// <summary>
         /// FILE_TRANSMISSION_LOG_ID
         /// </summary>
         public string FileTransmissionLogId
         {
             get { return GetColumnValue("FILE_TRANSMISSION_LOG_ID"); }
             set { SetColumnValue("FILE_TRANSMISSION_LOG_ID", value); }
         }
         #endregion

         #region UploadKey
         /// <summary>
         /// UPLOAD_KEY
         /// </summary>
         public string UploadKey
         {
             get { return GetColumnValue("UPLOAD_KEY"); }
             set { SetColumnValue("UPLOAD_KEY", value); }
         }
         #endregion

         #region EmailAddress
         /// <summary>
         /// EMAIL_ADDRESS
         /// </summary>
         public string EmailAddress
         {
             get { return GetColumnValue("EMAIL_ADDRESS"); }
             set { SetColumnValue("EMAIL_ADDRESS", value); }
         }
         #endregion

         #region ContactType
         /// <summary>
         /// CONTACT_TYPE
         /// </summary>
         public string ContactType
         {
             get { return GetColumnValue("CONTACT_TYPE"); }
             set { SetColumnValue("CONTACT_TYPE", value); }
         }
         #endregion

         #region NameFirst
         /// <summary>
         /// NAME_FIRST
         /// </summary>
         public string NameFirst
         {
             get { return GetColumnValue("NAME_FIRST"); }
             set { SetColumnValue("NAME_FIRST", value); }
         }
         #endregion

         #region NameMi
         /// <summary>
         /// NAME_MI
         /// </summary>
         public string NameMi
         {
             get { return GetColumnValue("NAME_MI"); }
             set { SetColumnValue("NAME_MI", value); }
         }
         #endregion

         #region NameLast
         /// <summary>
         /// NAME_LAST
         /// </summary>
         public string NameLast
         {
             get { return GetColumnValue("NAME_LAST"); }
             set { SetColumnValue("NAME_LAST", value); }
         }
         #endregion

         #region PhoneExt
         /// <summary>
         /// PHONE_EXT
         /// </summary>
         public string PhoneExt
         {
             get { return GetColumnValue("PHONE_EXT"); }
             set { SetColumnValue("PHONE_EXT", value); }
         }
         #endregion

         #region PrefInd
         /// <summary>
         /// PREF_IND
         /// </summary>
         public string PrefInd
         {
             get { return GetColumnValue("PREF_IND"); }
             set { SetColumnValue("PREF_IND", value); }
         }
         #endregion

         #region GatCode
         /// <summary>
         /// GAT_CODE
         /// </summary>
         public string GatCode
         {
             get { return GetColumnValue("GAT_CODE"); }
             set { SetColumnValue("GAT_CODE", value); }
         }
         #endregion


    }
}
