using EntityLayer.Enums;

namespace Api.Dtos.AppointmentDtos;

public class UpdateAppointmentDto
{
    public int AppointmentId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public AppointmentStatus Status { get; set; }
    public string Notes { get; set; }
    public int AnimalId { get; set; }
}