using System.ComponentModel.DataAnnotations;

namespace SabalanTracking.Models
{
    public class Unit : BaseModel
    {
        [Required]
        public string Name { get; set; }
    }
}
