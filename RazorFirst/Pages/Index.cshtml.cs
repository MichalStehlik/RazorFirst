using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorFirst.Data;
using RazorFirst.Models;

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
            User = HttpContext.User.Identity.IsAuthenticated
                ? 
                new IdentityUser { UserName = HttpContext.User.Identity.Name } 
                : 
                null;
            _logger.LogInformation("Index page accessed.");
            _logger.LogDebug("Fetching notes from the database.");
            _logger.LogDebug("Database context: {DbContext}", _db.Database.GetDbConnection().ConnectionString);
            Notes = _db.Notes.ToList();
        }
    }
}
