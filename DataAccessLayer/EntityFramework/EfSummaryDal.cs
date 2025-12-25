using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfSummaryDal : GenericRepository<Summary>, ISummaryDal
{
    public EfSummaryDal(VetContext vetContext) : base(vetContext)
    {
    }
}