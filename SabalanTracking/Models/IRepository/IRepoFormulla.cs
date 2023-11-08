namespace SabalanTracking.Models.IRepository
{
    public interface IRepoFormulla:IRepoGeneric<Formulla>
    {
        public Task<List<Formulla>?> GetByMaterialId(int id);
    }
}
