using AutoMapper;
using DTOLayer.SummaryDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class SummaryMapping : Profile
{
    public SummaryMapping()
    {
        CreateMap<Summary, ResultSummaryDto>().ReverseMap();
        CreateMap<Summary, CreateSummaryDto>().ReverseMap();
        CreateMap<Summary, GetSummaryDto>().ReverseMap();
        CreateMap<Summary, UpdateSummaryDto>().ReverseMap();
    }
}