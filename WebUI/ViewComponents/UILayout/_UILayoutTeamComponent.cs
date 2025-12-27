using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.ServiceDtos;
using DTOLayer.TeamDtos;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutTeamComponent : ViewComponent
{
    private readonly IMapper _mapper;
    private readonly ITeamService _teamService;

    public _UILayoutTeamComponent(IMapper mapper, ITeamService teamService)
    {
        _mapper = mapper;
        _teamService = teamService;
    }
    public IViewComponentResult Invoke()
    {
        var value = _teamService.TGetListAll();
        var service = _mapper.Map<List<ResultTeamDto>>(value);
        return View(service);
    }
}