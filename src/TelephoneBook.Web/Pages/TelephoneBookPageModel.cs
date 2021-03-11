using TelephoneBook.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TelephoneBook.Web.Pages
{
    public abstract class TelephoneBookPageModel : AbpPageModel
    {
        protected TelephoneBookPageModel()
        {
            LocalizationResourceType = typeof(TelephoneBookResource);
        }
    }
}