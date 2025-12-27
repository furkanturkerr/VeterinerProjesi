using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class BlogManager : IBlogService
{
    private readonly IBlogDal _blogDal;
    private readonly IUowDal _uowDal;

    public BlogManager(IBlogDal blogDal, IUowDal uowDal)
    {
        _blogDal = blogDal;
        _uowDal = uowDal;
    }
    
    public void TAdd(Blog entity)
    {
        _blogDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(Blog entity)
    {
        _blogDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(Blog entity)
    {
        _blogDal.Delete(entity);
        _uowDal.Save();
    }

    public List<Blog> TGetListAll()
    {
        return _blogDal.GetListAll();
    }

    public Blog TGetById(int id)
    {
        return _blogDal.GetById(id);
    }
}