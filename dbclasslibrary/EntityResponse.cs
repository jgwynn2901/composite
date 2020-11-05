using System;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DbClassLibrary
{
  public class EntityResponse
  {
    public string Instance { get; set; }
    public string RquId { get; set; }
    public string LastError { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EntityResponse"/> class.
    /// </summary>
    public EntityResponse()
      : this(GeneralUtility.GetDbInstanceFromRegistry())
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="EntityResponse"/> class.
    /// </summary>
    /// <param name="instance">The instance.</param>
    public EntityResponse(string instance)
    {
      Instance = instance;
    }

    /// <summary>
    /// Sets the source.
    /// </summary>
    public int SetSource(string source)
    {
      try
      {
        using (var conn = new OracleConnection(GeneralUtility.GetConnectStringFromInstance(Instance)))
        {
          var command = new OracleCommand("DBCLASSLIBRARY.CreateUpdateEntities", conn)
                          {
                            CommandType = CommandType.StoredProcedure
                          };

          var parameters = new[]
                                       {
                                         new OracleParameter
                                           {
                                             Direction = ParameterDirection.Output,
                                             OracleDbType = OracleDbType.Decimal,
                                             ParameterName = "P_ID"
                                           },
                                         new OracleParameter
                                           {
                                             Direction = ParameterDirection.Input,
                                             OracleDbType = OracleDbType.Varchar2,
                                             ParameterName = "P_RQUID",
                                             Value = RquId
                                           },
                                         new OracleParameter
                                           {
                                             Direction = ParameterDirection.Input,
                                             OracleDbType = OracleDbType.Clob,
                                             ParameterName = "p_SOURCEDATA",
                                             Value = source,
                                             Size = source.Length
                                           }

                                       };

          foreach (var parameter in parameters)
            command.Parameters.Add(parameter);

          conn.Open();
          command.ExecuteNonQuery();

          return Convert.ToInt32(command.Parameters[0].Value.ToString());
        }
      }
      catch (Exception ex)
      {
        LastError = ex.Message;
        GeneralUtility.DebugLog(LastError, ToString());
        return -1;
      }
    }

    /// <summary>
    /// Gets the source.
    /// </summary>
    public string GetSource()
    {
      try
      {
        using (var conn = new OracleConnection(GeneralUtility.GetConnectStringFromInstance(Instance)))
        {
          var command = new OracleCommand("DBCLASSLIBRARY.GetEntity", conn)
                          {
                            CommandType = CommandType.StoredProcedure
                          };

          var parameters = new[]
                               {
                                 new OracleParameter
                                   {
                                     Direction = ParameterDirection.Input,
                                     OracleDbType = OracleDbType.Varchar2,
                                     ParameterName = "P_RQUID",
                                     Value = RquId
                                   },
                                 new OracleParameter
                                   {
                                     Direction = ParameterDirection.Output,
                                     OracleDbType = OracleDbType.Clob,
                                     ParameterName = "p_SOURCEDATA",
                                   }

                               };

          foreach (var parameter in parameters)
            command.Parameters.Add(parameter);

          conn.Open();
          command.ExecuteNonQuery();

          var clobResults = (OracleClob)command.Parameters[1].Value;
          return clobResults.Value;
        }
      }
      catch (Exception ex)
      {
        LastError = ex.Message;
        GeneralUtility.DebugLog(LastError, ToString());
        return string.Empty;
      }
    }

    public static bool SetEntityResponse(string id, string data)
    {
      var entity = new EntityResponse { RquId = id };
      return entity.SetSource(data) != -1;
    }

    public static string GetEntityResponse(string id)
    {
      var entity = new EntityResponse { RquId = id };
      return entity.GetSource();
    }
  }
}
