using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoProcess : RepositoryGeneric<Proces>, IRepoProcess
    {
        private readonly DbSet<Proces> _dbSet;
        public RepoProcess(TrackingDbContext dbContext) : base(dbContext)
        {
            _dbSet = dbContext.Set<Proces>();
        }

        public async Task<IQueryable<Proces>> GetProcessByMaterialId(int Id)
        {
            var list = _dbSet.Where(t => t.MaterialId == Id).AsQueryable();
            return list;
        }

        public async Task<IQueryable<Proces>> GetProcessByMaterialName(string name)
        {
            var list = _dbSet.Where(t => t.Material.Name == name).AsQueryable();
            return list;
        }

        public async Task<Proces> GetProcessBySN(string SN)
        {
            var model = await _dbSet.Include(p => p.Material).Include(p => p.Device)
                           .Include(p => p.Material.Unit)
                           .Include(p => p.ProcessName).Include(p => p.Person)
                           .Where(t => t.SN == SN).FirstOrDefaultAsync();
            return model;
        }
    }
}
