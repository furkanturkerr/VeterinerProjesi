using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfFooterDal : GenericRepository<Footer>, IFooterDal
{
    public EfFooterDal(VetContext vetContext) : base(vetContext)
    {
    }
}