using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoProcessDetails : RepositoryGeneric<ProcessDetaile>, IRepoProcesDetails
    {
        private readonly TrackingDbContext _db;
        private readonly DbSet<ProcessDetaile> _dbSet;
        public RepoProcessDetails(TrackingDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
            _dbSet = dbContext.Set<ProcessDetaile>();
        }

        public async Task<IQueryable<ProcessDetaile?>> GetByProcessId(int id)
        {
            var detail = _dbSet.Where(t => t.ProcessId == id).AsQueryable();
            return detail;
        }

        public async Task<ProcessDetaile?> GetDetailsBySN(string SN)
        {
            var detail =await _dbSet.Where(t => t.Product_SN == SN).FirstOrDefaultAsync();
            return detail;
        }
    }
}
