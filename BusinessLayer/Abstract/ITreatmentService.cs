using EntityLayer.Entities;

namespace BusinessLayer.Abstract;

public interface ITreatmentService : IGenericService<Treatment>
{
    List<Treatment> TGetTreatmentsWithDetails();

}