using System.Collections.Generic;
using System.Linq;

namespace DbClassLibrary.ActiveRecords
{
  /// <summary>
  /// Quick access to auto Make and Model data here.
  /// </summary>
  public class AutoMakeModels : ActiveRecordSet<AutoMakeModel>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AutoMakeModels"/> class.
    /// </summary>
    public AutoMakeModels() : base("AutoMakeModel")
    {
      Instance = DbBaseClass.FNSP;
      query = "select AUTO_MAKE_MODEL_ID, YEAR, MAKE, MODEL from AUTO_MAKE_MODEL ORDER BY MAKE, MODEL";
    }

    /// <summary>
    /// Gets the makes.
    /// </summary>
    /// <returns></returns>
    static public IEnumerable<string> GetMakes()
    {
      return new AutoMakeModels().Results().Select(a=> GeneralUtility.ToTitleCase(a.Make)).Distinct().ToArray();
    }
    /// <summary>
    /// Get the makes that start with partial. 
    /// </summary>
    /// <param name="partial">The partial search term.</param>
    /// <returns></returns>
    static public IEnumerable<string> GetPartialMakes(string partial)
    {
      var makes = new AutoMakeModels
      {
        Query = string.Format("select AUTO_MAKE_MODEL_ID, YEAR, MAKE, MODEL from AUTO_MAKE_MODEL where MAKE LIKE '{0}%' ORDER BY MAKE", partial.ToUpper())
      };
      return makes.Results().Select(a => GeneralUtility.ToTitleCase(a.Make)).Distinct().ToArray();
    }

    /// <summary>
    /// Gets the models.
    /// </summary>
    /// <param name="make">The make.</param>
    /// <param name="partial">The partial.</param>
    /// <returns></returns>
    static public IEnumerable<string> GetModels(string make, string partial)
    {
      string query;
      if (!string.IsNullOrEmpty(partial))
      {
        query =
          string.Format(
            "select AUTO_MAKE_MODEL_ID, YEAR, MAKE, MODEL from AUTO_MAKE_MODEL where MAKE = :make and MODEL like '{0}%' ORDER BY MODEL",
            partial.ToUpper());
      }
      else
      {
        query = "select AUTO_MAKE_MODEL_ID, YEAR, MAKE, MODEL from AUTO_MAKE_MODEL where MAKE = :make ORDER BY MODEL";
      }
      var makes = new AutoMakeModels
      {
        Query = query
      };
      makes.AddParameter("make", make.ToUpper());

      return makes.Results().Select(a => GeneralUtility.ToTitleCase(a.Model)).Distinct().ToArray();
    }
  }


}
