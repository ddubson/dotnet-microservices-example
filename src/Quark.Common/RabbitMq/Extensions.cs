using System.Reflection;
using System.Threading.Tasks;
using Quark.Common.Commands;
using RawRabbit;
using RawRabbit.Common;

namespace Quark.Common.RabbitMq
{
    public static class Extensions
    {
        public static ISubscription WithCommandHandlerAsync<TCommand>(this IBusClient bus,
            ICommandHandler<TCommand> handler) where TCommand : ICommand
            => bus.SubscribeAsync<TCommand>(
                (msg, msgContext) => handler.HandleAsync(msg),
                ctx => ctx.WithQueue(cfg => cfg.WithName(GetQueueName<TCommand>()))
                );
        
        public static ISubscription WithEventHandlerAsync<TEvent>(this IBusClient bus,
            IEventHandler<TEvent> handler) where TEvent : IEvent
            => bus.SubscribeAsync<TEvent>((msg, msgContext) => handler.HandleAsync(msg),
                ctx => ctx.WithQueue(cfg => cfg.WithName(GetQueueName<TEvent>())));

        private static string GetQueueName<T>() => $"{Assembly.GetEntryAssembly()?.GetName()}/{typeof(T).Name}";
    }
}