using EntityLayer.Entities;

namespace BusinessLayer.Abstract;

public interface IAppointmentService : IGenericService<Appointment>
{
    List<Appointment> TListAnimal();
}