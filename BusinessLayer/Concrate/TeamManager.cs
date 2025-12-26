using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class TeamManager : ITeamService
{
    private readonly ITeamDal _teamDal;
    private readonly IUowDal _uowDal;

    public TeamManager(ITeamDal teamDal, IUowDal uowDal)
    {
        _teamDal = teamDal;
        _uowDal = uowDal;
    }
    
    public void TAdd(Team entity)
    {
        _teamDal.Add(entity);
        _uowDal.Save();
    }

    public void TUpdate(Team entity)
    {
        _teamDal.Update(entity);
        _uowDal.Save();
    }

    public void TDelete(Team entity)
    {
        _teamDal.Delete(entity);
        _uowDal.Save();
    }

    public List<Team> TGetListAll()
    {
        return _teamDal.GetListAll();
    }

    public Team TGetById(int id)
    {
        return _teamDal.GetById(id);
    }
}