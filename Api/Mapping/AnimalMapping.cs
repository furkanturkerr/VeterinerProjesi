using AutoMapper;
using Api.Dtos.AnimalDtos;
using EntityLayer.Entities;

namespace Api.Mapping;

public class AnimalMapping : Profile
{
    public AnimalMapping()
    {
        CreateMap<Animal, ResultAnimalDto>().ReverseMap();
        CreateMap<Animal, CreateAnimalDto>().ReverseMap();
        CreateMap<Animal, GetAnimalDto>().ReverseMap();
        CreateMap<Animal, UpdateAnimalDto>().ReverseMap();
    }
}