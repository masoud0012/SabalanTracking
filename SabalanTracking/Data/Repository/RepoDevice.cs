using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoDevice : RepositoryGeneric<Device>,IRepoDevice
    {
        public RepoDevice(TrackingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
