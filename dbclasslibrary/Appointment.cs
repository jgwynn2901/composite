#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Appointment.cs 7     1/05/10 10:52a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
    ///<summary>
    ///</summary>
	[ComVisible(false)]
	public class Appointment : DbBaseClass
    {

        #region Constructor
        ///<summary>
        ///</summary>
        public Appointment()
            : this(String.Empty)
        { }

        ///<summary>
        ///</summary>
        ///<param name="instance"></param>
        public Appointment(string instance)
            : base(instance)
        {
            _name = "DBCLASSLIBRARY.ProcessAppointment";

            _parameterNames = new[] {  "p_nAppointment_Id",
                                       "p_nEstar_Appraiser_Id",
                                       "p_nApptmtdate",
                                       "p_nDuration",
                                       "p_nTimeslots",
                                       "p_nDST",
                                       "p_nShiftUTC",
                                       "p_nTimezone"
            };

            Initialize();
        }
        #endregion
        #region Initialize
        /// <summary>
        /// Initialize
        /// </summary>
        protected override sealed void Initialize()
        {

            AddParm(System.Data.ParameterDirection.Output, "p_nAppointment_Id", "", System.Data.DbType.Int32);

            AddParm(System.Data.ParameterDirection.Input, "p_nEstar_Appraiser_Id", "", System.Data.DbType.Int32);

            AddParm(System.Data.ParameterDirection.Input, "p_nApptmtdate", "", System.Data.DbType.Date);

            AddParm(System.Data.ParameterDirection.Input, "p_nDuration", "", System.Data.DbType.Int32);

            //AddParm(System.Data.ParameterDirection.Input, "p_nTime", "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input, "p_nTimeslots", "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input, "p_nDST", "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input, "p_nShiftUTC", "", System.Data.DbType.Int32);

            AddParm(System.Data.ParameterDirection.Input, "p_nTimezone", "", System.Data.DbType.AnsiString);

            
            

        }
        #endregion

        #region AppointmentId
        ///<summary>
        ///</summary>
        public string AppointmentId
        {
            get
            {
                return GetValue("p_nAppointment_Id");
            }

        }
        #endregion

        #region EstarAppraiserId
        ///<summary>
        ///</summary>
        public string EstarAppraiserId
        {
            get
            {
                return GetValue("p_nEstar_Appraiser_Id");
            }
            set
            {
                SetValue("p_nEstar_Appraiser_Id", value);
            }
        }
        #endregion

        #region ApptmtDate
        ///<summary>
        ///</summary>
        public string ApptmtDate
        {
            get
            {
                return GetValue("p_nApptmtdate");
            }
            set
            {
                SetValue("p_nApptmtdate", value);
            }
        }
        #endregion

        #region Duration
        ///
        ///<summary>
        ///</summary>
        public string Duration
        {
            get
            {
                return GetValue("p_nDuration");
            }
            set
            {
                SetValue("p_nDuration", value);
            }
        }
        #endregion

        #region p_nTimeslots
        ///
        ///<summary>
        ///</summary>
        public string Timeslots
        {
            get
            {
                return GetValue("p_nTimeslots");
            }
            set
            {
                SetValue("p_nTimeslots", value);
            }
        }
        #endregion
        #region p_nDST
        ///
        ///<summary>
        ///</summary>
// ReSharper disable InconsistentNaming
       public string DST
// ReSharper restore InconsistentNaming
        {
            get
            {
                return GetValue("p_nDST");
            }
            set
            {
                SetValue("p_nDST", value);
            }
        }
        #endregion
        #region p_nShiftUTC
        ///
        ///<summary>
        ///</summary>
// ReSharper disable InconsistentNaming
        public string ShiftUTC
// ReSharper restore InconsistentNaming
        {
            get
            {
                return GetValue("p_nShiftUTC");
            }
            set
            {
                SetValue("p_nShiftUTC", value);
            }
        }
        #endregion

        #region p_nTimezone
        ///
        ///<summary>
        ///</summary>
        public string Timezone
        {
            get
            {
                return GetValue("p_nTimezone");
            }
            set
            {
                SetValue("p_nTimezone", value);
            }
        }
        #endregion
       
        #region Time
        //		public string Time
        //		{
        //			get
        //			{
        //				return GetValue("p_nTime");
        //			}
        //			set
        //			{
        //				SetValue("p_nTime", value);
        //			}
        //		}
        #endregion


    }
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Appointment.cs $
 * 
 * 7     1/05/10 10:52a John.gwynn
 * 
 * 6     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 5     2/13/08 10:23a Deepika.sharma
 * dms: added new data elements 
 * 
 * 4     2/12/08 2:39p Jenny.cheung
 * put in xml comments
 * 
 * 3     1/31/08 1:58p Deepika.sharma
 * dms: remove time , change date parameter
 * 
 * 2     12/06/07 11:12a Deepika.sharma
 * 
 * 1     11/27/07 2:28p Deepika.sharma
 */
#endregion
