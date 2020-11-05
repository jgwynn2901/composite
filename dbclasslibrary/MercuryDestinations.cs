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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/MercuryDestinations.cs 5     4/19/10 3:01p Gwynnj $ */
#endregion

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates the procedure that returns the set of DESTINATIONS from table MERCURY fields by TYPE
	/// </summary>
	[ComVisible(false)]	
	public class MercuryDestinations :DbBaseClass
	{
        /// <summary>
        /// CallRoutingEmail message type constant
        /// </summary>
	    public const string CallRoutingEmail = "CALLROUTING_EMAIL";

        /// <summary>
        /// DispatchFailEmail message type constant
        /// </summary>
	    public const string DispatchFailEmail = "DISPFAIL_EMAIL";

        /// <summary>
        /// EdiFailEmail message type constant
        /// </summary>
	    public const string EdiFailEmail = "EDIFAIL_EMAIL";

        /// <summary>
        /// OpmEmail message type constant
        /// </summary>
	    public const string OpmEmail = "OPM_EMAIL";

		/// <summary>
		/// Initializes a new instance of the <see cref="MercuryDestinations"/> class.
		/// </summary>
		public MercuryDestinations():this(String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="MercuryDestinations"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public MercuryDestinations(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.GetMercuryDestinations";
			_hasCursor = true;

			Initialize();
		}
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override sealed void Initialize()
		{
			///////////////////////////////////////////////////
			///// destinationType
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				"destinationType","",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// results
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"results","",System.Data.DbType.Object);
		}
		/// <summary>
		/// Gets or sets the type of the destination.
		/// </summary>
		/// <value>The type of the destination.</value>
		public string DestinationType
		{
			get
			{
				return GetValue("destinationType");
			}
			set
			{
				SetValue("destinationType", value);
			}
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/MercuryDestinations.cs $
 * 
 * 5     4/19/10 3:01p Gwynnj
 * Added Mercury Email constants
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
 * 3     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 2     6/23/06 5:41p John.gwynn
 * added ref cursor support and Selective Mandatory fields and
 * QueueAssignment
 * 
 * 1     5/08/06 6:46p John.gwynn
 * Formatting updates and support for SENP and CRAWP utilities
 */
#endregion