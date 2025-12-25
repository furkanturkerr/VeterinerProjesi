using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfAboutDal : GenericRepository<About>, IAboutDal
{
    public EfAboutDal(VetContext vetContext) : base(vetContext)
    {
    }
}