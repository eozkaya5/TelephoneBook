using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TelephoneBook
{
    [Dependency(ReplaceServices = true)]
    public class TelephoneBookBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TelephoneBook";
    }
}
