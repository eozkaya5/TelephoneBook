using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace TelephoneBook.Web.Pages
{
    public class IndexModel : TelephoneBookPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}