using System.Collections.Generic;
using System.Linq;
using System.Text;
using FnsComposite;

namespace FnsUtility
{
  public class CsvRecord : CsvFileReader
  {
    /// <summary>
    /// Gets a value indicating whether this instance has header.
    /// </summary>
    /// <value>
    /// <c>true</c> if this instance has header; otherwise, <c>false</c>.
    /// </value>
    protected override bool HasHeader { get { return true; } }

    /// <summary>
    /// Return Records for this instance.
    /// </summary>
    /// <returns></returns>
    public new IEnumerable<JsonObject> Records()
    {
      Open();
      var first = ReadLine();
      var header = Parse(first);
      return Lines().Where(a => !string.IsNullOrEmpty(a) && a != first)
       .Select(a => CreateJsonRecord(header, Parse(a)));

    }

    /// <summary>
    /// Serialize entire set to json.
    /// </summary>
    /// <returns></returns>
    public string ToJson()
    {
      var results = new StringBuilder("[\n");
      var first = true;
     
      foreach (var record in Records())
      {
        if (first)
        {
          first = false;
        }
        else
        {
          results.Append(",\n");
        }
        results.Append(record.ToJson());
      }
      results.Append("\n]");
      return results.ToString();
    }
    /// <summary>
    /// Creates the json record.
    /// </summary>
    /// <param name="names">The names.</param>
    /// <param name="values">The values.</param>
    /// <returns></returns>
    private JsonObject CreateJsonRecord(string[] names, string[] values)
    {
      var result = new JsonObject();
      for (var i = 0; i< names.Length && i<values.Length; ++i )
      {
        result.SetValue(names[i],values[i]);
      }
      return result;
    }

  }
}
