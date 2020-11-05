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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ClaimCmsId.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for SEL_CMS table.
	/// </summary>
	[ComVisible(false)]	
	public sealed class ClaimCmsId :DbBaseClass
	{
		private enum eParmList 
		{
			Id = 0,
			CmsId,
			CallId,
			LastName,
			FirstName,
			MidInitial,
			Prefix,
			Suffix,
			PropQId,
			PropQName
		};
		
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimCmsId"/> class.
		/// </summary>
		public ClaimCmsId() :this(String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimCmsId"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public ClaimCmsId(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.UpdateClaimCmsId2";
			_parameterNames = new string[] {
																			 "p_selCmsID",
																			 "p_cmsID",
																			 "p_callID",
																			 "p_lastName",
																			 "p_firstName",
																			 "p_middleInit",
																			 "p_prefix",
																			 "p_suffix",
																			 "p_propQId",
																			 "p_propQName"
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
			///// Id
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Output,
				_parameterNames[(int)eParmList.Id],"",DbType.Int32);
			///////////////////////////////////////////////////
			///// CmsId
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.CmsId],"",DbType.AnsiString);
			///////////////////////////////////////////////////
			///// CallId
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.CallId],"",DbType.Int32);
			///////////////////////////////////////////////////
			///// LastName
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.LastName],"",DbType.AnsiString);
			///////////////////////////////////////////////////
			///// FirstName
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.FirstName],"",DbType.AnsiString);
			///////////////////////////////////////////////////
			///// MidInitial
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.MidInitial],"",DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Prefix
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.Prefix],"",DbType.AnsiString);
			///////////////////////////////////////////////////
			///// Suffix
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.Suffix],"",DbType.AnsiString);
			///////////////////////////////////////////////////
			///// PropQId
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.PropQId],"",DbType.AnsiString);
			///////////////////////////////////////////////////
			///// PropQName
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.PropQName],"",DbType.AnsiString);
			
		}
		#endregion
		
		#region Id
		/// <summary>
		/// Gets  Id.
		/// </summary>
		/// <value>The  Id.</value>
		public string Id 
		{
			get 
			{
				return GetValue((int)eParmList.Id);
			}
		}
		#endregion
		#region CmsId
		/// <summary>
		/// Gets or sets the CSR id.
		/// </summary>
		/// <value>The CSR id.</value>
		public string CmsId 
		{
			get 
			{
				return GetValue((int)eParmList.CmsId);
			}
			set 
			{
				SetValue((int)eParmList.CmsId,value);
			}
		}
		#endregion
		#region CallId
		/// <summary>
		/// Gets or sets the call id.
		/// </summary>
		/// <value>The call id.</value>
		public string CallId 
		{
			get 
			{
				return GetValue((int)eParmList.CallId);
			}
			set 
			{
				SetValue((int)eParmList.CallId,value);
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
				return GetValue((int)eParmList.LastName);
			}
			set 
			{
				SetValue((int)eParmList.LastName,value);
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
				return GetValue((int)eParmList.FirstName);
			}
			set 
			{
				SetValue((int)eParmList.FirstName,value);
			}
		}
		#endregion
		#region MidInitial
			/// <summary>
			/// Gets or sets the mid initial.
			/// </summary>
			/// <value>The mid initial.</value>
			public string MidInitial 
		{
			get 
			{
				return GetValue((int)eParmList.MidInitial);
			}
			set 
			{
				SetValue((int)eParmList.MidInitial,value);
			}
		}
		#endregion
		#region Prefix
		/// <summary>
		/// Gets or sets the prefix.
		/// </summary>
		/// <value>The prefix.</value>
		public string Prefix 
		{
			get 
			{
				return GetValue((int)eParmList.Prefix);
			}
			set 
			{
				SetValue((int)eParmList.Prefix,value);
			}
		}
		#endregion
		#region Suffix
		/// <summary>
		/// Gets or sets the suffix.
		/// </summary>
		/// <value>The suffix.</value>
		public string Suffix 
		{
			get 
			{
				return GetValue((int)eParmList.Suffix);
			}
			set 
			{
				SetValue((int)eParmList.Suffix,value);
			}
		}
		#endregion
		#region PropQId
		/// <summary>
		/// Gets or sets the prop Q id.
		/// </summary>
		/// <value>The prop Q id.</value>
		public string PropQId 
		{
			get 
			{
				return GetValue((int)eParmList.PropQId);
			}
			set 
			{
				SetValue((int)eParmList.PropQId,value);
			}
		}
		#endregion
		#region PropQName
		/// <summary>
		/// Gets or sets the name of the prop Q.
		/// </summary>
		/// <value>The name of the prop Q.</value>
		public string PropQName 
		{
			get 
			{
				return GetValue((int)eParmList.PropQName);
			}
			set 
			{
				SetValue((int)eParmList.PropQName,value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ClaimCmsId.cs $
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
 * 4     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 3     11/14/06 10:20a John.gwynn
 * procedure changed to DBCLASSLIBRARY.UpdateClaimCmsId2 for additional
 * fileds for PRO and LIA calflows
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     8/01/06 5:53p John.gwynn
 * added coverage for SEN_CSR and SEN_CSA
 */ 
#endregion
