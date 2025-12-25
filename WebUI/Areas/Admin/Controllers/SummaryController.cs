using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.HeroDtos;
using DTOLayer.SummaryDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Controllers;
[Area("Admin")]
public class SummaryController : Controller
{
    private readonly ISummaryService _summaryService;
    private readonly IMapper _mapper;

    public SummaryController(ISummaryService summaryService, IMapper mapper)
    {
        _summaryService = summaryService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var values = _summaryService.TGetListAll();
        return View(_mapper.Map<List<ResultSummaryDto>>(values));
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateSummaryDto createSummaryDto)
    {
        var values = _mapper.Map<Summary>(createSummaryDto);
        _summaryService.TAdd(values);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var  values = _summaryService.TGetById(id);
        _summaryService.TDelete(values);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        var values = _summaryService.TGetById(id);
        return View(_mapper.Map<ResultSummaryDto>(values));
    }

    [HttpPost]
    public IActionResult Update(UpdateSummaryDto updateSummaryDto)
    {
        var values = _mapper.Map<Summary>(updateSummaryDto);
        _summaryService.TUpdate(values);
        return RedirectToAction("Index");
    }
}