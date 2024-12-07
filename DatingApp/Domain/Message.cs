namespace DatingAppFSDProject.Domain
{
    public class Message : BaseDomainModel
    {
        public string? Content { get; set; }
        public int UserId1 { get; set; }
        public int MessageBoxId { get; set; }
        public int UserId2 { get; set; }
    }   
}
