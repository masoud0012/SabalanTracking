using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class ProductCategoryService : IProductCategory
    {
        private readonly IRepoProductCat _repo;
        private readonly IUnitOfWork _unitOfWork;
        public ProductCategoryService(IUnitOfWork unitOfWork, IRepoProductCat repo)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;

        }
        public async Task<ProductCat> Create(ProductCat model)
        {
            await _repo.Add(model);
            await _unitOfWork.SaveChanges();
            return model;
        }

        public async Task<bool> delete(int Id)
        {
            var model = (await _repo.GetById(Id)).FirstOrDefault();
            await _repo.Delete(model);
            return true;
        }

        public async Task<List<ProductCat>> GetAllAsync()
        {
            var list=(await _repo.GetAllAsync()).ToList();
            return list;
        }

        public async Task<ProductCat> GetById(int Id)
        {
            var model = (await _repo.GetById(Id)).FirstOrDefault();
            return model;
        }

        public async Task<ProductCat> update(ProductCat model)
        {
            var mainModel = (await _repo.GetById(model.Id)).FirstOrDefault();
            mainModel.Category = model.Category;
            return model;
        }
    }
}
