using MicroRabbit.Baking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Baking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
