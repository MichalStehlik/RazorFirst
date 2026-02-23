using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorFirst.Pages
{
    public class ValueModel : PageModel
    {
        [TempData]
        public string? Success { get; set; }

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
            Success = "Hodnota byla úspìšnì zvýšena.";
            return RedirectToPage(new { Value });
        }
        public IActionResult OnGetDecrease()
        {
            Value--;
            //return Page();
            Success = "Hodnota byla úspìšnì snížena.";
            return RedirectToPage(new { Value });
        }
    }
}
