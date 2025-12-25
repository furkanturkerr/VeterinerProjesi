using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class AboutManager : IAboutService
{
    private readonly IAboutDal _aboutDal;
    private readonly IUowDal _uowDal;

    public AboutManager(IAboutDal aboutDal, IUowDal uowDal)
    {
        _aboutDal = aboutDal;
        _uowDal = uowDal;
    }
    
    public void TAdd(About entity)
    {
        _aboutDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(About entity)
    {
        _aboutDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(About entity)
    {
        _aboutDal.Delete(entity);
        _uowDal.Save();
    }

    public List<About> TGetListAll()
    {
        return _aboutDal.GetListAll();
    }

    public About TGetById(int id)
    {
        return _aboutDal.GetById(id);
    }
}