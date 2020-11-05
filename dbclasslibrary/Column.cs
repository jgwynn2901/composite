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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Column.cs 16    3/02/12 12:14p Gwynnj $ */
#endregion
using System;
using System.Runtime.InteropServices;
using FnsComposite;
using System.Xml;
using Newtonsoft.Json;

namespace DbClassLibrary
{
  /// <summary>
  /// ActiveRecord class encapsulates table Column attributes.
  /// </summary>
  [ComVisible(false)]	
  public class Column : CompositeLeaf, ICloneable
  {
    private readonly string _columnType;
    private string _lastCommitedValue;
        private byte[] _buffer;

    /// <summary>
    /// Initializes a new instance of the <see cref="Column"/> class.
    /// </summary>
    /// <param name="columnName">Name of the column.</param>
    public Column(string columnName) : this(columnName, String.Empty,String.Empty)
    {}
    /// <summary>
    /// Initializes a new instance of the <see cref="Column"/> class.
    /// </summary>
    public Column(string columnName, string columnValue, string columntype): base (columnName, columnValue)
    {
      _columnType = columntype;
      _lastCommitedValue = columnValue;
    }

        /// <summary>
    /// Gets the type of the column.
    /// </summary>
    /// <value>The type of the column.</value>
    public string ColumnType
    {
      get { return _columnType; }
    }

    /// <summary>
    /// Gets a value indicating whether this instance is binary (LONG RAW).
    /// </summary>
    public bool IsBinary
    {
      get
      {
        return _columnType.Equals("LONG RAW", StringComparison.InvariantCultureIgnoreCase);
      }
    }

    public string QueryName
    {
      get
      {
        return !_columnType.Equals("SHORTDATE", StringComparison.InvariantCultureIgnoreCase) 
          ? Name 
          : string.Format("TO_CHAR({0},'MM/DD/YYYY') AS {0}", Name);
      }
    }
    /// <summary>
    /// Gets or sets the blob data buffer.
    /// </summary>
    public byte[] Data
    {
      get
      {
        return _buffer;
      }
      set
      {
        _buffer = new byte[value.Length];
        for (int i = 0; i < value.Length; ++i)
          _buffer[i] = value[i];
      }
    }

    /// <summary>
    /// serialize xml to writer
    /// </summary>
    public void ToXml(XmlWriter writer)
    {
      writer.WriteStartElement(Name);
      writer.WriteRaw(Value);
      writer.WriteEndElement();
    }

        public override void ToJson(JsonWriter jsonWriter)
        {
            jsonWriter.WritePropertyName(GeneralUtility.PascalCase(Name));
            jsonWriter.WriteValue(Value);
        }

    /// <summary>
    /// Commits this instance.
    /// </summary>
    public override void Commit()
    {
      _lastCommitedValue = Value;
      base.Commit();
    }

    /// <summary>
    /// Rollbacks this instance.
    /// </summary>
    public override void Rollback()
    {
      Value = _lastCommitedValue;
      base.Commit();
    }

    /// <summary>
    /// Gets a value indicating whether this instance has changed.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance has changed; otherwise, <c>false</c>.
    /// </value>
    public override bool HasChanged
    {
      get
      {
        return !_lastCommitedValue.Equals(Value);
      }
    }

    /// <summary>
    /// Compares to.
    /// </summary>
    public bool CompareTo(Column source)
    {
      return Name.Equals(source.Name) && Value.Equals(source.Value);
    }

    #region ICloneable Members

    /// <summary>
    /// Creates a new object that is a copy of the current instance.
    /// </summary>
    /// <returns>
    /// A new object that is a copy of this instance.
    /// </returns>
    object ICloneable.Clone()
    {
      return Clone();
    }

    /// <summary>
    /// Clones this instance.
    /// </summary>
    /// <returns></returns>
    public new Column Clone()
    {
      return Copy();
    }

    /// <summary>
    /// Copies this instance.
    /// </summary>
    private new Column Copy()
    {
      return new Column(Name, Value, _columnType);
    }
    
    #endregion
  }

    /// <summary>
    /// 
    /// </summary>
    public class RawColumn: Column
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RawColumn"/> class.
        /// </summary>
        /// <param name="columnName">Name of the column.</param>
        public RawColumn(string columnName) : base(columnName, String.Empty,String.Empty)
    {}
    /// <summary>
    /// Initializes a new instance of the <see cref="Column"/> class.
    /// </summary>
        public RawColumn(string columnName, string columnValue, string columntype)
            : base(columnName, columnValue, columntype)
    {}

        /// <summary>
        /// Gets or sets the value as raw text sans encoding.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public override string Value
        {
            get
            {
                return _nodeValue;
            }
            set
            {
                _nodeValue = value;
            }
        }
        
    }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Column.cs $
 * 
 * 16    3/02/12 12:14p Gwynnj
 * subclassed Calumn to RawCalumn to isolate raw text Value for CallXml
 * 
 * 15    3/02/12 10:49a Gwynnj
 * Call_xml field override uses raw calumn values sans encoding/decoding
 * 
 * 14    1/19/11 2:38p Gwynnj
 * Added support for SHORTDATE column type
 * 
 * 13    12/09/09 2:40p John.gwynn
 * Added CompareTo for Callflow compare/diff support
 * 
 * 12    10/28/09 5:21p John.gwynn
 * Removed redundant IAccountHeirarchyStep interface
 * 
 * 11    10/13/09 4:34p John.gwynn
 * Added update for AhsActiveRecord class (updates ESIS upload_key)
 * implemented in terms of only adding those columns that have changed
 * from initial load.  Can be used in all ActiveRecord update statements
 * and values are paramaeterized.
 * 
 * 10    10/01/09 12:27p Jim.borys
 * fixed ClsCompliance issues
 * 
 * 9     6/05/09 7:28p John.gwynn
 * added CallData with ActiveRecord support for LONG RAW (only call_data
 * parameter at this point)
 * 
 * 8     5/26/09 7:03p John.gwynn
 * Added deep cloning and ToArray, ToList support (ToArray is for interop
 * ToList is because we have no LINQ today)
 * 
 * 7     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 5     10/03/07 5:21p John.gwynn
 * Added ToXml to ActiveRecordSets
 * 
 * 4     6/27/07 6:12p John.gwynn
 * Added support for Insert (for OPM)
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 2     3/21/07 5:13p John.gwynn
 * Added support for ActiveRecordSet (IEnemerable (ActiveRecord) aggregate
 * to encapsulate general queries and form the base for strongly typed
 * collections
 */
#endregion
