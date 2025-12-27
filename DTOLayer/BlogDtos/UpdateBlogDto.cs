namespace DTOLayer.BlogDtos;

public class UpdateBlogDto
{
    public int BlogId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
}