
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SabalanTracking.Models
{
    public class Material : BaseModel
    {

        [Required]
        [ForeignKey("ProductCat")]
        public int CatId { get; set; }
        public virtual ProductCat ProductCat { get; set; }

        public string MaterialCode { get; set; } = "PR00.0000";

        [ForeignKey(nameof(Unit))]
        public int? UnitId { get; set; }
        public Unit? Unit { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; } = "";
        [JsonIgnore]
        public virtual List<Proces> Processs { get; set; } = new List<Proces>();

    }
}
