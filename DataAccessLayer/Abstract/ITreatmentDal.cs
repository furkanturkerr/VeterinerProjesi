using EntityLayer.Entities;

namespace DataAccessLayer.Abstract;

public interface ITreatmentDal : IGenericDal<Treatment>
{
    List<Treatment> GetTreatmentsWithDetails();
}