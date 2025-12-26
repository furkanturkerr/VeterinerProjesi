using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfUIAppointmentDal : GenericRepository<UIAppointment>, IUIAppointmentDal
{
    public EfUIAppointmentDal(VetContext vetContext) : base(vetContext)
    {
    }
}