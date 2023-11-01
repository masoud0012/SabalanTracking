using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public abstract class RepositoryGeneric<TModel> : IRepoGeneric<TModel>
        where TModel : BaseModel
    {
        private TrackingDbContext _db;
        private DbSet<TModel> _dbSet;
        public RepositoryGeneric(TrackingDbContext dbContext)
        {
            _db = dbContext;
            _dbSet = _db.Set<TModel>();
        }

        public async Task<TModel> Add(TModel obj)
        {
            await _dbSet.AddAsync(obj);
            return obj;
        }

        public Task<bool> Delete(TModel obj)
        {
            _dbSet.Remove(obj);
            return Task.FromResult(true);
        }

        public async Task<IQueryable<TModel>> GetAllAsync(int start = 0, int length = 50)
        {
            var data = _dbSet.OrderBy(t => t.Id).AsQueryable();
            return data;
        }

        public async Task<IQueryable<TModel?>> GetById(int id)
        {
            return _dbSet.Where(t => t.Id == id).AsQueryable();
        }

        public Task<TModel?> Update(TModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
