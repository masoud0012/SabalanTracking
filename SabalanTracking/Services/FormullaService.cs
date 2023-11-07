using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class FormullaService : IFormulla
    {
        private readonly IRepoFormulla _service;
        private readonly IUnitOfWork _unitOfWork;
        public FormullaService(IRepoFormulla service, IUnitOfWork unitOfWork)
        {
            _service = service;
            _unitOfWork = unitOfWork;
        }
        public async Task<Formulla> Create(Formulla model)
        {
            await _service.Add(model);
            await _unitOfWork.SaveChanges();
            return model;
        }

        public async Task<bool> delete(int Id)
        {
            var model = (await _service.GetById(Id)).FirstOrDefault();
            await _service.Delete(model);
            await _unitOfWork.SaveChanges();
            return true;
        }
        public async Task<List<Formulla>> GetAllAsync()
        {
            var list = (await _service.GetAllAsync())
                .Include(t => t.Material)
                .ToList();
            return list;
        }
        public async Task<Formulla> GetById(int id)
        {
            var model= (await _service.GetById(id))
                .Include(t=>t.Material)
                .FirstOrDefault();
            return model;
        }

        public async Task<Formulla?> GetByMaterialID(int id)
        {
            var model = await _service.GetByMaterialId(id);
            return model;
        }

        public async Task<Formulla> update(Formulla model)
        {
            var formulla =(await _service.GetById(model.Id))
                .Include(t=>t.formullaDetails).FirstOrDefault();
            return model;
                }
    }
}
