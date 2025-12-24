using DataAccessLayer.Concrate;

namespace DataAccessLayer.UnitOfWork;

public class UowDal : IUowDal
{
    private readonly VetContext _vetContext;
    public UowDal(VetContext vetContext)
    {
        _vetContext = vetContext;
    }
    
    public void Save()
    {
        _vetContext.SaveChanges();
    }
}