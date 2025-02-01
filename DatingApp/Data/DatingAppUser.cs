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
        public string? Bio { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? Role { get; set; }
        public string? Interest { get; set; }
        public bool? isDeleted { get; set; }
        public int Age
        {
            get
            {
                if (DateOfBirth.HasValue)
                {
                    var today = DateTime.Today;
                    var age = today.Year - DateOfBirth.Value.Year;
                    if (DateOfBirth.Value.Date > today.AddYears(-age)) age--;
                    return age;
                }
                return 0; // Default value if DateOfBirth is null
            }
        }
    }
}
