using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FnsInterfaces
{
  [DataContract]
  public class ServiceRecord
  {
    [DataMember]
    public string DisplayName { get; set; }
    [DataMember]
    public string ServiceName { get; set; }
    [DataMember]
    public string Status { get; set; }
    [DataMember]
    public string MachineName { get; set; }
    [DataMember]
    public string ServiceType { get; set; }
  }

  [CollectionDataContract]
  public class ServiceRecordList : List<ServiceRecord>
  {
    public ServiceRecordList() { }
    public ServiceRecordList(IEnumerable<ServiceRecord> codes) : base(codes) { }
  }
}
