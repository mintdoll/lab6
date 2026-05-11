using System.Data.Entity.Migrations;
using MicrofinanceApp.Data;
using System.Data.SQLite.EF6.Migrations;

namespace MicrofinanceApp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(AppDbContext context)
        {
        }
    }
}
