namespace SportsLeague.Domain.Interfaces.Services
{
    public interface IMatchLineupService
    {
        Task<MatchLineupResponseDTO> CreateAsync(int matchId, CreateMatchLineupRequestDTO dto);
        Task<IEnumerable<MatchLineupResponseDTO>> GetByMatchAsync(int matchId);
    }
}