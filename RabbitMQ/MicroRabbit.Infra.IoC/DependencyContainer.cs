using MicroRabbit.Baking.Application.AccountServices;
using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Data.Context;
using MicroRabbit.Baking.Data.Repository;
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
            service.AddTransient<IEventBus, RabbitMQBus>();

            //Services
            service.AddTransient<IAccountServices, AccountServices>();

            //Repositories
            service.AddTransient<IAccountRepository, AccountRepository>();
            service.AddTransient<BakingDbContext>();
        }
    }
}
