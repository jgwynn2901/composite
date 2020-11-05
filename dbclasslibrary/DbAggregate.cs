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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/DbAggregate.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion
using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// DbAggregate encapsulates navigation of results sets
	/// </summary>
	[ComVisible(false)]	
	public class DbAggregate : DbBaseClass, IEnumerator, IEnumerable
	{
		private int _current;
		DataTable _table;
		
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="DbAggregate"/> class.
		/// </summary>
		public DbAggregate() :this(String.Empty) {}	
		/// <summary>
		/// Initializes a new instance of the <see cref="DbAggregate"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public DbAggregate(string instance) :base(instance)
		{
			_hasCursor = true;
			_current = -1;
			_table = null;
		}
		#endregion
		#region IEnumerator Members
		///<summary>
		///
		///<para>
		///Advances the enumerator to the next element of the collection.
		///</para>
		///
		///</summary>
		///
		///<returns>
		///
		///<para>
		///<see langword="true" /> if the enumerator was successfully advanced to the next element;
		/// <see langword="false" /> if the enumerator has passed the end of the collection.
		///</para>
		///
		///</returns>
		///
		///<exception cref="T:System.InvalidOperationException"><para>The collection was modified after the enumerator was created.</para></exception>
		public bool MoveNext()
		{
			if(HasDataTable() && _table.Rows.Count > ++_current)
			{
				return true;
			}	
			return false;
		}
		/// <summary>
		/// Reset data
		/// </summary>
		/// <remarks>resets parameter dataset to defaults</remarks>
		public new void Reset()
		{
			_current = -1;
		}
		///<summary>
		///
		///<para>
		///Gets the current element in the collection.
		///</para>
		///
		///</summary>
		///
		///<exception cref="T:System.InvalidOperationException"><para>The enumerator is positioned before the first element of the collection or after the last element.</para></exception>
		public object Current
		{
			get
			{			
				if(HasDataTable() && _current != -1 && _table.Rows.Count > _current)
				{
					return this;
				}
				return null;
			}
		}
		#endregion
		/// <summary>
		/// Determines whether [has data table].
		/// </summary>
		/// <returns>
		/// 	<c>true</c> if [has data table]; otherwise, <c>false</c>.
		/// </returns>
		private bool HasDataTable()
		{
			if(_table == null)
			{
				if(_data != null && _data.Tables != null && _data.Tables.Count > 0)
				{
					_table = _data.Tables[0];
				}
			}
			return (_table != null);
		}
		/// <summary>
		/// Gets the column value.
		/// </summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		protected string GetColumnValue(int index)
		{
			string results = String.Empty;
			
			if(HasDataTable() && _current != -1 && _table.Rows.Count > _current)
			{
				if(_table.Rows != null && _table.Rows.Count > _current)
				{
					DataRow row = _table.Rows[_current];
					if(row != null)
					{
						if(row.ItemArray.Length > index && row[index] != null)
						{
							results = row[index].ToString();
						}
					}
				}
			}
			return results;
		}
		#region IEnumerable Members

		/// <summary>
		/// Returns an enumerator that can iterate through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Collections.IEnumerator"/>
		/// that can be used to iterate through the collection.
		/// </returns>
		public IEnumerator GetEnumerator()
		{
			return this;
		}

		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/DbAggregate.cs $
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
 * 2     3/13/07 6:29p John.gwynn
 * Specific destination plumbing for ESIS Contact file load
 * 
 * 1     3/07/07 7:16p John.gwynn
 * added aggregate subclass to implement IEnumerable for result sets.
 * Table definition procedure wrapper is first class implemented in terms
 * of the new aggregate base and will be used for code generation tools.
 */
#endregion