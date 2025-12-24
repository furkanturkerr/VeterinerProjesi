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
}