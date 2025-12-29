using EntityLayer.Enums;

namespace EntityLayer.Entities;

public class Appointment
{
    public int AppointmentId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public AppointmentStatus Status { get; set; }
    public string Notes { get; set; }
    
    public int AnimalId { get; set; }
    public Animal Animal { get; set; }
    
    public List<Treatment> Treatments { get; set; }
    public List<Payment> Payments { get; set; }
}