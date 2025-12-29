using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework;

public class EfAppointmentDal : GenericRepository<Appointment> , IAppointmentDal
{
    public EfAppointmentDal(VetContext vetContext) : base(vetContext)
    {
    }

    public List<Appointment> ListAnimal()
    {
        var context = new VetContext();
        var values = context.Appointments.Include(x => x.Animal).ToList();
        return values;
    }
}