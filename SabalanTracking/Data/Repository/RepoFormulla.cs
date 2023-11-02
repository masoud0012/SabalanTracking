using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoFormulla : RepositoryGeneric<Formulla>,IRepoFormulla
    {
        private DbSet<Formulla> _dbset;
        public RepoFormulla(TrackingDbContext dbContext) : base(dbContext)
        {
            _dbset=dbContext.Set<Formulla>();   
        }

        public async Task<Formulla> GetByMaterialId(int id)
        {
            Formulla model=await _dbset.FirstOrDefaultAsync(t=>t.ProductId==id);
            return model;
        }
    }
}
