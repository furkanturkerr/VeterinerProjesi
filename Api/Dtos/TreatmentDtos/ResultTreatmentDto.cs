namespace Api.Dtos.TreatmentDtos;

public class ResultTreatmentDto
{
    public int TreatmentId { get; set; }
    public string TreatmentType  { get; set; }
    public string Notes  { get; set; }
    public string Cost  { get; set; }
    public DateOnly TreatmentDate  { get; set; }
    public TimeOnly TreatmentTime  { get; set; }
    
    public int AppointmentId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    
    public int AnimalId { get; set; }
    public string AnimalName { get; set; }
    public string AnimalSpecies { get; set; }
}