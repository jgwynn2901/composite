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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/MandatoryFields.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates the procedure that returns the set of (SELECTIVE) MANDATORY fields by LOB_CD
	/// </summary>
	[ComVisible(false)]	
	public class MandatoryFields :DbBaseClass
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MandatoryFields"/> class.
		/// </summary>
		public MandatoryFields():this(String.Empty)
		{
			//
			// TODO: Add constructor logic here
			//
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="MandatoryFields"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public MandatoryFields(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetMandatoryFields";
			_hasCursor = true;

			Initialize();
		}
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			///// p_LOB_CD
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_LOB_CD","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// results
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"results","",System.Data.DbType.Object);
		}
		/// <summary>
		/// Gets or sets the line of business.
		/// </summary>
		/// <value>The lob cd.</value>
		public string LobCd
		{
			get
			{
				return GetValue("p_LOB_CD");
			}
			set
			{
				SetValue("p_LOB_CD", value);
			}
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/MandatoryFields.cs $
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
 * 3     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     6/23/06 5:41p John.gwynn
 * added ref cursor support and Selective Mandatory fields and
 * QueueAssignment
 */
#endregion