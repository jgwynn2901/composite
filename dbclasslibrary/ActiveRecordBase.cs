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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/ActiveRecordBase.cs 51    5/24/11 4:12p Gwynnj $ */
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using DbClassLibrary.Interfaces;
using FnsComposite;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Oracle;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;


namespace DbClassLibrary
{
  /// <summary>
  /// Generic SQL based data access class emulating Fowler's Active Record Design Pattern
  /// </summary>
  [ClassInterface(ClassInterfaceType.None), Serializable]
  [Guid("E32F071F-B648-451a-94FD-95FDD05B37E3")]
  public class ActiveRecord : Composite, IActiveRecord, IDataRecord, ISqlParameterReader, ICloneable
  {
    /// <summary>
    /// collection of columns
    /// </summary>
    // ReSharper disable InconsistentNaming
    protected ColumnList columns;

    protected Action<JsonWriter> _serialize;

    /// <summary>
    /// The name of the database table 
    /// </summary>
    protected string tableName;
    protected string dbInstance;
    private string whereClauseOverride;
    protected bool _canDelete = false;

    /// <summary>
    /// olds the last errormessage returned from Oracle
    /// </summary>
    protected string lastErrorMessage;
    private string orderByClause;
    /// <summary>
    /// index for primary key field 
    /// </summary>
    protected int primaryKeyIndex; // default for most of FNSOWNER schema BUGBUG: need to formalize this
    // ReSharper restore InconsistentNaming
    private const string DefaultType = "String";
    /// <summary>
    /// Initializes a new instance of the <see cref="ActiveRecord"/> class.
    /// Required for COM Interop NB we need to now override the Name property
    /// </summary>
    public ActiveRecord()
      : this(String.Empty)
    { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActiveRecord"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    public ActiveRecord(string name)
      : base("ActiveRecord")
    {
      tableName = name;
      columns = new ColumnList();
      dbInstance = String.Empty;
      whereClauseOverride = String.Empty;
      lastErrorMessage = String.Empty;
      orderByClause = String.Empty;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ActiveRecord"/> class.
    /// </summary>
    /// <param name="source">The source.</param>
    public ActiveRecord(ActiveRecord source)
      : base("ActiveRecord")
    {
      tableName = source.tableName;
      columns = new ColumnList(source.columns);

      // keep state intact
      dbInstance = source.dbInstance;
      whereClauseOverride = source.whereClauseOverride;
      lastErrorMessage = source.lastErrorMessage;
      orderByClause = source.orderByClause;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActiveRecord"/> class.
    /// </summary>
    /// <param name="row">The row.</param>
    public ActiveRecord(DataRow row)
      : this(row.Table.TableName)
    {
      foreach (DataColumn col in row.ItemArray)
        columns.Add(new Column(col.ColumnName, col.ToString(), col.DataType.ToString()));
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActiveRecord"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    /// <param name="tableName">Name of the table.</param>
    public ActiveRecord(IDataReader reader, string tableName)
      : this(tableName)
    {
      Fill(reader);
    }


    internal void Fill(IDataReader reader)
    {
      var dt = reader.GetSchemaTable();
      if (dt == null) return;
      var oracleReader = ((OracleDataReaderWrapper)reader).InnerReader;
      foreach (var row in dt.Rows.Cast<DataRow>().Where(row => columns.IndexOf(row[0].ToString()) <= -1))
      {
        columns.Add(new Column(row["COLUMNNAME"].ToString(), String.Empty, row["DATATYPE"].ToString()));
      }
      // OK we've got the list of Columns now fill them
      var index = 0;
      foreach (var col in columns)
      {
        if (col.ColumnType == "System.Byte[]")
        {
          var buffer = new byte[16];
          var size = oracleReader.GetBytes(index++, 0, buffer, 0, 16);
          if (size == 16) // GUID
          {
            col.Value = GeneralUtility.GetHexString(buffer);
          }
        }
        else
          col.Value = reader.GetValue(index++).ToString();

        col.Commit();
      }
    }

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public new string Name
    {
      get { return tableName; }
      set { tableName = value; }
    }
    /// <summary>
    /// Gets the columns.
    /// </summary>
    /// <value>The columns.</value>
    [ComVisible(false)]
    public List<Column> Columns
    {
      get { return columns.ToList(); }
    }
    /// <summary>
    /// Gets or sets the instance.
    /// </summary>
    /// <value>The instance.</value>
    public string Instance
    {
      get { return dbInstance; }
      set { dbInstance = value; }
    }
    /// <summary>
    /// Gets or sets the where.
    /// </summary>
    /// <value>The where.</value>
    public string Where
    {
      get { return whereClauseOverride.Length > 0 ? whereClauseOverride : GenerateWhereClause(); }
      set { whereClauseOverride = value; }
    }
    /// <summary>
    /// Initializes this instance.
    /// </summary>
    public void Initialize()
    {
      try
      {
        var def = new TableDefinition(dbInstance) { TableName = Name };
        if (!def.Execute())
        {
          throw new ApplicationException(def.LastError);
        }
        foreach (TableDefinition row in def)
        {
          var col = new Column(row.ColumnName, String.Empty, row.DataType);
          columns.Add(col);
        }
      }
      catch (Exception ex)
      {
        GeneralUtility.LogError(ex.Message, Name);
        throw;
      }
    }
    /// <summary>
    /// Sets the column value.
    /// </summary>
    /// <param name="colName">Name of the col.</param>
    /// <param name="colValue">The col value.</param>
    /// <returns></returns>
    public bool SetColumnValue(string colName, string colValue)
    {
      if (columns[colName] == default(Column)) return false;
      columns[colName].Value = colValue;
      return true;
    }
    /// <summary>
    /// Gets the column value.
    /// </summary>
    /// <param name="colName">Name of the col.</param>
    /// <returns></returns>
    public string GetColumnValue(string colName)
    {
      var column = columns[colName.ToUpper()];
      return column  != null ? column.Value : String.Empty;
    }

    public string GetColumnValueAsShortDate(string colName)
    {
      DateTime dateValue;
      var column = columns[colName.ToUpper()];
      var results = column != null ? column.Value : String.Empty;
      if (string.IsNullOrEmpty(results)) return results;
      return DateTime.TryParse(results, out dateValue) ? dateValue.ToShortDateString() : results;
    }

    /// <summary>
    /// 
    /// </summary>
    public int? GetColumnValueAsInt(string column)
    {
      int result;

      if (int.TryParse(GetColumnValue(column), out result))
        return result;
      return null;
    }

    /// <summary>
    /// Gets or sets the index of the primary key.
    /// </summary>
    /// <value>The index of the primary key.</value>
    public int PrimaryKeyIndex
    {
      get { return primaryKeyIndex; }
      set { primaryKeyIndex = value; }
    }
    /// <summary>
    /// Sets the primary key value.
    /// </summary>
    /// <param name="colValue">The col value.</param>
    /// <returns></returns>
    public bool SetPrimaryKeyValue(string colValue)
    {
      return SetColumnValue(primaryKeyIndex, colValue);
    }

    /// <summary>
    /// Sets the index of the primary key.
    /// </summary>
    public bool SetPrimaryKeyIndex(string columnName)
    {
      var index = 0;
      foreach (var column in Columns)
      {
        if (column.Name.Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
        {
          primaryKeyIndex = index;
          return true;
        }
        ++index;
      }
      return false;
    }
    /// <summary>
    /// Sets the column value.
    /// </summary>
    /// <param name="colIndex">Index of the col.</param>
    /// <param name="colValue">The col value.</param>
    /// <returns></returns>
    private bool SetColumnValue(int colIndex, string colValue)
    {
      var col = columns[colIndex];
      if (col != null && colValue != null)
      {
        col.Value = colValue;
        return true;
      }
      return false;
    }

    /// <summary>
    /// Resets this instance.
    /// </summary>
    public void Reset()
    {
      foreach (Column c in columns)
      {
        c.Value = String.Empty;
        c.Commit();
      }
    }
    /// <summary>
    /// Gets the select.
    /// </summary>
    /// <value>The select.</value>
    public string Select
    {
      get
      {
        return GenerateSelectFrom();
      }
    }
    /// <summary>
    /// Gets the last error.
    /// </summary>
    /// <value>The last error.</value>
    public new string LastError
    {
      get { return lastErrorMessage; }
    }
    /// <summary>
    /// Gets or sets the order by clause.
    /// </summary>
    /// <value>The order by.</value>
    public string OrderBy
    {
      get { return orderByClause; }
      set { orderByClause = value; }
    }
    /// <summary>
    /// Executes this query.
    /// </summary>
    /// <returns></returns>
    public bool Execute()
    {
      bool results;
      try
      {
        GeneralUtility.DebugLog("Execute entered", Name);
        if (dbInstance.Length == 0)
        {
          dbInstance = ApplicationConfiguration.Instance.DefaultInstance;
        }
        Database db = new OracleDatabase(GeneralUtility.GetConnectStringFromInstance(dbInstance));
        GeneralUtility.DebugLog("Database created", Name);
        results = Execute(db);
      }
      catch (Exception ex)
      {
        results = false;
        lastErrorMessage = ex.Message;
        GeneralUtility.LogError(lastErrorMessage, Name);
      }
      return results;
    }
    /// <summary>
    /// Inserts the specified db.
    /// </summary>
    /// <param name="db">The db.</param>
    /// <returns></returns>
    public bool Insert(Database db)
    {
      return ExecuteNonQuery(db, GenerateInsertSql());
    }

    /// <summary>
    /// Updates the table record.
    /// </summary>
    public bool Update(Database db)
    {
      var sql = GenerateUpdateSql();
      if (string.IsNullOrEmpty(sql)) return false;
      AddUpdateParameters();
      return ExecuteNonQuery(db, sql);
    }

    /// <summary>
    /// If you use parameters in your update SQL
    /// You must also override this method to add
    /// their corresponding values from properties.
    /// </summary>
    protected virtual void AddUpdateParameters()
    {}

    /// <summary>
    /// Deletes the specified record.
    /// </summary>
    public bool Delete(Database db)
    {
      return ExecuteNonQuery(db, GenerateDeleteSql());
    }

    /// <summary>
    /// Generates the delete SQL
    /// subclasses must implement this explicitely
    /// for delete to work.  Carefully we presume...
    /// </summary>
    /// <returns></returns>
    protected virtual string GenerateDeleteSql()
    {
      var filter = GenerateWhereClause();
      if (string.IsNullOrEmpty(filter))
        throw new ApplicationException(string.Format("Attempt to delete with no primary key."));

      return string.Format("DELETE from {0} {1}", Name, filter);
    }

    /// <summary>
    /// Executes the query san results.
    /// It is assumed that the return is 1 row affected.
    /// </summary>
    protected virtual bool ExecuteNonQuery(Database db, string commandText)
    {
      try
      {
        return _sqlReader.ExecuteNonQuery(db, commandText) > 0;
      }

      catch (Exception ex)
      {
        lastErrorMessage = ex.Message;
        GeneralUtility.LogError(lastErrorMessage, Name);
      }
      return false;
    }


    /// <summary>
    /// Inserts this instance.
    /// </summary>
    /// <returns></returns>
    public bool Insert()
    {
      bool results;
      try
      {
        if (dbInstance.Length == 0)
        {
          dbInstance = ApplicationConfiguration.Instance.DefaultInstance;
        }
        GeneralUtility.DebugLog("Insert entered", Name);
        var db = new OracleDatabase(GeneralUtility.GetConnectStringFromInstance(dbInstance));
        GeneralUtility.DebugLog("Database created", Name);
        results = Insert(db);
      }
      catch (Exception ex)
      {
        results = false;
        lastErrorMessage = ex.Message;
        GeneralUtility.LogError(lastErrorMessage, Name);
      }
      return results;
    }

    /// <summary>
    /// Generates the update SQL.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns></returns>
    protected virtual string GenerateUpdateSql()
    {
      throw new NotImplementedException("Update Sql for this object is not defined!");
    }

    /// <summary>
    /// Generates the update SQL for changes.
    /// </summary>
    protected string GenerateUpdateSqlForChanges()
    {
      var hasChanges = false;
      var updateSql = new StringBuilder();

      updateSql.AppendFormat("update {0} set ", Name);
      var first = true;

      foreach (var column in columns.Where(column => column.HasChanged))
      {
        if (column == columns[PrimaryKeyIndex])
          throw new ApplicationException(string.Format("Attempt to update primary key column {0} which has apparently changed.", column.Name));

        if (first)
        {
          first = false;
          updateSql.AppendFormat("{0} = :{0}", column.Name);
        }
        else
          updateSql.AppendFormat(",{0} = :{0}", column.Name);

        AddParameter(column.Name, column.Value);
        if (!hasChanges) hasChanges = true;
      }

      if (!hasChanges) return "";
      var whereClause = GenerateWhereClause();
      if (string.IsNullOrEmpty(whereClause))
        throw new ApplicationException(string.Format("Attempt to update {0} with no valid where clause.", Name));
      updateSql.AppendFormat(" {0}", whereClause);
      return updateSql.ToString();
    }
    /// <summary>
    /// Updates this instance.
    /// </summary>
    /// <returns></returns>
    public bool Update()
    {
      try
      {
        var sql = GenerateUpdateSql();
        if (!string.IsNullOrEmpty(sql))
        {
          if (dbInstance.Length == 0)
            dbInstance = ApplicationConfiguration.Instance.DefaultInstance;

          GeneralUtility.DebugLog("Update entered", Name);
          var db = new OracleDatabase(GeneralUtility.GetConnectStringFromInstance(dbInstance));
          GeneralUtility.DebugLog("Database created", Name);
          AddUpdateParameters();
          if (ExecuteNonQuery(db, sql))
          {
            foreach (var c in columns)
              c.Commit();

            return true;
          }
        }
      }
      catch (Exception ex)
      {
        lastErrorMessage = ex.Message;
        GeneralUtility.LogError(lastErrorMessage, Name);
      }
      return false;
    }

    /// <summary>
    /// Deletes this instance.
    /// </summary>
    /// <returns></returns>
    public bool Delete()
    {
      bool results;
      try
      {
        if (!_canDelete) return false;
        if (dbInstance.Length == 0)
          dbInstance = ApplicationConfiguration.Instance.DefaultInstance;

        GeneralUtility.DebugLog("Delete entered", Name);
        var db = new OracleDatabase(GeneralUtility.GetConnectStringFromInstance(dbInstance));
        GeneralUtility.DebugLog("Database created", Name);
        results = Delete(db);
        Reset();
      }
      catch (Exception ex)
      {
        results = false;
        lastErrorMessage = ex.Message;
        GeneralUtility.LogError(lastErrorMessage, Name);
      }
      return results;
    }

    /// <summary>
    /// Executes the specified db.
    /// </summary>
    /// <param name="db">The db.</param>
    /// <returns></returns>
    public bool Execute(Database db)
    {
      return ExecuteReader(db);
    }

    private bool ExecuteReader(Database db)
    {
      bool results;
      try
      {
        using (var reader = _sqlReader.ExecuteReader(db, BuildQuery()))
        {
          var oracleReader = ((OracleDataReaderWrapper)reader).InnerReader;
          results = reader.Read();
          if (results)
          {
            var index = 0;
            foreach (var col in columns)
            {
              if (oracleReader != null && col.ColumnType.Contains("RAW"))
              {
                var data = oracleReader.GetOracleBinary(index);
                if (!data.IsNull && data.Length > 0)
                  col.Data = data.Value;
              }
              else if (col.ColumnType.Equals("BLOB"))
              {
                if (oracleReader != null)
                {
                  var blob = oracleReader.GetOracleBlob(index);
                  if (!blob.IsNull)
                  {
                    var buffer = new byte[blob.Length];
                    blob.Read(buffer, 0, buffer.Length);
                    col.Data = buffer;
                  }
                }
              }
              else
              {
                col.Value = reader.GetValue(index++).ToString();
                col.Commit();
              }
            }
          }
          reader.Close();
        }
      }
      catch (Exception ex)
      {
        results = false;
        lastErrorMessage = ex.Message;
        GeneralUtility.LogError(lastErrorMessage, Name);

      }

      return results;
    }

    /// <summary>
    /// Gets the next sequence.
    /// </summary>
    /// <returns></returns>
    public string GetNextSequence()
    {
      try
      {
        var seq = new Sequence(Name) { Instance = dbInstance };
        if (!seq.Execute())
          throw new ApplicationException(seq.LastError);
        return seq.NextValue.ToString(CultureInfo.InvariantCulture);
      }
      catch (Exception ex)
      {
        lastErrorMessage = ex.Message;
        // GeneralUtility.LogError(lastErrorMessage, Name);
        throw;
      }
    }
    /// <summary>
    /// convert to string in xml format
    /// </summary>
    /// <returns></returns>
    public override string ToXml()
    {
      var xmlWriterSettings = new XmlWriterSettings { Encoding = new UTF8Encoding(true) };
      using (var memoryStream = new MemoryStream())
      {
        using (XmlWriter writer = XmlWriter.Create(memoryStream, xmlWriterSettings))
        {
          writer.WriteStartDocument(true);
          ToXml(writer);
        }
        return Encoding.UTF8.GetString(memoryStream.ToArray());
      }
    }

    public override string ToJson()
    {
      var results = new StringBuilder();
      using (var sw = new StringWriter(results))
      {
        using (JsonWriter jsonWriter = new JsonTextWriter(sw))
        {
          jsonWriter.Formatting = Formatting.Indented;
          //jsonWriter.WritePropertyName(GeneralUtility.PascalCase(Name));
          jsonWriter.WriteStartObject();
          ToJsonArray(jsonWriter);
          jsonWriter.WriteEndObject();
        }
      }
      return results.ToString();
    }

    internal void ToJsonArray(JsonWriter jsonWriter)
    {
      foreach (var c in Columns)
      {
        c.ToJson(jsonWriter);
      }
      if (_serialize != null)
        _serialize(jsonWriter);
    }

    /// <summary>
    /// serialized XML to writer.
    /// </summary>
    public void ToXml(XmlWriter writer)
    {
      writer.WriteStartElement(tableName);
      foreach (var c in columns)
        c.ToXml(writer);
      writer.WriteEndElement();
    }
    /// <summary>
    /// Generates the select from statement.
    /// </summary>
    /// <returns></returns>
    public virtual string GenerateSelectFrom()
    {
      var sql = new StringBuilder();
      
      InitEncryption();
      if (columns.Count <= 0) return sql.ToString();
      var isFirst = true;
      sql.Append("SELECT ");
      foreach (var col in columns)
      {
        if (isFirst)
        {
          isFirst = false;
        }
        else
        {
          sql.Append(",");
        }
        sql.Append(GetColumnQueryName(col));
      }
      sql.AppendFormat(" FROM {0} ", Name);
      return sql.ToString();
    }

    /// <summary>
    /// Initializes the encryption.
    /// </summary>
    protected virtual void InitEncryption()
    {}

    /// <summary>
    /// Gets the name of the column query.
    /// Override this to apply formating filters i.e. encryption
    /// </summary>
    /// <param name="col">The col.</param>
    /// <returns></returns>
    protected virtual string GetColumnQueryName(Column col)
    {
      return col.QueryName;
    }
    /// <summary>
    /// Gets the name of the column filter. 
    /// Same as above but tailored for where clause.
    /// </summary>
    /// <param name="col">The col.</param>
    /// <returns></returns>
    protected virtual string GetColumnFilterName(Column col)
    {
      return col.QueryName;
    }

    /// <summary>
    /// Gets the name of the column filter.
    /// </summary>
    /// <param name="columnName">Name of the column.</param>
    /// <returns></returns>
    /// <exception cref="System.ApplicationException"></exception>
    public string GetColumnFilterName(string columnName)
    {
      var col = columns[columnName];
      if (col != null)
      {
        return GetColumnFilterName(col);
      }
      throw new ApplicationException(columnName + " not found!");
    }

    /// <summary>
    /// Gets the column filter value.
    /// </summary>
    /// <param name="columnName">Name of the column.</param>
    /// <returns></returns>
    /// <exception cref="System.ApplicationException"></exception>
    public string GetColumnFilterValue(string columnName)
    {
      var col = columns[columnName];
      if (col != null)
      {
        return GetColumnFilterValue(col);
      }
      throw new ApplicationException(columnName + " not found!");
    }


    protected virtual string GetColumnFilterValue(Column col)
    {
      return col.ColumnType.Contains("CHAR") ? "'" + col.Value + "'" : col.Value;
    }

    /// <summary>
    /// Gets the column query value.
    /// </summary>
    /// <param name="col">The col.</param>
    /// <returns></returns>
    protected virtual string GetColumnQueryValue(Column col)
    {
      return col.ColumnType.Contains("CHAR") ? "'" + col.Value + "'" : col.Value;
    }
    /// <summary>
    /// Generates the insert SQL.
    /// </summary>
    /// <returns></returns>
    protected virtual string GenerateInsertSql()
    {
      return String.Format("INSERT INTO {0} {1} VALUES {2}",
                           tableName, GenerateInsertColumnsClause(),
                           GenerateInsertValuesClause());
    }
    /// <summary>
    /// Generates the insert columns clause.
    /// </summary>
    /// <returns></returns>
    protected virtual string GenerateInsertColumnsClause()
    {
      var sql = new StringBuilder();

      sql.Append("(");
      var isFirst = true;
      foreach (var col in columns.Where(col => col.Value.Length > 0))
      {
        if (isFirst)
        {
          isFirst = false;
        }
        else
        {
          sql.Append(",");
        }
        sql.Append(col.Name);
      }
      sql.Append(")");

      return sql.ToString();
    }

    /// <summary>
    /// Generates the insert values clause.
    /// </summary>
    /// <returns></returns>
    protected virtual string GenerateInsertValuesClause()
    {
      var sql = new StringBuilder();
      sql.Append("(");
      var isFirst = true;
      foreach (var col in columns.Where(col => col.Value.Length > 0))
      {
        if (isFirst)
        {
          isFirst = false;
        }
        else
        {
          sql.Append(",");
        }
        if (col.ColumnType.IndexOf("NUMBER", StringComparison.Ordinal) > -1)
        {
          sql.Append(!string.IsNullOrEmpty(col.Value) ? col.Value : "null");
        }
        else if (col.ColumnType.IndexOf("SHORTDATE", StringComparison.Ordinal) > -1)
        {
          sql.AppendFormat("TO_DATE('{0}','MM/DD/YYYY')", col.Value);
        }
        else if (col.ColumnType.IndexOf("DATE", StringComparison.Ordinal) > -1)
        {
          sql.AppendFormat("TO_DATE('{0}','MM/DD/YYYY HH12:MI:SS AM')", col.Value);
        }
        else
        {
          sql.AppendFormat("'{0}'", col.Value);
        }
      }
      sql.Append(")");
      return sql.ToString();
    }

    /// <summary>
    /// Generates the where clause.
    /// </summary>
    /// <returns></returns>
    protected virtual string GenerateWhereClause()
    {
      return whereClauseOverride.Length > 0
          ? String.Format("\r\nWHERE {0}", whereClauseOverride)
          : GeneratePrimaryKeyWhereClause();
    }

    /// <summary>
    /// Generates the primary key where clause.
    /// </summary>
    /// <returns></returns>
    protected virtual string GeneratePrimaryKeyWhereClause()
    {
      var primaryKeyCol = columns[primaryKeyIndex];
      if (primaryKeyCol == null || primaryKeyCol.Value.Length <= 0)
        throw new ApplicationException("GeneratePrimaryKeyWhereClause failed!");
      // TODO:  This is woefully inadaquate!!!
      const string baseFormattedClause = "WHERE {0} = {1}";
      return string.Format(baseFormattedClause, GetColumnFilterName(primaryKeyCol), GetColumnFilterValue(primaryKeyCol));
    }
    /// <summary>
    /// Builds the query.
    /// </summary>
    /// <returns></returns>
    protected virtual string BuildQuery()
    {
      return String.Format("{0}\n\r{1}\r\n{2}", GenerateSelectFrom(), GenerateWhereClause(), orderByClause);
    }

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
      if (columns.Count >= i)
      {
        return columns[i].Name;
      }
      throw new IndexOutOfRangeException(String.Format("IDataReader.GetName({0}) Failed!", i));
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
      if (columns.Count >= i)
      {
        return DefaultType; //BUGBUG:  Default everything to string for now
      }
      throw new IndexOutOfRangeException(String.Format("IDataReader.GetDataTypeName({0}) Failed!", i));
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
      if (columns.Count >= i)
      {
        return typeof(string); //BUGBUG:  Default everything to string for now
      }
      throw new IndexOutOfRangeException(String.Format("IDataReader.GetDataTypeName({0}) Failed!", i));
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
      if (columns.Count >= i)
      {
        return columns[i].Value;
      }
      throw new IndexOutOfRangeException(String.Format("IDataReader.GetName({0}) Failed!", i));
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
    public int GetValues(object[] values)
    {
      int result = 0;
      foreach (Column c in columns)
      {
        if (values.GetUpperBound(0) < result)
        {
          break;
        }
        values[result++] = c.Value;
      }
      return result;
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
      int result = 0;
      bool found = false;
      foreach (Column c in columns)
      {
        if (String.Compare(c.Name, name, StringComparison.OrdinalIgnoreCase) == 0)
        {
          found = true;
          break;
        }
        ++result;
      }
      if (!found)
        throw new IndexOutOfRangeException(String.Format("IDataReader.GetOrdinal({0}) Failed!", name));

      return result;
    }

    /// <summary>
    /// Gets the value of the specified column as a Boolean.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns>
    /// The value of the column.
    /// </returns>
    /// 
    /// <param name="i">The zero-based column ordinal. </param>
    /// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public bool GetBoolean(int i)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Gets the 8-bit unsigned integer value of the specified column.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns>
    /// The 8-bit unsigned integer value of the specified column.
    /// </returns>
    /// 
    /// <param name="i">The zero-based column ordinal. </param>
    /// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public byte GetByte(int i)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Reads a stream of bytes from the specified column offset into the buffer as an array, starting at the given buffer offset.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns>
    /// The actual number of bytes read.
    /// </returns>
    /// 
    /// <param name="buffer">The buffer into which to read the stream of bytes. </param>
    /// <param name="bufferoffset">The index for buffer to start the read operation. </param>
    /// <param name="fieldOffset">The index within the field from which to start the read operation. </param>
    /// <param name="i">The zero-based column ordinal. </param>
    /// <param name="length">The number of bytes to read. </param>
    /// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Gets the character value of the specified column.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns>
    /// The character value of the specified column.
    /// </returns>
    /// 
    /// <param name="i">The zero-based column ordinal. </param>
    /// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public char GetChar(int i)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Reads a stream of characters from the specified column offset into the buffer as an array, starting at the given buffer offset.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns>
    /// The actual number of characters read.
    /// </returns>
    /// 
    /// <param name="fieldoffset">The index within the row from which to start the read operation. </param>
    /// <param name="buffer">The buffer into which to read the stream of bytes. </param>
    /// <param name="bufferoffset">The index for buffer to start the read operation. </param>
    /// <param name="i">The zero-based column ordinal. </param>
    /// <param name="length">The number of bytes to read. </param>
    /// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
    {
      throw new NotImplementedException();
    }

    ///<summary>
    ///Returns the GUID value of the specified field.
    ///</summary>
    ///
    ///<returns>
    ///The GUID value of the specified field.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public Guid GetGuid(int i)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Gets the 16-bit signed integer value of the specified field.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns>
    /// The 16-bit signed integer value of the specified field.
    /// </returns>
    /// 
    /// <param name="i">The index of the field to find. </param>
    /// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public short GetInt16(int i)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Gets the 32-bit signed integer value of the specified field.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns>
    /// The 32-bit signed integer value of the specified field.
    /// </returns>
    /// 
    /// <param name="i">The index of the field to find. </param>
    /// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public int GetInt32(int i)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Gets the 64-bit signed integer value of the specified field.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns>
    /// The 64-bit signed integer value of the specified field.
    /// </returns>
    /// 
    /// <param name="i">The index of the field to find. </param>
    /// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public long GetInt64(int i)
    {
      throw new NotImplementedException();
    }

    ///<summary>
    ///Gets the single-precision floating point number of the specified field.
    ///</summary>
    ///
    ///<returns>
    ///The single-precision floating point number of the specified field.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public float GetFloat(int i)
    {
      throw new NotImplementedException();
    }

    ///<summary>
    ///Gets the double-precision floating point number of the specified field.
    ///</summary>
    ///
    ///<returns>
    ///The double-precision floating point number of the specified field.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public double GetDouble(int i)
    {
      throw new NotImplementedException();
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
      return GetValue(i) as string;
    }

    ///<summary>
    ///Gets the fixed-position numeric value of the specified field.
    ///</summary>
    ///
    ///<returns>
    ///The fixed-position numeric value of the specified field.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public decimal GetDecimal(int i)
    {
      throw new NotImplementedException();
    }

    ///<summary>
    ///Gets the date and time data value of the specified field.
    ///</summary>
    ///
    ///<returns>
    ///The date and time data value of the spcified field.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public DateTime GetDateTime(int i)
    {
      throw new NotImplementedException();
    }

    ///<summary>
    ///Gets an <see cref="T:System.Data.IDataReader"></see> to be used when the field points to more remote structured data.
    ///</summary>
    ///
    ///<returns>
    ///An <see cref="T:System.Data.IDataReader"></see> to be used when the field points to more remote structured data.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public IDataReader GetData(int i)
    {
      throw new NotImplementedException();
    }

    ///<summary>
    ///Return whether the specified field is set to null.
    ///</summary>
    ///
    ///<returns>
    ///true if the specified field is set to null. Otherwise, false.
    ///</returns>
    ///
    ///<param name="i">The index of the field to find. </param>
    ///<exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount"></see>. </exception><filterpriority>2</filterpriority>
    public bool IsDBNull(int i)
    {
      return false;
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
      get { return columns.Count; }
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
        return GetValue(i) as string;
      }
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
    public new object this[string name]
    {
      get { return GetColumnValue(name); }
    }

    #endregion

    #region ISqlParameterReader Members

    private readonly SqlParameterReader _sqlReader = new SqlParameterReader();

    /// <summary>
    /// Adds a parameter if using parameterized SQL
    /// using the default idiom of :1, :2 ... :n
    /// </summary>
    /// <param name="parm">The parm.</param>
    public void AddParameter(object parm)
    {
      _sqlReader.AddParameter(parm);
    }

    /// <summary>
    /// Adds a named parameter to the parameters collection.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="parm"></param>
    public void AddParameter(string name, object parm)
    {
      _sqlReader.AddParameter(name, parm);
    }

    /// <summary>
    /// Gets the parameters collection.
    /// </summary>
    /// <value>The lazy parameters.</value>
    [ComVisible(false)]
    public Dictionary<string, object> LazyParameters
    {
      get { return _sqlReader.LazyParameters; }
    }

    /// <summary>
    /// Executes the reader.
    /// </summary>
    /// <param name="db">The database (connection).</param>
    /// <param name="query">The SQL query.</param>
    /// <returns></returns>
    [ComVisible(false)]
    public IDataReader ExecuteReader(Database db, string query)
    {
      return _sqlReader.ExecuteReader(db, query);
    }

    /// <summary>
    /// Resets the parameters.
    /// </summary>
    void ISqlParameterReader.ResetParameters()
    {
      _sqlReader.ResetParameters();
    }

    /// <summary>
    /// Executes the SQL command.
    /// </summary>
    /// <param name="db">The database.</param>
    /// <param name="command">The SQL command.</param>
    /// <returns>
    /// The number of rows affected by the command.
    /// </returns>
    int ISqlParameterReader.ExecuteNonQuery(Database db, string command)
    {
      return _sqlReader.ExecuteNonQuery(db, command);
    }

    #endregion

    #region ICloneable Members

    object ICloneable.Clone()
    {
      return Clone();
    }

    /// <summary>
    /// Clones this instance.
    /// </summary>
    /// <returns></returns>
    public new ActiveRecord Clone()
    {
      return Copy();
    }


    #endregion

    private new ActiveRecord Copy()
    {
      ActiveRecord results = null;

      // get copy constructor
      var typeArray = new Type[1];
      typeArray[0] = typeof(ActiveRecord);

      ConstructorInfo requestedConstructor = GetType().GetConstructor(typeArray);

      if (requestedConstructor != null)
        results = (ActiveRecord)requestedConstructor.Invoke(new object[] { this });

      return results ?? (new ActiveRecord(tableName));
    }

    /// <summary>
    /// Determines whether [is active record type] [the specified record type].
    /// </summary>
    /// <param name="recordType">Type of the record.</param>
    /// <returns></returns>
    public static Type IsActiveRecordType(string recordType)
    {
      var requestedAssembly = Assembly.GetExecutingAssembly();
      var results =
          requestedAssembly.GetType(string.Format("DbClassLibrary.ActiveRecords.{0}", recordType)) ??
          requestedAssembly.GetType(string.Format("DbClassLibrary.Opm.{0}", recordType)) ??
          requestedAssembly.GetType(string.Format("DbClassLibrary.Callflow.{0}", recordType)) ??
          requestedAssembly.GetType(string.Format("DbClassLibrary.Security.{0}", recordType)) ??
          requestedAssembly.GetType(string.Format("DbClassLibrary.Import.{0}", recordType)) ??
          requestedAssembly.GetType(string.Format("DbClassLibrary.{0}", recordType));


      // TODO: need to ensure we are dealing with a true activerecord type.
      // right now this bug is masked by the fact that we need a constructor that taked an IDataReader.
      return results;
    }


    /// <summary>
    /// Gets the column value as int.
    /// </summary>
    /// <param name="columnName">Name of the column.</param>
    /// <returns></returns>
    int IActiveRecord.GetColumnValueAsInt(string columnName)
    {
      return GetColumnValueAsInt(columnName) ?? 0;
    }

    /// <summary>
    /// Gets the column value as date time.
    /// </summary>
    protected DateTime? GetColumnValueAsDateTime(string columnName)
    {
      var columnValue = GetColumnValue(columnName);
      if (string.IsNullOrEmpty(columnValue)) return null;
      DateTime results;
      if (DateTime.TryParse(columnValue, out results))
        return results;
      return null;
    }

    /// <summary>
    /// toString
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      var results = new StringBuilder("{ ");
      var first = true;
      foreach (var c in Columns)
      {
        if (string.IsNullOrEmpty(c.Value)) continue;
        if (!first)
          results.Append(", ");
        else
          first = false;
        results.AppendFormat("{0} = {1}", c.Name, c.Value);
      }
      results.Append(" }");
      return results.ToString();
    }
  }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/ActiveRecordBase.cs $
 * 
 * 51    5/24/11 4:12p Gwynnj
 * GetColumnValieAsInt is public
 * 
 * 50    2/09/11 2:20p Gwynnj
 * added suport for server insert, update and delete
 * 
 * 49    2/07/11 3:40p Gwynnj
 * Added server info
 * 
 * 48    1/19/11 2:38p Gwynnj
 * Added support for SHORTDATE column type
 * 
 * 47    10/14/10 4:15p Deepika.sharma
 * dms: It seems meta data has column names in upper case only, so doing a
 * upper to passed in value. 
 * 
 * 46    7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 45    5/18/10 1:13p Gwynnj
 * CallXmlRecord.HasCallXml for esurance Phase 3 calls
 * 
 * 44    5/17/10 12:44p Deepika.sharma
 * dms: uppercase column name
 * 
 * 43    5/17/10 12:36p Deepika.sharma
 * dms: - upppercase columnname
 * 
 * 42    4/07/10 4:49p Gwynnj
 * Added new classes (Policy, Agent) support for policy lookup for
 * Narragansett
 * 
 * 41    3/12/10 5:14p Gwynnj
 * linq for User basic query working
 * 
 * 40    3/02/10 12:45p Gwynnj
 * 
 * 39    2/05/10 5:13p Gwynnj
 * fullname is specialized
 * 
 * 38    2/05/10 1:26p Gwynnj
 * added linq -not ready for prime time
 * 
 * 37    12/09/09 2:40p John.gwynn
 * Added CompareTo for Callflow compare/diff support
 * 
 * 36    10/28/09 5:21p John.gwynn
 * Removed redundant IAccountHeirarchyStep interface
 * 
 * 35    10/13/09 4:34p John.gwynn
 * Added update for AhsActiveRecord class (updates ESIS upload_key)
 * implemented in terms of only adding those columns that have changed
 * from initial load.  Can be used in all ActiveRecord update statements
 * and values are paramaeterized.
 * 
 * 34    10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 33    10/06/09 6:17p John.gwynn
 * Added ClaimSubmission for Selective and Employee for vb conversions
 * 
 * 32    10/01/09 12:27p Jim.borys
 * fixed ClsCompliance issues
 * 
 * 31    9/25/09 2:37p John.gwynn
 * Added ActiveRecordSet<T> to achieve covariance with respect to the
 * IEnumerable<ActiveRecord> base implementation for articulating strongly
 * typed repositories.
 * 
 * 30    9/22/09 11:05a John.gwynn
 * Import Field updates
 * 
 * 29    9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 28    7/07/09 6:18p John.gwynn
 * Implemented CALLDATA SAVE and LOAD for Interop also created CALL_DATAB
 * and added support for BLOB types in ActiveRecord.
 * 
 * 27    6/05/09 7:28p John.gwynn
 * added CallData with ActiveRecord support for LONG RAW (only call_data
 * parameter at this point)
 * 
 * 26    5/27/09 11:55a John.gwynn
 * added Security in the factoryMethod
 * 
 * 25    5/26/09 7:33p John.gwynn
 * Added GetColumnValueAsInt to the IActiveRecord interface
 * 
 * 24    5/26/09 7:03p John.gwynn
 * Added deep cloning and ToArray, ToList support (ToArray is for interop
 * ToList is because we have no LINQ today)
 * 
 * 23    5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 21    4/23/09 3:24p John.gwynn
 * added support for named parameters.  refactored SQL processing to
 * SqlParameterReader class 
 * 
 * 20    4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 19    4/01/09 7:28p John.gwynn
 * added parameterized SQL to ActiveRecord and beefed up User class for
 * use in VbSecurity
 * 
 * 18    3/31/09 5:43p John.gwynn
 * added executeReader with support for parameterized SQL
 * 
 * 17    2/26/09 4:00p John.gwynn
 * 
 * 16    1/21/09 1:32p John.gwynn
 * fixed SS keyword bug and added UserId to the CallRecord update
 * 
 * 15    10/16/08 8:26p John.gwynn
 * Added delete to SessionKey
 * 
 * 14    12/03/07 2:09p John.gwynn
 * added CallXmlRecord for interface to CALL_XML table.  Insert and update
 * methods implemented.
 * 
 * 13    10/23/07 11:50a John.gwynn
 * 
 * 12    10/11/07 6:08p John.gwynn
 * implemented IDataRecord and IDataReader interfaces
 * 
 * 11    10/03/07 5:21p John.gwynn
 * Added ToXml to ActiveRecordSets
 * 
 * 10    9/27/07 8:57p John.gwynn
 * Added AutoMake and AutoModel Records
 * 
 * 9     8/07/07 6:15p John.gwynn
 * several fixes to default instance to registry when not supplied.
 * Specific destination support. Added ISequenceStep interface for OPM
 * 
 * 8     7/19/07 5:43p John.gwynn
 * UnitOfWork enhancements
 * 
 * 7     7/10/07 7:26p John.gwynn
 * Start of UnitOfWork generic implementation
 * 
 * 6     7/10/07 4:54p John.gwynn
 * added Interfaces folder, and interfaces for outcome and outcome step.
 * Added support for Insert and Update of active records and
 * GetNextSequence() method to retrieve a primary key prior to insert
 * 
 * 5     6/27/07 6:12p John.gwynn
 * Added support for Insert (for OPM)
 * 
 * 4     4/23/07 6:23p John.gwynn
 * Added interop wrapper classes (work in progress)
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 3     4/03/07 6:49p John.gwynn
 * ActiveRecordBase changed to ActiveRecord.  EsisPolicyLookup nullADODB
 * parms fixed.
 * 
 * 2     3/21/07 5:13p John.gwynn
 * Added support for ActiveRecordSet (IEnemerable (ActiveRecord) aggregate
 * to encapsulate general queries and form the base for strongly typed
 * collections
 * 
 * 1     3/20/07 6:56p John.gwynn
 * First cut for ActiveRecord class (Fowlers Active Record design
 * pattern) for SQL based data encapsulation object layer.
 */
#endregion


