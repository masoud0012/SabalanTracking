using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SabalanTracking.Models
{
    public class ProductCat :BaseModel
    {
       
        [Required]
        [StringLength(200)]
        public string Category { get; set; } = "";

        public virtual List<Material> Materials { get; set; } = new List<Material>();
    }
}
