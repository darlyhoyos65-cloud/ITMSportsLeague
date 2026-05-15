using Microsoft.EntityFrameworkCore;
using SportsLeague.DataAccess.Context;
using SportsLeague.Domain.Entities;
using SportsLeague.Domain.Repositories;

namespace SportsLeague.DataAccess.Repositories
{
    public class MatchLineupRepository : GenericRepository<MatchLineup>, IMatchLineupRepository
    {
        public MatchLineupRepository(LeagueDbContext context) : base(context) { }

        public async Task<IEnumerable<MatchLineup>> GetByMatchAsync(int matchId)
        {
            return await _context.MatchLineups
                .Include(ml => ml.Player)
                .Where(ml => ml.MatchId == matchId)
                .ToListAsync();
        }
    }
}