using MediatR;
using MicroRabbit.Baking.Domain.Commands;
using MicroRabbit.Baking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Baking.Domain.CommandHandler
{
    public class TransferCommandHandler : IRequestHandler<TransferCommand, bool>
    {
        private readonly IEventBus bus;

        public TransferCommandHandler(IEventBus bus)
        {
            this.bus = bus;
        }

        public Task<bool> Handle(TransferCommand request, CancellationToken cancellationToken)
        {
            bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));

            return Task.FromResult(true);
        }
    }
}
