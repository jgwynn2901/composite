﻿// ================================================================================
// Source File -- $itemname$.cs
// 
// NAME: DbClassLibrary.$itemname$.cs
// AUTHOR: Ashley A. Pinto
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// 
// © 2010 Innovation First Notice, http://www.firstnotice.com/
// 
// DATE: $time$
// VERSION: $clrversion$
// 
// COMMENT:
// ================================================================================


using System;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
    [ComVisible(false)]
    public class EsisFacilityCdLookup : ActiveRecord
    {
        private const string StrTableName = "ESIS_FACILITYCD_REFERENCE";

        public EsisFacilityCdLookup()
            : base(StrTableName)
        {
            // Begin AutoGenerated Column Definitions
            columns.Add(new Column("HR_FACILITY_CD", String.Empty, "VARCHAR2"));
            columns.Add(new Column("HR_COSTCENTER_CD", String.Empty, "VARCHAR2"));
            columns.Add(new Column("ESIS_FACILITY_CD", String.Empty, "VARCHAR2"));
        }

        public EsisFacilityCdLookup(IDataReader reader)
            : base(reader, StrTableName)
        {
        }

        public string HrFacilityCd
        {
            get { return GetColumnValue("HR_FACILITY_CD"); }
            set { SetColumnValue("HR_FACILITY_CD", value); }
        }

        public string HrCostCenterCd
        {
            get { return GetColumnValue("HR_COSTCENTER_CD"); }
            set { SetColumnValue("HR_COSTCENTER_CD", value); }
        }

        public string EsisFacilityCd
        {
            get { return GetColumnValue("ESIS_FACILITY_CD"); }
            set { SetColumnValue("ESIS_FACILITY_CD", value); }
        }
    } ;

    [ComVisible(false)]
    public sealed class EsisFacilityCdLookupSet : ActiveRecordSet
    {
        public EsisFacilityCdLookupSet()
            : base("EsisFacilityCdLookup")
        {
            ClientCode = "843";
        }

        public string ClientCode { get; set; }
        public override string Query
        {
            get
            {
                if (query.Length == 0)
                {
                    query = String.Format("select HR_FACILITY_CD, HR_COSTCENTER_CD, ESIS_FACILITY_CD from ESIS_FACILITYCD_REFERENCE WHERE CLIENT_CD = '{0}' AND ARCHIVED_FLG = 'N' ORDER BY HR_FACILITY_CD, HR_COSTCENTER_CD", ClientCode);
                }
                return query;
            }
        }
    }
}