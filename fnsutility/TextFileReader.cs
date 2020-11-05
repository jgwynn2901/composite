using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FnsUtility
{
  /// <summary>
  /// 
  /// </summary>
  public class TextFileReader : FileReader, IFileReader<string>
  {
    private StreamReader _stream;
    private bool _disposed;

    /// <summary>
    /// Gets a value indicating whether this instance has header.
    /// </summary>
    /// <value>
    /// <c>true</c> if this instance has header; otherwise, <c>false</c>.
    /// </value>
    virtual protected bool HasHeader { get { return false; }}

    /// <summary>
    /// Opens this instance.
    /// </summary>
    public override bool Open()
    {
      try
      {
        _stream = new StreamReader(FileName);
        return true;
      }
      catch (Exception ex)
      {
        ErrorLog.LogError(ex.Message, ToString());
        return false;
      }
    }

    /// <summary>
    /// Reads the line.
    /// </summary>
    public override string ReadLine()
    {
      return _stream != null
         ? _stream.ReadLine()
         : default(string);
    }

    /// <summary>
    /// Lineses this instance.
    /// </summary>
    protected IEnumerable<string> Lines()
    {
      if (!Open()) yield break;
      string result;
      while ((result = ReadLine()) != null)
        yield return result;
    }

    /// <summary>
    /// yields each record
    /// </summary>
    public IEnumerable<string> Records()
    {
      return (Lines()
           .Where(a => !string.IsNullOrEmpty(a))
           .Select(a => a)).ToArray();
    }


    /// <summary>
    /// override this to release unmanaged and - optionally - managed resources
    /// </summary>
    /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
      if (!disposing || _disposed) return;
      if (_stream != null)
        _stream.Dispose();
      _disposed = true;
    }

    /// <summary>
    /// Reads the file and returns contents as string.
    /// </summary>
    /// <param name="fileName">Name of the file.</param>
    /// <returns></returns>
    static public string ReadFile(string fileName)
    {
      var results = new StringBuilder();
      using (var reader = new TextFileReader {FileName = fileName})
      {
        foreach (var line in reader.Lines())
        {
          results.Append(line);
        }
      }
      return results.ToString();
    }
  }
}
