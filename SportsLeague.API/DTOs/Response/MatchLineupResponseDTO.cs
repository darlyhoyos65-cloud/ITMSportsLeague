namespace SportsLeague.API.DTOs.Response
{
    public record MatchLineupResponseDto(int Id, int MatchId, int PlayerId, bool IsStarter, string Position);
}