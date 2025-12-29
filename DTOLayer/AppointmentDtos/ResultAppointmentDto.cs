using EntityLayer.Enums;

namespace DTOLayer.AppointmentDtos;

public class ResultAppointmentDto
{
    public int AppointmentId { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public AppointmentStatus Status { get; set; }
    public string Notes { get; set; }
    public string AnimalName { get; set; }
    public string AnimalSpecies { get; set; }
    public string AnimalAge { get; set; }
}