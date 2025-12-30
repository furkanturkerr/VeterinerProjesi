namespace Api.Dtos.TreatmentDtos;

public class CreateTreatmentDto
{
    public string TreatmentType  { get; set; }
    public string Notes  { get; set; }
    public string Cost  { get; set; }
    public int AppointmentId { get; set; }
}