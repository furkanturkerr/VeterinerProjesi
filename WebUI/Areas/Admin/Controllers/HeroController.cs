using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DTOLayer.HeroDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Areas.Admin.Controllers;

[Area("Admin")]
public class HeroController : Controller
{
    private readonly IHeroService _heroService;
    private readonly IMapper _mapper;

    public HeroController(IHeroService heroService, IMapper mapper)
    {
        _heroService = heroService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var values = _heroService.TGetListAll();
        return View(_mapper.Map<List<ResultHeroDto>>(values));
    }

    [HttpGet]
    public IActionResult UpdateHero(int id)
    {
        var values = _heroService.TGetById(id);
        return View(_mapper.Map<UpdateHeroDto>(values));
    }

    [HttpPost]
    public IActionResult UpdateHero(UpdateHeroDto updateHeroDto)
    {
        var heroEntity = _mapper.Map<Hero>(updateHeroDto);  
        _heroService.TUpdate(heroEntity);                  
        return RedirectToAction("Index");
    }
}