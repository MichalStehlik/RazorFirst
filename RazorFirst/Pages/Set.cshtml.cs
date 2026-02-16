using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorFirst.Pages
{
    public class SetModel : PageModel
    {
        [BindProperty]
        public int Value { get; set; }
        public void OnGet()
        {
            Value = 100;
        }

        public IActionResult OnPost()
        {

            return RedirectToPage("/Value", new { value = Value });
        }
    }
}
