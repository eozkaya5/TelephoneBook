using System.Threading.Tasks;

namespace TelephoneBook.Data
{
    public interface ITelephoneBookDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
