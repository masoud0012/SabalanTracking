using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TrackingDbContext _trackingDbContext;
        public UnitOfWork(TrackingDbContext trackingDbContext)
        {

            _trackingDbContext = trackingDbContext;

        }
        public void IDisposable()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChanges()
        {
            try
            {
                await _trackingDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
