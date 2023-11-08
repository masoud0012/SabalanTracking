using SabalanTracking.Models;

namespace SabalanTracking.ServiceContrcats
{
    public interface IFormulla:IGenerice<Formulla>
    {
      public Task<List<Formulla>?> GetByMaterialID(int id);
    }
}
