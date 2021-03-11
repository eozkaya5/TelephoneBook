using System;
using System.Collections.Generic;
using System.Text;
using TelephoneBook.Localization;
using Volo.Abp.Application.Services;

namespace TelephoneBook
{
    /* Inherit your application services from this class.
     */
    public abstract class TelephoneBookAppService : ApplicationService
    {
        protected TelephoneBookAppService()
        {
            LocalizationResource = typeof(TelephoneBookResource);
        }
    }
}
