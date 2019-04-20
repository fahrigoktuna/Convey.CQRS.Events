using System.Threading.Tasks;
using Convey.MessageBrokers;

namespace Convey.CQRS.Events
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event, ICorrelationContext context);
    }
}