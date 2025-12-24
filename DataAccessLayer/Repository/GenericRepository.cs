using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;

namespace DataAccessLayer.Repository;

public class GenericRepository<T> : IGenericDal<T> where T : class
{
    private readonly VetContext _vetContext;
    public GenericRepository(VetContext vetContext)
    {
        _vetContext = vetContext;
    }
    
    public void Add(T entity)
    {
        _vetContext.Add(entity);
    }

    public void Update(T entity)
    {
        _vetContext.Update(entity);
    }

    public void Delete(T entity)
    {
        _vetContext.Remove(entity);
    }

    public List<T> GetListAll()
    {
        return _vetContext.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _vetContext.Set<T>().Find(id);
    }
}