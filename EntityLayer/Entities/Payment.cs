namespace EntityLayer.Entities;

public class Payment
{
    public int PaymentId { get; set; }
    public Decimal AmountPaid { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod  { get; set; }
    
    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }
}