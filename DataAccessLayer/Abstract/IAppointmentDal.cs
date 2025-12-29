using EntityLayer.Entities;

namespace DataAccessLayer.Abstract;

public interface IAppointmentDal : IGenericDal<Appointment>
{
    List<Appointment> ListAnimal();
}