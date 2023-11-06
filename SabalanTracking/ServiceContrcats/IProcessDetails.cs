using SabalanTracking.Models;

namespace SabalanTracking.ServiceContrcats
{
    public interface IProcessDetails:IGenerice<ProcessDetaile>
    {
        public Task<List<ProcessDetaile>> GetDetailsBySN(string SN);
        public Task<List<ProcessDetaile>> GetDetailsByProcessId(int id);
    }
}
