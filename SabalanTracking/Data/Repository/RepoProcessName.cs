using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoProcessName : RepositoryGeneric<ProcessName>,IRepoProcessName
    {
        public RepoProcessName(TrackingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
