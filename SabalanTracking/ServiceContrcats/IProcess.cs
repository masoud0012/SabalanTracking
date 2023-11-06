using SabalanTracking.Models;

namespace SabalanTracking.ServiceContrcats
{
    public interface IProcess:IGenerice<Proces>
    {
        public Task<List<Proces>> GetProcessByMateralId(int Id);
        public Task<List<Proces>> GetProcessByFormullaId(int Id);
        public Task<List<Proces>> GetProcessByMaterialName(string name);
        public Task<Proces> GetProcessBySN(string SN);
    }
}
