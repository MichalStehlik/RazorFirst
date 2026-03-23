using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorFirst.Pages
{
    [Authorize(Roles = "Administrátor")]
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
