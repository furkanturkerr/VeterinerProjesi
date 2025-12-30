using Api.Dtos.TreatmentDtos;
using AutoMapper;
using EntityLayer.Entities;

namespace Api.Mapping;

public class TreatmentMapping : Profile
{
    public TreatmentMapping()
    {
        CreateMap<Treatment, ResultTreatmentDto>()
            .ForMember(dest => dest.AnimalId,
                opt => opt.MapFrom(src => src.Appointment.Animal.AnimalId))
            .ForMember(dest => dest.AnimalName,
                opt => opt.MapFrom(src => src.Appointment.Animal.Name))
            .ForMember(dest => dest.AnimalSpecies,
            opt => opt.MapFrom(src => src.Appointment.Animal.Species));
        
        CreateMap<Treatment, CreateTreatmentDto>().ReverseMap();
        CreateMap<Treatment, GetTreatmentDto>().ReverseMap();
        CreateMap<Treatment, UpdateTreatmentDto>().ReverseMap();
    }
}