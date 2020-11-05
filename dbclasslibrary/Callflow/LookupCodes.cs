using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace DbClassLibrary.Callflow
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.None)]
  public class LookupCodes : ActiveRecordSet<LookupCode>
  {
    private static Dictionary<string, LookupCodes> _lazyCache;
    private static readonly object CacheSynch = new object();

    /// <summary>
    /// Initializes a new instance of the <see cref="LookupCodes"/> class.
    /// </summary>
    public LookupCodes()
      : base("LookupCode")
    { }

    /// <summary>
    /// Gets or sets the lookup type code.
    /// </summary>
    public string CodeTypeId { get; set; }

    /// <summary>
    /// Gets or sets the SQL query.
    /// </summary>
    public override string Query
    {
      get
      {
        return string.Format("select * from LU_CODE where LU_TYPE_ID in ({0}) order by SEQUENCE", CodeTypeId);
      }
    }

    //protected override void AddQueryParameters()
    //{
    //  AddParameter("code_type", CodeTypeId);
    //}

    /// <summary>
    /// Gets LU_TYPE_ID by name.
    /// </summary>
    static public string GetLookupTypeIdByName(string name)
    {
      var results = new ActiveRecordSet
                        {
                          Query = string.Format("select LU_TYPE_ID from LU_TYPE where NAME = '{0}'", name)
                        };
      return (results.Execute() && results.MoveNext()) ? results[0].ToString(): string.Empty;
    }

    /// <summary>
    /// Lookups the name of the by type.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns></returns>
    static public IEnumerable<LookupCode> LookupByTypeName(string name)
    {
      return LookupByTypeId(GetLookupTypeIdByName(name));
    }

    /// <summary>
    /// Lookups the by type id.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <returns></returns>
    static public IEnumerable<LookupCode> LookupByTypeId(string id)
    {
      var codes = new LookupCodes { CodeTypeId = id };
      if (!codes.Execute())
      {
      }
      else
      {
        foreach (var c in codes)
          yield return c;
      }
    }

    /// <summary>
    /// Gets the lookup codes by type id.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <returns></returns>
    public static LookupCodes GetLookupCodesByTypeId(int id)
    {
      if (_lazyCache == null)
      {
        lock (CacheSynch)
        {
          if (_lazyCache == null)
            _lazyCache = new Dictionary<string, LookupCodes>();
        }
      }

      if (_lazyCache.ContainsKey(id.ToString(CultureInfo.InvariantCulture)))
      {
        var result = _lazyCache[id.ToString(CultureInfo.InvariantCulture)];
        result.Reset();
        return result;
      }

      var codes = new LookupCodes { CodeTypeId = id.ToString(CultureInfo.InvariantCulture) };
      if (!codes.Execute()) return codes;
      lock (_lazyCache)
      {
        _lazyCache.Add(id.ToString(CultureInfo.InvariantCulture), codes);
      }
      return codes;
    }
  }
}
