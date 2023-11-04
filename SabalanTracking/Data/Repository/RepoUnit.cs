using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoUnit : RepositoryGeneric<Unit>, IRepoUnit
    {
        private readonly DbSet<Unit> _unitSet;
        public RepoUnit(TrackingDbContext dbContext) : base(dbContext)
        {
            _unitSet=dbContext.Set<Unit>();
        }
    }
}
