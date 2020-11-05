using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FnsUtility
{
  /// <summary>
  /// 
  /// </summary>
  public class CsvFileReader : TextFileReader, IFileReader<string[]>
  {
    private const string CsvDelimiter = ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))";

    /// <summary>
    /// yields each record
    /// </summary>
    public new IEnumerable<string[]> Records()
    {
      return Lines()
        .Where(a => !string.IsNullOrEmpty(a))
        .Select(a => Parse(a));
    }

    protected static string[] Parse(string values)
    {
      var r = new Regex(CsvDelimiter);

      if (string.IsNullOrEmpty(values))
        return default(string[]);

      var items = r.Split(values);
      var leading = new Regex("^\"");
      var trailing = new Regex("\"$");

      for (var i = 0; i < items.Length; ++i)
      {
        items[i] = leading.Replace(items[i], "");
        items[i] = trailing.Replace(items[i], "");
      }
      return items;
    }
  }
}
