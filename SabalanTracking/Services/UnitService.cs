using SabalanTracking.Data.Repository;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class UnitService : IUnit
    {
        private readonly IRepoUnit _repo;
        public UnitService(IRepoUnit repo)
        {
            _repo=repo;
        }
        public async Task<Unit> Create(Unit model)
        {
            await _repo.Add(model);
            return model;
        }

        public async Task<bool> delete(int Id)
        {
            var model= (await _repo.GetById(Id)).FirstOrDefault();
            await _repo.Delete(model);
            return true;
        }

        public async Task<List<Unit>> GetAllAsync()
        {
            var list = (await _repo.GetAllAsync()).ToList();
            return list;
        }

        public async Task<Unit> GetById(int Id)
        {
            var model=(await _repo.GetById(Id)).FirstOrDefault();
            return model;
        }

        public async Task<Unit> update(Unit model)
        {
            var mainModel =(await _repo.GetById(model.Id)).FirstOrDefault();
            mainModel.Name = model.Name;
            return model;
        }
    }
}
