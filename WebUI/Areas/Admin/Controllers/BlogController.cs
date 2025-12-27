using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.BlogDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Areas.Admin.Controllers;
[Area("Admin")]
public class BlogController : Controller
{
    private readonly IBlogService _blogService;
    private readonly IMapper _mapper;

    public BlogController(IBlogService blogService, IMapper mapper)
    {
        _blogService = blogService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var value = _blogService.TGetListAll();
        return View(_mapper.Map<List<ResultBlogDto>>(value));
    }
    
    [HttpGet]
    public IActionResult CreateBlog()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateBlog(CreateBlogDto createBlogDto)
    {
        var value = _mapper.Map<Blog>(createBlogDto);
        _blogService.TAdd(value);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteBlog(int id)
    {
        var value = _blogService.TGetById(id);
        _blogService.TDelete(value);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateBlog(int id)
    {
        var value = _blogService.TGetById(id);
        return View(_mapper.Map<UpdateBlogDto>(value));
    }

    [HttpPost]
    public IActionResult UpdateBlog(UpdateBlogDto updateBlogDto)
    {
        var value = _mapper.Map<Blog>(updateBlogDto);
        _blogService.TUpdate(value);
        return RedirectToAction("Index");
    }
}