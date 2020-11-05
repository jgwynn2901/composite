using System;

namespace DbClassLibrary
{

	
	/// <summary>
	/// Wrapper class for ProcessDepartmentCodes.
	/// </summary>
	public class DepartmentCodes : DbBaseClass
	{
		private enum ParmList
		{
			/// <summary>
			/// the primary key
			/// </summary>
			DepartmentCodeId = 0,

			/// <summary>
			/// The parent AHS record
			/// </summary>
			AhsId,

			/// <summary>
			/// Code
			/// </summary>
			DepartmentCode,

			/// <summary>
			/// Name
			/// </summary>
			DepartmentName, 

			/// <summary>
			/// last load
			/// </summary>
			FileTranLogId,

			/// <summary>
			/// 
			/// </summary>
			AccountNumber
		};

		/// <summary>
		/// Initializes a new instance of the <see cref="DepartmentCodes"/> class.
		/// </summary>
		public DepartmentCodes() : this(String.Empty) { }	

		/// <summary>
		/// Initializes a new instance of the <see cref="DepartmentCodes"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public DepartmentCodes(string instance)
			: base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessDepartmentCodes";

			_parameterNames = new[] {
										"p_nDepartmentCodeID",
										"p_nAHSID",
										"p_nDepartmentCode",
										"p_nName",
										"p_nFileTranLogID",
                                        "p_nAccountNumber"
									};
			Initialize();
		}

		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override sealed void Initialize()
		{
			///////////////////////////////////////////////////
			/////DepartmentCodeId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
					_parameterNames[(int)ParmList.DepartmentCodeId], "", System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// AhsId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
					_parameterNames[(int)ParmList.AhsId], "", System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// DepartmentCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.DepartmentCode], "", System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// DepartmentName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.DepartmentName], "", System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// FileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.FileTranLogId], "", System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// AccountNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)ParmList.AccountNumber], "", System.Data.DbType.AnsiString);

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
				return GetValue(_parameterNames[(int)ParmList.DepartmentCodeId]);
			}
		}
		#endregion

		#region AhsId

		/// <summary>
		/// Gets or sets the ahs id.
		/// </summary>
		public string AhsId
		{
			get
			{
				return GetValue(_parameterNames[(int)ParmList.AhsId]);
			}
			set
			{
				SetValue(_parameterNames[(int)ParmList.AhsId], value);
			}
		}
		#endregion

		#region DepartmentCode
		/// <summary>
		/// Gets or sets the DepartmentCode.
		/// </summary>
		public string DepartmentCode
		{
			get
			{
				return GetValue(_parameterNames[(int)ParmList.DepartmentCode]);
			}
			set
			{
				SetValue(_parameterNames[(int)ParmList.DepartmentCode], value);
			}
		}
		#endregion

		#region DepartmentName
		/// <summary>
		/// Gets or sets the DepartmentName.
		/// </summary>
		public string DepartmentName
		{
			get
			{
				return GetValue(_parameterNames[(int)ParmList.DepartmentName]);
			}
			set
			{
				SetValue(_parameterNames[(int)ParmList.DepartmentName], value);
			}
		}
		#endregion

		#region FileTranLogId
		/// <summary>
		/// Gets or sets the file tran log id.
		/// </summary>
		public string FileTranLogId
		{
			get
			{
				return GetValue(_parameterNames[(int)ParmList.FileTranLogId]);
			}
			set
			{
				SetValue(_parameterNames[(int)ParmList.FileTranLogId], value);
			}
		}
		#endregion

		#region AccountNumber
		/// <summary>
		/// Gets or sets the AccountNumber.
		/// </summary>
		public string AccountNumber
		{
			get
			{
				return GetValue(_parameterNames[(int)ParmList.AccountNumber]);
			}
			set
			{
				SetValue(_parameterNames[(int)ParmList.AccountNumber], value);
			}
		}
		#endregion

	}
}
