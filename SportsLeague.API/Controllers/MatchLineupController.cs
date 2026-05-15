using AutoMapper;
using SportsLeague.Domain.Entities;

namespace SportsLeague.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateMatchLineupRequestDTO, MatchLineup>();
            CreateMap<MatchLineup, MatchLineupResponseDTO>();
        }
    }
}