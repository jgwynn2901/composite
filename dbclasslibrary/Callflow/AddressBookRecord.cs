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
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/AddressBookRecord.cs 6     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;

namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// Encapsulates a record from the ADDRESS_BOOK_ENTRY table
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class AddressBookRecord : ActiveRecord
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="AddressBookRecord"/> class.
		/// </summary>
		public AddressBookRecord()
			: base("ADDRESS_BOOK_ENTRY")
		{
			// Begin Generated Column Definitions
      columns.Add(new Column("ADDRESS_BOOK_ENTRY_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("CALLFLOW_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("NAME", String.Empty, "VARCHAR2"));
      columns.Add(new Column("DESCRIPTION", String.Empty, "VARCHAR2"));
			// End Generated Column Definitions
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="AddressBookRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public AddressBookRecord(IDataReader reader):base(reader,"ADDRESS_BOOK_ENTRY")
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AddressBookRecord"/> class.
		/// </summary>
		/// <param name="source">The source.</param>
		public AddressBookRecord(ActiveRecord source)
			: base(source)
		{ }

		#endregion
		#region AddressBookEntryId
		/// <summary>
		/// Gets or sets the address book entry id.
		/// </summary>
		/// <value>The address book entry id.</value>
		public string AddressBookEntryId
		{
			get
			{
				return GetColumnValue("ADDRESS_BOOK_ENTRY_ID");
			}
			set
			{
				SetColumnValue("ADDRESS_BOOK_ENTRY_ID", value);
			}
		}
		#endregion
		#region CallflowId
		/// <summary>
		/// Gets or sets the callflow id.
		/// </summary>
		/// <value>The callflow id.</value>
		public string CallflowId
		{
			get
			{
				return GetColumnValue("CALLFLOW_ID");
			}
			set
			{
				SetColumnValue("CALLFLOW_ID", value);
			}
		}
		#endregion
		#region FieldName
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		public string FieldName
		{
			get
			{
				return GetColumnValue("NAME");
			}
			set
			{
				SetColumnValue("NAME", value);
			}
		}
		#endregion
		#region Description
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description
		{
			get
			{
				return GetColumnValue("DESCRIPTION");
			}
			set
			{
				SetColumnValue("DESCRIPTION", value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/AddressBookRecord.cs $
 * 
 * 6     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 5     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 4     5/26/09 7:03p John.gwynn
 * Added deep cloning and ToArray, ToList support (ToArray is for interop
 * ToList is because we have no LINQ today)
 * 
 * 3     5/26/09 11:06a John.gwynn
 * Added interop definitions
 * 
 * 2     6/03/07 2:09p John.gwynn
 * 
 * 1     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 */
#endregion