using System;
using System.Globalization;
using System.Text;

namespace FnsUtility
{
  /// <summary>
  /// encapsulate date formats
  /// </summary>
  public class Date
  {
    private DateTime _date;

    /// <summary>
    /// Initializes a new instance of the <see cref="Date"/> class.
    /// </summary>
    /// <param name="date">The date.</param>
    public Date(string date)
    {
      if (DateTime.TryParse(date, out _date)) return;
      var results = date.Split(" ".ToCharArray());
      if (results.Length > 0 && results[0].Length == 8)
      {
        var date2Parse = new StringBuilder();
        date2Parse.AppendFormat("{0}/{1}/{2}", results[0].Substring(0, 2), results[0].Substring(2, 2), results[0].Substring(4));
        if (results.Length > 1)
        {
          date2Parse.Append(" ");
          date2Parse.Append(results[1]);
          if (results.Length == 3)
            date2Parse.Append(results[2]);
        }
        if (!DateTime.TryParse(date2Parse.ToString(), out _date))
          ErrorLog.LogError(string.Format("Unable to parse {0} as Date!", date2Parse), ToString());
      }
      else
        ErrorLog.LogError(string.Format("Unable to parse {0} as Date!", date), ToString());
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Date"/> class.
    /// </summary>
    /// <param name="date">The date.</param>
    /// <param name="time">The time.</param>
    public Date(string date, string time)
    {
      var currentDate = new Date(date);
      var currentTime = FormatCallTimeString(time);
      _date = DateTime.Parse(string.Format("{0} {1}",
          currentDate.DateTime.ToShortDateString(),
          currentTime));
    }

    private static string FormatCallTimeString(string time)
    {
      var results = time.Trim();
      return results.Length == 6
          ? string.Format("{0}:{1} {2}",
                      results.Substring(0, 2),
                      results.Substring(2, 2),
                      results.Substring(4, 2))
          : results;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Date"/> class.
    /// </summary>
    /// <param name="date">The date.</param>
    public Date(DateTime date)
    {
      _date = date;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Date"/> class.
    /// </summary>
    public Date()
    {
      _date = DateTime.Now;
    }

    /// <summary>
    /// Gets the date time.
    /// </summary>
    /// <value>The date time.</value>
    public DateTime DateTime
    {
      get { return _date; }
    }

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override sealed string ToString()
    {
      return _date.ToString(CultureInfo.CurrentCulture);
    }

    /// <summary>
    /// Toes the date string.
    /// </summary>
    /// <returns></returns>
    public string ToDateString()
    {
      return Format("MMddyyy");
    }

    /// <summary>
    /// Toes the time string.
    /// </summary>
    /// <returns></returns>
    public string ToTimeString()
    {
      return Format("hh:mm:ss tt");
    }

    /// <summary>
    /// Formats to date string.
    /// </summary>
    /// <returns></returns>
    static public string FormatToDateString(string date)
    {
      var results = new Date(date);
      return results.ToDateString();
    }

    /// <summary>
    /// Gets the sysdate.
    /// </summary>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    static public Date GetSysdate(string instance)
    {
      var results = GetSysdateAsString(instance);
      return results.Length > 0 ? new Date(results) : default(Date);
    }

    /// <summary>
    /// Gets the sysdate.
    /// </summary>
    /// <returns></returns>
    static public Date GetSysdate()
    {
      return GetSysdate(GeneralUtility.InstanceFromRegistry);
    }

    public string Format(string format)
    {
      return _date.ToString(format, CultureInfo.CurrentCulture);
    }
    /// <summary>
    /// Validates the loss date.
    /// </summary>
    /// <param name="lossDate">The loss date.</param>
    /// <returns></returns>
    static public bool ValidateLossDate(string lossDate)
    {
      DateTime lossDateTime;

      if (!DateTime.TryParse(lossDate, out lossDateTime)) return false;
      if (lossDateTime <= DateTime.Now) return true;
      var difference = lossDateTime - DateTime.Now;
      return (difference.Days <= 0 && difference.Hours < 2);
    }

    /// <summary>
    /// Gets the sysdate as string.
    /// </summary>
    /// <param name="instance">The instance.</param>
    /// <returns></returns>
    public static string GetSysdateAsString(string instance)
    {
      return DbClassLibrary.GeneralUtility.GetSysdateAsString(instance);
    }

    /// <summary>
    /// Validates the input string can be parsed as a datetime 
    /// and return it intact or return an empty string.
    /// </summary>
    public static string DateIsValidOrEmpty(string source)
    {
      DateTime results;
      if (!string.IsNullOrEmpty(source) && DateTime.TryParse(source, out results))
        return source;

      return "";
    }

    /// <summary>
    /// Formats the call date string from MMDDYYYY to MM/DD/YYYY.
    /// Use this to provide an easy convert to Data
    /// </summary>
    static public string FormatCallDateString(string date)
    {
      var results = date.Trim();

      if (!string.IsNullOrEmpty(results) && results.Length == 8)
        return string.Format("{0}/{1}/{2}",
                             date.Substring(0, 2),
                             date.Substring(2, 2),
                             date.Substring(4));

      return results;
    }
    /// <summary>
    /// Formats the call date string from MM/DD/YYYY to MMDDYYYY.
    /// Use this to provide an easy convert to Data
    /// </summary>
    static public string FormatDateCallString(string date)
    {
      var results = DateTime.Parse(date.Trim());
      return results.ToString("MMddyyyy");
    }
  }

}
