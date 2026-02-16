using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorFirst.Pages
{
    public class ValueModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Value { get; set; }
        public void OnGet(/*int id = 0*/)
        {
            //Value = id;
        }

        public IActionResult OnGetIncrease()
        {
            Value++;
            //return Page();
            return RedirectToPage(new { Value });
        }
        public IActionResult OnGetDecrease()
        {
            Value--;
            //return Page();
            return RedirectToPage(new { Value });
        }
    }
}
