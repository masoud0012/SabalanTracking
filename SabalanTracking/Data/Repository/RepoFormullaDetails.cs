using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoFormullaDetails : RepositoryGeneric<FormullaDetails>,IRepoFormullaDetails
    {
        private readonly DbSet<FormullaDetails> _dbSet;
        private readonly TrackingDbContext _context;
        public RepoFormullaDetails(TrackingDbContext dbContext) : base(dbContext)
        {
            _dbSet=dbContext.Set<FormullaDetails>();
            _context = dbContext;
        }

        public async Task<List<FormullaDetails>> GetByFormullId(int Id)
        {
            return await _dbSet
                .Include(t => t.Material)
                .Include(t => t.Formula)
                .Include(t => t.Formula)
                .Include(t=>t.Material.Unit)
                .Where(t => t.FormullaId == Id).ToListAsync();
        }

        public async Task<List<FormullaDetails>> GetFormullaDetailsByMaterialId(int Id)
        {
            var formulla = _context.Formulas.FirstOrDefault(t => t.ProductId == Id);
            return await _dbSet
            .Include(t => t.Material)
            .Include(t=>t.Material.Unit)
            .Include(t => t.Formula)
            .Where(t => t.FormullaId == formulla.Id).ToListAsync();
        }

        public async Task<double> GetQuantityByFormullIdAndMaterialId(int formullId, int materialId)
        {
            FormullaDetails? model = await _dbSet.FirstOrDefaultAsync(t =>
            t.FormullaId == formullId & t.MaterialId == materialId);

            return model.quantity;
        }
    }
}
