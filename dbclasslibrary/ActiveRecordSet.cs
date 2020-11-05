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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ActiveRecordSet.cs 43    7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using DbClassLibrary.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Oracle;

namespace DbClassLibrary
{
  /// <summary>
  /// Summary description for ActiveRecordSet.
  /// </summary>
  [ClassInterface(ClassInterfaceType.None), Serializable]
  [Guid("5712810A-3AD0-41d7-AFF3-3222E29EF345")]
  public class ActiveRecordSet : SqlParameterReader, IActiveRecordSet, IEnumerable<ActiveRecord>, IEnumerator<ActiveRecord>
  {
    private readonly string _activeRecordType;
    /// <summary>
    /// overridable query 
    /// </summary>
    // ReSharper disable InconsistentNaming
    protected string query;
    // ReSharper restore InconsistentNaming
    private string _dbInstance;
    private string _lastErrorMessage;
    private int _current;

    private readonly List<ActiveRecord> _records;
    /// <summary>
    /// Initializes a new instance of the <see cref="ActiveRecordSet"/> class.
    /// Defautls to a set of ActiveRecord nodes
    /// </summary>
    public ActiveRecordSet()
      : this("ActiveRecord")
    { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActiveRecordSet"/> class.
    /// </summary>
    /// <param name="recordType">Type of the record.</param>
    public ActiveRecordSet(string recordType)
    {
      _activeRecordType = recordType;
      _records = new List<ActiveRecord>();
      query = String.Empty;
      _dbInstance = String.Empty;
      _lastErrorMessage = String.Empty;
      _current = -1;
    }

    /// <summary>
    /// Gets the records.
    /// </summary>
    public List<ActiveRecord> Records { get { return _records; } }

    private string PluralizeRecordType()
    {
      return _activeRecordType.EndsWith("s")
          ? _activeRecordType + "Set"
          : _activeRecordType + "s";
    }

    /// <summary>
    /// Gets the type of the record.
    /// </summary>
    /// <value>The type of the record.</value>
    public string RecordType
    {
      get { return _activeRecordType; }
    }
    /// <summary>
    /// Gets the last error.
    /// </summary>
    /// <value>The last error.</value>
    public string LastError
    {
      get { return _lastErrorMessage; }
    }

    /// <summary>
    /// Gets or sets the query.
    /// </summary>
    /// <value>The query.</value>
    virtual public string Query
    {
      get { return query; }
      set { query = value; }
    }

    /// <summary>
    /// Gets or sets the instance.
    /// </summary>
    /// <value>The instance.</value>
    public string Instance
    {
      get { return _dbInstance; }
      set { _dbInstance = value; }
    }

    /// <summary>
    /// Gets the count.
    /// </summary>
    /// <value>The count.</value>
    public int Count
    {
      get { return _records.Count; }
    }

    /// <summary>
    /// Executes this instance.
    /// </summary>
    /// <returns></returns>
    public bool Execute()
    {
      try
      {
        _records.Clear();
        if (_dbInstance.Length == 0)
          _dbInstance = ApplicationConfiguration.Instance.DefaultInstance;

        GeneralUtility.DebugLog("Execute entered", _activeRecordType);
        var db = new OracleDatabase(GeneralUtility.GetConnectStringFromInstance(_dbInstance));

        GeneralUtility.DebugLog("Database created", _activeRecordType);
        return ExecuteReader(db);
      }
      catch (Exception ex)
      {
        _lastErrorMessage = ex.Message;
        GeneralUtility.LogError(_lastErrorMessage, _activeRecordType);
      }
      return false;
    }

    /// <summary>
    /// Adds the query parameters.
    /// </summary>
    protected virtual void AddQueryParameters()
    { }

    /// <summary>
    /// Executes the reader.
    /// </summary>
    /// <param name="db">The db.</param>
    /// <returns></returns>
    [ComVisible(false)]
    private bool ExecuteReader(Database db)
    {
      bool results;
      try
      {
        _records.Clear();
        AddQueryParameters();

        using (var reader = ExecuteReader(db, Query))
        {
          while (reader.Read())
          {
            _records.Add(ActiveRecordFactoryMethod(reader, _activeRecordType, _dbInstance));
          }
          reader.Close();
        }
        _current = -1;
        results = _records.Count > 0;
      }
      catch (Exception ex)
      {
        results = false;
        _lastErrorMessage = ex.Message;
        GeneralUtility.LogError(_lastErrorMessage, _activeRecordType);
      }

      ResetParameters();
      return results;
    }

    /// <summary>
    /// Returns an enumerator that can iterate through a collection.
    /// </summary>
    /// <returns>
    /// An <see cref="T:System.Collections.IEnumerator"/>
    /// that can be used to iterate through the collection.
    /// </returns>
    [DispId(-4)]
    public IEnumerator GetEnumerator()
    {
      return this;
    }

    /// <summary>
    /// Toes the XML.
    /// </summary>
    /// <returns></returns>
    public string ToXml()
    {
      var xmlWriterSettings = new XmlWriterSettings { Encoding = new UTF8Encoding(true) };
      using (var memoryStream = new MemoryStream())
      {

        using (var writer = XmlWriter.Create(memoryStream, xmlWriterSettings))
        {
          if (writer != null)
          {
            writer.WriteStartDocument(true);
            writer.WriteStartElement(PluralizeRecordType());
            writer.WriteStartAttribute("Query");
            writer.WriteRaw(Query);
            writer.WriteEndAttribute();

            foreach (var r in _records)
              r.ToXml(writer);

            writer.WriteEndElement();
          }
        }
        return Encoding.UTF8.GetString(memoryStream.ToArray());
      }
    }

    /// <summary>
    /// Actives the record factory method.
    /// </summary>
    /// <param name="reader">The reader.</param>
    /// <param name="recordType">Type of the record.</param>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    private static ActiveRecord ActiveRecordFactoryMethod(IDataReader reader, string recordType, string instance)
    {
      ActiveRecord results = null;

      Type activeRecordType = ActiveRecord.IsActiveRecordType(recordType);
      if (activeRecordType != null && !recordType.Equals("ActiveRecord"))
      {
        var typeArray = new Type[1];
        typeArray[0] = reader.GetType();
        ConstructorInfo requestedConstructor = activeRecordType.GetConstructor(typeArray);
        if (requestedConstructor != null)
        {
          var parms = new object[1];
          parms[0] = reader;
          results = (ActiveRecord)requestedConstructor.Invoke(parms);
        }
      }
      else
      {
        results = new ActiveRecord(reader, recordType);
      }
      if (results != null)
      {
        results.Instance = instance;
      }
      return results;
    }

    /// <summary>
    /// return as array for interop
    /// </summary>
    /// <returns></returns>

    public ArrayList ToArray()
    {
      var results = new ArrayList();
      foreach (ActiveRecord record in this)
        results.Add(record.Clone());

      return results;
    }


    /// <summary>
    /// creates a typesafe cloned list
    /// </summary>
    /// <returns></returns>
    [ComVisible(false)]
    public List<IActiveRecord> ToList()
    {
      var results = new List<IActiveRecord>();
      foreach (ActiveRecord record in this)
        results.Add(record.Clone());

      return results;
    }


    #region IDisposable Members

    ///<summary>
    ///Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    ///</summary>
    ///<filterpriority>2</filterpriority>
    public void Dispose()
    {
      // note Dispose can be caled from Ienumerator
      // _records.Clear();
    }

    #endregion

    #region IDataRecord Members

    ///<summary>
    ///Gets the name for the field to find.
    ///</summary>
    ///
    ///<returns>
    ///The name of the field or the empty string (""), if there is no value to return.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public string GetName(int i)
    {
      if (_current > -1 && _current >= _records.Count)
      {
        return _records[_current].GetName(i);
      }
      throw new IndexOutOfRangeException(string.Format("ActiveRecordSet.GetName({0}) Failed!", i));
    }

    ///<summary>
    ///Gets the data type information for the specified field.
    ///</summary>
    ///
    ///<returns>
    ///The data type information for the specified field.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public string GetDataTypeName(int i)
    {
      if (_current > -1 && _current < _records.Count)
      {
        return _records[_current].GetDataTypeName(i);
      }
      throw new IndexOutOfRangeException(string.Format("ActiveRecordSet.GetDataTypeName({0}) Failed!", i));
    }

    ///<summary>
    ///Gets the <see cref="T:System.Type"></see> information corresponding to the type of <see cref="T:System.Object"></see> that would be returned from <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)"></see>.
    ///</summary>
    ///
    ///<returns>
    ///The <see cref="T:System.Type"></see> information corresponding to the type of <see cref="T:System.Object"></see> that would be returned from <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)"></see>.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public Type GetFieldType(int i)
    {
      if (_current > -1 && _current < _records.Count)
      {
        return _records[_current].GetFieldType(i);
      }
      throw new IndexOutOfRangeException(string.Format("ActiveRecordSet.GetFieldType({0}) Failed!", i));
    }

    ///<summary>
    ///Return the value of the specified field.
    ///</summary>
    ///
    ///<returns>
    ///The <see cref="T:System.Object"></see> which will contain the field value upon return.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public object GetValue(int i)
    {
      if (_current > -1 && _current <= _records.Count)
      {
        return _records[_current].GetValue(i);
      }
      throw new IndexOutOfRangeException(string.Format("ActiveRecordSet.GetValue({0}) Failed!", i));
    }

    ///<summary>
    ///Gets all the attribute fields in the collection for the current record.
    ///</summary>
    ///
    ///<returns>
    ///The number of instances of <see cref="T:System.Object"></see> in the array.
    ///</returns>
    ///
    ///<param name="values">An array of <see cref="T:System.Object"></see> to copy the attribute fields into. </param><filterpriority>2</filterpriority>
    [ComVisible(false)]
    public int GetValues(object[] values)
    {
      if (_current > -1 && _current < _records.Count)
      {
        return _records[_current].GetValues(values);
      }
      return 0;
    }

    ///<summary>
    ///Return the index of the named field.
    ///</summary>
    ///
    ///<returns>
    ///The index of the named field.
    ///</returns>
    ///
    ///<param name="name">The name of the field to find. </param><filterpriority>2</filterpriority>
    public int GetOrdinal(string name)
    {
      if (_current > -1 && _current < _records.Count)
      {
        return _records[_current].GetOrdinal(name);
      }
      return -1;
    }

    ///<summary>
    ///Gets the string value of the specified field.
    ///</summary>
    ///
    ///<returns>
    ///The string value of the specified field.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public string GetString(int i)
    {
      if (_current > -1 && _current < _records.Count)
      {
        return _records[_current].GetString(i);
      }
      throw new IndexOutOfRangeException(string.Format("ActiveRecordSet.GetString({0}) Failed!", i));
    }

    ///<summary>
    ///Gets the number of columns in the current row.
    ///</summary>
    ///
    ///<returns>
    ///When not positioned in a valid recordset, 0; otherwise the number of columns in the current record. The default is -1.
    ///</returns>
    ///<filterpriority>2</filterpriority>
    public int FieldCount
    {
      get
      {
        if (_current > -1 && _current < _records.Count)
        {
          return _records[_current].FieldCount;
        }
        return 0;
      }
    }

    ///<summary>
    ///Gets the column located at the specified index.
    ///</summary>
    ///
    ///<returns>
    ///The column located at the specified index as an <see cref="T:System.Object"></see>.
    ///</returns>
    ///
    ///<param name="i">The index of the column to get. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public object this[int i]
    {
      get
      {
        if (_current > -1 && _current < _records.Count)
        {
          if (i > -1 && i < _records[_current].Columns.Count)
            return _records[_current][i];
        }
        throw new IndexOutOfRangeException();
      }
    }

    /// <summary>
    /// Gets the record.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns></returns>
    public IActiveRecord GetRecord(int index)
    {
      if (index > -1 && index < _records.Count)
      {
        return _records[index];
      }
      return null;
    }

    ///<summary>
    ///Gets the column with the specified name.
    ///</summary>
    ///
    ///<returns>
    ///The column with the specified name as an <see cref="T:System.Object"></see>.
    ///</returns>
    ///
    ///<param name="name">The name of the column to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">No column with the specified name was found. </exception><filterpriority>2</filterpriority>
    public object this[string name]
    {
      get
      {
        if (_current > -1 && _current < _records.Count)
        {
          return _records[_current][name];
        }
        return null;
      }
    }

    #endregion

    #region IEnumerable<ActiveRecord> Members

    [ComVisible(false)]
    IEnumerator<ActiveRecord> IEnumerable<ActiveRecord>.GetEnumerator()
    {
      return _records.GetEnumerator();
    }

    /// <summary>
    /// 
    /// </summary>
    [ComVisible(false)]
    public IEnumerable<T> GetEnumerator<T>()
      where T : ActiveRecord
    {
      return _records.Cast<T>();
    }

    #endregion

    #region IEnumerator<ActiveRecord> Members

    /// <summary>
    /// Gets the element in the collection at the current position of the enumerator.
    /// </summary>
    /// <value></value>
    /// <returns>
    /// The element in the collection at the current position of the enumerator.
    /// </returns>
    public ActiveRecord Current
    {
      get { return _records[_current]; }
    }

    #endregion

    #region IEnumerator Members

    object IEnumerator.Current
    {
      get { return Current; }
    }

    /// <summary>
    /// Advances the enumerator to the next element of the collection.
    /// </summary>
    /// <returns>
    /// true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">
    /// The collection was modified after the enumerator was created.
    /// </exception>
    public bool MoveNext()
    {
      return (++_current < _records.Count);
    }

    /// <summary>
    /// Sets the enumerator to its initial position, which is before the first element in the collection.
    /// </summary>
    /// <exception cref="T:System.InvalidOperationException">
    /// The collection was modified after the enumerator was created.
    /// </exception>
    public void Reset()
    {
      _current = -1;
    }

    #endregion
  }

  /// <summary>
  /// I am creating this class to use as the base in order to achieve covariance
  /// with respect to the IEnumerable of type ActiveRecord.
  /// We can now have the subclasses i.e. IEnumerable of FroiImportField express
  /// the IEnumerable interface in a strongly typed manner.  I'm sure there is an easier
  /// way to do this (I would have done this from the start but we are evolving from 1.1)
  /// but for now it works...
  /// </summary>
  /// <typeparam name="T">The subclas to explicitly return</typeparam>
  [ComVisible(false), ClassInterface(ClassInterfaceType.None)]
  public class ActiveRecordSet<T> : ActiveRecordSet, IEnumerable<T> where T : ActiveRecord
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ActiveRecordSet&lt;T&gt;"/> class.
    /// </summary>
    /// <param name="baseTypeThatNeedsToChangeToRealTypes">The base type that needs to change to real types.</param>
    protected ActiveRecordSet(string baseTypeThatNeedsToChangeToRealTypes)
      : base(baseTypeThatNeedsToChangeToRealTypes)
    { }

    /// <summary>
    /// Resultses this instance.
    /// </summary>
    /// <returns></returns>
    public IEnumerable<T> Results()
    {
      Execute();
      return this;
    }

    #region IEnumerable<T> Members

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
    /// </returns>
    public new IEnumerator<T> GetEnumerator()
    {
      return Records.Cast<T>().GetEnumerator();
    }

    #endregion

    #region IEnumerable Members

    IEnumerator IEnumerable.GetEnumerator()
    {
      return base.GetEnumerator();
    }

    #endregion
  }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ActiveRecordSet.cs $
 * 
 * 43    7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 42    5/31/10 3:19p Gwynnj
 * Added outputItem and OutputItems for printing
 * 
 * 41    3/12/10 3:41p Gwynnj
 * added Results() to get linq cheap
 * 
 * 40    11/02/09 1:40p John.gwynn
 * minor edits
 * 
 * 39    10/29/09 11:15a John.gwynn
 * Added Employees and the ability to edit an employee
 * 
 * 38    10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 37    9/29/09 6:05p John.gwynn
 * Added DepartmentCodes for Esis Excel Load
 * 
 * 36    9/25/09 2:37p John.gwynn
 * Added ActiveRecordSet<T> to achieve covariance with respect to the
 * IEnumerable<ActiveRecord> base implementation for articulating strongly
 * typed repositories.
 * 
 * 35    9/22/09 11:05a John.gwynn
 * Import Field updates
 * 
 * 34    9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 33    6/05/09 7:28p John.gwynn
 * added CallData with ActiveRecord support for LONG RAW (only call_data
 * parameter at this point)
 * 
 * 32    6/01/09 4:09p John.gwynn
 * GetEnumerator to DISPID -4
 * 
 * 31    5/27/09 11:55a John.gwynn
 * added Security in the factoryMethod
 * 
 * 30    5/26/09 7:03p John.gwynn
 * Added deep cloning and ToArray, ToList support (ToArray is for interop
 * ToList is because we have no LINQ today)
 * 
 * 29    5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 27    4/23/09 3:24p John.gwynn
 * added support for named parameters.  refactored SQL processing to
 * SqlParameterReader class 
 * 
 * 26    4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 25    4/01/09 7:28p John.gwynn
 * added parameterized SQL to ActiveRecord and beefed up User class for
 * use in VbSecurity
 * 
 * 24    3/31/09 5:43p John.gwynn
 * added executeReader with support for parameterized SQL
 * 
 * 23    3/11/09 1:33p John.gwynn
 * added comments to public members
 * 
 * 22    3/11/09 12:24p John.gwynn
 * added GeneralUtility.ExecuteReader(sql) to return reader for a given
 * query 
 * 
 * 21    3/10/09 6:47p John.gwynn
 * added interfaces
 * 
 * 20    3/09/09 9:01p John.gwynn
 * 
 * 19    2/18/09 6:37p John.gwynn
 * added callflow frames
 * 
 * 18    2/18/09 10:54a Varun.jain
 * 
 * 17    2/05/09 11:31a Varun.jain
 * 
 * 16    11/29/07 3:05p John.gwynn
 * fix bug for generic activerecord based queries
 * 
 * 15    10/30/07 7:14p John.gwynn
 * ActiveRecordSet now sets instance on record instantiation.  Added
 * support for Evaluation of dynamic Business rules (see RuleRecordSet)
 * and added UsStates for eSurance dropdowns
 * 
 * 14    10/11/07 6:08p John.gwynn
 * implemented IDataRecord and IDataReader interfaces
 * 
 * 13    10/03/07 5:21p John.gwynn
 * Added ToXml to ActiveRecordSets
 * 
 * 12    10/01/07 12:08p John.gwynn
 * 
 * 11    8/27/07 12:10p John.gwynn
 * 
 * 10    8/07/07 6:15p John.gwynn
 * several fixes to default instance to registry when not supplied.
 * Specific destination support. Added ISequenceStep interface for OPM
 * 
 * 9     7/19/07 5:43p John.gwynn
 * UnitOfWork enhancements
 * 
 * 8     6/26/07 2:38p John.gwynn
 * fixed a bug in the overridable Query property
 * 
 * 7     6/04/07 4:47p John.gwynn
 * Added Specific Destination and sequenceStep for OPM
 * 
 * 6     6/03/07 2:52p John.gwynn
 * added Transmissionxxx to ActiveRecordSet factory method and verified
 * unit tests
 * 
 * 5     4/23/07 6:23p John.gwynn
 * Added interop wrapper classes (work in progress)
 * 
 * 4     4/20/07 5:16p John.gwynn
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 2     4/03/07 6:49p John.gwynn
 * ActiveRecordBase changed to ActiveRecord.  EsisPolicyLookup nullADODB
 * parms fixed.
 * 
 * 1     3/21/07 5:13p John.gwynn
 * Added support for ActiveRecordSet (IEnemerable (ActiveRecord) aggregate
 * to encapsulate general queries and form the base for strongly typed
 * collections
 */
#endregion
