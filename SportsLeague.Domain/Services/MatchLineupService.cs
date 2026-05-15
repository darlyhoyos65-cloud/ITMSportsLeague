using SportsLeague.Domain.Entities;
using SportsLeague.Domain.Interfaces.Services;
using SportsLeague.Domain.Repositories;

namespace SportsLeague.API.Services
{
    IMatchLineupService
    public class MatchLineupService :
    {
        private readonly IMatchLineupRepository _repository;
        private readonly IMapper _mapper;

        public MatchLineupService(IMatchLineupRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<MatchLineupResponseDto> CreateAsync(int matchId, CreateMatchLineupRequestDto dto)
        {
            var lineup = _mapper.Map<MatchLineup>(dto);
            lineup.MatchId = matchId;
            await _repository.AddAsync(lineup);
            await _repository.SaveChangesAsync();
            return _mapper.Map<MatchLineupResponseDto>(lineup);
        }

        public async Task<IEnumerable<MatchLineupResponseDto>> GetByMatchAsync(int matchId)
        {
            var result = await _repository.GetByMatchAsync(matchId);
            return _mapper.Map<IEnumerable<MatchLineupResponseDto>>(result);
        }
    }
}