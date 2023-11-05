using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class ProcessNameService : IProcessName
    {
        private readonly IRepoProcessName _repo;
        public ProcessNameService( IRepoProcessName repo)
        {
            _repo = repo;
        }

        public async Task<ProcessName> Create(ProcessName model)
        {
            _repo.Add(model);
            return model;
        }

        public async Task<bool> delete(int Id)
        {
            var model = (await _repo.GetById(Id)).FirstOrDefault();
            await _repo.Delete(model);
            return true;
        }

        public async Task<List<ProcessName>> GetAllAsync()
        {
            var list=(await _repo.GetAllAsync()).Include(t=>t.Processes).ToList();
            return list;
        }

        public async Task<ProcessName> GetById(int Id)
        {
            var model = (await _repo.GetById(Id)).Include(t=>t.Processes).FirstOrDefault();
            return model;
        }

        public async Task<ProcessName> update(ProcessName model)
        {
            var main = (await _repo.GetById(model.Id)).FirstOrDefault();
            main.Name = model.Name;
            main.Code = model.Code;
            return model;
        }
    }
}
