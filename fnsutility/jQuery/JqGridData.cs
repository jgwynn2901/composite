﻿using System.Runtime.Serialization;

namespace FnsUtility.jQuery
{
	[DataContract]
	public class JqGridData
	{
		/// <summary>
		/// The number of pages which should be displayed in the paging controls at the bottom of the grid.
		/// </summary>
		[DataMember]
		public int Total { get; set; }
		/// <summary>
		/// The current page number which should be highlighted in the paging controls at the bottom of the grid.
		/// </summary>
		[DataMember]
		public int Page { get; set; }
		/// <summary>
		/// The total number of records in the entire data set, not just the portion returned in Rows.
		/// </summary>
		[DataMember]
		public int Records { get; set; }
		/// <summary>
		/// See the JqGrid documentation for repeatitems. This property controls how the grid interprets the Rows 
		/// property. When set false, Rows is presumed to contain a list of objects where the property name is 
		/// the grid column name in the property value is the value which should be displayed in the grid. When 
		/// set true, the ID and the non-ID values would be stored separately.
		/// </summary>
		[DataMember]
		public static bool RepeatItems { get { return false; } }
		
		/// <summary>
		/// Arbitrary data to be returned to the grid along with the row data. Leave null if not using. 
		/// Must be serializable to JSON!
		/// </summary>
		[DataMember]
		public object UserData { get; set; }
	}
}
