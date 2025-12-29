using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class AppointmentManager : IAppointmentService
{
    private readonly IAppointmentDal _appointmentDal;
    private readonly IUowDal _uowDal;

    public AppointmentManager(IAppointmentDal appointmentDal, IUowDal uowDal)
    {
        _appointmentDal = appointmentDal;
        _uowDal = uowDal;
    }
    
    public void TAdd(Appointment entity)
    {
        _appointmentDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(Appointment entity)
    {
        _appointmentDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(Appointment entity)
    {
        _appointmentDal.Delete(entity);
        _uowDal.Save();
    }

    public List<Appointment> TGetListAll()
    {
        return _appointmentDal.GetListAll();
    }

    public Appointment TGetById(int id)
    {
        return _appointmentDal.GetById(id);
    }

    public List<Appointment> TListAnimal()
    {
        return _appointmentDal.ListAnimal();
    }
}