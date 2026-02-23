using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace RazorFirst.Pages
{
    public class SetModel : PageModel
    {
        [BindProperty]
        [DisplayName("Hodnota")]
        public int Value { get; set; }
        [BindProperty]
        public InputModel Input { get; set; }
        
        public SetModel()
        {
            Input = new InputModel();
        }
        public void OnGet()
        { 
            Value = 100;
        }

        public IActionResult OnPost()
        {

            return RedirectToPage("/Value", new { value = Input.Value });
        }
    }

    public class InputModel
    {
        [DisplayName("Hodnota")]
        public int Value { get; set; }
    }
}
