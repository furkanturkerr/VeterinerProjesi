namespace DTOLayer.FooterDtos;

public class UpdateFooterDto
{
    public int FooterId { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}