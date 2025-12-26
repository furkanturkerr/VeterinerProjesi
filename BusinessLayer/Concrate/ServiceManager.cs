using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class ServiceManager: IServiceService
{
    private readonly IServiceDal _serviceDal;
    private readonly IUowDal _uowDal;

    public ServiceManager(IServiceDal serviceDal, IUowDal uowDal)
    {
        _serviceDal = serviceDal;
        _uowDal = uowDal;
    }
    
    public void TAdd(Service entity)
    {
        _serviceDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(Service entity)
    {
        _serviceDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(Service entity)
    {
        _serviceDal.Delete(entity);
        _uowDal.Save();
    }

    public List<Service> TGetListAll()
    {
        return  _serviceDal.GetListAll();
    }

    public Service TGetById(int id)
    {
        return _serviceDal.GetById(id);
    }
}