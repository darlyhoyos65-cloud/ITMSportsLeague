namespace SportsLeague.Domain.Entities
{
    public class MatchLineup : AuditBase
    {
        public int MatchId { get; set; }
        public int PlayerId { get; set; }
        public bool IsStarter { get; set; }
        public string Position { get; set; } = string.Empty;

        public virtual Match Match { get; set; } = null!;
        public virtual Player Player { get; set; } = null!;
    }
}