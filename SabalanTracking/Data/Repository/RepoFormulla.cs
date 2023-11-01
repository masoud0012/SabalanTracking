using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoFormulla : RepositoryGeneric<Formulla>,IRepoFormulla
    {
        public RepoFormulla(TrackingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
