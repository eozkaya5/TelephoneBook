using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace TelephoneBook.EntityFrameworkCore
{
    public static class TelephoneBookDbContextModelCreatingExtensions
    {
        public static void ConfigureTelephoneBook(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TelephoneBookConsts.DbTablePrefix + "YourEntities", TelephoneBookConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}