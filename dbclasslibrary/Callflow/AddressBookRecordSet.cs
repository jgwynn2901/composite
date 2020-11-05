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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/AddressBookRecordSet.cs 3     5/26/09 11:06a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// Encapsulates a set of AddressBook Records
	/// Usage: Set CallflowId and Execute (Do Not Override)
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class AddressBookRecordSet : ActiveRecordSet<AddressBookRecord>
	{
		private string _callflowId;
		/// <summary>
		/// Initializes a new instance of the <see cref="AddressBookRecordSet"/> class.
		/// </summary>
    public AddressBookRecordSet()
      : base("AddressBookRecord")
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="AddressBookRecordSet"/> class.
		/// </summary>
		/// <param name="callflowId">The callflow id.</param>
		public AddressBookRecordSet(string callflowId)
			: base("AddressBookRecord")
		{
			_callflowId = callflowId;
		}
		/// <summary>
		/// Gets or sets the callflow id.
		/// </summary>
		/// <value>The callflow id.</value>
		public string CallflowId
		{
			get { return _callflowId; }
			set { _callflowId = value; }
		}
		/// <summary>
		/// Gets or sets the query.
		/// </summary>
		/// <value>The query.</value>
		public override string Query
		{
			get { return String.Format("select * from ADDRESS_BOOK_ENTRY where CALLFLOW_ID = {0} ORDER BY NAME", _callflowId); }
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/AddressBookRecordSet.cs $
 * 
 * 3     5/26/09 11:06a John.gwynn
 * Added interop definitions
 * 
 * 2     6/03/07 2:10p John.gwynn
 * 
 * 1     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 */
#endregion
