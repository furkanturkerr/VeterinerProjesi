namespace EntityLayer.Entities;

public class Appointment
{
    public int AppointmentId { get; set; }
    public DateTime Date { get; set; }
    public TimeOnly Time { get; set; }
    public enum Status
    {
        Scheduled,
        Completed,
        Cancelled
    }
    public string Notes { get; set; }
}