using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorFirst.Data;
using RazorFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RazorFirst.Pages
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly RazorFirst.Data.ApplicationDbContext _context;
        private readonly ILogger<CreateModel> _logger;

        public CreateModel(
            RazorFirst.Data.ApplicationDbContext context,
            ILogger<CreateModel> logger
            )
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public NoteIM Note { get; set; } = default!;
        [TempData]
        public string? Success { get; set; }
        [TempData]
        public string? Failure { get; set; }

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                _logger.LogInformation("Creating a new note with title: {Title}", Note.Title);
                var userId = User?.Claims?.Where(c => c.Type == ClaimTypes.NameIdentifier)?.FirstOrDefault()?.Value;

                Note input = new Note
                {
                    Title = Note.Title,
                    Content = Note.Content,
                    UserId = userId ?? "Unknown",
                    CreatedAt = DateTime.Now
                };
                _context.Notes.Add(input);
                await _context.SaveChangesAsync();
                Success = "Poznámka byla úspěšně vytvořena.";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while logging the note creation.");
                Failure = "Došlo k chybě při ukládání poznámky.";
            }
            return RedirectToPage("./Index");
        }
    }

    public class NoteIM
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(10, ErrorMessage = "Obsah musí být alespoň 10 znaků dlouhý.")]
        public string Content { get; set; } = string.Empty;

    }
}
