using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.AnimalDtos;
using DTOLayer.AppointmentDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VeterinerProjesi.Controllers;
[Area("Admin")]
public class AppointmentController : Controller
{
    private readonly IAppointmentService _appointmentService;
    private readonly IAnimalService _animalService;
    private readonly IMapper _mapper;

    public AppointmentController(IAppointmentService appointmentService, IMapper mapper, IAnimalService animalService)
    {
        _appointmentService = appointmentService;
        _mapper = mapper;
        _animalService = animalService;
    }
    
    public IActionResult ChangeStatusTrue(int id)
    {
        var animal = _animalService.TGetById(id);
        _appointmentService.TChangeStatusTrue(id);
        return RedirectToAction("Index");
    }
    
    public IActionResult ChangeStatusFalse(int id)
    {
        var animal = _animalService.TGetById(id);
        _appointmentService.TChangeStatusFalse(id);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Index()
    {
        var value = _appointmentService.TListAnimal();
        return View(_mapper.Map<List<ResultAppointmentDto>>(value));
    }

    [HttpGet]
    public IActionResult CreateAppointment()
    {
        var animals = _animalService.TGetListAll();
        var animalDtos = _mapper.Map<List<ResultAnimalDto>>(animals);
        ViewBag.Animals = new SelectList(animalDtos, "AnimalId", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult CreateAppointment(CreateAppointmentDto createAppointmentDto)
    {
        var value = _mapper.Map<Appointment>(createAppointmentDto);
        value.Status = 0;
        _appointmentService.TAdd(value);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateAppointment(int id)
    {
        var appointment = _appointmentService.TGetById(id);
        var dto = _mapper.Map<UpdateAppointmentDto>(appointment);

        var animals = _animalService.TGetListAll();
        var animalDtos = _mapper.Map<List<ResultAnimalDto>>(animals);
        ViewBag.Animals = new SelectList(animalDtos, "AnimalId", "Name", dto.AnimalId);

        return View(dto);
    }


    [HttpPost]
    public IActionResult UpdateAppointment(UpdateAppointmentDto updateAppointmentDto)
    { 
        var animals = _animalService.TGetListAll();
        var animalDtos = _mapper.Map<List<ResultAnimalDto>>(animals);
        ViewBag.Animals = new SelectList(animalDtos, "AnimalId", "Name", updateAppointmentDto.AnimalId);
        
        var entity = _mapper.Map<Appointment>(updateAppointmentDto);
        _appointmentService.TUpdate(entity);
        return RedirectToAction("Index");
    }
    
}