using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repository;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework;

public class EfTreatmentDal : GenericRepository<Treatment>, ITreatmentDal
{
    private readonly VetContext _context;
    public EfTreatmentDal(VetContext vetContext) : base(vetContext)
    {
        _context = vetContext;
    }

    public List<Treatment> GetTreatmentsWithDetails()
    {
        return _context.Treatments.Include(x => x.Appointment).ThenInclude(x => x.Animal).ToList();
    }
}