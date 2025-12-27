using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class FooterManager : IFooterService
{
    private readonly IFooterDal _footerDal;
    private readonly IUowDal _uowDal;

    public FooterManager(IFooterDal footerDal, IUowDal uowDal)
    {
        _footerDal = footerDal;
        _uowDal = uowDal;
    }
    
    public void TAdd(Footer entity)
    {
        _footerDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(Footer entity)
    {
        _footerDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(Footer entity)
    {
        _footerDal.Delete(entity);
        _uowDal.Save();
    }

    public List<Footer> TGetListAll()
    {
        return _footerDal.GetListAll();
    }

    public Footer TGetById(int id)
    {
        return _footerDal.GetById(id);
    }
}