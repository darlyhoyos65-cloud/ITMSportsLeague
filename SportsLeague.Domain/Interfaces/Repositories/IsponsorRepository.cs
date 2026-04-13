using SportsLeague.Domain.Entities;
using SportsLeague.Domain.Interfaces.Repositories;

namespace SportsLeague.Domain.Interfaces
{
    public interface ISponsorRepository : IGenericRepository<Sponsor>
    {
        Task<Sponsor?> GetByNameAsync(string name);
        Task<bool> ExistsByNameAsync(string name);
    }
}