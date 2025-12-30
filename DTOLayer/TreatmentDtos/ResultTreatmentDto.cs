namespace DTOLayer.TreatmentDtos;

public class ResultTreatmentDto
{
    public int TreatmentId { get; set; }
    public string TreatmentType  { get; set; }
    
    public DateOnly TreatmentDate  { get; set; }
    public string TreatmentTime  { get; set; }
    public string Notes  { get; set; }
    public string Cost  { get; set; }
    
    public string Date { get; set; }
    public string Time { get; set; }
    
    public string AnimalName { get; set; }
    public string AnimalSpecies { get; set; }
    
    public int AppointmentId { get; set; }
}