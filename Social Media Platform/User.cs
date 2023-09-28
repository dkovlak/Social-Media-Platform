using System;
using System.ComponentModel.DataAnnotations;
namespace Social_Media_Platform
{
	public class User
	{
		[Key()]
		public int Id { get; set; }

		[Required(ErrorMessage = "Come on, don't leave your name blank!")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Your name should be between 2 and 50 characters.")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Your last name is like the cherry on top - can't be missing!")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters.")]
		public string LastName { get; set; }

		[MaxLength(255)]
		public string ProfilePicture { get; set; }

		[MaxLength(500)]
		public string About { get; set; }

		[Required(ErrorMessage = "Don't be shy, give us a username!")]
		[StringLength(25, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 25 characters.")]
		[RegularExpression(@"^[a-zA-z0-9._]+$", ErrorMessage = "UserName can only contain letters, numbers, dots, and underscores.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "We need your email to send you cat memes!")]
		[EmailAddress(ErrorMessage = "Invalid email address. Did you misspell it?")]
		public string Email { get; set; }

		[Required(ErrorMessage = "A password is like a secret handshake, and you forgot it!")]
		[MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
		public string Password { get; set; }

		[DataType(DataType.DateTime)]
		public DateTime CreatedAt { get; set; }

		[DataType(DataType.DateTime)]
		public DateTime LastLogin { get; set; }

		public ICollection<Post> Posts { get; set; }

		public User()
		{
			CreatedAt = DateTime.UtcNow;
		}
	}
}

