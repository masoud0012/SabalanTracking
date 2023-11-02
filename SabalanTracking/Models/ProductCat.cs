using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SabalanTracking.Models
{
    public class ProductCat : BaseModel
    {

        [Required]
        [StringLength(200)]
        public string Category { get; set; } = "";

        [JsonIgnore]
        public virtual List<Material> Materials { get; set; } = new List<Material>();
    }
}
