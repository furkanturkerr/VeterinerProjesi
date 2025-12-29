using EntityLayer.Entities;

namespace BusinessLayer.Abstract;

public interface IAppointmentService : IGenericService<Appointment>
{
    List<Appointment> TListAnimal();
    void TChangeStatusTrue(int id);
    void TChangeStatusFalse(int id);
}