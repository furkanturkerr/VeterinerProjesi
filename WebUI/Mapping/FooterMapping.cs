using AutoMapper;
using DTOLayer.FooterDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class FooterMapping : Profile
{
    public FooterMapping()
    {
        CreateMap<Footer, ResultFooterDto>().ReverseMap();
        CreateMap<Footer, CreateFooterDto>().ReverseMap();
        CreateMap<Footer, UpdateFooterDto>().ReverseMap();
    }
}