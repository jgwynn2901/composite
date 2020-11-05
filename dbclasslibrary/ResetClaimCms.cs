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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ResetClaimCms.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// RESETS the SEL_CMS and SELCSR on new lookup to clear any prior data
	/// </summary>
	[ComVisible(false)]	
	public sealed class ResetClaimCms :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ResetClaimCms"/> class.
		/// </summary>
		public ResetClaimCms() :this(String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="ResetClaimCms"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public ResetClaimCms(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.ResetClaimCsr";

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
			///// p_callID
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				"p_callID","",DbType.Int32);
			
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
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ResetClaimCms.cs $
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
 * 5     11/15/06 5:33p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 4     11/14/06 10:23a John.gwynn
 * changed class definition to sealed
 * 
 * 3     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 2     8/16/06 10:34a John.gwynn
 * now reseting SEL_CSR clear out prior on set new
 * 
 * 1     8/15/06 5:46p John.gwynn
 * added resetCms and Provider parameters for update
 */ 
#endregion
