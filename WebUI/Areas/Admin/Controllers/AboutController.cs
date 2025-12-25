using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.About;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Areas.Admin.Controllers;
[Area("Admin")]
public class AboutController : Controller
{
    private readonly IAboutService _aboutService;
    private readonly IMapper _mapper;

    public AboutController(IAboutService aboutService, IMapper mapper)
    {
        _aboutService = aboutService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var values = _aboutService.TGetListAll();
        return View(_mapper.Map<List<ResultAboutDto>>(values));
    }

    [HttpGet]
    public IActionResult CreateAbout()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateAbout(CreateAboutDto createAboutDto)
    {
        var values = _mapper.Map<About>(createAboutDto);
        _aboutService.TAdd(values);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteAbout(int id)
    {
        var  values = _aboutService.TGetById(id);
        _aboutService.TDelete(values);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateAbout(int id)
    {
        var values = _aboutService.TGetById(id);
        return View(_mapper.Map<UpdateAboutDto>(values));
    }

    [HttpPost]
    public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
    {
        var values = _mapper.Map<About>(updateAboutDto);
        _aboutService.TUpdate(values);
        return RedirectToAction("Index");
    }
}