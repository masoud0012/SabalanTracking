using SabalanTracking.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SabalanTracking.DTO
{
    public class ProcessDetailsResponse
    {
        public ProcessDetaile detaile { get; set; }
        public Proces proces {  get; set; }
        public double Consumed { get; set; } = 0;
    }
}
