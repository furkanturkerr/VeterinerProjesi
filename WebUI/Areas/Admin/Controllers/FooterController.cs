using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.BlogDtos;
using DTOLayer.FooterDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Areas.Admin.Controllers;
[Area("Admin")]
public class FooterController : Controller
{
    private readonly IFooterService _footerService;
    private readonly IMapper _mapper;

    public FooterController(IFooterService footerService, IMapper mapper)
    {
        _footerService = footerService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var value = _footerService.TGetListAll();
        return View(_mapper.Map<List<ResultFooterDto>>(value));
    }
    
    [HttpGet]
    public IActionResult CreateFooter()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateFooter(CreateFooterDto createFooterDto)
    {
        var value = _mapper.Map<Footer>(createFooterDto);
        _footerService.TAdd(value);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteFooter(int id)
    {
        var value = _footerService.TGetById(id);
        _footerService.TDelete(value);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult UpdateFooter(int id)
    {
        var value = _footerService.TGetById(id);
        return View(_mapper.Map<UpdateFooterDto>(value));
    }

    [HttpPost]
    public IActionResult UpdateFooter(UpdateFooterDto updateFooterDto)
    {
        var value = _mapper.Map<Footer>(updateFooterDto);
        _footerService.TUpdate(value);
        return RedirectToAction("Index");
    }
}