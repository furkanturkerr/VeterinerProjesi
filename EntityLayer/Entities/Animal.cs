namespace EntityLayer.Entities;

public class Animal
{
    public int AnimalId { get; set; }
    public int OwnerId { get; set; }
    public string Name { get; set; }
    public string Age { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public string Species { get; set; }
    public string Breed { get; set; }
    public string MedicalHistory { get; set; }
    
    public List<Appointment> Appointments { get; set; }
}