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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ClaimCsrId.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates CRUD stored procedure for SEL_CSR table.
	/// </summary>
	[ComVisible(false)]	
	public sealed class ClaimCsrId :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimCsrId"/> class.
		/// </summary>
		public ClaimCsrId() :this(String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimCsrId"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public ClaimCsrId(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.UpdateClaimCsrId";

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
			///// p_selCsrID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_selCsrID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_csrID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_csrID","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_callID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_callID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_lastName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_lastName","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_firstName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_firstName","",System.Data.DbType.AnsiString);
			
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
				return GetValue("p_selCsrID");
			}
		}
		#endregion
		#region CsrId
		/// <summary>
		/// Gets or sets the CSR id.
		/// </summary>
		/// <value>The CSR id.</value>
		public string CsrId 
		{
			get 
			{
				return GetValue("p_csrID");
			}
			set 
			{
				SetValue("p_csrID",value);
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
				return GetValue("p_callID");
			}
			set 
			{
				SetValue("p_callID",value);
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
				return GetValue("p_lastName");
			}
			set 
			{
				SetValue("p_lastName",value);
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
				return GetValue("p_firstName");
			}
			set 
			{
				SetValue("p_firstName",value);
			}
		}
		#endregion
		#region ProcessDelimitedCsrString
		/// <summary>
		/// Processes the delimited CSR string.
		/// </summary>
		/// <param name="callId">The call id.</param>
		/// <param name="csrIds">The CSR ids.</param>
		/// <returns></returns>
		static public bool ProcessDelimitedCsrString(string callId, string csrIds)
		{
			bool results;
			
			try
			{
				var reset = new ResetClaimCms {CallId = callId};

			  reset.Execute();
				
				var test = new ClaimCsrId();
			
				var names = csrIds.Split(';');
			
				foreach (var t in names)
				{
				  var namesId = t.Split(',');
				  if (namesId.Length < 2) continue;
				  var csrIdname = namesId[0].Split(' ');
				  if (csrIdname.Length <= 1) continue;
				  test.Reset();
				  test.CallId = callId;
				  test.CsrId = csrIdname[0].Trim();
				  test.LastName = csrIdname[csrIdname.Length -1].Trim();
				  test.FirstName = namesId[1].Trim();
				  if(namesId.Length == 3)
				  {
				    test.FirstName = namesId[2].Trim();
				    test.LastName += " " + namesId[1].Trim();
				  }
          if(!test.Execute())
            throw new ApplicationException(test.LastError);
				}
				results = true;
			}
			catch (Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message, "ProcessDelimitedCsrString");	
				results = false;
			}
			return results;
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ClaimCsrId.cs $
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
 * 6     11/30/06 3:43p John.gwynn
 * Fixed a parsing bug of CSR names 
 * 
 * 5     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 4     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 3     10/12/06 3:04p John.gwynn
 * fixed a bug which precluded parsing of names with 3 parameters for
 * selctive CSR parsing
 * 
 * 2     8/16/06 10:34a John.gwynn
 * now reseting SEL_CSR clear out prior on set new
 * 
 * 1     8/01/06 5:53p John.gwynn
 * added coverage for SEN_CSR and SEN_CSA
 */ 
#endregion
