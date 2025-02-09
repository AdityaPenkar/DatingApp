using DatingApp.Data;

namespace DatingAppFSDProject.Domain
{
    public class Message : BaseDomainModel
    {
        public string? Content { get; set; }
        public string? SenderId { get; set; }
        public string? ReceiverId { get; set; }
        public string? EmojiURL { get; set; }
        public DateTime? Timestamp { get; set; }
        public DatingAppUser? Sender { get; set; }
        public DatingAppUser? Receiver { get; set; }
    }   
}
