using System.ComponentModel.DataAnnotations;

namespace Social_Media_Platform
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;
    }
}