using Microsoft.EntityFrameworkCore;
using SabalanTracking.Data;
using SabalanTracking.Models;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class ProcessService : IProcess
    {
        private readonly TrackingDbContext _dbContext;
        public ProcessService(TrackingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Proces> Create(Proces model)
        {
            await _dbContext.Processes.AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<bool> delete(int Id)
        {
            Proces proces = await _dbContext.Processes.FirstOrDefaultAsync(t => t.Id == Id);
            _dbContext.Processes.Remove(proces);
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<List<Proces>> GetAllAsync()
        {
            List<Proces> list = await _dbContext.Processes
                          .Include(p => p.Material).Include(p => p.Device)
                          .Include(p => p.ProcessName).Include(p => p.Person).ToListAsync();
            return list;
        }

        public async Task<Proces> GetById(int Id)
        {
            Proces? proces = await _dbContext.Processes
                    .Include(p => p.Material).Include(p => p.Device)
                    .Include(p => p.ProcessName).Include(p => p.Person)
                    .FirstOrDefaultAsync(t=>t.Id==Id);
            return proces;
        }

        public async Task<List<Proces>> GetProcessByMateralId(int Id)
        {
            List<Proces>? list = await _dbContext.Processes
                                     .Where(t => t.MaterialId == Id).ToListAsync();
            return list;
        }

        public Task<List<Proces>> GetProcessByMaterialName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Proces> GetProcessBySN(string SN)
        {
            var process = await _dbContext.Processes
                .Include(t => t.ProcessName)
                .Include(t => t.Device)
                .Include(t => t.Person)
                .Include(t => t.Material)
                .FirstOrDefaultAsync(t => t.SN == SN);
            return process;
        }

        public Task<Proces> update(Proces model)
        {
            throw new NotImplementedException();
        }
    }
}
