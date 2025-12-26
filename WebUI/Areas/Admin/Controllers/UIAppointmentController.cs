using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.UIAppointmentDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Areas.Admin.Controllers;
[Area("Admin")]
public class UIAppointmentController : Controller
{
    private readonly IUIAppointmentService _uiAppointmentService;
    private readonly IMapper _mapper;

    public UIAppointmentController(IUIAppointmentService uiAppointmentService, IMapper mapper)
    {
        _uiAppointmentService = uiAppointmentService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var value = _uiAppointmentService.TGetListAll();
        return View(_mapper.Map<List<ResultUIAppointmentDto>>(value));
    }

    [HttpGet]
    public IActionResult CreateUIAppointment()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateUIAppointment(CreateUIAppointmentDto createUIAppointmentDto)
    {
        var value = _mapper.Map<UIAppointment>(createUIAppointmentDto);
        _uiAppointmentService.TAdd(value);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteUIAppointment(int id)
    {
        var value = _uiAppointmentService.TGetById(id);
        _uiAppointmentService.TDelete(value);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateUIAppointment(int id)
    {
        var value = _uiAppointmentService.TGetById(id);
        return View(_mapper.Map<UpdateUIAppointmentDto>(value));
    }

    [HttpPost]
    public IActionResult UpdateUIAppointment(UpdateUIAppointmentDto updateUIAppointmentDto)
    {
        var value = _mapper.Map<UIAppointment>(updateUIAppointmentDto);
        _uiAppointmentService.TUpdate(value);
        return RedirectToAction("Index");
    }
}