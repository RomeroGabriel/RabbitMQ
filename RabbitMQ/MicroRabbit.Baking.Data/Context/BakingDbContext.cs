using MicroRabbit.Baking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Baking.Data.Context
{
    public class BakingDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public BakingDbContext(DbContextOptions options) : base(options)
        {
        }

        public BakingDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FECGN83;Database=BankingDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
