using DatingApp.Data;
using System.Collections.Generic;

namespace DatingAppFSDProject.Domain
{
	public class Profile : BaseDomainModel
	{

		public string? UId { get; set; } // Foreign key for User
        public string? Role { get; set; }
        public string? Bio { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? Interest { get; set; }
        public string? SeenProfiles { get; set; }

        // Navigation property
        public DatingAppUser? User { get; set; }
    }

}

