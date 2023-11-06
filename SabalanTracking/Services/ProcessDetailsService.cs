using Microsoft.EntityFrameworkCore;
using SabalanTracking.Data;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class ProcessDetailsService : IProcessDetails
    {
        public readonly IRepoProcesDetails _repo;
        public ProcessDetailsService(IRepoProcesDetails repo)
        {
            _repo = repo;
        }
        public Task<ProcessDetaile> Create(ProcessDetaile model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProcessDetaile>> GetAllAsync()
        {
            List<ProcessDetaile> list = (await _repo.GetAllAsync())
                .Include(t => t.Process)
                .ToList();
            return list;
        }

        public async Task<ProcessDetaile> GetById(int Id)
        {
            ProcessDetaile? details = (await _repo.GetById(Id)).FirstOrDefault();
            return details;
        }

        public async Task<List<ProcessDetaile>> GetDetailsByProcessId(int id)
        {
            List<ProcessDetaile> details = (await _repo.GetByProcessId(id))
                .Include(t => t.Process)
                .Include(t => t.Process.Person)
                .Include(t => t.Process.Device)
                .Include(t => t.Process.Material)
                .Include(t => t.Process.ProcessName)
                .Where(t => t.ProcessId == id).ToList();
            return details;
        }
        public async Task<List<ProcessDetaile>?> GetDetailsBySN(string SN)
        {
            var process = await _repo.GetDetailsBySN(SN);
            return process;
        }

        public Task<ProcessDetaile> update(ProcessDetaile model)
        {
            throw new NotImplementedException();
        }
    }
}
