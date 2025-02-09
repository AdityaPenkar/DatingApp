namespace DatingAppFSDProject.Domain
{
    public class Report: BaseDomainModel
    {
        public string? Reason { get; set; }
        public DateTime DateTimeReported { get; set; }
        public string? Status { get; set; }
        public string? SenderId { get; set; }
        public string? RecieverId { get; set; }
    }
}
