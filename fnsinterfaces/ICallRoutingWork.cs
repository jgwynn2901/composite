namespace FnsInterfaces
{
    public interface ICallRoutingWork
    {
        string Instance { get; }
        int Id { get; }
        int CallId { get; }
        string FinalSaveStatus { get; }
        string Status { get; }
    }
}
