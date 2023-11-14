using SabalanTracking.Models.IdentityEntities;
using System.ComponentModel.DataAnnotations;

namespace SabalanTracking.DTO.IdentityDTO
{
    public class RoleDTO
    {
        [Required]
        public string Name { get; set; }
        public ApplicationRole ToRole()
        {
            return new ApplicationRole()
            {
                Id=Guid.NewGuid(),
                Name = Name,
            };
        }
    }
}
