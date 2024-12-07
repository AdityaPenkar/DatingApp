namespace DatingAppFSDProject.Domain
{
    public class User : BaseDomainModel
    {

        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Location { get; set; }
        public string? Biography { get; set; }
        public string? Interests { get; set; }
    }
}
