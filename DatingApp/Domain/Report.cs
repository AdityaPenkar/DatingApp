namespace DatingAppFSDProject.Domain
{
    public class Report: BaseDomainModel
    {
        public string? Reason { get; set; }
        public DateTime DateReported { get; set; }
        public string? Status { get; set; }
        public int UserId1 { get; set; }
        public int UserId2 { get; set; }
    }
}
