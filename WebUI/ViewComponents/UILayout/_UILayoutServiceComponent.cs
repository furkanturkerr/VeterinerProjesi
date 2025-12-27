using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.ServiceDtos;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutServiceComponent : ViewComponent
{
    private readonly IMapper _mapper;
    private readonly IServiceService _service;

    public _UILayoutServiceComponent(IMapper mapper, IServiceService service)
    {
        _mapper = mapper;
        _service = service;
    }
    public IViewComponentResult Invoke()
    {
        var values = _service.TGetListAll();
        var service = _mapper.Map<List<ResultServiceDto>>(values);
        return View(service);
    }
}