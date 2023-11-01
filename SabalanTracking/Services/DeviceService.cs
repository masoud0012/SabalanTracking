using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class DeviceService : IDevice
    {
        private readonly IRepoDevice _repo;
        public DeviceService(IRepoDevice repo)
        {
            _repo = repo;
        }
        public async Task<Device> Create(Device model)
        {
            await _repo.Add(model);
            return model;
        }

        public async Task<bool> delete(int Id)
        {
            var device = (await _repo.GetById(Id)).SingleOrDefault();
           await _repo.Delete(device);
            return true;
        }

        public async Task<List<Device>> GetAllAsync()
        {
            var list = (await _repo.GetAllAsync()).ToList();
            return list;
        }

        public async Task<Device> GetById(int Id)
        {
            var model =(await _repo.GetById(Id)).FirstOrDefault();
            return model;
        }

        public async Task<Device> update(Device model)
        {
            var device =await _repo.Update(model);
            return device;
        }
    }
}
