namespace EntityLayer.Entities;

public class Treatment
{
    public int TreatmentId { get; set; }
    public string TreatmentType  { get; set; }
    public string Notes  { get; set; }
    public string Cost  { get; set; }
    public DateOnly TreatmentDate  { get; set; }
    public TimeOnly TreatmentTime  { get; set; }
    
    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }
}