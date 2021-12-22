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
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Domain Bus
            service.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Banking Commands
            service.AddTransient<IRequestHandler<TransferCommand, bool>, TransferCommandHandler>();

            //Services
            service.AddTransient<IAccountServices, AccountServices>();

            //Repositories
            service.AddTransient<IAccountRepository, AccountRepository>();
            service.AddTransient<BakingDbContext>();
        }
    }
}
