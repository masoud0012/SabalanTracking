using System.ComponentModel.DataAnnotations;

namespace SabalanTracking.Models
{
    public class ProcessName:BaseModel
    {
        
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = "";
    }
}
