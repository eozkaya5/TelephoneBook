using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TelephoneBook.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class TelephoneBookMigrationsDbContextFactory : IDesignTimeDbContextFactory<TelephoneBookMigrationsDbContext>
    {
        public TelephoneBookMigrationsDbContext CreateDbContext(string[] args)
        {
            TelephoneBookEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<TelephoneBookMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new TelephoneBookMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TelephoneBook.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
