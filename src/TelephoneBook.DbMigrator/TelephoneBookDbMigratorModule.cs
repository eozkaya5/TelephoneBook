using TelephoneBook.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TelephoneBook.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TelephoneBookEntityFrameworkCoreDbMigrationsModule),
        typeof(TelephoneBookApplicationContractsModule)
        )]
    public class TelephoneBookDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
