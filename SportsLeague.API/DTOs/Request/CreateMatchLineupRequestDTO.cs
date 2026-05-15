namespace SportsLeague.API.DTOs.Request
{
    public record CreateMatchLineupRequestDto(int PlayerId, bool IsStarter, string Position);
}