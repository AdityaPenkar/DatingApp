using System.Collections.Generic;

namespace DatingAppFSDProject.Domain
{
	public class Profile : BaseDomainModel
	{
		public ICollection<Photo> Photos { get; set; } = new List<Photo>();

		public bool Visible { get; set; }
		public string? BlockedUser { get; set; }
		public int UserId { get; set; } // Foreign key for User
		public int SettingId { get; set; } // Foreign key for Setting
	}

	// Photo Entity (Nested within Profile class file)
	public class Photo
	{
		public int Id { get; set; } // Primary key for Photo

		public string Url { get; set; } = string.Empty; // Stores the photo URL or file path

		public int ProfileId { get; set; } // Foreign key for Profile
		public Profile? Profile { get; set; } // Navigation property to Profile
	}
}

