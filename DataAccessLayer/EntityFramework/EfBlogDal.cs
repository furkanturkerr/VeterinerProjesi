using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfBlogDal : GenericRepository<Blog>, IBlogDal
{
    public EfBlogDal(VetContext vetContext) : base(vetContext)
    {
    }
}