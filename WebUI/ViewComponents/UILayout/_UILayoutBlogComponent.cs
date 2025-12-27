using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.BlogDtos;
using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutBlogComponent : ViewComponent
{
    private readonly IMapper _mapper;
    private readonly IBlogService _blogService;

    public _UILayoutBlogComponent(IMapper mapper, IBlogService blogService)
    {
        _mapper = mapper;
        _blogService = blogService;
    }
    public IViewComponentResult Invoke()
    {
        var value = _blogService.TGetListAll();
        var blog = _mapper.Map<List<ResultBlogDto>>(value);
        return View(blog);
    }
}