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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AHSExtension.cs 3     7/13/10 11:39a Gwynnj $ */
#endregion
using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for PolicyExtension.
	/// </summary>
	[ComVisible(false)]
// ReSharper disable InconsistentNaming
	public class AHSExtension : DbBaseClass
 // ReSharper restore InconsistentNaming
	{
		/// <summary>
		/// enumerated parameter list
		/// </summary>
		private enum eParmList 
		{
			/// <summary>
			/// the primary key
			/// </summary>
			AHSExtensionId = 0,
			/// <summary>
			/// The parent AHS record
			/// </summary>
			AHSId,
			/// <summary>
			/// Field Name (from Callflow)
			/// </summary>
			FieldName,
			/// <summary>
			/// Field Value
			/// </summary>
			FieldValue,
			/// <summary>
			/// link to (last) load
			/// </summary>
			FileTranLogId
		};
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateCsaaVendorNetwork"/> class.
		/// </summary>
		public AHSExtension() :this(String.Empty) {}	
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateCsaaVendorNetwork"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public AHSExtension(string instance) :base(instance)
		{
			_name = "UIFSegment.ProcessAHSExtension";

			_parameterNames = new string[]
												{
													"p_nAHSExtensionID",
													"p_nAHSID",
													"p_nName",
													"p_nValue",
													"p_nFileTranLogId" 
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
			/////AHSExtId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.AHSExtensionId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// AHSId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.AHSId],"",System.Data.DbType.Int32);
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
			///////////////////////////////////////////////////
			///// FileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.FileTranLogId],"",System.Data.DbType.Int32);
			
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
				return GetValue(_parameterNames[(int)eParmList.AHSExtensionId]);
			}
		}
		#endregion
		#region AHSId
		/// <summary>
		/// Gets or sets the AHS id.
		/// </summary>
		/// <value>The AHS id.</value>
		public string AHSId 
		{
			get 
			{
				return GetValue(_parameterNames[(int)eParmList.AHSId]);
			}
			set 
			{
				SetValue(_parameterNames[(int)eParmList.AHSId],value);
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
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AHSExtension.cs $
 * 
 * 3     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     11/07/07 9:16a Jenny.cheung
 * 
 * 2     5/03/07 10:20a Jenny.cheung
 * Created AHSExtension segment for Esis Actec Load
 * 
 * 1     5/02/07 4:18p Jenny.cheung
 * Added AHSExtension Segment class for Esis Actec Load
 * 
 * 1     3/01/07 3:52p John.gwynn
 * Esis Policy Load support (Policy Extension)
 */
#endregion