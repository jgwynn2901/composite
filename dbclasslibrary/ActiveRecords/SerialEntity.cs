using System.Data;

namespace DbClassLibrary.ActiveRecords
{
  public class SerialEntity : ActiveRecord
  {
    public SerialEntity()
      : base("SERIAL_ENTITIES")
		{
      columns.Add(new Column("SERIAL_ENTITY_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("OBJECT_KEY", string.Empty, "VARCHAR2"));
      columns.Add(new Column("ENTITY_ID", string.Empty, "NUMBER"));
      columns.Add(new Column("CREATED_DT", string.Empty, "DATE"));
      columns.Add(new Column("LAST_MODIFIED_DT", string.Empty, "DATE"));
		}

    public SerialEntity(IDataReader reader)
      : base(reader, "SERIAL_ENTITIES")
		{}

    #region SerialEntityId
    /// <summary>
    /// SERIAL_ENTITY_ID
    /// </summary>
    public string SerialEntityId
    {

      get { return GetColumnValue("SERIAL_ENTITY_ID"); }
      set { SetColumnValue("SERIAL_ENTITY_ID", value); }
    }
    #endregion

    #region ObjectKey
    /// <summary>
    /// OBJECT_KEY
    /// </summary>
    public string ObjectKey
    {

      get { return GetColumnValue("OBJECT_KEY"); }
      set { SetColumnValue("OBJECT_KEY", value); }
    }
    #endregion

    #region EntityId
    /// <summary>
    /// ENTITY_ID
    /// </summary>
    public string EntityId
    {

      get { return GetColumnValue("ENTITY_ID"); }
      set { SetColumnValue("ENTITY_ID", value); }
    }
    #endregion

    #region CreatedDate
    /// <summary>
    /// CREATED_DT
    /// </summary>
    public string CreatedDate
    {

      get { return GetColumnValue("CREATED_DT"); }
    }
    #endregion

    #region LastModifiedDate
    /// <summary>
    /// LAST_MODIFIED_DT
    /// </summary>
    public string LastModifiedDate
    {

      get { return GetColumnValue("LAST_MODIFIED_DT"); }
    }
    #endregion
  }
}
