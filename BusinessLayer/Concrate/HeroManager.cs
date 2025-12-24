using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class HeroManager : IHeroService
{
    private readonly IHeroDal _heroDal;
    private readonly IUowDal _uowDal;

    public HeroManager(IHeroDal heroDal, IUowDal uowDal)
    {
        _heroDal = heroDal;
        _uowDal = uowDal;
    }
    
    public void TAdd(Hero entity)
    {
        _heroDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(Hero entity)
    {
        _heroDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(Hero entity)
    {
        _heroDal.Delete(entity);
        _uowDal.Save();
    }

    public List<Hero> TGetListAll()
    {
        return _heroDal.GetListAll();
    }

    public Hero TGetById(int id)
    {
        return _heroDal.GetById(id);
    }
}