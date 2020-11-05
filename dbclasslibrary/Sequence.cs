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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Sequence.cs 4     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Globalization;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates the SEQUENCE.NEXTVAL operation
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class Sequence : ActiveRecord
	{
		private const string NextVal = "NEXTVAL";
		/// <summary>
		/// Initializes a new instance of the <see cref="Sequence"/> class.
		/// </summary>
		/// <param name="table">The table.</param>
		public Sequence (string table) : base(String.Format("{0}_SEQ",table))
		{
			columns.Add(new Column(NextVal, String.Empty, "NUMBER"));
		}
		/// <summary>
		/// Gets the next value.
		/// </summary>
		/// <value>The next value.</value>
		public int NextValue
		{
			get
			{
				return GetColumnValueAsInt(NextVal) ?? -1;
			}
		}
		/// <summary>
		/// Builds the query.
		/// </summary>
		/// <returns></returns>
		protected override string BuildQuery()
		{
			return String.Format("SELECT {0}.NEXTVAL from DUAL", tableName);
		}
		/// <summary>
		/// Gets the next sequence.
		/// </summary>
		/// <param name="table">The table for which NEXT [sequence] is requested.</param>
		/// <param name="instance">The database instance.</param>
		/// <returns></returns>
		static public string GetNextSequence(string table, string instance)
		{
      return GetSequence(table, instance).ToString(CultureInfo.InvariantCulture);
		}

    static public int GetSequence(string table)
	  {
	    return GetSequence(table, GeneralUtility.GetDbInstanceFromRegistry());
	  }

	  static public int GetSequence(string table, string instance )
	  {
	    var seq = new Sequence(table) {Instance = instance};

		  if(seq.Execute())
			{
				return seq.NextValue;
			}
			throw new ApplicationException(seq.LastError);
	  }

	}
}
#region History
/*
 * $History: Sequence.cs $
 * 
 * *****************  Version 4  *****************
 * User: Gwynnj       Date: 7/13/10    Time: 11:39a
 * Updated in $/SourceCode/Components/FNS2005/DbClassLibrary
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * *****************  Version 3  *****************
 * User: John.gwynn   Date: 9/15/09    Time: 5:01p
 * Updated in $/SourceCode/Components/FNS2005/DbClassLibrary
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * *****************  Version 2  *****************
 * User: John.gwynn   Date: 5/26/09    Time: 11:05a
 * Updated in $/SourceCode/Components/FNS2005/DbClassLibrary
 * Added interop definitions
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 6/27/07    Time: 6:12p
 * Created in $/SourceCode/Components/FNS2005/DbClassLibrary
 * Added support for Insert (for OPM)
 */
#endregion