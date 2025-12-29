using System.Globalization;
using AutoMapper;
using DTOLayer.AppointmentDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class AppointmentMapping : Profile
{
    public AppointmentMapping()
    {
        CreateMap<Appointment, ResultAppointmentDto>().ReverseMap();
        CreateMap<Appointment, CreateAppointmentDto>().ReverseMap();
        CreateMap<Appointment, GetAppointmentDto>().ReverseMap();
        CreateMap<Appointment, UpdateAppointmentDto>().ReverseMap();
    }
}