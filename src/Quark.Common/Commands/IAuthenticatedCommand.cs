using System;

namespace Quark.Common.Commands
{
    public interface IAuthenticatedCommand: ICommand
    {
        Guid UserId { get; set; }
    }
}