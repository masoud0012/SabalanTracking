using SabalanTracking.Data;
using SabalanTracking.Models;

namespace SabalanTracking.Helper
{
    public class GetProcessDetails
    {
        private readonly TrackingDbContext _db;
        public GetProcessDetails(TrackingDbContext db)
        {
            _db=db;
        }
        public List<ProcessDetaile> GetDetailsBySN(string SN)
        {
            List<ProcessDetaile> list = _db.ProcessDetails.Where(t =>
            t.Product_SN == SN).ToList();
            return list;
        }
    }
}
