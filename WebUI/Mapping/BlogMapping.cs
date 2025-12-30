using AutoMapper;
using DTOLayer.BlogDtos;
using EntityLayer.Entities;

namespace VeterinerProjesi.Mapping;

public class BlogMapping : Profile
{
    public BlogMapping()
    {
        CreateMap<Blog, ResultBlogDto>().ReverseMap();
        CreateMap<Blog, CreateBlogDto>().ReverseMap();
        CreateMap<Blog, UpdateBlogDto>().ReverseMap();
    }
}