using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.HeroDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutHeroComponent : ViewComponent
{
    private readonly IMapper _mapper;
    private readonly IHeroService _heroService;

    public _UILayoutHeroComponent(IMapper mapper, IHeroService heroService)
    {
        _mapper = mapper;
        _heroService = heroService;
    }
    
    public IViewComponentResult Invoke()
    {
        var value = _heroService.TGetListAll().FirstOrDefault(); 
        var dto = _mapper.Map<ResultHeroDto>(value);
        return View(dto);
    }

}