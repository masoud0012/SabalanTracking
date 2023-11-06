using System.ComponentModel.DataAnnotations;

namespace SabalanTracking.Models
{
    public class ProcessName : BaseModel
    {

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = "";
        public string Code { get; set; } = "F";

        public virtual List<Proces> Processes { get; set; } = new List<Proces>();
    }
}
