using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorFirst.Data;
using RazorFirst.Models;
using System.Security.Claims;

namespace RazorFirst.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _db;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public List<Note> Notes { get; set; }
        public IdentityUser User { get; set; }
        public void OnGet()
        {
            _logger.LogInformation("Index page accessed.");

            if (!HttpContext.User.Identity?.IsAuthenticated ?? true)
            {
                return;
            }

            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            _logger.LogDebug("Fetching notes from the database.");
            _logger.LogDebug("Database context: {DbContext}", _db.Database.GetDbConnection().ConnectionString);

            Notes = _db.Notes.Where(n => n.UserId == userId).ToList();
        }
    }
}
