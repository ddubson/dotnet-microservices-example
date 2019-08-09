using System.Threading.Tasks;

namespace Quark.Common
{
    public interface IEventHandler<in T> where T: IEvent
    {
        Task HandleAsync(T command);
    }
}