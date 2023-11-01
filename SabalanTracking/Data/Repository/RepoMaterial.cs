using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoMaterial : RepositoryGeneric<Material>,IRepoMaterial
    {
        public RepoMaterial(TrackingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
