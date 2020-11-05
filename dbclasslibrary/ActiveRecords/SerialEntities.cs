using System;

namespace DbClassLibrary.ActiveRecords
{
  class SerialEntities : ActiveRecordSet<SerialEntity>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingPlans"/> class.
    /// </summary>
    public SerialEntities()
      : base("SerialEntity")
    { }

    static public bool CreateSerialEntity(string entityKey, string record)
    {
      try
      {

        return true;
      }
      catch (Exception ex)
      {
        GeneralUtility.LogError(ex.Message, "CreateSerialEntity");
        return false;
      }
          
    }
  }
}
