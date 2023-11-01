namespace SabalanTracking.Models.IRepository
{
    public interface IRepoFormullaDetails:IRepoGeneric<FormullaDetails>
    {
        Task<List<FormullaDetails>> GetByFormullId(int Id);
        Task<List<FormullaDetails>> GetFormullaDetailsByMaterialId(int Id);
    }
}
