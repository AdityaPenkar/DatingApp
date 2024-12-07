namespace DatingAppFSDProject.Domain
{
    public class Setting : BaseDomainModel
    {
        public string? NotificationPreference { get; set; }
        public string? PrivacySetting { get; set; }
        public string? ThemePreference { get; set; }
        public int UserId { get; set; }
    }
}
