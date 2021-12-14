using MicroRabbit.Baking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Baking.Application.Interfaces
{
    public interface IAccountServices
    {
        IEnumerable<Account> GetAccounts();
    }
}
