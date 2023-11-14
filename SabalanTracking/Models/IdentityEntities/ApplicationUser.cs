using Microsoft.AspNetCore.Identity;

namespace SabalanTracking.Models.IdentityEntities
{
    public class ApplicationUser:IdentityUser<Guid>
    {
        public string PersonName { get; set; } = string.Empty;
        
    }
}
