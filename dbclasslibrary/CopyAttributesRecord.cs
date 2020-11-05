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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/CopyAttributesRecord.cs 5     7/13/10 11:39a Gwynnj $ */
#endregion
using System;
using System.Data;

namespace DbClassLibrary
{
	/// <summary>
	/// Record class for FNSOWNER.COPY_ATTRIBUTES tuples
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class CopyAttributesRecord : ActiveRecord
	{
		private const string _tableName = "COPY_ATTRIBUTES";
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="CopyAttributesRecord"/> class.
		/// </summary>
		public CopyAttributesRecord()
			: base(_tableName)
		{
			// Begin Generated Column Definitions
			columns.Add(new Column("COPY_ATTRIBUTES_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("GROUP_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ATTRIBUTE_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DEFAULT_VALUE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("OVERRIDE", String.Empty, "CHAR"));
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="CopyAttributesRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public CopyAttributesRecord(IDataReader reader)
			: base(reader, _tableName)
		{ }
		#endregion
		#region CopyAttributesId
		/// <summary>
		/// Gets or sets the copy attributes id.
		/// </summary>
		/// <value>The copy attributes id.</value>
		public string CopyAttributesId
		{
			get
			{
				return GetColumnValue("COPY_ATTRIBUTES_ID");
			}
			set
			{
				SetColumnValue("COPY_ATTRIBUTES_ID", value);
			}
		}
		#endregion
		#region GroupName
		/// <summary>
		/// Gets or sets the name of the group.
		/// </summary>
		/// <value>The name of the group.</value>
		public string GroupName
		{
			get
			{
				return GetColumnValue("GROUP_NAME");
			}
			set
			{
				SetColumnValue("GROUP_NAME", value);
			}
		}
		#endregion
        #region SourceAttributeName
        /// <summary>
        /// Gets or sets the name of the source attribute.
        /// </summary>
        /// <value>The name of the source attribute.</value>
        public string SourceAttributeName
        {
            get
            {
                return GetColumnValue("SOURCE_ATTRIBUTE_NAME");
            }
            set
            {
                SetColumnValue("SOURCE_ATTRIBUTE_NAME", value);
            }
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
				return GetColumnValue("ATTRIBUTE_NAME");
			}
			set
			{
				SetColumnValue("ATTRIBUTE_NAME", value);
			}
		}
		#endregion
		#region DefaultValue
		/// <summary>
		/// Gets or sets the default value.
		/// </summary>
		/// <value>The default value.</value>
		public string DefaultValue
		{
			get
			{
				return GetColumnValue("DEFAULT_VALUE");
			}
			set
			{
				SetColumnValue("DEFAULT_VALUE", value);
			}
		}
		#endregion
		#region Override
		/// <summary>
		/// Gets or sets the override.
		/// </summary>
		/// <value>The override.</value>
		public string Override
		{
			get
			{
				return GetColumnValue("OVERRIDE");
			}
			set
			{
				SetColumnValue("OVERRIDE", value);
			}
		}
		#endregion
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/CopyAttributesRecord.cs $
 * 
 * 5     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 4     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 3     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 2     3/27/09 11:23a Deepika.sharma
 * SED SAML Implementation - added new column to copy_attributes
 * 
 * 1     8/27/07 12:10p John.gwynn
 */
#endregion