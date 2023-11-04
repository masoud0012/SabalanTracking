using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SabalanTracking.Models
{
    public class FormullaDetails:BaseModel
    {
       

        [ForeignKey(nameof(Formula))]
        public int FormullaId {  get; set; }
        public Formulla Formula { get; set; }


        [ForeignKey(nameof(Material))]
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public double quantity { get; set; } = 1;

    }
}
