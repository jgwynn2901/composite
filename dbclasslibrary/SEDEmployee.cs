#region Header
/**************************************************************************
 * Source File -- SEDEmployee.cs
 * 
 * NAME: DbClassLibrary.SEDEmployee.cs
 * AUTHOR: Pintoa

 * Innovation First Notice
 * 140 Kendrick Street 
 * Building A, Suite 300 
 * Needham, MA 02494
 * (617) 886-2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2012 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SEDEmployee.cs 1     4/26/12 6:51p Pintoa $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
    [ComVisible(false)]
    // ReSharper disable InconsistentNaming
    public class SEDEmployee : DbBaseClass
    // ReSharper restore InconsistentNaming
    {
        private enum eParmList
        {
            EmployeeId = 0,
            AhsId,
            Ssn,
            FirstName,
            LastName,
            MiddleInitial,
            Title,
            Address1,
            Address2,
            City,
            State,
            Zip,
            Country,
            Phone,
            ClientNumber,
            FilingState,
            TotalDependents,
            Dep18Under,
            DateOfBirth,
            Gender,
            MaritalStatus,
            ReportingUnit,
            Department,
            Status,
            DateOfHire,
            JobCode,
            JobTitle,
            EmployeeCode,
            WageFrequency,
            UploadKey,
            TestFlag,
            SupervisorFirstName,
            SupervisorLastName,
            SupervisorPhone,
            NcciJobClass,
            HourlyWage,
            AnnualSalary,
            MonthlyWage,
            DailyWage,
            PaidForOvertime,
            WorkPhone,
            TerminateDate,
            CostCenterId,
            EmploymentStatus,
            SpecialId,
            UnionCode,
            FileTranLogId,
            TelecommuterFlg,
            SupervisorEmail,
            CloseDate,
            FlsaStatus,
            RecordActive
        };

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCsaaVendorNetwork"/> class.
        /// </summary>
        public SEDEmployee() : this(String.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCsaaVendorNetwork"/> class.
        /// </summary>
        /// <param name="instance"></param>
        public SEDEmployee(string instance)
            : base(instance)
        {
            _name = "UIFSEGMENT.ProcessSEDEmployee";

            _parameterNames = new[] {
										"p_nEmployeeID",
										"p_nAHSID",
										"p_nSSN",
										"p_nNameFirst",
										"p_nNameLast",
										"p_nNameMid",
										"p_nTitle",
										"p_nAddress1",
										"p_nAddress2",
										"p_nCity",
										"p_nState",
										"p_nZip",
										"p_nCountry",
										"p_nPhone",
										"p_nClientNumber",
										"p_nFilingState",
										"p_nTotalDependents",
										"p_nDep18Under",
										"p_nDateOfBirth",
										"p_nGENDER",
										"p_nMARITAL_STATUS",
										"p_nREPORTING_UNIT",
										"p_nDEPARTMENT",
										"p_nSTATUS",
										"p_nDATE_OF_HIRE",
										"p_nJOB_CODE",
										"p_nJOB_TITLE",
										"p_nEMPLOYEE_CODE",
										"p_nWAGE_FREQUENCY",
										"p_nUploadKey",
										"p_nTEST_FLG",
										"p_nSupervisorNameFirst",
										"p_nSupervisorNameLast",
										"p_nSupervisorPhone",
										"p_nNCCIJobClass",
										"p_nHourlyWage",
										"p_nAnnualSalary",
										"p_nMonthlyWage",
										"p_nDailyWage",
										"p_nPaidForOvertime",
										"p_nWorkPhone",
										"p_nTerminateDate",
										"p_nCostCenterID",
										"p_nEmploymentStatus",
										"p_nSpecialID",
										"p_nUnionCode",
										"p_nFileTranLogID",
										"p_nTelecommuterFlg",
										"p_nSupervisorEmail",
										"p_nCloseDate",
										"p_nFLSAStatus",
                                        "p_nRecordActive"                                        
            };

            Initialize();
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        protected override sealed void Initialize()
        {
            ///////////////////////////////////////////////////
            /////EmployeeId
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Output, _parameterNames[(int)eParmList.EmployeeId], "", System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            ///// AhsId
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.AhsId], "", System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            ///// Ssn
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Ssn], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// FirstName
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.FirstName], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// LastName
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.LastName], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// MiddleInitial
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.MiddleInitial], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// Title
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Title], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// Address1
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Address1], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// Address2
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Address2], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// City
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.City], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// State
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.State], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// Zip
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Zip], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// Country
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Country], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// Phone
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Phone], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// ClientNumber
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.ClientNumber], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// FilingState
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.FilingState], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// TotalDependents
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.TotalDependents], "", System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            ///// Dep18Under
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Dep18Under], "", System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            ///// DateOfBirth
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.DateOfBirth], "", System.Data.DbType.Date);
            ///////////////////////////////////////////////////
            ///// Gender
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Gender], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// MaritalStatus
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.MaritalStatus], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// ReportingUnit
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.ReportingUnit], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// Department
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Department], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// Status
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.Status], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// DateOfHire
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.DateOfHire], "", System.Data.DbType.Date);
            ///////////////////////////////////////////////////
            ///// JobCode
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.JobCode], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// JobTitle
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.JobTitle], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// EmployeeCode
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.EmployeeCode], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// WageFrequency
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.WageFrequency], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// UploadKey
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.UploadKey], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// TestFlag
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.TestFlag], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// SupervisorFirstName
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.SupervisorFirstName], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// SupervisorLastName
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.SupervisorLastName], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// SupervisorPhone
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.SupervisorPhone], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// NcciJobClass
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.NcciJobClass], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// HourlyWage
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.HourlyWage], "", System.Data.DbType.Double);
            ///////////////////////////////////////////////////
            ///// AnnualSalary
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.AnnualSalary], "", System.Data.DbType.Double);
            ///////////////////////////////////////////////////
            ///// MonthlyWage
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.MonthlyWage], "", System.Data.DbType.Double);
            ///////////////////////////////////////////////////
            ///// DailyWage
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.DailyWage], "", System.Data.DbType.Double);
            ///////////////////////////////////////////////////
            ///// PaidForOvertime
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.PaidForOvertime], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// WorkPhone
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.WorkPhone], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// TerminateDate
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.TerminateDate], "", System.Data.DbType.Date);
            ///////////////////////////////////////////////////
            ///// CostCenterId
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.CostCenterId], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// EmploymentStatus
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.EmploymentStatus], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// SpecialId
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.SpecialId], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// UnionCode
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.UnionCode], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// FileTranLogId
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.FileTranLogId], "", System.Data.DbType.Int32);
            ///////////////////////////////////////////////////
            ///// TelecommuterFlg
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.TelecommuterFlg], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// SupervisorEmail
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.SupervisorEmail], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// CloseDate
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.CloseDate], "", System.Data.DbType.Date);
            ///////////////////////////////////////////////////
            ///// FlsaStatus
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.FlsaStatus], "", System.Data.DbType.AnsiString);
            ///////////////////////////////////////////////////
            ///// RecordActive
            ///////////////////////////////////////////////////
            AddParm(System.Data.ParameterDirection.Input, _parameterNames[(int)eParmList.RecordActive], "Y", System.Data.DbType.AnsiString);
        }
        #endregion
        #region Id
        /// <summary>
        /// Gets the id.
        /// </summary>
        /// <value>The id.</value>
        public string Id
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.EmployeeId]);
            }
        }
        #endregion
        #region AhsId
        /// <summary>
        /// Gets or sets the ahs id.
        /// </summary>
        /// <value>The ahs id.</value>
        public string AhsId
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.AhsId]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.AhsId], value);
            }
        }
        #endregion
        #region Ssn
        /// <summary>
        /// Gets or sets the SSN.
        /// </summary>
        /// <value>The SSN.</value>
        public string Ssn
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Ssn]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Ssn], value);
            }
        }
        #endregion
        #region FirstName
        /// <summary>
        /// Gets or sets the name of the first.
        /// </summary>
        /// <value>The name of the first.</value>
        public string FirstName
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.FirstName]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.FirstName], value);
            }
        }
        #endregion
        #region LastName
        /// <summary>
        /// Gets or sets the name of the last.
        /// </summary>
        /// <value>The name of the last.</value>
        public string LastName
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.LastName]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.LastName], value);
            }
        }
        #endregion
        #region MiddleInitial
        /// <summary>
        /// Gets or sets the middle initial.
        /// </summary>
        /// <value>The middle initial.</value>
        public string MiddleInitial
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.MiddleInitial]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.MiddleInitial], value);
            }
        }
        #endregion
        #region Title
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Title]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Title], value);
            }
        }
        #endregion
        #region Address1
        /// <summary>
        /// Gets or sets the address1.
        /// </summary>
        /// <value>The address1.</value>
        public string Address1
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Address1]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Address1], value);
            }
        }
        #endregion
        #region Address2
        /// <summary>
        /// Gets or sets the address2.
        /// </summary>
        /// <value>The address2.</value>
        public string Address2
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Address2]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Address2], value);
            }
        }
        #endregion
        #region City
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.City]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.City], value);
            }
        }
        #endregion
        #region State
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.State]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.State], value);
            }
        }
        #endregion
        #region Zip
        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>The zip.</value>
        public string Zip
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Zip]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Zip], value);
            }
        }
        #endregion
        #region Country
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        public string Country
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Country]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Country], value);
            }
        }
        #endregion
        #region Phone
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>The phone.</value>
        public string Phone
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Phone]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Phone], value);
            }
        }
        #endregion
        #region ClientNumber
        /// <summary>
        /// Gets or sets the client number.
        /// </summary>
        /// <value>The client number.</value>
        public string ClientNumber
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.ClientNumber]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.ClientNumber], value);
            }
        }
        #endregion
        #region FilingState
        /// <summary>
        /// Gets or sets the state of the filing.
        /// </summary>
        /// <value>The state of the filing.</value>
        public string FilingState
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.FilingState]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.FilingState], value);
            }
        }
        #endregion
        #region LastName
        /// <summary>
        /// Gets or sets the total dependents.
        /// </summary>
        /// <value>The total dependents.</value>
        public string TotalDependents
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.TotalDependents]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.TotalDependents], value);
            }
        }
        #endregion
        #region Dep18Under
        /// <summary>
        /// Gets or sets the dep18 under.
        /// </summary>
        /// <value>The dep18 under.</value>
        public string Dep18Under
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Dep18Under]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Dep18Under], value);
            }
        }
        #endregion
        #region DateOfBirth
        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>The date of birth.</value>
        public string DateOfBirth
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.DateOfBirth]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.DateOfBirth], value);
            }
        }
        #endregion
        #region Gender
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>The gender.</value>
        public string Gender
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Gender]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Gender], value);
            }
        }
        #endregion
        #region MaritalStatus
        /// <summary>
        /// Gets or sets the marital status.
        /// </summary>
        /// <value>The marital status.</value>
        public string MaritalStatus
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.MaritalStatus]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.MaritalStatus], value);
            }
        }
        #endregion
        #region ReportingUnit
        /// <summary>
        /// Gets or sets the reporting unit.
        /// </summary>
        /// <value>The reporting unit.</value>
        public string ReportingUnit
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.ReportingUnit]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.ReportingUnit], value);
            }
        }
        #endregion
        #region Department
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>The department.</value>
        public string Department
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Department]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Department], value);
            }
        }
        #endregion
        #region Status
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public string Status
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.Status]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.Status], value);
            }
        }
        #endregion
        #region DateOfHire
        /// <summary>
        /// Gets or sets the date of hire.
        /// </summary>
        /// <value>The date of hire.</value>
        public string DateOfHire
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.DateOfHire]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.DateOfHire], value);
            }
        }
        #endregion
        #region JobCode
        /// <summary>
        /// Gets or sets the job code.
        /// </summary>
        /// <value>The job code.</value>
        public string JobCode
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.JobCode]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.JobCode], value);
            }
        }
        #endregion
        #region JobTitle
        /// <summary>
        /// Gets or sets the job title.
        /// </summary>
        /// <value>The job title.</value>
        public string JobTitle
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.JobTitle]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.JobTitle], value);
            }
        }
        #endregion
        #region EmployeeCode
        /// <summary>
        /// Gets or sets the employee code.
        /// </summary>
        /// <value>The employee code.</value>
        public string EmployeeCode
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.EmployeeCode]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.EmployeeCode], value);
            }
        }
        #endregion
        #region WageFrequency
        /// <summary>
        /// Gets or sets the wage frequency.
        /// </summary>
        /// <value>The wage frequency.</value>
        public string WageFrequency
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.WageFrequency]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.WageFrequency], value);
            }
        }
        #endregion
        #region Status
        /// <summary>
        /// Gets or sets the upload key.
        /// </summary>
        /// <value>The upload key.</value>
        public string UploadKey
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.UploadKey]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.UploadKey], value);
            }
        }
        #endregion
        #region TestFlag
        /// <summary>
        /// Gets or sets the test flag.
        /// </summary>
        /// <value>The test flag.</value>
        public string TestFlag
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.TestFlag]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.TestFlag], value);
            }
        }
        #endregion
        #region SupervisorFirstName
        /// <summary>
        /// Gets or sets the name of the supervisor first.
        /// </summary>
        /// <value>The name of the supervisor first.</value>
        public string SupervisorFirstName
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.SupervisorFirstName]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.SupervisorFirstName], value);
            }
        }
        #endregion
        #region SupervisorLastName
        /// <summary>
        /// Gets or sets the name of the supervisor last.
        /// </summary>
        /// <value>The name of the supervisor last.</value>
        public string SupervisorLastName
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.SupervisorLastName]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.SupervisorLastName], value);
            }
        }
        #endregion
        #region SupervisorPhone
        /// <summary>
        /// Gets or sets the supervisor phone.
        /// </summary>
        /// <value>The supervisor phone.</value>
        public string SupervisorPhone
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.SupervisorPhone]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.SupervisorPhone], value);
            }
        }
        #endregion
        #region NcciJobClass
        /// <summary>
        /// Gets or sets the ncci job class.
        /// </summary>
        /// <value>The ncci job class.</value>
        public string NcciJobClass
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.NcciJobClass]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.NcciJobClass], value);
            }
        }
        #endregion
        #region HourlyWage
        /// <summary>
        /// Gets or sets the hourly wage.
        /// </summary>
        /// <value>The hourly wage.</value>
        public string HourlyWage
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.HourlyWage]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.HourlyWage], value);
            }
        }
        #endregion
        #region AnnualSalary
        /// <summary>
        /// Gets or sets the annual salary.
        /// </summary>
        /// <value>The annual salary.</value>
        public string AnnualSalary
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.AnnualSalary]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.AnnualSalary], value);
            }
        }
        #endregion
        #region MonthlyWage
        /// <summary>
        /// Gets or sets the monthly wage.
        /// </summary>
        /// <value>The monthly wage.</value>
        public string MonthlyWage
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.MonthlyWage]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.MonthlyWage], value);
            }
        }
        #endregion
        #region DailyWage
        /// <summary>
        /// Gets or sets the daily wage.
        /// </summary>
        /// <value>The daily wage.</value>
        public string DailyWage
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.DailyWage]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.DailyWage], value);
            }
        }
        #endregion
        #region PaidForOvertime
        /// <summary>
        /// Gets or sets the paid for overtime.
        /// </summary>
        /// <value>The paid for overtime.</value>
        public string PaidForOvertime
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.PaidForOvertime]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.PaidForOvertime], value);
            }
        }
        #endregion
        #region WorkPhone
        /// <summary>
        /// Gets or sets the work phone.
        /// </summary>
        /// <value>The work phone.</value>
        public string WorkPhone
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.WorkPhone]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.WorkPhone], value);
            }
        }
        #endregion
        #region TerminateDate
        /// <summary>
        /// Gets or sets the terminate date.
        /// </summary>
        /// <value>The terminate date.</value>
        public string TerminateDate
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.TerminateDate]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.TerminateDate], value);
            }
        }
        #endregion
        #region CostCenterId
        /// <summary>
        /// Gets or sets the cost center id.
        /// </summary>
        /// <value>The cost center id.</value>
        public string CostCenterId
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.CostCenterId]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.CostCenterId], value);
            }
        }
        #endregion
        #region EmploymentStatus
        /// <summary>
        /// Gets or sets the employment status.
        /// </summary>
        /// <value>The employment status.</value>
        public string EmploymentStatus
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.EmploymentStatus]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.EmploymentStatus], value);
            }
        }
        #endregion
        #region SpecialId
        /// <summary>
        /// Gets or sets the special id.
        /// </summary>
        /// <value>The special id.</value>
        public string SpecialId
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.SpecialId]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.SpecialId], value);
            }
        }
        #endregion
        #region UnionCode
        /// <summary>
        /// Gets or sets the union code.
        /// </summary>
        /// <value>The union code.</value>
        public string UnionCode
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.UnionCode]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.UnionCode], value);
            }
        }
        #endregion
        #region FileTranLogId
        /// <summary>
        /// Gets or sets the file tran log id.
        /// </summary>
        /// <value>The file tran log id.</value>
        public string FileTranLogId
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.FileTranLogId]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.FileTranLogId], value);
            }
        }
        #endregion
        #region TelecommuterFlg
        /// <summary>
        /// Gets or sets the telecommuter FLG.
        /// </summary>
        /// <value>The telecommuter FLG.</value>
        public string TelecommuterFlg
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.TelecommuterFlg]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.TelecommuterFlg], value);
            }
        }
        #endregion
        #region SupervisorEmail
        /// <summary>
        /// Gets or sets the supervisor email.
        /// </summary>
        /// <value>The supervisor email.</value>
        public string SupervisorEmail
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.SupervisorEmail]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.SupervisorEmail], value);
            }
        }
        #endregion
        #region CloseDate
        /// <summary>
        /// Gets or sets the close date.
        /// </summary>
        /// <value>The close date.</value>
        public string CloseDate
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.CloseDate]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.CloseDate], value);
            }
        }
        #endregion
        #region FlsaStatus
        /// <summary>
        /// Gets or sets the flsa status.
        /// </summary>
        /// <value>The flsa status.</value>
        public string FlsaStatus
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.FlsaStatus]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.FlsaStatus], value);
            }
        }
        #endregion
        #region RecordActive
        /// <summary>
        /// Gets or sets the employee status.
        /// </summary>
        /// <value>The employee status.</value>
        public string RecordActive
        {
            get
            {
                return GetValue(_parameterNames[(int)eParmList.RecordActive]);
            }
            set
            {
                SetValue(_parameterNames[(int)eParmList.RecordActive], value);
            }
        }
        #endregion
    }
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/SEDEmployee.cs $ 
 * 
 * 1     4/26/12 6:51p Pintoa
 * Sedgwick Employee Parser implementation.
 * 
*/
#endregion
