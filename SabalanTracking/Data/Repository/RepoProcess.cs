using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoProcess : RepositoryGeneric<Proces>,IRepoProcess
    {
        public RepoProcess(TrackingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
