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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/EncyptAttributeSet.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates select stored procedure for ENCRYPT_ATTRIBUTE table.
	/// </summary>
	[ComVisible(false)]	
	public class EncryptAttributeSet :DbBaseClass, IEnumerable
	{
		private enum eParmList 
		{
			AhsId = 0,
			LobCd,
			EncryptType,
			Results
		};
		/// <summary>
		/// enumerates the REF CURSOR result set Columns
		/// </summary>
		public enum ResultList
		{
			/// <summary>
			/// ATTRIBUTE_NAME
			/// </summary>
			AttributeName = 0,
			/// <summary>
			/// ENCRYPTION_TYPE
			/// </summary>
			EncryptionType
		};
			
				
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="EncryptAttributeSet"/> class.
		/// </summary>
		public EncryptAttributeSet():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="EncryptAttributeSet"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public EncryptAttributeSet(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetEncrptAttributeSet";

			_parameterNames = new string[] {
																			 "p_ahsId",
																			 "p_lobCd",
																			 "p_encryptType",
																			 "results" };
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
			// AhsId
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.AhsId],"",DbType.Int32);
			///////////////////////////////////////////////////
			// LobCd
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.LobCd],"",DbType.AnsiString);
			///////////////////////////////////////////////////
			// EncryptType
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				_parameterNames[(int)eParmList.EncryptType],"",DbType.AnsiString);
			///////////////////////////////////////////////////
			// Results
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Output,
				_parameterNames[(int)eParmList.Results],"",DbType.Object);
		}
		#endregion
		
		#region AhsId
		/// <summary>
		/// Gets or sets the accnt_hrcy_step_id.
		/// </summary>
		/// <value>The ahsId.</value>
		public string AhsId
		{
			get 
			{
				return GetValue((int)eParmList.AhsId);
			}
			set 
			{
				SetValue((int)eParmList.AhsId,value);
			}
		}
		#endregion
		#region LobCd
		/// <summary>
		/// Gets or sets the server.
		/// </summary>
		/// <value>The server.</value>
		public string LobCd
		{
			get 
			{
				return GetValue((int)eParmList.LobCd);
			}
			set 
			{
				SetValue((int)eParmList.LobCd,value);
			}
		}
		#endregion
		#region	EncryptType
		/// <summary>
		/// Gets or sets the type of the encrypt.
		/// </summary>
		/// <value>The type of the encrypt.</value>
		public string EncryptType
		{
			get 
			{
				return GetValue((int)eParmList.EncryptType);
			}
			set 
			{
				SetValue((int)eParmList.EncryptType,value);
			}
		}
		#endregion

		/// <summary>
		/// Returns an enumerator that can iterate through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Collections.IEnumerator"/>
		/// that can be used to iterate through the collection.
		/// </returns>
		public IEnumerator GetEnumerator()
		{
			IEnumerator results = null;
			
			if(_data != null && _data.Tables.Count > 0)
			{
				DataTable table = _data.Tables[0];
				if(table != null)
				{
					return table.Rows.GetEnumerator();
				}
			}
			return results;
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/EncyptAttributeSet.cs $
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
 * 3     3/07/07 7:16p John.gwynn
 * added aggregate subclass to implement IEnumerable for result sets.
 * Table definition procedure wrapper is first class implemented in terms
 * of the new aggregate base and will be used for code generation tools.
 * 
 * 2     11/30/06 6:24p John.gwynn
 * Added EncryptType for additional results filter by type
 * 
 * 1     11/26/06 9:32a John.gwynn
 * encapsulates retrieval of encrypt attributes by ahsId and LOB_CD
 */
#endregion

