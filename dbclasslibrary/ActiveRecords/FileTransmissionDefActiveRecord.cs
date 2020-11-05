using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{
    public class FileTransmissionDefActiveRecords : ActiveRecordSet<FileTransmissionDefActiveRecord>
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public FileTransmissionDefActiveRecords()
            : base("FileTransmissionDefActiveRecord")
        {
            Instance = DbBaseClass.SEDP;
        }
    }

    [ComVisible(false), TableDefinition(TableName = "FNSOWNER.FILE_TRANSMISSION_DEF")]
    public class FileTransmissionDefActiveRecord : ActiveRecord
    {
        public FileTransmissionDefActiveRecord()
            : base("FILE_TRANSMISSION_DEF")
        {
            columns.Add(new Column("FILE_TRANSMISSION_DEF_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("ACCNT_HRCY_STEP_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("DIRECTORY", string.Empty, "VARCHAR2"));
            columns.Add(new Column("SERVER", string.Empty, "VARCHAR2"));
            columns.Add(new Column("TYPE", string.Empty, "VARCHAR2"));
            columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
            columns.Add(new Column("LAST_LOAD_SEQUENCE", string.Empty, "NUMBER"));
            columns.Add(new Column("FILE_NAME_PATTERN", string.Empty, "VARCHAR2"));
            columns.Add(new Column("LOCATION_IDENTIFIER", string.Empty, "VARCHAR2"));
            columns.Add(new Column("DESCRIPTION", string.Empty, "VARCHAR2"));
            columns.Add(new Column("SEQUENCE", string.Empty, "NUMBER"));
            columns.Add(new Column("SOURCE_LOCATION", string.Empty, "VARCHAR2"));
            columns.Add(new Column("DESTINATION_UIF_LOCATION", string.Empty, "VARCHAR2"));
            columns.Add(new Column("FROI_IMP_RECORD_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("REPORT_TYPE", string.Empty, "NUMBER"));
        }

        public FileTransmissionDefActiveRecord(IDataReader reader)
            : base(reader, "FILE_TRANSMISSION_DEF")
        { }

        public string FileTransmissionDefId
        {
            get { return GetColumnValue("FILE_TRANSMISSION_DEF_ID"); }
            set { SetColumnValue("FILE_TRANSMISSION_DEF_ID", value); }
        }
        public string AccntHrcyStepId
        {
            get { return GetColumnValue("ACCNT_HRCY_STEP_ID"); }
            set { SetColumnValue("ACCNT_HRCY_STEP_ID", value); }
        }
        public string Directory
        {
            get { return GetColumnValue("DIRECTORY"); }
            set { SetColumnValue("DIRECTORY", value); }
        }
        public string Server
        {
            get { return GetColumnValue("SERVER"); }
            set { SetColumnValue("SERVER", value); }
        }
        public string Type
        {
            get { return GetColumnValue("TYPE"); }
            set { SetColumnValue("TYPE", value); }
        }
        public string CreatedDt
        {
            get { return GetColumnValue("CREATED_DT"); }
            set { SetColumnValue("CREATED_DT", value); }
        }
        public string LastLoadSequence
        {
            get { return GetColumnValue("LAST_LOAD_SEQUENCE"); }
            set { SetColumnValue("LAST_LOAD_SEQUENCE", value); }
        }
        public string FileNamePattern
        {
            get { return GetColumnValue("FILE_NAME_PATTERN"); }
            set { SetColumnValue("FILE_NAME_PATTERN", value); }
        }
        public string LocationIdentifier
        {
            get { return GetColumnValue("LOCATION_IDENTIFIER"); }
            set { SetColumnValue("LOCATION_IDENTIFIER", value); }
        }
        public string Description
        {
            get { return GetColumnValue("DESCRIPTION"); }
            set { SetColumnValue("DESCRIPTION", value); }
        }
        public string Sequence
        {
            get { return GetColumnValue("SEQUENCE"); }
            set { SetColumnValue("SEQUENCE", value); }
        }
        public string SourceLocation
        {
            get { return GetColumnValue("SOURCE_LOCATION"); }
            set { SetColumnValue("SOURCE_LOCATION", value); }
        }
        public string DestinationUifLocation
        {
            get { return GetColumnValue("DESTINATION_UIF_LOCATION"); }
            set { SetColumnValue("DESTINATION_UIF_LOCATION", value); }
        }
        public string FroiImpRecordId
        {
            get { return GetColumnValue("FROI_IMP_RECORD_ID"); }
            set { SetColumnValue("FROI_IMP_RECORD_ID", value); }
        }
        public string ReportType
        {
            get { return GetColumnValue("REPORT_TYPE"); }
            set { SetColumnValue("REPORT_TYPE", value); }
        }

    }
}
