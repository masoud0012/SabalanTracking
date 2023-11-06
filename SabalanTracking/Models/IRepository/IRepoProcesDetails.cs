namespace SabalanTracking.Models.IRepository
{
    public interface IRepoProcesDetails:IRepoGeneric<ProcessDetaile>
    {
        Task<IQueryable<ProcessDetaile?>> GetByProcessId(int id);
        Task<List<ProcessDetaile>?> GetDetailsBySN(string SN);

    }
}
