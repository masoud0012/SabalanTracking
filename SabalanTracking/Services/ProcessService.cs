using Microsoft.EntityFrameworkCore;
using SabalanTracking.Data;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class ProcessService : IProcess
    {
        private readonly IRepoProcess _service;
        public ProcessService(IRepoProcess dbContext)
        {
            _service = dbContext;
        }

        public async Task<Proces> Create(Proces model)
        {
            await _service.Add(model);
            return model;
        }

        public async Task<bool> delete(int Id)
        {
            var model = (await _service.GetById(Id)).FirstOrDefault();
            await _service.Delete(model);
            return true;
        }

        public async Task<List<Proces>> GetAllAsync()
        {
            var list = (await _service.GetAllAsync()).
                Include(p => p.Material).Include(p => p.Device)
                          .Include(p => p.Material.Unit)
                          .Include(p => p.ProcessName)
                          .Include(p => p.Person).ToList();
            return list;
        }

        public async Task<Proces> GetById(int Id)
        {
            var proces = (await _service.GetById(Id))
                    .Include(p => p.Material).Include(p => p.Device)
                    .Include(p => p.ProcessName).Include(p => p.Person)
                    .Include(p => p.Material.Unit)
                    .FirstOrDefault(t => t.Id == Id);
            return proces;
        }

        public async Task<List<Proces>> GetProcessByMateralId(int Id)
        {
            List<Proces>? list = (await _service.GetProcessByMaterialId(Id))
                .Include(p => p.Material).Include(p => p.Device)
                          .Include(p => p.Material.Unit)
                          .Include(p => p.ProcessName).Include(p => p.Person).ToList();
            return list;
        }

        public Task<List<Proces>> GetProcessByMaterialName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Proces> GetProcessBySN(string SN)
        {
            var process =await _service.GetProcessBySN(SN);
            return process;
        }

        public Task<Proces> update(Proces model)
        {
            throw new NotImplementedException();
        }
    }
}
