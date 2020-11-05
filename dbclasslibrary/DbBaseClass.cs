#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2006 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/DbBaseClass.cs 17    4/08/11 8:39a Gwynnj $ */
#endregion

using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using Oracle.DataAccess.Client;
using OracleDatabase = Microsoft.Practices.EnterpriseLibrary.Data.Oracle.OracleDatabase;

namespace DbClassLibrary
{
  /// <summary>
  /// DbBaseClass is designed to encapsulate the UIF procedures
  /// that load data into the static tables.  It can be used as a
  /// generic stored procedure wrapper but it does not manage complex types
  /// such as resultsets (at this time)
  /// </summary>
  [ComVisible(false)]
  public class DbBaseClass
  {
    /// <summary>
    /// Name of encapsulated Stored Procedure set by subclass
    /// </summary>
    // ReSharper disable InconsistentNaming
    protected string _name;
    /// <summary>
    /// Holds any error returned from Oracle
    /// </summary>
    protected string _lastErrorMessage;
    /// <summary>
    /// Classes have the ability to initialize to a specific instance in their constructor
    /// Otherwise this defaults to the Registry ConnectString value
    /// </summary>
    protected string _databaseInstance;
    /// <summary>
    /// Dynamic collection of parameters for stored procedure
    /// </summary>
    protected Hashtable _alParameters;
    /// <summary>
    /// parameters are stored by name KEY to hash
    /// </summary>
    protected ArrayList _alParamNames;
    /// <summary>
    /// support for REF CURSOR results
    /// </summary>
    protected bool _hasCursor;
    /// <summary>
    /// internal REF CURSOR results storage
    /// </summary>
    protected DataSet _data;
    /// <summary>
    /// Leaf classes define parm names (TODO: makes _alParamNames obsolete)
    /// </summary>
    protected string[] _parameterNames;

    /// <summary>
    /// FNSP database instance
    /// </summary>
    public static string FNSP = DatabaseInstance.FNSP;
    /// <summary>
    /// FNSBA database instance
    /// </summary>
    public static string FNSBA = DatabaseInstance.FNSBA;
    /// <summary>
    /// FNQA database instance
    /// </summary>
    public static string FNSQA = DatabaseInstance.FNSQA;

    /// <summary>
    /// AMEBA database instance
    /// </summary>
    public static string AMEBA = DatabaseInstance.AMEBA;
    /// <summary>
    /// AMEQA database instance
    /// </summary>
    public static string AMEQA = DatabaseInstance.AMEQA;
    /// <summary>
    /// AMEPP database instance
    /// </summary>
    public static string AMEPP = DatabaseInstance.AMEPP;
    /// <summary>
    /// AMEP database instance
    /// </summary>
    public static string AMEP = DatabaseInstance.AMEP;

    /// <summary>
    /// Use this for web policy loads
    /// </summary>
    public static int DefaultFileTransmissionLogId = -102;

    /// <summary>
    /// CISGBA database instance
    /// </summary>
    public static string CISGBA = "CISGBA";
    /// <summary>
    /// CISGQA database instance
    /// </summary>
    public static string CISGQA = "CISGQA";
    /// <summary>
    /// CISGPP database instance
    /// </summary>
    public static string CISGPP = "CISGPP";
    /// <summary>
    /// CISG database instance
    /// </summary>
    public static string CISG = "CISG";

    /// <summary>
    /// CRAWBA database instance
    /// </summary>
    public static string CRAWBA = "CRAWBA";
    /// <summary>
    /// FNSP database instance
    /// </summary>
    public static string CRAWQA = "CRAWQA";
    /// <summary>
    /// CRAWPP database instance
    /// </summary>
    public static string CRAWPP = "CRAWPP";
    /// <summary>
    /// CRAWP database instance
    /// </summary>
    public static string CRAWP = "CRAWP";

    /// <summary>
    /// ESUBA database instance
    /// </summary>
    public static string ESUBA = DatabaseInstance.ESUBA;
    /// <summary>
    /// ESUQA database instance
    /// </summary>
    public static string ESUQA = DatabaseInstance.ESUQA;
    /// <summary>
    /// ESUPP database instance
    /// </summary>
    public static string ESUPP = DatabaseInstance.ESUPP;
    /// <summary>
    /// ESUP database instance
    /// </summary>
    public static string ESUP = DatabaseInstance.ESUP;

    /// <summary>
    /// SEDBA database instance
    /// </summary>
    public static string SEDBA = DatabaseInstance.SEDBA;
    /// <summary>
    /// SEDQA database instance
    /// </summary>
    public static string SEDQA = DatabaseInstance.SEDQA;
    /// <summary>
    /// SEDPP database instance
    /// </summary>
    public static string SEDPP = DatabaseInstance.SEDPP;
    /// <summary>
    /// SEDP database instance
    /// </summary>
    public static string SEDP = DatabaseInstance.SEDP;

    /// <summary>
    /// SELBA database instance
    /// </summary>
    public static string SELBA = DatabaseInstance.SELBA;
    /// <summary>
    /// SELQA database instance
    /// </summary>
    public static string SELQA = DatabaseInstance.SELQA;
    /// <summary>
    /// SELPP database instance
    /// </summary>
    public static string SELPP = DatabaseInstance.SELPP;
    /// <summary>
    /// SELP database instance
    /// </summary>
    public static string SELP = DatabaseInstance.SELP;

    /// <summary>
    /// SENBA database instance
    /// </summary>
    public static string SENBA = DatabaseInstance.SENBA;
    /// <summary>
    /// SENQA database instance
    /// </summary>
    public static string SENQA = DatabaseInstance.SENQA;
    /// <summary>
    /// SENPP database instance
    /// </summary>
    public static string SENPP = DatabaseInstance.SENPP;
    /// <summary>
    /// SENP database instance
    /// </summary>
    public static string SENP = DatabaseInstance.SENP;

    /// <summary>
    /// TOWBA database instance
    /// </summary>
    public static string TOWBA = DatabaseInstance.TOWBA;
    /// <summary>
    /// TOWQA database instance
    /// </summary>
    public static string TOWQA = DatabaseInstance.TOWQA;
    /// <summary>
    /// TOWPP database instance
    /// </summary>
    public static string TOWPP = DatabaseInstance.TOWPP;
    /// <summary>
    /// TOWP database instance
    /// </summary>
    public static string TOWP = DatabaseInstance.TOWP;
    // ReSharper restore InconsistentNaming

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    protected virtual void Initialize()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DbBaseClass"/> class.
    /// </summary>
    //public DbBaseClass() :this (ApplicationConfiguration.Instance.DefaultInstance)
    //{

    //}
    public DbBaseClass(string instance)
    {
      _name = String.Empty;
      _lastErrorMessage = String.Empty;
      _alParameters = new Hashtable();
      _alParamNames = new ArrayList();
      _databaseInstance = (instance.Length > 0 ? instance : ApplicationConfiguration.Instance.DefaultInstance);
      _hasCursor = false;
      _data = null;
      _parameterNames = null;
    }
    /// <summary>
    /// Reset data
    /// </summary>
    /// <returns>void</returns>
    /// <remarks>resets parameter dataset to defaults</remarks>
    public void Reset()
    {
      for (int i = 0; i < _alParameters.Count; i++)
      {
        var paramList = (SpParameters)_alParameters[_alParamNames[i]];
        paramList.Value = "";
      }
    }
    /// <summary>
    /// Adds the parm.
    /// </summary>
    /// <param name="iDir">The direction (IN/OUT).</param>
    /// <param name="strName">Name of the parm.</param>
    /// <param name="strdefault">The default.</param>
    /// <param name="aType">A (database) type.</param>
    /// <returns></returns>
    protected bool AddParm(ParameterDirection iDir, string strName, string strdefault, DbType aType)
    {
      var parm = new SpParameters(iDir, strName, strdefault, aType);
      _alParameters.Add(strName, parm);
      _alParamNames.Add(strName);

      return true;
    }
    /// <summary>
    /// Execute stored procedure as defined by derived classes
    /// </summary>
    /// <returns>true if no errors</returns>
    /// <remarks>submits parameters and executes target procedure</remarks>
    /// <exception cref="FormatException"><c>FormatException</c>.</exception>
    public bool Execute()
    {
      try
      {
        GeneralUtility.DebugLog("Execute entered", _name);
        if (_databaseInstance.Length == 0)
          _databaseInstance = ApplicationConfiguration.Instance.DefaultInstance;

        var db = new OracleDatabase(GeneralUtility.GetConnectStringFromInstance(_databaseInstance));
        GeneralUtility.DebugLog("Database created", _name);
        var cmd = (OracleCommand)db.GetStoredProcCommand(_name);
        if (_alParameters.Count > 0)
        {
          for (var i = 0; i < _alParameters.Count; i++)
          {
            var paramList = (SpParameters)_alParameters[_alParamNames[i]];
            if (paramList.Direction == ParameterDirection.Input)
            {
              if (string.IsNullOrEmpty(paramList.Value))
              {
                db.AddInParameter(cmd, paramList.Name, paramList.DataType);
              }
              else
              {
                try
                {
                  switch (paramList.DataType)
                  {
                    case DbType.Date:
                      GeneralUtility.DebugLog("converting date " + paramList.Value, _name);
                      var myDateParm = Convert.ToDateTime(paramList.Value);
                      db.AddInParameter(cmd, paramList.Name, paramList.DataType, myDateParm);
                      break;
                    case DbType.Int32:
                      var myInt32Parm = Convert.ToInt32(paramList.Value);
                      db.AddInParameter(cmd, paramList.Name, paramList.DataType, myInt32Parm);
                      break;
                    case DbType.Double:
                      var myDoubleParm = Convert.ToDouble(paramList.Value);
                      db.AddInParameter(cmd, paramList.Name, paramList.DataType, myDoubleParm);
                      break;
                    case DbType.Byte:
                      var val = Convert.ToByte(paramList.Value[0]);
                      db.AddInParameter(cmd, paramList.Name, paramList.DataType, val);
                      break;
                    default:
                      db.AddInParameter(cmd, paramList.Name, paramList.DataType, paramList.Value);
                      break;
                  }
                }
                catch (FormatException formatException)
                {
                  throw new FormatException(string.Format("{0}'s value \"{1}\" is not of type {2}.", paramList.Name, paramList.Value, paramList.DataType), formatException);
                }
              }
            }
            else
            {
              if (paramList.DataType == DbType.Object)
              {
                _hasCursor = true;
                db.AddParameter(cmd, paramList.Name, OracleDbType.RefCursor, 0, ParameterDirection.Output, true, 0, 0, String.Empty, DataRowVersion.Default, Convert.DBNull);
              }
              else if (paramList.Direction == ParameterDirection.ReturnValue)
              {
                db.AddParameter(cmd, paramList.Name, paramList.DataType, 4000, ParameterDirection.ReturnValue, true, 0, 0, String.Empty, DataRowVersion.Default, Convert.DBNull);
              }
              else
              {
                db.AddOutParameter(cmd, paramList.Name, paramList.DataType, 4000);
              }
            }
          }
          if (_hasCursor == false)
          {
            GeneralUtility.DebugLog("ExecuteNonQuery -start", _name);
            db.ExecuteNonQuery(cmd);
            GeneralUtility.DebugLog("ExecuteNonQuery -finish", _name);

            for (var i = 0; i < _alParameters.Count; i++)
            {
              var paramList = (SpParameters)_alParameters[_alParamNames[i]];
              if (paramList.Direction != ParameterDirection.Input)
              {
                paramList.Value = db.GetParameterValue(cmd, paramList.Name).ToString();
              }
            }
          }
          else
          {
            if (_data != null)
            {
              _data.Dispose();
              _data = null;
              GeneralUtility.DebugLog("Dataset reset", _name);
            }
            GeneralUtility.DebugLog("ExecuteDataSet -start", _name);
            _data = db.ExecuteDataSet(cmd);
            GeneralUtility.DebugLog("ExecuteDataSet -finish", _name);
          }
        }
        return true;
      }
      catch (Exception ex)
      {
        _lastErrorMessage = ex.Message;
        GeneralUtility.DebugLog(_lastErrorMessage, _name);
        return false;
      }
    }
    /// <summary>
    /// GetValue Returns named value
    /// </summary>
    /// <returns>value of named parameter</returns>
    /// <remarks>designed for derived classes exposing get/set on members</remarks>
    protected string GetValue(string strName)
    {
      var strVal = "";
      var paramList = (SpParameters)_alParameters[strName];
      if (paramList != null)
      {
        strVal = paramList.Value;
      }
      return strVal;
    }
    /// <summary>
    /// Gets the value.
    /// </summary>
    /// <param name="nameIndex">Index of the name.</param>
    /// <returns></returns>
    protected string GetValue(int nameIndex)
    {
      if (_parameterNames.Length < nameIndex)
      {
        throw new IndexOutOfRangeException("DbBaseClass.GetValue Index out of range.");
      }
      return GetValue(_parameterNames[nameIndex]);
    }
    /// <summary>
    /// Gets the data row value.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns></returns>
    protected string GetDataRowValue(int index)
    {
      var results = String.Empty;

      if (_data == null || _data.Tables.Count <= 0) return results;
      using (var table = _data.Tables[0])
      {
        if (table.Rows == null || table.Rows.Count <= 0) return results;
        var row = table.Rows[0];
        if (row == null) return results;
        if (row[index] != null)
        {
          results = row[index].ToString();
        }
      }
      return results;
    }
    /// <summary>
    /// SetValue sets named parameter value
    /// </summary>
    /// <returns>true if successful</returns>
    /// <remarks>designed for derived classes exposing get/set on members</remarks>
    public bool SetValue(string strName, string strValue)
    {
      var bVal = false;
      var paramList = (SpParameters)_alParameters[strName];
      if (paramList != null)
      {
        paramList.Value = strValue;
        bVal = true;
      }
      return bVal;
    }
    /// <summary>
    /// Sets the value.
    /// </summary>
    /// <param name="nameIndex">Index of the name.</param>
    /// <param name="strValue">The STR value.</param>
    /// <returns></returns>
    protected bool SetValue(int nameIndex, string strValue)
    {
      if (_parameterNames.Length < nameIndex)
      {
        throw new IndexOutOfRangeException("DbBaseClass.SetValue Index out of range.");
      }
      return SetValue(_parameterNames[nameIndex], strValue);
    }
    /// <summary>
    /// Gets the last error.
    /// </summary>
    /// <value>The last error.</value>
    public string LastError
    {
      get
      {
        return _lastErrorMessage;
      }
    }
    /// <summary>
    /// override the registry setting
    /// </summary>
    public string CurrentDbInstance
    {
      get
      {
        return _databaseInstance;
      }
      set
      {
        _databaseInstance = value;
      }
    }
    /// <summary>
    /// Gets the results.
    /// </summary>
    /// <value>The results.</value>
    public DataSet Results
    {
      get
      {
        return _data;
      }
    }

    public DbBaseClass ToUpper()
    {
      for (var i = 0; i < _alParameters.Count; i++)
      {
        var parm = (SpParameters)_alParameters[_alParamNames[i]];
        if (parm.DataType == DbType.AnsiString)
          parm.Value = parm.Value.ToUpper();
      }

      return this;
    }
  }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/DbBaseClass.cs $
 * 
 * 17    4/08/11 8:39a Gwynnj
 * adapted for setting of null to values
 * 
 * 16    3/02/11 3:27p Pintoa
 * User friendly exception description
 * 
 * 15    2/14/11 2:22p Gwynnj
 * Support for Twer database instance constants
 * 
 * 14    9/10/10 2:45p Gwynnj
 * minor reformatting and added ToUpper for web loads
 * 
 * 13    9/09/10 5:16p Gwynnj
 * no more documentation requirements and or COM regstrations
 * 
 * 12    9/09/10 4:54p Gwynnj
 * Added DefaultFileTransmissionLogId (-102) for policy loads via web
 * 
 * 11    8/10/10 6:30p Gwynnj
 * created DatabaseInstance to manage all connection string code logic
 * 
 * 10    2/23/10 2:53p Gwynnj
 * Added CallRouting support
 * 
 * 9     10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 8     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 7     4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 6     3/31/09 5:43p John.gwynn
 * added executeReader with support for parameterized SQL
 * 
 * 5     8/07/07 6:15p John.gwynn
 * several fixes to default instance to registry when not supplied.
 * Specific destination support. Added ISequenceStep interface for OPM
 * 
 * 4     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 3     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 2     1/18/07 8:44a John.gwynn
 * conversion to 2.0 framework
 * 
 * 17    11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 16    11/14/06 10:21a John.gwynn
 * Instance will default to registry only if not set in constructor
 * 
 * 15    11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 14    10/17/06 11:38a John.gwynn
 * modified out parameter size to a default of 1024.  Prioir size was 4
 * used mostly for integer output, but now fuctions like ZipFromFips etc
 * require char out parms.  
 * 
 * 13    8/25/06 10:07a John.gwynn
 * added vehicle coverage extensions and vehicle lien support
 * 
 * 12    7/12/06 10:32a John.gwynn
 * Added Provider support for Beech
 * 
 * 11    6/23/06 5:41p John.gwynn
 * added ref cursor support and Selective Mandatory fields and
 * QueueAssignment
 * 
 * 10    6/12/06 11:25a John.gwynn
 * Updated AHS, reset dependencies to strong named components
 * 
 * 9     5/08/06 6:46p John.gwynn
 * Formatting updates and support for SENP and CRAWP utilities
 * 
 * 8     4/18/06 5:43p John.gwynn
 * Claim submission unit testing
 * 
 * 7     4/06/06 6:16p John.gwynn
 * Added NcciCode and AhsIdFromLocation
 * 
 * 6     3/29/06 5:38p John.gwynn
 * added Vehicle Coverage
 * 
 * 5     3/15/06 6:31p John.gwynn
 * support for CSAAWeb deployment
 * 
 * 4     3/06/06 6:07p John.gwynn
 * added constructor db instance support
 * 
 * 3     3/04/06 5:27p John.gwynn
 * added the ability to set dbInstance in constructor
 * 
 * 2     11/16/05 6:21p John.gwynn
 * Added AHS
 * 
 * 1     11/15/05 6:41p John.gwynn
 */
#endregion