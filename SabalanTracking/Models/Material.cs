
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SabalanTracking.Models
{
    public class Material :BaseModel
    {
       
        [Required]
        [ForeignKey("ProductCat")]
        public int CatId { get; set; }
        
        public int? UnitId { get; set; }
        [Required]
        [StringLength(300)]
        public string Name { get; set; } = "";
        public virtual ProductCat ProductCat { get; set; }
        [JsonIgnore]
        public virtual ICollection<Proces> Processs { get; set; } = new List<Proces>();

    }
}
