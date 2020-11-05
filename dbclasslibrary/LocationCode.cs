#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2006 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/LocationCode.cs 8     10/12/09 5:42p John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for ANI LocationCode (Alaska National Client).
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class LocationCode : DbBaseClass
	{
		private enum ParmList 
		{
			LocationCodeId = 0,
            AccountNumber,
			AhsId,
			CodingValue1,
			CodingDesc1,
            CodingValue2,
            CodingDesc2,
            CodingValue3,
            CodingDesc3,
            CodingValue4,
            CodingDesc4,
            CodingValue5,
            CodingDesc5,
            UploadKey,
			FileTransmissionLogId,
            Type1,
            Type2,
            Type3,
            Type4,
            Type5,
            LastCodeValue,
            LastCodeDescription
			
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationCode"/> class.
		/// </summary>
		public LocationCode():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationUser"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public LocationCode(string instance) :base(instance)
		{
			_name = "DbClassLibrary.ProcessANI_LocationCode";

			_parameterNames = new[] 
											{
												"p_nANI_LocationCodeID",
												"p_nAccountNumber",
                                                "p_nAHSID",
												"p_nCodingValue1",
												"p_nCodingDesc1",
												"p_nCodingValue2",
												"p_nCodingDesc2",
												"p_nCodingValue3",
                                                "p_nCodingDesc3",
                                                "p_nCodingValue4",
                                                "p_nCodingDesc4",
                                                "p_nCodingValue5",
                                                "p_nCodingDesc5",
                                                "p_nUploadKey",
                                                "p_nFileTranLogId",
                                                "p_nType1",
                                                "p_nType2",
                                                "p_nType3",
                                                "p_nType4",
                                                "p_nType5",
                                                "p_nLastCodeValue",
                                                "p_nLastCodeDescription"
											};
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
		
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)ParmList.LocationCodeId],"",System.Data.DbType.Int32);
		
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.AccountNumber],"",System.Data.DbType.AnsiString);
           
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)ParmList.FileTransmissionLogId], "", System.Data.DbType.Int32);

            AddParm(System.Data.ParameterDirection.Input,
               _parameterNames[(int)ParmList.UploadKey], "", System.Data.DbType.AnsiString);
			
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.AhsId],"",System.Data.DbType.Int32);
		
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.CodingValue1],"",System.Data.DbType.AnsiString);
		
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.CodingDesc1],"",System.Data.DbType.AnsiString);
			
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.CodingValue2],"",System.Data.DbType.AnsiString);
			
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.CodingDesc2],"",System.Data.DbType.AnsiString);
	
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.CodingValue3],"",System.Data.DbType.AnsiString);
		
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.CodingDesc3],"",System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)ParmList.CodingValue4], "", System.Data.DbType.AnsiString);
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)ParmList.CodingDesc4], "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)ParmList.CodingValue5], "", System.Data.DbType.AnsiString);
     
            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)ParmList.CodingDesc5], "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)ParmList.Type1], "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
                _parameterNames[(int)ParmList.Type2], "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
               _parameterNames[(int)ParmList.Type3], "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
               _parameterNames[(int)ParmList.Type4], "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
               _parameterNames[(int)ParmList.Type5], "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
               _parameterNames[(int)ParmList.LastCodeValue], "", System.Data.DbType.AnsiString);

            AddParm(System.Data.ParameterDirection.Input,
               _parameterNames[(int)ParmList.LastCodeDescription], "", System.Data.DbType.AnsiString);
		
		}
	
		#endregion
	
		#region Public Properties
		
	/// <summary>
	/// Gets the cra ncci class code id.
	/// </summary>
	/// <value>The cra ncci class code id.</value>
	public string  LocationCodeId 
    {
	    get 
            {
            return GetValue((int)ParmList.LocationCodeId);
        
        //string result = GetValue((int) eParmList.LocationCodeId);
	//return result.Length > 0 ? Convert.ToInt32(result): -1;
          }
    }
	/// <summary>
	/// Gets or sets the ahs id.
	/// </summary>
	/// <value>The ahs id.</value>
	public string AhsId
{
	get 
{
	return GetValue((int)ParmList.AhsId);
}
	set 
{
	SetValue((int)ParmList.AhsId,value);
}
}
	/// <summary>
	/// Gets or sets the lob code.
	/// </summary>
	/// <value>The lob code.</value>
	public string AccountNumber
{
	get 
{
	return GetValue((int)ParmList.AccountNumber);
}
	set 
{
	SetValue((int)ParmList.AccountNumber,value);
}
}
	/// <summary>
	/// Gets or sets the Client Code.
	/// </summary>
	/// <value>The Client code.</value>
	public string CodingValue1
{
	get 
{
	return GetValue((int)ParmList.CodingValue1);
}
	set 
{
	SetValue((int)ParmList.CodingValue1,value);
}
}

/// <summary>
/// Gets or sets the coding desc1.
/// </summary>
/// <value>The coding desc1.</value>
	public string CodingDesc1
{
	get 
{
	return GetValue((int)ParmList.CodingDesc1);
}
	set 
{
	SetValue((int)ParmList.CodingDesc1,value);
}
}

/// <summary>
/// Gets or sets the coding value2.
/// </summary>
/// <value>The coding value2.</value>
	public string CodingValue2
{
	get 
{
	return GetValue((int)ParmList.CodingValue2);
}
	set 
{
	SetValue((int)ParmList.CodingValue2,value);
}
}

/// <summary>
/// Gets or sets the coding desc2.
/// </summary>
/// <value>The coding desc2.</value>
	public string CodingDesc2
{
	get 
{
	return GetValue((int)ParmList.CodingDesc2);
}
	set 
{
	SetValue((int)ParmList.CodingDesc2,value);
}
}

/// <summary>
/// Gets or sets the coding value3.
/// </summary>
/// <value>The coding value3.</value>
        public string CodingValue3
		{
			get 
			{
				return GetValue((int)ParmList.CodingValue3);
			}
			set 
			{
                SetValue((int)ParmList.CodingValue3, value);
			}
		}

        /// <summary>
        /// Gets or sets the coding desc3.
        /// </summary>
        /// <value>The coding desc3.</value>
        public string CodingDesc3
		{
			get 
			{
				return GetValue((int)ParmList.CodingDesc3);
			}
			set 
			{
                SetValue((int)ParmList.CodingDesc3, value);
			}
		}

        /// <summary>
        /// Gets or sets the coding value4.
        /// </summary>
        /// <value>The coding value4.</value>
        public string CodingValue4
        {
            get
            {
                return GetValue((int)ParmList.CodingValue4);
            }
            set
            {
                SetValue((int)ParmList.CodingValue4, value);
            }
        }

        /// <summary>
        /// Gets or sets the coding desc4.
        /// </summary>
        /// <value>The coding desc4.</value>
        public string CodingDesc4
        {
            get
            {
                return GetValue((int)ParmList.CodingDesc4);
            }
            set
            {
                SetValue((int)ParmList.CodingDesc4, value);
            }
        }

        /// <summary>
        /// Gets or sets the coding value5.
        /// </summary>
        /// <value>The coding value5.</value>
        public string CodingValue5
        {
            get
            {
                return GetValue((int)ParmList.CodingValue5);
            }
            set
            {
                SetValue((int)ParmList.CodingValue5, value);
            }
        }

        /// <summary>
        /// Gets or sets the coding desc3.
        /// </summary>
        /// <value>The coding desc3.</value>
        public string CodingDesc5
        {
            get
            {
                return GetValue((int)ParmList.CodingDesc5);
            }
            set
            {
                SetValue((int)ParmList.CodingDesc5, value);
            }
        }

        /// <summary>
        /// Gets or sets the upload_ key.
        /// </summary>
        /// <value>The upload_ key.</value>
        public string Upload_Key
        {
            get
            {
                return GetValue((int)ParmList.UploadKey);
            }
            set
            {
                SetValue((int)ParmList.UploadKey, value);
            }
        }
		/// <summary>
		/// Gets or sets the FileTransmissionId.
		/// </summary>
		/// <value>The FileTransmissionId.</value>
		public string FileTransmissionId
		{
			get 
			{
				return GetValue((int)ParmList.FileTransmissionLogId);
			}
			set 
			{
				SetValue((int)ParmList.FileTransmissionLogId,value);
			}
		}

        /// <summary>
        /// Gets or sets the type1.
        /// </summary>
        /// <value>The type1.</value>
        public string Type1
        {
            get
            {
                return GetValue((int)ParmList.Type1);
            }
            set
            {
                SetValue((int)ParmList.Type1, value);
            }
        }

        /// <summary>
        /// Gets or sets the type2.
        /// </summary>
        /// <value>The type2.</value>
        public string Type2
        {
            get
            {
                return GetValue((int)ParmList.Type2);
            }
            set
            {
                SetValue((int)ParmList.Type2, value);
            }
        }

        /// <summary>
        /// Gets or sets the type3.
        /// </summary>
        /// <value>The type3.</value>
        public string Type3
        {
            get
            {
                return GetValue((int)ParmList.Type3);
            }
            set
            {
                SetValue((int)ParmList.Type3, value);
            }
        }

        /// <summary>
        /// Gets or sets the type4.
        /// </summary>
        /// <value>The type4.</value>
        public string Type4
        {
            get
            {
                return GetValue((int)ParmList.Type4);
            }
            set
            {
                SetValue((int)ParmList.Type4, value);
            }
        }

        /// <summary>
        /// Gets or sets the type5.
        /// </summary>
        /// <value>The type5.</value>
        public string Type5
        {
            get
            {
                return GetValue((int)ParmList.Type5);
            }
            set
            {
                SetValue((int)ParmList.Type5, value);
            }
        }

        /// <summary>
        /// Gets or sets the last code value.
        /// </summary>
        /// <value>The last code value.</value>
        public string LastCodeValue
        {
            get
            {
                return GetValue((int)ParmList.LastCodeValue);
            }
            set
            {
                SetValue((int)ParmList.LastCodeValue, value);
            }
        }

        /// <summary>
        /// Gets or sets the last code description.
        /// </summary>
        /// <value>The last code description.</value>
        public string LastCodeDescription
        {
            get
            {
                return GetValue((int)ParmList.LastCodeDescription);
            }
            set
            {
                SetValue((int)ParmList.LastCodeDescription, value);
            }
        }
	#endregion

}
	}
#region Log

#endregion