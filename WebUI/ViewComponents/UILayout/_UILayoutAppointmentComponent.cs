using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.TeamDtos;
using DTOLayer.UIAppointmentDtos;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutAppointmentComponent : ViewComponent
{
    private readonly IMapper _mapper;
    private readonly IUIAppointmentService _uiAppointmentService;

    public _UILayoutAppointmentComponent(IMapper mapper, IUIAppointmentService uiAppointmentService)
    {
        _mapper = mapper;
        _uiAppointmentService = uiAppointmentService;
    }
    public IViewComponentResult Invoke()
    {
        var value = _uiAppointmentService.TGetListAll().FirstOrDefault();
        var service = _mapper.Map<ResultUIAppointmentDto>(value);
        return View(service);
    }
}