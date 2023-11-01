using Microsoft.EntityFrameworkCore;
using SabalanTracking.Data;
using SabalanTracking.Models;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class FormullaService : IFormulla
    {
        public TrackingDbContext _db;
        public FormullaService(TrackingDbContext db)
        {
            _db = db;
        }
        public async Task<Formulla> Create(Formulla model)
        {
            await _db.Formulas.AddAsync(model);
            await _db.SaveChangesAsync();
            return model;
        }

        public async Task<bool> delete(int Id)
        {
            Formulla formulla =await _db.Formulas.FirstOrDefaultAsync(t => t.Id == Id);
            _db.Formulas.Remove(formulla);
            _db.SaveChanges();
            return true;
        }
         public async Task<List<Formulla>> GetAllAsync()
        {
            var list = await _db.Formulas.Include(t=>t.Material).ToListAsync();
            return list;
        }
        public async Task<Formulla> GetById(int id)
        {
            return await _db.Formulas.FirstOrDefaultAsync(t => t.Id == id);
        }
        public Task<Formulla> update(Formulla model)
        {
            throw new NotImplementedException();
        }
    }
}
