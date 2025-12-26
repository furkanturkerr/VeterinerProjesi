using AutoMapper;
using DTOLayer.TeamDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class TeamMapping : Profile
{
    public TeamMapping()
    {
        CreateMap<Team, ResultTeamDto>().ReverseMap();
        CreateMap<Team, CreateTeamDto>().ReverseMap();
        CreateMap<Team, GetTeamDto>().ReverseMap();
        CreateMap<Team, UpdateTeamDto>().ReverseMap();
    }
}