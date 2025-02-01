using DatingApp.Data;

namespace DatingAppFSDProject.Domain
{
    public class ConnectionRequest
    {
        public int? Id { get; set; }
        public string? SenderId { get; set; }
        public string? ReceiverId { get; set; }
        public RequestStatus? Status { get; set; }  // Default, Accepted, Rejected

        public DatingAppUser? Sender { get; set; }
        public DatingAppUser? Receiver { get; set; }
    }

    public enum RequestStatus
    {
        Default,
        Accepted,
        Rejected
    }

}
