using DatingApp.Data;

namespace DatingAppFSDProject.Domain
{
    public class Message : BaseDomainModel
    {
        public string? Content { get; set; }
        public int UserId1 { get; set; }
        public int MessageBoxId { get; set; }
        public int UserId2 { get; set; }
        // Updated
        public string? SenderId { get; set; }
        public string? ReceiverId { get; set; }
        public string? EmojiURL { get; set; }
        public DateTime? Timestamp { get; set; }
        public DatingAppUser? Sender { get; set; }
        public DatingAppUser? Receiver { get; set; }
    }   
}
