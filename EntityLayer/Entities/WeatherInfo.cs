namespace EntityLayer.Entities;

public class WeatherInfo
{
    public int WeatherInfoId { get; set; }
    public string City { get; set; }
    public string Temperature { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
}