using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfAnimalDal : GenericRepository<Animal>, IAnimalDal 
{
    public EfAnimalDal(VetContext vetContext) : base(vetContext)
    {
    }
}