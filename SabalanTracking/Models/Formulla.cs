using SabalanTracking.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SabalanTracking.Models
{
    public class Formulla : BaseModel
    {
        public string Name { get; set; }

        [ForeignKey(nameof(Material))]
        public int ProductId { get; set; }
        public Material Material { get; set; }
        [JsonIgnore]
        public virtual List<FormullaDetails>? formullaDetails { get; set; } = new List<FormullaDetails>();
    }
}
