using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForumWeb.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }
        public int? QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Question? Question { get; set; }
    }
}
