using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TelephoneBook.Data
{
    /* This is used if database provider does't define
     * ITelephoneBookDbSchemaMigrator implementation.
     */
    public class NullTelephoneBookDbSchemaMigrator : ITelephoneBookDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}