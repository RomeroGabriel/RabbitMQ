using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Application.Models;
using MicroRabbit.Baking.Domain.Commands;
using MicroRabbit.Baking.Domain.Interfaces;
using MicroRabbit.Baking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroRabbit.Baking.Application.AccountServices
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository accountRepository;
        private readonly IEventBus bus;

        public AccountServices(
            IAccountRepository accountRepository,
            IEventBus bus)
        {
            this.accountRepository = accountRepository;
            this.bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new TransferCommand(
                    accountTransfer.FromAccount,
                    accountTransfer.ToAccount,
                    accountTransfer.TransferAmount
                );

            bus.SendCommand(createTransferCommand);
        }
    }
}
