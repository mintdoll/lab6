using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite;
using System.Data.SQLite.EF6;

namespace MicrofinanceApp.Data
{
    public class SqliteDbConfiguration : DbConfiguration
    {
        public SqliteDbConfiguration()
        {
            var providerFactory = SQLiteProviderFactory.Instance;
            var providerServices = (DbProviderServices)providerFactory.GetService(typeof(DbProviderServices));

            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", providerFactory);
            SetProviderServices("System.Data.SQLite", providerServices);
            SetProviderServices("System.Data.SQLite.EF6", providerServices);
        }
    }
}
