// ================================================================================
// Source File -- MdClaimArchive.cs
// 
// NAME: DbClassLibrary.MdClaimArchive.cs
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

using System.Runtime.InteropServices;

namespace DbClassLibrary
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Miami-Dade claim archive. </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [ComVisible(false)]
    public sealed class MdClaimArchive : DbBaseClass
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public MdClaimArchive() : base(string.Empty)
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public MdClaimArchive(string instance)
            : base(instance)
        {
            _name = "UIFSEGMENT.ProcessMiamidadeClaimArchive";
            Initialize();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Initializes this object. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        protected override void Initialize()
        {
            AddParm(System.Data.ParameterDirection.Output, "p_nMdClaimArchiveId", string.Empty, System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Input, "p_nMdClaimNumber", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nClaimantTaxId", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nClaimantFullname", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nAccidentDt", string.Empty, System.Data.DbType.Date);
            AddParm(System.Data.ParameterDirection.Input, "p_nUploadKey", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nFileTranLogId", string.Empty, System.Data.DbType.Int32);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the identifier of the md claim archive. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string MdClaimArchiveId
        {
            get { return GetValue("p_nMdClaimArchiveId"); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the md claim number. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string MdClaimNumber
        {
            get { return GetValue("p_nMdClaimNumber"); }
            set { SetValue("p_nMdClaimNumber", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the claimant tax. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string ClaimantTaxId
        {
            get { return GetValue("p_nClaimantTaxId"); }
            set { SetValue("p_nClaimantTaxId", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the claimant fullname. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string ClaimantFullname
        {
            get { return GetValue("p_nClaimantFullname"); }
            set { SetValue("p_nClaimantFullname", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the accident dt. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string AccidentDt
        {
            get { return GetValue("p_nAccidentDt"); }
            set { SetValue("p_nAccidentDt", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the upload key. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string UploadKey
        {
            get { return GetValue("p_nUploadKey"); }
            set { SetValue("p_nUploadKey", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the file tran log. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string FileTranLogId
        {
            get { return GetValue("p_nFileTranLogId"); }
            set { SetValue("p_nFileTranLogId", value); }
        }
    }
}