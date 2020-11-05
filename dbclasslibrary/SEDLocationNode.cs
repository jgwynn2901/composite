#region Header
// ================================================================================
// Source File -- SEDLocationNode.cs
// 
// NAME: DbClassLibrary.SEDLocationNode.cs
// AUTHOR: Ashley A. Pinto
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// 
// © 2011 Innovation First Notice, http://www.firstnotice.com/
// 
// $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SEDLocationNode.cs 1     4/24/11 11:18p Pintoa $ 
// 
// COMMENT:
// ================================================================================
#endregion

using System.Runtime.InteropServices;

namespace DbClassLibrary
{
    [ComVisible(false)]
    public class SEDLocationNode : DbBaseClass
    {
        public SEDLocationNode()
            : base(string.Empty)
        {
        }

        public SEDLocationNode(string instance)
            : base(instance)
        {
            _name = "UIFSEGMENT.ProcessLocationNode";
            Initialize();
        }

        protected override void Initialize()
        {
            AddParm(System.Data.ParameterDirection.Output, "p_nLocationNodeId", string.Empty, System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Input, "p_nClientId", string.Empty, System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Input, "p_nLocationNode", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nName", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nAddress1", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nAddress2", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nCity", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nState", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nZip", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nCounty", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nCountry", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nPhone", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nAltPhone", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nCanAddClaims", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nActiveStartDate", string.Empty, System.Data.DbType.Date);
            AddParm(System.Data.ParameterDirection.Input, "p_nActiveEndDate", string.Empty, System.Data.DbType.Date);
            AddParm(System.Data.ParameterDirection.Input, "p_nActiveStatus", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nUploadKey", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nFileTranLogId", string.Empty, System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Output, "p_nIsInsert", string.Empty, System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Output, "p_nIsUpdate", string.Empty, System.Data.DbType.Int32);

        }

        public string LocationNodeId
        {
            get { return GetValue("p_nLocationNodeId"); }
        }

        public string ClientId
        {
            get { return GetValue("p_nClientId"); }
            set { SetValue("p_nClientId", value); }
        }

        public string LocationNode
        {
            get { return GetValue("p_nLocationNode"); }
            set { SetValue("p_nLocationNode", value); }
        }

        public string Name
        {
            get { return GetValue("p_nName"); }
            set { SetValue("p_nName", value); }
        }

        public string Address1
        {
            get { return GetValue("p_nAddress1"); }
            set { SetValue("p_nAddress1", value); }
        }

        public string Address2
        {
            get { return GetValue("p_nAddress2"); }
            set { SetValue("p_nAddress2", value); }
        }

        public string City
        {
            get { return GetValue("p_nCity"); }
            set { SetValue("p_nCity", value); }
        }

        public string State
        {
            get { return GetValue("p_nState"); }
            set { SetValue("p_nState", value); }
        }

        public string Zip
        {
            get { return GetValue("p_nZip"); }
            set { SetValue("p_nZip", value); }
        }

        public string County
        {
            get { return GetValue("p_nCounty"); }
            set { SetValue("p_nCounty", value); }
        }

        public string Country
        {
            get { return GetValue("p_nCountry"); }
            set { SetValue("p_nCountry", value); }
        }

        public string Phone
        {
            get { return GetValue("p_nPhone"); }
            set { SetValue("p_nPhone", value); }
        }

        public string AltPhone
        {
            get { return GetValue("p_nAltPhone"); }
            set { SetValue("p_nAltPhone", value); }
        }

        public string CanAddClaims
        {
            get { return GetValue("p_nCanAddClaims"); }
            set { SetValue("p_nCanAddClaims", value); }
        }

        public string ActiveStartDate
        {
            get { return GetValue("p_nActiveStartDate"); }
            set { SetValue("p_nActiveStartDate", value); }
        }

        public string ActiveEndDate
        {
            get { return GetValue("p_nActiveEndDate"); }
            set { SetValue("p_nActiveEndDate", value); }
        }

        public string ActiveStatus
        {
            get { return GetValue("p_nActiveStatus"); }
            set { SetValue("p_nActiveStatus", value); }
        }

        public string UploadKey
        {
            get { return GetValue("p_nUploadKey"); }
            set { SetValue("p_nUploadKey", value); }
        }

        public string FileTranLogId
        {
            get { return GetValue("p_nFileTranLogId"); }
            set { SetValue("p_nFileTranLogId", value); }
        }

        public string IsInsert
        {
            get { return GetValue("p_nIsInsert"); }
            set { SetValue("p_nIsInsert", value); }
        }

        public string IsUpdate
        {
            get { return GetValue("p_nIsUpdate"); }
            set { SetValue("p_nIsUpdate", value); }
        }

    }
}

/*
 *
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/SEDLocationNode.cs $ 
 * 
 * 1     4/24/11 11:18p Pintoa
 * Sedgwick SRS Location Node implementation.
 *
 */

