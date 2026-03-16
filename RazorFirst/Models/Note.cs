using Microsoft.AspNetCore.Identity;

namespace RazorFirst.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public required string Content { get; set; }
        public required string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public required string UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
