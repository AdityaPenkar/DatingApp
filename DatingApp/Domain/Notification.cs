namespace DatingAppFSDProject.Domain
{
    public class Notification: BaseDomainModel
    {
        public string? Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime TimeRecived { get; set; }
        public int UserId { get; set; }
        public int MessageId { get; set; }
    }
}
