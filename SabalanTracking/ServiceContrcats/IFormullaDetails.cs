using SabalanTracking.Models;

namespace SabalanTracking.ServiceContrcats
{
    public interface IFormullaDetails:IGenerice<FormullaDetails>
    {
        public Task<List<FormullaDetails>> GetFormullaDetailsByMaterialId(int Id);
        public Task<List<FormullaDetails>> GetByFormullId(int Id);

        Task<double> GetQuantityByFormullIdAndMaterialId(int formullId, int MaterialId);


    }
}
