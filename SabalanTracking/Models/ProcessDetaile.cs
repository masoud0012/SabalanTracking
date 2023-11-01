using SabalanTracking.DTO;
using SabalanTracking.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SabalanTracking.Models
{
    public class ProcessDetaile:BaseModel
    {
        public ProcessDetaile()
        {

        }
      
        [Required]
        [ForeignKey("Proces")]
        public int ProcessId { get; set; }

        public virtual Proces Process { get; private set; }

        [Required]
        public string Product_SN { get; set; }
        [Required]
        public double QntyPerPc { get; set; } = 0;
        public string? Desciption { get; set; } = string.Empty;
    }
}