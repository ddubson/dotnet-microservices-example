namespace Quark.Common
{
    public interface IRejectedEvent: IEvent
    {
        string Reason { get; }
        
        string Code { get; }
    }
}