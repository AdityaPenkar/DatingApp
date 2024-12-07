    namespace DatingAppFSDProject.Domain
{
    public class Match : BaseDomainModel
    {
        public int MatchScore { get; set; }
        public string? Status { get; set; }
        public int UserId1 { get; set; }
        public int UserId2 { get; set; }
    }
}
