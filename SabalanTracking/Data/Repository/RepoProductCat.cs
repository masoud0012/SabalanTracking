using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoProductCat : RepositoryGeneric<ProductCat>,IRepoProductCat
    {
        public RepoProductCat(TrackingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
