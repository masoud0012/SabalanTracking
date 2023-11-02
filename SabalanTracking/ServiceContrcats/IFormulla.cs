using SabalanTracking.Models;

namespace SabalanTracking.ServiceContrcats
{
    public interface IFormulla:IGenerice<Formulla>
    {
      public Task<Formulla> GetByMaterialID(int id);
    }
}
