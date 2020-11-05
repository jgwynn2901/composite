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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/FileTranError.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for FileTranError.
	/// </summary>
	[ComVisible(false)]	
	public class FileTranError :DbBaseClass
	{
		private enum eParmList 
		{
			eFileTranErrorID = 0,
			eFileTranLogId,
			eAhsId,
			eSeverity,
			eErrorText,
			eType,
			eName,
			eRecordData,
			eLobCd,
			ePolicyNumber,
			eEffectiveDate,
			eExpirationDate,
			eCancelDate,
			eErrorCode,
			eEntityName,
			eEntityId,
			eNodeName,
			eNodeId
		};
		
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="FileTranError"/> class.
		/// </summary>
		public FileTranError():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="FileTranError"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public FileTranError(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessFileTranError";

			_parameterNames = new string[] {
			                               "p_nFileTranErrorID",
																		 "p_nFileTranLogID",
																		 "p_nAHSID",
																		 "p_nSeverity",
																		 "p_nErrorText",
																		 "p_nType",
																		 "p_nName",
																		 "p_nRecordData",
																		 "p_nLOB_CD",
																		 "p_nPolicyNumber",
																		 "p_nEffectiveDate",
																		 "p_nExpirationDate",
																		 "p_nCancelDate",
																		 "p_nErrorCode",
																		 "p_nEntityName",
																		 "p_nEntityID",
																		 "p_nNodeName",
																		 "p_nNodeID" };
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
			/////p_nFileTranErrorID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
			        _parameterNames[(int)eParmList.eFileTranErrorID],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_nFileTranLogID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eFileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nAHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eAhsId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nSeverity
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eSeverity],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nErrorText
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eErrorText],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eType],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nRecordData
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eRecordData],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nLOB_CD
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eLobCd],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nPolicyNumber
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.ePolicyNumber],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nEffectiveDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eEffectiveDate],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nExpirationDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eExpirationDate],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nCancelDate
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eCancelDate],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nErrorCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eErrorCode],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nEntityName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eEntityName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nEntityID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eEntityId],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNodeName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eNodeName],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nNodeID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
			        _parameterNames[(int)eParmList.eNodeId],"",System.Data.DbType.AnsiString);
		}
		#endregion
		#region Public Properties
		
		/// <summary>
		/// Gets the file tran error id.
		/// </summary>
		/// <value>The file tran error id.</value>
		public int FileTranErrorId 
		{
			get 
			{
				string result = GetValue((int) eParmList.eFileTranErrorID);
				return result.Length > 0 ? Convert.ToInt32(result): -1;
			}
		}
		/// <summary>
		/// Gets or sets the file tran log id.
		/// </summary>
		/// <value>The file tran log id.</value>
		public string  FileTranLogId 
		{
			get 
			{
				return GetValue((int)eParmList.eFileTranLogId);
			}
			set 
			{
				SetValue((int)eParmList.eFileTranLogId,value);
			}
		}
		/// <summary>
		/// Gets or sets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string  AhsId 
		{
			get 
			{
				return GetValue((int)eParmList.eAhsId);
			}
			set 
			{
				SetValue((int)eParmList.eAhsId,value);
			}
		}
		/// <summary>
		/// Gets or sets the severity.
		/// </summary>
		/// <value>The severity.</value>
		public string  Severity 
		{
			get 
			{
				return GetValue((int)eParmList.eSeverity);
			}
			set 
			{
				SetValue((int)eParmList.eSeverity,value);
			}
		}
		/// <summary>
		/// Gets or sets the error text.
		/// </summary>
		/// <value>The error text.</value>
		public string  ErrorText 
		{
			get 
			{
				return GetValue((int)eParmList.eErrorText);
			}
			set 
			{
				SetValue((int)eParmList.eErrorText,value);
			}
		}
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string  Type 
		{
			get 
			{
				return GetValue((int)eParmList.eType);
			}
			set 
			{
				SetValue((int)eParmList.eType,value);
			}
		}
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string  Name 
		{
			get 
			{
				return GetValue((int)eParmList.eName);
			}
			set 
			{
				SetValue((int)eParmList.eName,value);
			}
		}
		/// <summary>
		/// Gets or sets the record data.
		/// </summary>
		/// <value>The record data.</value>
		public string RecordData 
		{
			get 
			{
				return GetValue((int)eParmList.eRecordData);
			}
			set 
			{
				SetValue((int)eParmList.eRecordData,value);
			}
		}
		/// <summary>
		/// Gets or sets the lob cd.
		/// </summary>
		/// <value>The lob cd.</value>
		public string LobCd 
		{
			get 
			{
				return GetValue((int)eParmList.eLobCd);
			}
			set 
			{
				SetValue((int)eParmList.eLobCd,value);
			}
		}
		/// <summary>
		/// Gets or sets the policy number.
		/// </summary>
		/// <value>The policy number.</value>
		public string PolicyNumber 
		{
			get 
			{
				return GetValue((int)eParmList.ePolicyNumber);
			}
			set 
			{
				SetValue((int)eParmList.ePolicyNumber,value);
			}
		}
		/// <summary>
		/// Gets or sets the effective date.
		/// </summary>
		/// <value>The effective date.</value>
		public string EffectiveDate 
		{
			get 
			{
				return GetValue((int)eParmList.eEffectiveDate);
			}
			set 
			{
				SetValue((int)eParmList.eEffectiveDate,value);
			}
		}
		
		/// <summary>
		/// Gets or sets the expiration date.
		/// </summary>
		/// <value>The expiration date.</value>
		public string ExpirationDate 
		{
			get 
			{
				return GetValue((int)eParmList.eExpirationDate);
			}
			set 
			{
				SetValue((int)eParmList.eExpirationDate,value);
			}
		}
		/// <summary>
		/// Gets or sets the cancel date.
		/// </summary>
		/// <value>The cancel date.</value>
		public string CancelDate 
		{
			get 
			{
				return GetValue((int)eParmList.eCancelDate);
			}
			set 
			{
				SetValue((int)eParmList.eCancelDate,value);
			}
		}
		/// <summary>
		/// Gets or sets the error code.
		/// </summary>
		/// <value>The error code.</value>
		public string ErrorCode 
		{
			get 
			{
				return GetValue((int)eParmList.eErrorCode);
			}
			set 
			{
				SetValue((int)eParmList.eErrorCode,value);
			}
		}
		/// <summary>
		/// Gets or sets the name of the entity.
		/// </summary>
		/// <value>The name of the entity.</value>
		public string EntityName 
		{
			get 
			{
				return GetValue((int)eParmList.eEntityName);
			}
			set 
			{
				SetValue((int)eParmList.eEntityName,value);
			}
		}
		/// <summary>
		/// Gets or sets the entity id.
		/// </summary>
		/// <value>The entity id.</value>
		public string EntityId 
		{
			get 
			{
				return GetValue((int)eParmList.eEntityId);
			}
			set 
			{
				SetValue((int)eParmList.eEntityId,value);
			}
		}
		/// <summary>
		/// Gets or sets the name of the node.
		/// </summary>
		/// <value>The name of the node.</value>
		public string NodeName 
		{
			get 
			{
				return GetValue((int)eParmList.eNodeName);
			}
			set 
			{
				SetValue((int)eParmList.eNodeName,value);
			}
		}
		/// <summary>
		/// Gets or sets the node id.
		/// </summary>
		/// <value>The node id.</value>
		public string NodeId 
		{
			get 
			{
				return GetValue((int)eParmList.eNodeId);
			}
			set 
			{
				SetValue((int)eParmList.eNodeId,value);
			}
		}
		
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/FileTranError.cs $
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
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/04/06 1:11p John.gwynn
 * new classes to support .Net loads for InputProcessingManager
 */
#endregion