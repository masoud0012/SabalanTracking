using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SabalanTracking.Models
{
    public class Person:BaseModel
    {
        
        [Required]
        [StringLength(300)]
        public string Name { get; set; } = "";

        [Phone]
        public string? Phone { get; set; } = "";

        [EmailAddress]
        public string? Email { get; set; }= "";
        public string? Address { get; set; } = "";
        [JsonIgnore]
        public virtual ICollection<Proces> Processs { get; set; } = new List<Proces>();


    }
}
