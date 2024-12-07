namespace DatingAppFSDProject.Domain
{
    public class MessageBox : BaseDomainModel
    {
        public DateTime TimeRecieved { get; set; }
        public int MatchId { get; set; }
        public int UserId { get; set; }
    }
}
