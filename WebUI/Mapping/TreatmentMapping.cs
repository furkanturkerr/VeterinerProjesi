using AutoMapper;
using DTOLayer.TreatmentDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class TreatmentMapping : Profile
{
    public TreatmentMapping()
    {
        CreateMap<Treatment, ResultTreatmentDto>().ReverseMap();
        CreateMap<Treatment, CreateTreatmentDto>().ReverseMap();
        CreateMap<Treatment, UpdateTreatmentDto>().ReverseMap();
    } 
}