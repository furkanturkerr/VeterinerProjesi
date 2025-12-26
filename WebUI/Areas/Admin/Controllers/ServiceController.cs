using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.ServiceDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Controllers;
[Area("Admin")]
public class ServiceController : Controller
{
    private readonly IServiceService _service;
    private readonly IMapper _mapper;
    
    public ServiceController(IServiceService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var values = _service.TGetListAll();
        return View(_mapper.Map<List<ResultServiceDto>>(values));
    }

    [HttpGet]
    public IActionResult CreateService()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult CreateService(CreateServiceDto createServiceDto)
    {
        var entity = _mapper.Map<Service>(createServiceDto);
        _service.TAdd(entity);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateService(int id)
    {
        var values = _service.TGetById(id);
        return View(_mapper.Map<UpdateServiceDto>(values));
    }

    [HttpPost]
    public IActionResult UpdateService(UpdateServiceDto updateServiceDto)
    {
        var values = _mapper.Map<Service>(updateServiceDto);
        _service.TUpdate(values);
        return RedirectToAction("Index");
    }
}