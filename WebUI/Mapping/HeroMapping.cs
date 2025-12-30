using AutoMapper;
using DTOLayer.HeroDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class HeroMapping : Profile
{
    public HeroMapping()
    {
        CreateMap<Hero, ResultHeroDto>().ReverseMap();
        CreateMap<Hero, CreateHeroDto>().ReverseMap();
        CreateMap<Hero, UpdateHeroDto>().ReverseMap();
    }
}