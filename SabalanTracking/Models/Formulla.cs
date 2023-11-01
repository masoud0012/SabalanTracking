using SabalanTracking.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SabalanTracking.Models
{
    public class Formulla : BaseModel
    {
        public string Name { get; set; }

        [ForeignKey(nameof(Material))]
        public int ProductId { get; set; }
        public Material Material { get; set; }
        public virtual List<FormullaDetails>? formullaDetails { get; set; } = new List<FormullaDetails>();
    }
}
