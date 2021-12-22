using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly IEventBus bus;
        private readonly ITransferRepository transferRepository;

        public TransferService(
            IEventBus bus,
            ITransferRepository transferRepository)
        {
            this.bus = bus;
            this.transferRepository = transferRepository;
        }

        public IEnumerable<TransferLog> GetTransfers()
        {
            return transferRepository.GetTransfers();
        }
    }
}
