using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TelephoneBook.EntityFrameworkCore
{
    [DependsOn(
        typeof(TelephoneBookEntityFrameworkCoreModule)
        )]
    public class TelephoneBookEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TelephoneBookMigrationsDbContext>();
        }
    }
}
