using AutoMapper;
using DTOLayer.AnimalDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class AnimalMapping : Profile
{
    public AnimalMapping()
    {
        CreateMap<Animal, ResultAnimalDto>().ReverseMap();
        CreateMap<Animal, CreateAnimalDto>().ReverseMap();
        CreateMap<Animal, UpdateAnimalDto>().ReverseMap();
    } 
}