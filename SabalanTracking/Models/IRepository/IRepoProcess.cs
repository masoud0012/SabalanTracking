namespace SabalanTracking.Models.IRepository
{
    public interface IRepoProcess:IRepoGeneric<Proces>
    {
        public Task<IQueryable<Proces>> GetProcessByMaterialName(string name);
        public Task<IQueryable<Proces>> GetProcessByMaterialId(int Id);
        public Task<Proces> GetProcessBySN(string SN);
    }
}
