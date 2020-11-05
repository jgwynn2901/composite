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
*
* Created by: John Gwynn
* Created: Monday, July 30, 2007
***************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateXClaimData.cs 2     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// utility class to update X_CALL_CLAIM data that was not correctly loaded
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class UpdateXClaimData : DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateXClaimData"/> class.
		/// </summary>
		public UpdateXClaimData()
			: this(String.Empty)
		{}
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateXClaimData"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public UpdateXClaimData(string instance)
			: base(instance)
		{
			_name = "UpdateXClaimData";
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
			///// p_attributeName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_claimId", "", System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_fieldName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_fieldName", "", System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_fieldValue
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_fieldValue", "", System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_results
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_results", "", System.Data.DbType.Int32);
		}
		#endregion
		#region ClaimId
		/// <summary>
		/// Gets or sets the claim id.
		/// </summary>
		/// <value>The claim id.</value>
			public string ClaimId
		{
			get
			{
				return GetValue("p_claimId");
			}
			set
			{
				SetValue("p_claimId", value);
			}
		}
		#endregion
		#region FieldName
		/// <summary>
		/// Gets or sets the name of the attribute.
		/// </summary>
		/// <value>The name of the attribute.</value>
		public string FieldName
		{
			get
			{
				return GetValue("p_fieldName");
			}
			set
			{
				SetValue("p_fieldName", value);
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
				return GetValue("p_fieldValue");
			}
			set
			{
				SetValue("p_fieldValue", value);
			}
		}
		#endregion
		#region Results
		/// <summary>
		/// Gets the results.
		/// </summary>
		/// <value>The results.</value>
		public string Result
		{
			get
			{
				return GetValue("p_results");
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/UpdateXClaimData.cs $
 * 
 * 2     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 1     8/07/07 6:15p John.gwynn
 * several fixes to default instance to registry when not supplied.
 * Specific destination support. Added ISequenceStep interface for OPM
 */
#endregion