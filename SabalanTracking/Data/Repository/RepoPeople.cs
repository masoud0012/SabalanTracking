using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Data.Repository
{
    public class RepoPeople : RepositoryGeneric<Person>,IRepoPeople
    {
        public RepoPeople(TrackingDbContext dbContext) : base(dbContext)
        {
        }

       
    }
}
