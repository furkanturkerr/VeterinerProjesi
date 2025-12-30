using AutoMapper;
using DTOLayer.UIAppointmentDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class UIAppointmentMapping : Profile
{
    public UIAppointmentMapping()
    {
        CreateMap<UIAppointment, ResultUIAppointmentDto>().ReverseMap();
        CreateMap<UIAppointment, CreateUIAppointmentDto>().ReverseMap();
        CreateMap<UIAppointment, UpdateUIAppointmentDto>().ReverseMap();
    }
}