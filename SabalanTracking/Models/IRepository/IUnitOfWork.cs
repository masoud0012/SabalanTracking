namespace SabalanTracking.Models.IRepository
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChanges();
        void IDisposable();

    }
}
