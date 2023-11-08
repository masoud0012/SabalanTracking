using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SabalanTracking.Models
{
    public class ProductCat : BaseModel
    {

        [Required]
        [StringLength(200)]
        public string Category { get; set; } = "";

        public string CategoryCode { get; set; } = "C00.0000";
        public string Symbol { get; set; } = "S";

        [JsonIgnore]
        public virtual List<Material> Materials { get; set; } = new List<Material>();
    }
}
