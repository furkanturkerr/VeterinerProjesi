using EntityLayer.Entities;

namespace DataAccessLayer.Abstract;

public interface IAppointmentDal : IGenericDal<Appointment>
{
    List<Appointment> ListAnimal();
    
    void ChangeStatusTrue(int id);
    void ChangeStatusFalse(int id);
}