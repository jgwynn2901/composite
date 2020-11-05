using System.ServiceModel;

namespace FnsInterfaces
{
    [ServiceContract]
    public interface IPolicyLookupService
    {
        [OperationContract]
        string ExecuteLookup(string callXml);
        [OperationContract]
        string GetDetails(string callXml);
    }
}
