using System.Data;
using System.Runtime.Serialization;
#region File Header
/**************************************************************************
 * Innovation First Notice
 * Proprietary Source Code -- Distribution restricted
 * Copyright (c) 2011 by Innovation Group
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ActiveRecords/PerformanceData.cs 1     5/10/11 5:51p Gwynnj $ */
#endregion

namespace DbClassLibrary.ActiveRecords
{
    [DataContract]
    public sealed class PerformanceData : ActiveRecord
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceData"/> class.
        /// </summary>
        public PerformanceData()
            : base("PERF_DATA")
        {
            columns.Add(new Column("PERF_DATA_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("SERVER", string.Empty, "VARCHAR2"));
            columns.Add(new Column("USER_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("CALL_ID", string.Empty, "NUMBER"));
            columns.Add(new Column("COMPONENT", string.Empty, "VARCHAR2"));
            columns.Add(new Column("METHOD", string.Empty, "VARCHAR2"));
            columns.Add(new Column("START_TIME", string.Empty, "DATE"));
            columns.Add(new Column("END_TIME", string.Empty, "DATE"));
            columns.Add(new Column("FRAME_NAME", string.Empty, "VARCHAR2"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceData"/> class.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public PerformanceData(IDataReader reader)
            : base(reader, "PERF_DATA")
        { }

        #endregion

        /// <summary>
        /// Updates the performance record with the end time.
        /// </summary>
        static public bool Touch (int id)
        {
            return new PerformanceData { Id = id }.Update();
        }

        protected override string GenerateInsertSql()
        {
            if (Id == 0)
                SetColumnValue("PERF_DATA_ID", GetNextSequence());

            return base.GenerateInsertSql();
        }

        protected override string GenerateUpdateSql()
        {
            return "update PERF_DATA set END_TIME = sysdate where PERF_DATA_ID = :id";
        }

        protected override void AddUpdateParameters()
        {
            AddParameter("id", Id);
        }

        #region Id
        /// <summary>
        /// PERF_DATA_ID
        /// </summary>
        [DataMember]
        public int Id
        {
            get { return GetColumnValueAsInt("PERF_DATA_ID") ?? 0; }
            set { SetColumnValue("PERF_DATA_ID", value.ToString()); }
        }
        #endregion

        #region Server
        /// <summary>
        /// SERVER
        /// </summary>
        [DataMember]
        public string Server
        {

            get { return GetColumnValue("SERVER"); }
            set { SetColumnValue("SERVER", value); }
        }
        #endregion

        #region UserId
        /// <summary>
        /// USER_ID
        /// </summary>
        [DataMember]
        public int UserId
        {

            get { return GetColumnValueAsInt("USER_ID") ?? 0; }
            set { SetColumnValue("USER_ID", value.ToString()); }
        }
        #endregion

        #region CallId
        /// <summary>
        /// CALL_ID
        /// </summary>
        [DataMember]
        public int CallId
        {

            get { return GetColumnValueAsInt("CALL_ID") ?? 0; }
            set { SetColumnValue("CALL_ID", value.ToString()); }
        }
        #endregion

        #region Component
        /// <summary>
        /// COMPONENT
        /// </summary>
        [DataMember]
        public string Component
        {

            get { return GetColumnValue("COMPONENT"); }
            set { SetColumnValue("COMPONENT", value); }
        }
        #endregion

        #region Method
        /// <summary>
        /// METHOD
        /// </summary>
        [DataMember]
        public string Method
        {

            get { return GetColumnValue("METHOD"); }
            set { SetColumnValue("METHOD", value); }
        }
        #endregion

        #region StartTime
        /// <summary>
        /// START_TIME
        /// </summary>
        public string StartTime
        {

            get { return GetColumnValue("START_TIME"); }
            set { SetColumnValue("START_TIME", value); }
        }
        #endregion

        #region EndTime
        /// <summary>
        /// END_TIME
        /// </summary>
        public string EndTime
        {

            get { return GetColumnValue("END_TIME"); }
            set { SetColumnValue("END_TIME", value); }
        }
        #endregion

        #region FrameName
        /// <summary>
        /// FRAME_NAME
        /// </summary>
        [DataMember]
        public string FrameName
        {

            get { return GetColumnValue("FRAME_NAME"); }
            set { SetColumnValue("FRAME_NAME", value); }
        }
        #endregion

    }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ActiveRecords/PerformanceData.cs $
 * 
 * 1     5/10/11 5:51p Gwynnj
 */
#endregion