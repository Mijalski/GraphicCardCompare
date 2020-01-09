using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Mijalski.EntityFrameworkCore
{
    public class DesignTimeDatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=GraphicCardCompare__DEV;Trusted_Connection=True;";
            builder.UseSqlServer(connectionString);
            return new DatabaseContext(builder.Options);
        }
    }
}