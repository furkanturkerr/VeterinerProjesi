using EntityLayer.Enums;

namespace DTOLayer.AppointmentDtos;

public class GetAppointmentDto
{
    public int AppointmentId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public AppointmentStatus Status { get; set; }
    public string Notes { get; set; }
}