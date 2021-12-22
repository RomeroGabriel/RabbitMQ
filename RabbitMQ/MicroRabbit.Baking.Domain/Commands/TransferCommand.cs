using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Baking.Domain.Commands
{
    public class TransferCommand : Command
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCommand(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
