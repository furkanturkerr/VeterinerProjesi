using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.TeamDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Areas.Admin.Controllers;
[Area("Admin")]
public class TeamController : Controller
{
    private readonly ITeamService _teamService;
    private readonly IMapper _mapper;

    public TeamController(ITeamService teamService, IMapper mapper)
    {
        _teamService = teamService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var value = _teamService.TGetListAll();
        return View(_mapper.Map<List<ResultTeamDto>>(value));
    }

    [HttpGet]
    public IActionResult CreateTeam()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult CreateTeam(CreateTeamDto createTeamDto)
    {
        var team = _mapper.Map<Team>(createTeamDto);
        _teamService.TAdd(team);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteTeam(int id)
    {
        var value = _teamService.TGetById(id);
        _teamService.TDelete(value);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateTeam(int id)
    {
        var value = _teamService.TGetById(id);
        return View(_mapper.Map<ResultTeamDto>(value));
    }

    [HttpPost]
    public IActionResult UpdateTeam(ResultTeamDto updateTeamDto)
    {
        var team = _mapper.Map<Team>(updateTeamDto);
        _teamService.TUpdate(team);
        return RedirectToAction("Index");
    }
}