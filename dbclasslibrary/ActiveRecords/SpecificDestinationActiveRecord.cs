using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DbClassLibrary.ActiveRecords
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Specific destination active records. </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [ComVisible(false)]
    public class SpecificDestinationActiveRecords : ActiveRecordSet<SpecificDestinationActiveRecord>
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public SpecificDestinationActiveRecords()
            : base("SpecificDestinationActiveRecord")
        { }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Specific destination active record. </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [ComVisible(false)]
    public class SpecificDestinationActiveRecord : ActiveRecord
    {
        public static int addLobOperation = 1;
        public static int deleteLobOperation = 2;
        private static readonly char[] DecodeLobCharacter = new[] { ';', '\"' };
        private readonly string[] _validLobs = new[] { "AL", "GL", "WC", "DS", "LV", "CR", "PR" };
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public SpecificDestinationActiveRecord()
            : base("SPECIFIC_DESTINATION")
        {
            columns.Add(new Column("SPECIFIC_DESTINATION_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("NAME_FIRST", string.Empty, "VARCHAR2"));
            columns.Add(new Column("ADDRESS1", string.Empty, "VARCHAR2"));
            columns.Add(new Column("NAME_LAST", string.Empty, "VARCHAR2"));
            columns.Add(new Column("ADDRESS2", string.Empty, "VARCHAR2"));
            columns.Add(new Column("TITLE", string.Empty, "VARCHAR2"));
            columns.Add(new Column("NAME_MI", string.Empty, "VARCHAR2"));
            columns.Add(new Column("CITY", string.Empty, "VARCHAR2"));
            columns.Add(new Column("STATE", string.Empty, "VARCHAR2"));
            columns.Add(new Column("ZIP", string.Empty, "VARCHAR2"));
            columns.Add(new Column("PHONE", string.Empty, "VARCHAR2"));
            columns.Add(new Column("ALTERNATE_FORM_FLG", string.Empty, "VARCHAR2"));
            columns.Add(new Column("LOB", string.Empty, "VARCHAR2"));
            columns.Add(new Column("FILE_TRANSMISSION_LOG_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("UPLOAD_KEY", string.Empty, "VARCHAR2"));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <param name="reader">   The reader. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public SpecificDestinationActiveRecord(IDataReader reader)
            : base(reader, "SPECIFIC_DESTINATION")
        { }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the specific destination. </summary>
        ///
        /// <value> The identifier of the specific destination. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string SpecificDestinationId
        {
            get { return GetColumnValue("SPECIFIC_DESTINATION_ID"); }
            set { SetColumnValue("SPECIFIC_DESTINATION_ID", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the Account Hierarchy Step. </summary>
        ///
        /// <value> The identifier of the Account Hierarchy Step. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string AccntHrcyStepId
        {
            get { return GetColumnValue("ACCNT_HRCY_STEP_ID"); }
            set { SetColumnValue("ACCNT_HRCY_STEP_ID", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the first name. </summary>
        ///
        /// <value> The first name. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string NameFirst
        {
            get { return GetColumnValue("NAME_FIRST"); }
            set { SetColumnValue("NAME_FIRST", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Address 1. </summary>
        ///
        /// <value> The Address 1. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Address1
        {
            get { return GetColumnValue("ADDRESS1"); }
            set { SetColumnValue("ADDRESS1", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the last name. </summary>
        ///
        /// <value> The last name. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string NameLast
        {
            get { return GetColumnValue("NAME_LAST"); }
            set { SetColumnValue("NAME_LAST", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Address 2. </summary>
        ///
        /// <value> The Address 2. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Address2
        {
            get { return GetColumnValue("ADDRESS2"); }
            set { SetColumnValue("ADDRESS2", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the title. </summary>
        ///
        /// <value> The title. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Title
        {
            get { return GetColumnValue("TITLE"); }
            set { SetColumnValue("TITLE", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the middle initial. </summary>
        ///
        /// <value> The middle initial. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string NameMi
        {
            get { return GetColumnValue("NAME_MI"); }
            set { SetColumnValue("NAME_MI", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the city. </summary>
        ///
        /// <value> The city. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string City
        {
            get { return GetColumnValue("CITY"); }
            set { SetColumnValue("CITY", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the state. </summary>
        ///
        /// <value> The state. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string State
        {
            get { return GetColumnValue("STATE"); }
            set { SetColumnValue("STATE", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the zip. </summary>
        ///
        /// <value> The zip. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Zip
        {
            get { return GetColumnValue("ZIP"); }
            set { SetColumnValue("ZIP", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the phone. </summary>
        ///
        /// <value> The phone. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Phone
        {
            get { return GetColumnValue("PHONE"); }
            set { SetColumnValue("PHONE", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the alternate form flag. </summary>
        ///
        /// <value> The alternate form flag. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string AlternateFormFlg
        {
            get { return GetColumnValue("ALTERNATE_FORM_FLG"); }
            set { SetColumnValue("ALTERNATE_FORM_FLG", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the lob. </summary>
        ///
        /// <value> The lob. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Lob
        {
            get { return GetColumnValue("LOB"); }
            set { SetColumnValue("LOB", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the file transmission log. </summary>
        ///
        /// <value> The identifier of the file transmission log. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string FileTransmissionLogId
        {
            get { return GetColumnValue("FILE_TRANSMISSION_LOG_ID"); }
            set { SetColumnValue("FILE_TRANSMISSION_LOG_ID", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the upload key. </summary>
        ///
        /// <value> The upload key. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string UploadKey
        {
            get { return GetColumnValue("UPLOAD_KEY"); }
            set { SetColumnValue("UPLOAD_KEY", value); }
        }

        protected override string GenerateUpdateSql()
        {
            return GenerateUpdateSqlForChanges();
        }

        public bool MergeLOB(string listLob, int lOperation)
        {
            if(lOperation != addLobOperation && lOperation != deleteLobOperation)
                return false;

            bool bUpdateNeeded = false;
            var dicLob = new SortedDictionary<string, string>();
            string[] myList = Lob.Split(DecodeLobCharacter, StringSplitOptions.RemoveEmptyEntries);

            foreach (string strLob in myList)
            {
                dicLob[strLob.Trim()] = strLob.Trim();
            }

            myList = listLob.Split(DecodeLobCharacter, StringSplitOptions.RemoveEmptyEntries);
            foreach (string strLob in myList)
            {
                string strLobTrimmed = strLob.Trim();
                if (!_validLobs.Any(validLob => string.Compare(validLob, strLobTrimmed, true) == 0))
                    continue;   // Do not add undesired LOBs

                if (lOperation == addLobOperation)
                    dicLob[strLobTrimmed] = strLobTrimmed;
                else
                    dicLob.Remove(strLobTrimmed);
            }

            // NOTE: NOT CHECKING FOR EMPTY LOB LIST
            StringBuilder sbLob = new StringBuilder(255);
            foreach (KeyValuePair<string, string> valuePair in dicLob)
            {
                sbLob.AppendFormat("{0} ;", valuePair.Key);
            }

            // Now check if LOB has changed.
            if (Lob.CompareTo(sbLob.ToString()) != 0)
            {
                bUpdateNeeded = true;
                Lob = sbLob.ToString();

                // Also update the Upload_key
                string[] strUpload_key = UploadKey.Split("/".ToCharArray(), StringSplitOptions.None);
                strUpload_key[5] = sbLob.ToString();

                UploadKey = string.Join("/", strUpload_key);
            }

            return bUpdateNeeded;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="record"></param>
        public bool MergeLOB(SpecificDestinationActiveRecord record)
        {
            bool bUpdateNeeded = false;
            var dicLob = new SortedDictionary<string, string>();
            string[] myList = Lob.Split(DecodeLobCharacter, StringSplitOptions.RemoveEmptyEntries);

            foreach (string strLob in myList)
            {
                dicLob[strLob.Trim()] = strLob.Trim();
            }

            myList = record.Lob.Split(DecodeLobCharacter, StringSplitOptions.RemoveEmptyEntries);
            foreach (string strLob in myList)
            {
                dicLob[strLob.Trim()] = strLob.Trim();
            }

            StringBuilder sbLob = new StringBuilder(255);
            foreach (KeyValuePair<string, string> valuePair in dicLob)
            {
                sbLob.AppendFormat("{0} ;", valuePair.Key);
            }

            // Now check if LOB has changed.
            if (Lob.CompareTo(sbLob.ToString()) != 0)
            {
                bUpdateNeeded = true;
                Lob = sbLob.ToString();

                // Also update the Upload_key
                string[] strUpload_key = UploadKey.Split("/".ToCharArray(), StringSplitOptions.None);
                strUpload_key[5] = sbLob.ToString();

                UploadKey = string.Join("/", strUpload_key);
            }

            return bUpdateNeeded;
        }

        /// <summary>
        /// Copy the contents of another record into self if possible
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public bool MergeWith(SpecificDestinationActiveRecord record)
        {
            bool bResult = true;
            try
            {
                if (string.IsNullOrEmpty(Address1) && !string.IsNullOrEmpty(record.Address1))
                    Address1 = record.Address1;
                if (string.IsNullOrEmpty(Address2) && !string.IsNullOrEmpty(record.Address2))
                    Address2 = record.Address2;
                if (string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(record.City))
                    City = record.City;
                if (string.IsNullOrEmpty(NameFirst) && !string.IsNullOrEmpty(record.NameFirst))
                    NameFirst = record.NameFirst;
                if (string.IsNullOrEmpty(NameLast) && !string.IsNullOrEmpty(record.NameLast))
                    NameLast = record.NameLast;
                if (string.IsNullOrEmpty(NameMi) && !string.IsNullOrEmpty(record.NameMi))
                    NameMi = record.NameMi;
                if (string.IsNullOrEmpty(Phone) && !string.IsNullOrEmpty(record.Phone))
                    Phone = record.Phone;
                if (string.IsNullOrEmpty(State) && !string.IsNullOrEmpty(record.State))
                    State = record.State;
                if (string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(record.Title))
                    Title = record.Title;
                if (string.IsNullOrEmpty(Zip) && !string.IsNullOrEmpty(record.Zip))
                    Zip = record.Zip;
            }
            catch (Exception)
            {
                bResult = false;
            }

            return bResult;
        }

        public static bool operator >(SpecificDestinationActiveRecord a, SpecificDestinationActiveRecord b)
        {
            int aSpecificDestinationId, bSpecificDestinationId;
            if (int.TryParse(a.SpecificDestinationId, out aSpecificDestinationId) == false)
                throw new ArithmeticException(string.Format("Failed to parse {0} into integer", a.SpecificDestinationId));
            if (int.TryParse(b.SpecificDestinationId, out bSpecificDestinationId) == false)
                throw new ArithmeticException(string.Format("Failed to parse {0} into integer", b.SpecificDestinationId));

            return aSpecificDestinationId > bSpecificDestinationId;
        }

        public static bool operator <(SpecificDestinationActiveRecord a, SpecificDestinationActiveRecord b)
        {
            int aSpecificDestinationId, bSpecificDestinationId;
            if (int.TryParse(a.SpecificDestinationId, out aSpecificDestinationId) == false)
                throw new ArithmeticException(string.Format("Failed to parse {0} into integer", a.SpecificDestinationId));
            if (int.TryParse(b.SpecificDestinationId, out bSpecificDestinationId) == false)
                throw new ArithmeticException(string.Format("Failed to parse {0} into integer", b.SpecificDestinationId));

            return aSpecificDestinationId < bSpecificDestinationId;
        }

        public static bool operator !=(SpecificDestinationActiveRecord a, SpecificDestinationActiveRecord b)
        {
            int aSpecificDestinationId, bSpecificDestinationId;
            if (int.TryParse(a.SpecificDestinationId, out aSpecificDestinationId) == false)
                throw new ArithmeticException(string.Format("Failed to parse {0} into integer", a.SpecificDestinationId));
            if (int.TryParse(b.SpecificDestinationId, out bSpecificDestinationId) == false)
                throw new ArithmeticException(string.Format("Failed to parse {0} into integer", b.SpecificDestinationId));

            return aSpecificDestinationId != bSpecificDestinationId;
        }

        public static bool operator ==(SpecificDestinationActiveRecord a, SpecificDestinationActiveRecord b)
        {
            return !(a != b);
        }

        public bool Equals(SpecificDestinationActiveRecord other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            
            return this == other;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;

            return Equals(obj as SpecificDestinationActiveRecord);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode()*397) ^ (_validLobs != null ? _validLobs.GetHashCode() : 0);
            }
        }
    }
}
