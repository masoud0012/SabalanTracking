using System.ComponentModel.DataAnnotations;

namespace SabalanTracking.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
