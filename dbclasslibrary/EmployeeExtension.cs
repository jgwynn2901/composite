#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2007 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/EmployeeExtension.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for EmployeeExtension.
	/// </summary>
	[ComVisible(false)]	
	public class EmployeeExtension :DbBaseClass
	{
		private enum eParmList 
		{
			/// <summary>
			/// the primary key
			/// </summary>
			EmployeeExtId = 0,
			/// <summary>
			/// The parent EMPLOYEE record
			/// </summary>
			EmployeeId,
			/// <summary>
			/// link to (last) load
			/// </summary>
			FileTranLogId,
			/// <summary>
			/// Field Name (from Callflow)
			/// </summary>
			FieldName,
			/// <summary>
			/// Field Value
			/// </summary>
			FieldValue
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateCsaaVendorNetwork"/> class.
		/// </summary>
		public EmployeeExtension() :this(String.Empty) {}	
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateCsaaVendorNetwork"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public EmployeeExtension(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessEmployeeExtension";

			_parameterNames = new string[]
												{
													"p_nEmployeeExtId",
													"p_nEmployeeId",
													"p_nFileTranLogId",
													"p_nFieldName",
													"p_nFieldValue"
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
			///////////////////////////////////////////////////
			/////EmployeeExtId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
			        _parameterNames[(int)eParmList.EmployeeExtId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// EmployeeId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.EmployeeId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// FileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// FieldName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FieldName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// FieldValue
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FieldValue],"",System.Data.DbType.AnsiString);
			
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
				return GetValue(_parameterNames[(int)eParmList.EmployeeExtId]);
			}
		}
		#endregion
		#region EmployeeId
		/// <summary>
		/// Gets or sets the employee id.
		/// </summary>
		/// <value>The employee id.</value>
		public string EmployeeId 
		{
			get 
			{
				return GetValue(_parameterNames[(int)eParmList.EmployeeId]);
			}
			set 
			{
				SetValue(_parameterNames[(int)eParmList.EmployeeId],value);
			}
		}
		#endregion
		#region FieldName
		/// <summary>
		/// Gets or sets the name of the field.
		/// </summary>
		/// <value>The name of the field.</value>
		public string FieldName 
		{
			get 
			{
				return GetValue(_parameterNames[(int)eParmList.FieldName]);
			}
			set 
			{
				SetValue(_parameterNames[(int)eParmList.FieldName],value);
			}
		}
		#endregion
		#region FieldValue
		/// <summary>
		/// Gets or sets the field value.
		/// </summary>
		/// <value>The field value.</value>
		public string FieldValue 
		{
			get 
			{
				return GetValue(_parameterNames[(int)eParmList.FieldValue]);
			}
			set 
			{
				SetValue(_parameterNames[(int)eParmList.FieldValue],value);
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
				SetValue(_parameterNames[(int)eParmList.FileTranLogId],value);
			}
		}
		#endregion
		
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/EmployeeExtension.cs $
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 2     1/12/07 10:19a John.gwynn
 * Support for EmployeeExtension attributes
 * 
 * 1     1/09/07 10:33a John.gwynn
 * Added Employee and Employee extension
 */
#endregion