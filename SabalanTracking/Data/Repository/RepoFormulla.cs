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

        public async Task<List<Formulla>?> GetByMaterialId(int id)
        {
            var model=await _dbset
                .Include(t=>t.formullaDetails)
                .Where(t=>t.ProductId==id).ToListAsync();
            return model;
        }
    }
}
