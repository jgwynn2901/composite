/******************************************************************************
* Innovation First Notice 
* 140 Kendrick Street 
* Building A, Suite 300 
* Needham, MA 02494
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2011 by Innovation First Notice 
*
* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/LocationFromZip.cs 2     2/23/11 2:43p Pintoa $
******************************************************************************/

using System;

namespace DbClassLibrary
{
    public class LocationFromZip : DbBaseClass
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Values that represent eParmList. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private enum eParmList
        {
            LOCATION_CODE_ID = 0,
            STATE,
            FIPS,
            CITY,
            ZIP,
            COUNTY,
            LON,
            LAT,
            PRIMARY_LOC,
            COUNTRY,
            SEQ,
            UPLOAD_KEY,
            FILE_TRANS_LOG_ID,
            ISINSERT,
            ISUPDATE
        };

        #region Constructor
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public LocationFromZip() : this(String.Empty) { }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <param name="instance"> The instance. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public LocationFromZip(string instance)
            : base(instance)
        {
            _name = "UIFSEGMENT.ProcessLocationCodeSegment";

            _parameterNames = new[] {
                                    "p_nLocationCodeID",
                                    "p_nState",
                                    "p_nFips",
                                    "p_nCity",
                                    "p_nZip",
                                    "p_nCounty",
                                    "p_nLongitude",	                                      
                                    "p_nLatitude",
                                    "p_nPrimaryLocation",
                                    "p_nCountry",
                                    "p_nSequence",
                                    "p_nUploadKey",
                                    "p_nFileTranLogId",
                                    "p_nIsInsert",
                                    "p_nIsUpdate"};

            Initialize();
        }
        #endregion

        #region Initialize
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Initializes this object. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        protected override void Initialize()
        {
            ///////////////////////////////////////////////////
            /////LOCATION_CODE_ID
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Output,
                _parameterNames[(int)eParmList.LOCATION_CODE_ID], string.Empty, System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            ///// STATE
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.STATE], string.Empty, System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// FIPS
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.FIPS], string.Empty, System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// CITY
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.CITY], string.Empty, System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// ZIP
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.ZIP], string.Empty, System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// COUNTY
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.COUNTY], string.Empty, System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// LON
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.LON], string.Empty, System.Data.DbType.Double);
            ///////////////////////////////////////////////////
            ///// LAT
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.LAT], string.Empty, System.Data.DbType.Double);
            ///////////////////////////////////////////////////
            ///// PRIMARY_LOC
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.PRIMARY_LOC], string.Empty, System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// COUNTRY
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.COUNTRY], string.Empty, System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// SEQ
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.SEQ], string.Empty, System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            ///// UPLOAD_KEY
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.UPLOAD_KEY], string.Empty, System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// FILE_TRANS_LOG_ID
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)eParmList.FILE_TRANS_LOG_ID], string.Empty, System.Data.DbType.Int32);

            ///////////////////////////////////////////////////
            /////ISINSERT
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Output,
                 _parameterNames[(int)eParmList.ISINSERT], string.Empty, System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            /////ISUPDATE
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Output,
                _parameterNames[(int)eParmList.ISUPDATE], string.Empty, System.Data.DbType.Int32);
        }
        #endregion

        #region Location_Code_Id
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the identifier of the location code. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Location_Code_Id
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.LOCATION_CODE_ID]);
            }
        }
        #endregion

        #region State
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the state. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string State
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.STATE]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.STATE], value);
            }
        }
        #endregion

        #region Fips
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the fips. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Fips
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.FIPS]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.FIPS], value);
            }
        }
        #endregion

        #region City
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the city. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string City
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.CITY]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.CITY], value);
            }
        }
        #endregion

        #region Zip
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the zip. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Zip
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.ZIP]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.ZIP], value);
            }
        }
        #endregion

        #region County
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the county. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string County
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.COUNTY]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.COUNTY], value);
            }
        }
        #endregion

        #region Lon
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the lon. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Lon
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.LON]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.LON], value);
            }
        }
        #endregion

        #region Lat
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the lat. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Lat
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.LAT]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.LAT], value);
            }
        }
        #endregion

        #region Primary_Loc
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the primary location. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Primary_Loc
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.PRIMARY_LOC]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.PRIMARY_LOC], value);
            }
        }
        #endregion

        #region Country
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the country. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Country
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.COUNTRY]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.COUNTRY], value);
            }
        }
        #endregion

        #region Seq
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the sequence. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Seq
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.SEQ]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.SEQ], value);
            }
        }
        #endregion

        #region Upload_Key
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the upload key. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Upload_Key
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.UPLOAD_KEY]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.UPLOAD_KEY], value);
            }
        }
        #endregion

        #region File_Trans_Log_Id
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the file trans log. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string File_Trans_Log_Id
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.FILE_TRANS_LOG_ID]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.FILE_TRANS_LOG_ID], value);
            }
        }
        #endregion

        #region IsInsert
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the is insert. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string IsInsert
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.ISINSERT]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.ISINSERT], value);
            }
        }
        #endregion

        #region IsUpdate
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the is update. </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string IsUpdate
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.ISUPDATE]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.ISUPDATE], value);
            }
        }
        #endregion
    }
}

/*
 *
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/LocationFromZip.cs $ 
 * 
 * 2     2/23/11 2:43p Pintoa
 * prettified code.
 *
 */