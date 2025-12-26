using AutoMapper;
using DTOLayer.ServiceDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class ServiceMapping : Profile
{
    public ServiceMapping()
    {
        CreateMap<Service, ResultServiceDto>().ReverseMap();
        CreateMap<Service, CreateServiceDto>().ReverseMap();
        CreateMap<Service, UpdateServiceDto>().ReverseMap();
        CreateMap<Service, GetServiceDto>().ReverseMap();
    }
}