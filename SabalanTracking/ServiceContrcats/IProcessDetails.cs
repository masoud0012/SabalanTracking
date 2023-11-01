using SabalanTracking.Models;

namespace SabalanTracking.ServiceContrcats
{
    public interface IProcessDetails:IGenerice<ProcessDetaile>
    {
        public Task<ProcessDetaile> GetDetailsBySN(string SN);
        public Task<List<ProcessDetaile>> GetDetailsByProcessId(int id);
    }
}
