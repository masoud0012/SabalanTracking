namespace SabalanTracking.Models.IRepository
{
    public interface IRepoFormulla:IRepoGeneric<Formulla>
    {
        public Task<Formulla?> GetByMaterialId(int id);
    }
}
