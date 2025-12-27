using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DTOLayer.AnimalDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Areas.Admin.Controllers;

[Area("Admin")]
public class AnimalController : Controller
{
    private readonly IAnimalService _animalService;
    private readonly IMapper _mapper;

    public AnimalController(IAnimalService animalService, IMapper mapper)
    {
        _animalService = animalService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var value = _animalService.TGetListAll();
        return View(_mapper.Map<List<ResultAnimalDto>>(value));
    }

    [HttpGet]
    public IActionResult CreateAnimal()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateAnimal(CreateAnimalDto createAnimalDto)
    {
        var values = _mapper.Map<Animal>(createAnimalDto);
        _animalService.TAdd(values);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteAnimal(int id)
    {
        var values = _animalService.TGetById(id);
        _animalService.TDelete(values);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateAnimal(int id)
    {
        var value = _animalService.TGetById(id);
        return View(_mapper.Map<ResultAnimalDto>(value));
    }

    [HttpPost]
    public IActionResult UpdateAnimal(ResultAnimalDto updateAnimalDto)
    {
        var values = _mapper.Map<Animal>(updateAnimalDto);
        _animalService.TUpdate(values);
        return RedirectToAction("Index");
    }
}