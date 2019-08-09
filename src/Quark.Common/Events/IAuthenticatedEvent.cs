using System;

namespace Quark.Common
{
    public interface IAuthenticatedEvent: IEvent
    {
        Guid UserId { get; }
    }
}