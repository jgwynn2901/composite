using System.Collections.Generic;
using System.Data;

namespace DbClassLibrary.ActiveRecords
{
  /// <summary>
  /// Base for encrypted tables
  /// </summary>
  public class EncryptedActiveRecord : ActiveRecord
  {
    public EncryptedActiveRecord(string name)
      : base(name)
    {
      EncryptAttributes = new List<string>();
    }

    public EncryptedActiveRecord(IDataReader reader, string name)
      : base(reader, name)
    {}
    /// <summary>
    /// Gets or sets the encryption attributes.
    /// </summary>
    /// <value>
    /// The encryption attributes.
    /// </value>
    protected List<string> EncryptAttributes { get; set; }

    /// <summary>
    /// Gets the name of the column query.
    /// Override this to apply formating filters i.e. encryption
    /// </summary>
    /// <param name="col">The col.</param>
    /// <returns></returns>
    protected override string GetColumnQueryName(Column col)
    {
      return EncryptAttributes.Contains(col.QueryName) 
        ? string.Format("GEN_ENCR.decrypt({0}) AS {0}", col.QueryName) 
        : col.QueryName;
    }

    /// <summary>
    /// Gets the name of the column filter.
    /// Same as above but tailored for where clause.
    /// </summary>
    /// <param name="col">The col.</param>
    /// <returns></returns>
    protected override string GetColumnFilterName(Column col)
    {
      return EncryptAttributes.Contains(col.QueryName)
        ? string.Format("GEN_ENCR.decrypt({0})", col.QueryName)
        : col.QueryName;
    }

    /// <summary>
    /// Gets the column query value.
    /// </summary>
    /// <param name="col">The col.</param>
    /// <returns></returns>
    protected override string GetColumnQueryValue(Column col)
    {
      return EncryptAttributes.Contains(col.QueryName)
        ? string.Format("GEN_ENCR.encrypt('{0}')", col.Value)
        : base.GetColumnQueryValue(col);
    }

    /// <summary>
    /// Gets the query. For generating correct sql state
    /// </summary>
    /// <value>
    /// The query.
    /// </value>
    public string Query
    {
      get { return BuildQuery(); }
    }
  }
}
