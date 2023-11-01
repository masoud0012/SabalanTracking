
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SabalanTracking.Models
{
    public class Device:BaseModel
    {
        
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = "";
        public string? DeviceSN { get; set; } = "SN";

        public string? Description { get; set; } = "";

        [JsonIgnore]
        public virtual List<Proces> Processs { get; set; } = new List<Proces>();
    }
}
