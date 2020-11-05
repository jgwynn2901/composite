#region File Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 1993-2005 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/AhsidFromLocation.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for AhsidFromLocation.
	/// </summary>
	[ComVisible(false)]	
	public sealed class AhsidFromLocation :DbBaseClass
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AhsidFromLocation"/> class.
		/// </summary>
		public AhsidFromLocation():this(String.Empty)
		{	}
		/// <summary>
		/// Initializes a new instance of the <see cref="AhsidFromLocation"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public AhsidFromLocation(string instance) :base(instance)
		{
			_name = "GetAhsidFromlocation";

		
			Initialize();
		}
		/// <summary>
		/// Initializes this instance parameters.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////p_location_id
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_location_id","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_locationCode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_locationCode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_accountLocation
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_accountLocation","",System.Data.DbType.AnsiString);
		}
		#region Properties
		/// <summary>
		/// Gets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string AhsId 
		{
			get 
			{
				return GetValue("p_location_id");
			}
		}
		/// <summary>
		/// Gets or sets the location code.
		/// </summary>
		/// <value>The location code.</value>
		public string LocationCode 
		{
			get 
			{
				return GetValue("p_locationCode");
			}
			set 
			{
				SetValue("p_locationCode",value);
			}
		}
		/// <summary>
		/// Gets or sets the account number.
		/// </summary>
		/// <value>The account number.</value>
		public string AccountNumber 
		{
			get 
			{
				return GetValue("p_accountLocation");
			}
			set 
			{
				SetValue("p_accountLocation",value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/AhsidFromLocation.cs $
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
 * 3     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 2     5/08/06 6:46p John.gwynn
 * Formatting updates and support for SENP and CRAWP utilities
 * 
 * 1     4/06/06 6:16p John.gwynn
 * Added NcciCode and AhsIdFromLocation
 */
#endregion