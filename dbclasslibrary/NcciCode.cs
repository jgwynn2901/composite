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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/NcciCode.cs 4     5/26/09 11:05a John.gwynn $ */
using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for NcciCode.
	/// </summary>
	[ComVisible(false)]	
	public class NcciCode :DbBaseClass
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NcciCode"/> class.
		/// </summary>
		public NcciCode():this(String.Empty)
		{	}
		/// <summary>
		/// Initializes a new instance of the <see cref="NcciCode"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public NcciCode(string instance) :base(instance)
		{
			_name = "UIFSEGMENT.ProcessNCCICodes";

			Initialize();
		}
		/// <summary>
		/// Initializes this instance parameters.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////p_nNCCICodeID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_nNCCICodeID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nAHSID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nAHSID","",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nNCCICode
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nNCCICode","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nDescription
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nDescription","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nFileTranLogID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_nFileTranLogID","",System.Data.DbType.Int32);
		}
		/// <summary>
		/// Gets the ncci code id.
		/// </summary>
		/// <value>The ncci code id.</value>
		public string NcciCodeId 
		{
			get 
			{
				return GetValue("p_nNCCICodeID");
			}
		}
		/// <summary>
		/// Gets or sets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string AhsId 
		{
			get 
			{
				return GetValue("p_nAHSID");
			}
			set 
			{
				SetValue("p_nAHSID",value);
			}
		}
		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		/// <value>The code.</value>
		public string Code 
		{
			get 
			{
				return GetValue("p_nNCCICode");
			}
			set 
			{
				SetValue("p_nNCCICode",value);
			}
		}
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description 
		{
			get 
			{
				return GetValue("p_nDescription");
			}
			set 
			{
				SetValue("p_nDescription",value);
			}
		}
		/// <summary>
		/// Gets or sets the file tran log id.
		/// </summary>
		/// <value>The file tran log id.</value>
		public string FileTranLogId 
		{
			get 
			{
				return GetValue("p_nFileTranLogID");
			}
			set 
			{
				SetValue("p_nFileTranLogID",value);
			}
		}
	}
}
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/NcciCode.cs $
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
 * 2     4/07/06 9:32a John.gwynn
 * fixed name
 * 
 * 1     4/06/06 6:16p John.gwynn
 * Added NcciCode and AhsIdFromLocation
 */