using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.About;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutAboutComponent : ViewComponent
{
    private readonly IMapper _mapper;
    private readonly IAboutService _aboutService;

    public _UILayoutAboutComponent(IMapper mapper, IAboutService aboutService)
    {
        _mapper = mapper;
        _aboutService = aboutService;
    }
    public IViewComponentResult Invoke()
    {
        var values = _aboutService.TGetListAll().FirstOrDefault();
        var about =  _mapper.Map<ResultAboutDto>(values);
        return View(about);
    }
}