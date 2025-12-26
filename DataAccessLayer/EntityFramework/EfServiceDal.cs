using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfServiceDal : GenericRepository<Service>, IServiceDal
{
    public EfServiceDal(VetContext vetContext) : base(vetContext)
    {
    }
}