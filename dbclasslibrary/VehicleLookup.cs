// ================================================================================
// Source File -- VehicleLookup.cs
// 
// NAME: DbClassLibrary.VehicleLookup.cs
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
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Vehicle lookup. </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [ComVisible(false)]
    public sealed class VehicleLookup : DbBaseClass
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public VehicleLookup()
            : this(String.Empty)
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        /// <param name="instance"> The instance. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public VehicleLookup(string instance)
            : base(instance)
        {
            _name = "UIFSEGMENT.ProcessAutoMakeModel";
            Initialize();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Initializes this object. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        protected override void Initialize()
        {
            AddParm(System.Data.ParameterDirection.Output, "p_nAutoMakeModelId", string.Empty, System.Data.DbType.Int32);
            AddParm(System.Data.ParameterDirection.Input, "p_nYear", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nMake", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nModel", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nReferenceId", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nUploadKey", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nArchiveFlg", string.Empty, System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nFileTranLogId", string.Empty, System.Data.DbType.Int32);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the identifier of the automatic make model. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string AutoMakeModelId
        {
            get { return GetValue("p_nAutoMakeModelId"); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the year. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Year
        {
            get { return GetValue("p_nYear"); }
            set { SetValue("p_nYear", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the make. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Make
        {
            get { return GetValue("p_nMake"); }
            set { SetValue("p_nMake", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the model. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Model
        {
            get { return GetValue("p_nModel"); }
            set { SetValue("p_nModel", value); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the reference. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string ReferenceId
        {
            get { return GetValue("p_nReferenceId"); }
            set { SetValue("p_nReferenceId", value); }
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
        /// <summary>   Gets or sets the archive flg. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string ArchiveFlg
        {
            get { return GetValue("p_nArchiveFlg"); }
            set { SetValue("p_nArchiveFlg", value); }
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