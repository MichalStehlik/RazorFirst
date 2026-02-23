using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public void OnGet()
        {
            Notes = _db.Notes.ToList();
        }
    }
}
