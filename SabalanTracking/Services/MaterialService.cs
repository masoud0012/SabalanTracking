using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class MaterialService : IMaterial
    {
        private readonly IRepoMaterial _repo;
        public MaterialService(IRepoMaterial repo)
        {
            _repo = repo;
        }
        public async Task<Material> Create(Material model)
        {
            var material = await _repo.Add(model);
            return material;
        }

        public async Task<bool> delete(int Id)
        {
            var mat = (await _repo.GetById(Id)).FirstOrDefault();
            await _repo.Delete(mat);
            return true;
        }

        public async Task<List<Material>> GetAllAsync()
        {
            var list=(await _repo.GetAllAsync()).Include(t=>t.Processs).ToList();
            return list;
        }

        public async Task<Material> GetById(int Id)
        {
            var model=(await _repo.GetById(Id)).Include(t=>t.Processs).FirstOrDefault();
            return model;
        }

        public async Task<Material> update(Material model)
        {
            var main = (await _repo.GetById(model.Id)).FirstOrDefault();
            main.ProductCat = model.ProductCat;
            main.Name = model.Name;
            return model;
        }
    }
}
