using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfHeroDal : GenericRepository<Hero>, IHeroDal
{
    public EfHeroDal(VetContext vetContext) : base(vetContext)
    {
    }
}