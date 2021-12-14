using MicroRabbit.Baking.Data.Context;
using MicroRabbit.Baking.Domain.Interfaces;
using MicroRabbit.Baking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Baking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BakingDbContext ctx;

        public AccountRepository(BakingDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return ctx.Accounts;
        }
    }
}
