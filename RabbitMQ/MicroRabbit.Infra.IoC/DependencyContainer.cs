using MediatR;
using MicroRabbit.Baking.Application.AccountServices;
using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Data.Context;
using MicroRabbit.Baking.Data.Repository;
using MicroRabbit.Baking.Domain.CommandHandler;
using MicroRabbit.Baking.Domain.Commands;
using MicroRabbit.Baking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Domain.EventHandler;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Domain Bus
            service.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            service.AddTransient<TransferEventHandler>();

            //Domain Transfer Events
            service.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Domain Banking Commands
            service.AddTransient<IRequestHandler<TransferCommand, bool>, TransferCommandHandler>();

            //Services
            service.AddTransient<IAccountServices, AccountServices>();
            service.AddTransient<ITransferService, TransferService>();

            //Repositories
            service.AddTransient<IAccountRepository, AccountRepository>();
            service.AddTransient<ITransferRepository, TransferRepository>();

            //Data
            service.AddTransient<BakingDbContext>();
            service.AddTransient<TransferDbContext>();
        }
    }
}
