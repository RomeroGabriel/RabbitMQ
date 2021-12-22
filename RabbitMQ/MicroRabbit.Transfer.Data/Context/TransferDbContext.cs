using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public DbSet<TransferLog> TransfersLogs { get; set; }

        public TransferDbContext(DbContextOptions options) : base(options)
        {

        }

        public TransferDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FECGN83;Database=BankingDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
