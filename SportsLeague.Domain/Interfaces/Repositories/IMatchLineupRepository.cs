using SportsLeague.Domain.Entities;
using SportsLeague.Domain.Interfaces.Repositories;

namespace SportsLeague.Domain.Repositories
{
    public interface IMatchLineupRepository : IGenericRepository<MatchLineup>
    {
        Task<IEnumerable<MatchLineup>> GetByMatchAsync(int matchId);
    }
}