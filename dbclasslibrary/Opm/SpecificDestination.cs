#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by Innovation First Notice 
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/SpecificDestination.cs 4     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// Encapsulates FNSOWNER.SPECIFIC_DESTINATION for OPM
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class SpecificDestinationRecord : ActiveRecord
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="SpecificDestinationRecord"/> class.
		/// </summary>
		public SpecificDestinationRecord()
			: base("SPECIFIC_DESTINATION")
		{
			// Begin Generated Column Definitions
			columns.Add(new Column("SPECIFIC_DESTINATION_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ACCNT_HRCY_STEP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("NAME_FIRST", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDRESS1", String.Empty, "VARCHAR2"));
			columns.Add(new Column("NAME_LAST", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ADDRESS2", String.Empty, "VARCHAR2"));
			columns.Add(new Column("TITLE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("NAME_MI", String.Empty, "CHAR"));
			columns.Add(new Column("CITY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("STATE", String.Empty, "CHAR"));
			columns.Add(new Column("ZIP", String.Empty, "VARCHAR2"));
			columns.Add(new Column("PHONE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ALTERNATE_FORM_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("LOB", String.Empty, "VARCHAR2"));
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="SpecificDestinationRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public SpecificDestinationRecord(IDataReader reader)
			: base(reader, "SPECIFIC_DESTINATION")
		{
		}
		#endregion
		#region SpecificDestinationRecordId
		/// <summary>
		/// Gets or sets the specific destination id.
		/// </summary>
		/// <value>The specific destination id.</value>
		public string SpecificDestinationRecordId
		{
			get
			{
				return GetColumnValue("SPECIFIC_DESTINATION_ID");
			}
			set
			{
				SetColumnValue("SPECIFIC_DESTINATION_ID", value);
			}
		}
		#endregion
		#region AccntHrcyStepId
		/// <summary>
		/// Gets or sets the accnt hrcy step id.
		/// </summary>
		/// <value>The accnt hrcy step id.</value>
		public string AccntHrcyStepId
		{
			get
			{
				return GetColumnValue("ACCNT_HRCY_STEP_ID");
			}
			set
			{
				SetColumnValue("ACCNT_HRCY_STEP_ID", value);
			}
		}
		#endregion
		#region NameFirst
		/// <summary>
		/// Gets or sets the name first.
		/// </summary>
		/// <value>The name first.</value>
		public string NameFirst
		{
			get
			{
				return GetColumnValue("NAME_FIRST");
			}
			set
			{
				SetColumnValue("NAME_FIRST", value);
			}
		}
		#endregion
		#region Address1
		/// <summary>
		/// Gets or sets the address1.
		/// </summary>
		/// <value>The address1.</value>
		public string Address1
		{
			get
			{
				return GetColumnValue("ADDRESS1");
			}
			set
			{
				SetColumnValue("ADDRESS1", value);
			}
		}
		#endregion
		#region NameLast
		/// <summary>
		/// Gets or sets the name last.
		/// </summary>
		/// <value>The name last.</value>
		public string NameLast
		{
			get
			{
				return GetColumnValue("NAME_LAST");
			}
			set
			{
				SetColumnValue("NAME_LAST", value);
			}
		}
		#endregion
		#region Address2
		/// <summary>
		/// Gets or sets the address2.
		/// </summary>
		/// <value>The address2.</value>
		public string Address2
		{
			get
			{
				return GetColumnValue("ADDRESS2");
			}
			set
			{
				SetColumnValue("ADDRESS2", value);
			}
		}
		#endregion
		#region Title
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		public string Title
		{
			get
			{
				return GetColumnValue("TITLE");
			}
			set
			{
				SetColumnValue("TITLE", value);
			}
		}
		#endregion
		#region NameMi
		/// <summary>
		/// Gets or sets the name mi.
		/// </summary>
		/// <value>The name mi.</value>
		public string NameMi
		{
			get
			{
				return GetColumnValue("NAME_MI");
			}
			set
			{
				SetColumnValue("NAME_MI", value);
			}
		}
		#endregion
		#region City
		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City
		{
			get
			{
				return GetColumnValue("CITY");
			}
			set
			{
				SetColumnValue("CITY", value);
			}
		}
		#endregion
		#region State
		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		public string State
		{
			get
			{
				return GetColumnValue("STATE");
			}
			set
			{
				SetColumnValue("STATE", value);
			}
		}
		#endregion
		#region Zip
		/// <summary>
		/// Gets or sets the zip.
		/// </summary>
		/// <value>The zip.</value>
		public string Zip
		{
			get
			{
				return GetColumnValue("ZIP");
			}
			set
			{
				SetColumnValue("ZIP", value);
			}
		}
		#endregion
		#region Phone
		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		/// <value>The phone.</value>
		public string Phone
		{
			get
			{
				return GetColumnValue("PHONE");
			}
			set
			{
				SetColumnValue("PHONE", value);
			}
		}
		#endregion
		#region AlternateFormFlg
		/// <summary>
		/// Gets or sets the alternate form FLG.
		/// </summary>
		/// <value>The alternate form FLG.</value>
		public string AlternateFormFlg
		{
			get
			{
				return GetColumnValue("ALTERNATE_FORM_FLG");
			}
			set
			{
				SetColumnValue("ALTERNATE_FORM_FLG", value);
			}
		}
		#endregion
		#region Lob
		/// <summary>
		/// Gets or sets the lob.
		/// </summary>
		/// <value>The lob.</value>
		public string Lob
		{
			get
			{
				return GetColumnValue("LOB");
			}
			set
			{
				SetColumnValue("LOB", value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Opm/SpecificDestination.cs $
 * 
 * 4     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 3     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 2     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 1     6/04/07 4:46p John.gwynn
 * Added Specific Destination and sequenceStep for OPM
 */
#endregion
