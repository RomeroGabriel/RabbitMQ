using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Domain.Interfaces;
using MicroRabbit.Baking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Baking.Application.AccountServices
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository accountRepository;

        public AccountServices(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }
    }
}
