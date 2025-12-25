using AutoMapper;
using DTOLayer.About;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class AboutMapping : Profile
{
    public AboutMapping()
    {
        CreateMap<About, ResultAboutDto>().ReverseMap();
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, GetAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
    }
}