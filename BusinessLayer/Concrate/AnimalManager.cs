using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class AnimalManager : IAnimalService
{
    private readonly IAnimalDal _animalDal;
    private readonly UowDal _uowDal;
    public AnimalManager(IAnimalDal animalDal, UowDal uowDal)
    {
        _animalDal = animalDal;
        _uowDal = uowDal;
    }
    public void TAdd(Animal entity)
    {
        _animalDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(Animal entity)
    {
        _animalDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(Animal entity)
    {
        _animalDal.Delete(entity);
        _uowDal.Save();
    }

    public List<Animal> TGetListAll()
    {
        return _animalDal.GetListAll();
    }

    public Animal TGetById(int id)
    {
        return _animalDal.GetById(id);
    }
}