using System.Globalization;
using Api.Dtos.AppointmentDtos;
using AutoMapper;
using EntityLayer.Entities;

namespace Api.Mapping;

public class AppointmentMapping : Profile
{
    public AppointmentMapping()
    {
        CreateMap<Appointment, ResultAppointmentDto>().ReverseMap();
        CreateMap<Appointment, CreateAppointmentDto>().ReverseMap();
        CreateMap<Appointment, UpdateAppointmentDto>().ReverseMap();
    }
}