using Microsoft.AspNetCore.Mvc.Rendering;

namespace SabalanTracking.DTO.IdentityDTO
{
    public class UserRoleViewModel
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public List<string>? Roles { get; set; }
        public List<SelectListItem>? AvailableRoles { get; set; }
    }
}
