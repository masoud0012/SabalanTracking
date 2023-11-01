using Microsoft.EntityFrameworkCore;
using SabalanTracking.Data;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class FormullaDetailsService : IFormullaDetails
    {
        private readonly IRepoFormullaDetails _repo;
        public FormullaDetailsService(IRepoFormullaDetails repo)
        {
            _repo=repo;
        }
        public Task<FormullaDetails> Create(FormullaDetails model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FormullaDetails>> GetAllAsync()
        {
            var list=(await _repo.GetAllAsync()).ToList();
            return list;
        }

        public async Task<FormullaDetails> GetById(int Id)
        {
            var detail = (await _repo.GetById(Id)).FirstOrDefault();
            return detail;
        }
        public async Task<List<FormullaDetails>> GetByFormullId(int Id)
        {
            var detail = await _repo.GetByFormullId(Id);
            return detail;
        }
        public async Task<List<FormullaDetails>> GetFormullaDetailsByMaterialId(int Id)
        {
            var list = await _repo.GetFormullaDetailsByMaterialId(Id);
            return list;
        }

        public Task<FormullaDetails> update(FormullaDetails model)
        {
            throw new NotImplementedException();
        }
    }
}
