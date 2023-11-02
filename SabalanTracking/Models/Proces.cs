using SabalanTracking.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SabalanTracking.Models
{
    public class Proces:BaseModel

    {
       
        [Required]
        [ForeignKey("ProcessName")]
        public int ProcessNameId { get; set; }
        public virtual ProcessName? ProcessName { get; private set; }


        [Required]
        [ForeignKey("Device")]
        public int DeviceId { get; set; }
        public virtual Device? Device { get; private set; }


        [Required]
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person? Person { get; private set; }


        [Required]
        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        public virtual Material? Material { get; private set; }


        [Required]
        public double Quantity { get; set; }
        [Required]
        public string DateTime { get; set; } = "2023/10/25";
        [Required]
        public string SN { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        [JsonIgnore]
        public virtual List<ProcessDetaile>? ProcessDetails { get; set; }=new List<ProcessDetaile>();
    }
    public static class DetailsExtension
    {
        public static ProcessDetailsResponse ToDetailsResponse(
            this Proces proces, ProcessDetaile details,double totalQty)
        {
            return new ProcessDetailsResponse()
            {
             
                Consumed = totalQty * details.QntyPerPc,
                proces=proces,
                detaile=details
            };
        }
    }

}
