using TelephoneBook.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TelephoneBook.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TelephoneBookController : AbpController
    {
        protected TelephoneBookController()
        {
            LocalizationResource = typeof(TelephoneBookResource);
        }
    }
}