namespace Api.Dtos.TreatmentDtos;

public class UpdateTreatmentDto
{
    public int TreatmentId { get; set; }
    public string TreatmentType  { get; set; }
    public string Notes  { get; set; }
    public string Cost  { get; set; }
    
    public int AppointmentId { get; set; }
}