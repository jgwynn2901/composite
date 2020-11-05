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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/QueueAssignments.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates the procedure that returns the set of Assignments from table SEL_QUEUE_ASSIGNMENT fields by NAME
	/// </summary>
	[ComVisible(false)]	
	public class QueueAssignments :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="QueueAssignments"/> class.
		/// </summary>
		public QueueAssignments() :this(String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="QueueAssignments"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public QueueAssignments(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetQueueAssignments";
			_hasCursor = true;

			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override sealed void Initialize()
		{
			///////////////////////////////////////////////////
			///// p_attributeName
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"p_attributeName","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// results
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"results","",System.Data.DbType.Object);
		}
		#endregion
		#region AttributeName
		/// <summary>
		/// Gets or sets the name of the attribute.
		/// </summary>
		/// <value>The name of the attribute.</value>
		public string AttributeName
		{
			get
			{
				return GetValue("p_attributeName");
			}
			set
			{
				SetValue("p_attributeName", value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/QueueAssignments.cs $
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
 * 3     11/15/06 5:33p John.gwynn
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