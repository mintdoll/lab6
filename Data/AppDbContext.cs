using System.Data.Entity;
using System.Data.SQLite;
using MicrofinanceApp.Models;

namespace MicrofinanceApp.Data
{
    [DbConfigurationType(typeof(SqliteDbConfiguration))]
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base(new SQLiteConnection("Data Source=|DataDirectory|\\Microfinance.db;Version=3;Foreign Keys=True;"), true)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>()
                .HasRequired(l => l.Client)
                .WithMany(c => c.Loans)
                .HasForeignKey(l => l.ClientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loan>()
                .HasRequired(l => l.Manager)
                .WithMany(m => m.Loans)
                .HasForeignKey(l => l.ManagerId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
