using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class SummaryManager : ISummaryService
{
    private readonly ISummaryDal _summaryDal;
    private readonly IUowDal _uowDal;

    public SummaryManager(ISummaryDal summaryDal, IUowDal uowDal)
    {
        _summaryDal = summaryDal;
        _uowDal = uowDal;
    }
    
    public void TAdd(Summary entity)
    {
        _summaryDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(Summary entity)
    {
        _summaryDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(Summary entity)
    {
        _summaryDal.Delete(entity);
        _uowDal.Save();
    }

    public List<Summary> TGetListAll()
    {
        return _summaryDal.GetListAll();
    }

    public Summary TGetById(int id)
    {
        return _summaryDal.GetById(id);
    }
}