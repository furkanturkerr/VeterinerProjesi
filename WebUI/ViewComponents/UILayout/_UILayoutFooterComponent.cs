using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.FooterDtos;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutFooterComponent : ViewComponent
{
    private readonly IMapper _mapper;
    private readonly IFooterService _footerService;

    public _UILayoutFooterComponent(IMapper mapper, IFooterService footerService)
    {
        _mapper = mapper;
        _footerService = footerService;
    }
    public IViewComponentResult Invoke()
    {
        var value = _footerService.TGetListAll().FirstOrDefault();
        var footer = _mapper.Map<ResultFooterDto>(value);
        return View(footer);
    }
}