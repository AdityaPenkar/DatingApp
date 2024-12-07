namespace DatingAppFSDProject.Domain
{
    public class Admin: BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int ReportId { get; set; }
    }
}
