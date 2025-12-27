using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.About;
using DTOLayer.SummaryDtos;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutSummaryComponent : ViewComponent
{
    private readonly IMapper _mapper;
    private readonly ISummaryService _summaryService;

    public _UILayoutSummaryComponent(IMapper mapper, ISummaryService summaryService)
    {
        _mapper = mapper;
        _summaryService = summaryService;
    }
    public IViewComponentResult Invoke()
    {
        var value = _summaryService.TGetListAll();
        var summary = _mapper.Map<List<ResultSummaryDto>>(value);
        return View(summary);
    }
}