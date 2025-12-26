using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class UIAppointmentManager : IUIAppointmentService
{
    private readonly IUIAppointmentDal _UIAppointmentDal;
    private readonly IUowDal _UowDal;

    public UIAppointmentManager(IUIAppointmentDal UIAppointmentDal, IUowDal UowDal)
    {
        _UIAppointmentDal = UIAppointmentDal;
        _UowDal = UowDal;
    }
    
    public void TAdd(UIAppointment entity)
    {
        _UIAppointmentDal.Add(entity);
        _UowDal.Save();
    }

    public void TUpdate(UIAppointment entity)
    {
        _UIAppointmentDal.Update(entity);
        _UowDal.Save();
    }

    public void TDelete(UIAppointment entity)
    {
        _UIAppointmentDal.Delete(entity);
        _UowDal.Save();
    }

    public List<UIAppointment> TGetListAll()
    {
        return _UIAppointmentDal.GetListAll();
    }

    public UIAppointment TGetById(int id)
    {
        return _UIAppointmentDal.GetById(id);
    }
}