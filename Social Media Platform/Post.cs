using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Media_Platform
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User Author { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;

        public string Location { get; set; }
    }
}