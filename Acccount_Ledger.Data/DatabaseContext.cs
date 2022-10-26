using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Acccount_Ledger.Data.Models;

namespace Account_Ledger.Data
{
    public class DatabaseContext : DbContext
    {
        #region Fields
        protected readonly IConfiguration Configuration;
        #endregion Fields

        #region Public Constructors
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }
        #endregion Public Constructors

        #region properties
        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
        #endregion

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connect to sql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("LedgerAccountDatabase");
            optionsBuilder.UseSqlServer(@"server=.;database=LedgerAccounts;persist security info=True;user id=sa;password=1234;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<AccountType>(b =>
            {
                b.HasData(
                new AccountType()
                {
                    Id = 1,
                    Name = "Debit"

                },
                new AccountType()
                {
                    Id = 2,
                    Name = "Credit"
                });
            });
        
        }

        #endregion Protected Methods
    }
}
