using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoUnit : RepositoryGeneric<Unit>, IRepoUnit
    {
        public RepoUnit(TrackingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
