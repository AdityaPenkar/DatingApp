using DatingAppFSDProject.Domain;
using Microsoft.AspNetCore.Identity;

namespace DatingApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class DatingAppUser : IdentityUser
    {
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? isDeleted { get; set; }

        public Profile? Profile { get; set; }
    }
}
