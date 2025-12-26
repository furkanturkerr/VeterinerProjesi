using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfTeamDal : GenericRepository<Team> , ITeamDal
{
    public EfTeamDal(VetContext vetContext) : base(vetContext)
    {
    }
}