﻿using System;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{
    [ComVisible(false)]
    public class ActiveGroupLocationLookup : ActiveRecord
    {
        private const string StrTableName = "GEORGIAPACIFIC_GROUPLOC_LOOKUP";

        public ActiveGroupLocationLookup()
            : base(StrTableName)
        {
            // Begin AutoGenerated Column Definitions
            columns.Add(new Column("DIVISION_NUMBER", String.Empty, "VARCHAR2"));
            columns.Add(new Column("LOCATION_NUMBER", String.Empty, "VARCHAR2"));
            columns.Add(new Column("PRIMARY_LOCATION", String.Empty, "CHAR"));
        }

        public ActiveGroupLocationLookup(IDataReader reader)
            : base(reader, StrTableName)
        {
        }

        public string DivisionNumber
        {
            get { return GetColumnValue("DIVISION_NUMBER"); }
            set { SetColumnValue("DIVISION_NUMBER", value); }
        }

        public string LocationNumber
        {
            get { return GetColumnValue("LOCATION_NUMBER"); }
            set { SetColumnValue("LOCATION_NUMBER", value); }
        }

        public string PrimaryLocation
        {
            get { return GetColumnValue("PRIMARY_LOCATION"); }
            set { SetColumnValue("PRIMARY_LOCATION", value); }
        }
    } ;


    [ComVisible(false)]
    public sealed class ActiveGroupLocationLookupSet : ActiveRecordSet
    {
        public ActiveGroupLocationLookupSet()
            : base("ActiveGroupLocationLookup")
        {
        }

        public override string Query
        {
            get
            {
                if (query.Length == 0)
                {
                    query = String.Format("select DIVISION_NUMBER, LOCATION_NUMBER, PRIMARY_LOCATION from GEORGIAPACIFIC_GROUPLOC_LOOKUP ORDER BY DIVISION_NUMBER, LOCATION_NUMBER, PRIMARY_LOCATION");
                }
                return query;
            }
        }
    }
}
