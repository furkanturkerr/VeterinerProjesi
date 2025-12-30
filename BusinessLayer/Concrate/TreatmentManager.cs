using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class TreatmentManager : ITreatmentService
{
    private readonly ITreatmentDal _treatmentDal;
    private readonly IUowDal _uowDal;

    public TreatmentManager(ITreatmentDal treatmentDal, IUowDal uowDal)
    {
        _treatmentDal = treatmentDal;
        _uowDal = uowDal;
    }
    
    public void TAdd(Treatment entity)
    {
        _treatmentDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(Treatment entity)
    {
        _treatmentDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(Treatment entity)
    {
        _treatmentDal.Delete(entity);
        _uowDal.Save();
    }

    public List<Treatment> TGetListAll()
    {
        return _treatmentDal.GetListAll();
    }

    public Treatment TGetById(int id)
    {
        return _treatmentDal.GetById(id);
    }

    public List<Treatment> TGetTreatmentsWithDetails()
    {
        return _treatmentDal.GetTreatmentsWithDetails();
    }
}