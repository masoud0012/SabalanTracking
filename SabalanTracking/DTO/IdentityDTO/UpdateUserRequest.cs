using SabalanTracking.Models.IdentityEntities;
using System.ComponentModel.DataAnnotations;

namespace SabalanTracking.DTO.IdentityDTO
{
    public class UpdateUserRequest
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string PersonName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<UserRoleViewModel>? roles { get; set; }
    }
    public static class UpdateUserExtesuion
    {
        public static UpdateUserRequest ToUpdateUserReqest(this ApplicationUser user)
        {
            return new UpdateUserRequest()
            {
                Id = user.Id,
                PersonName = user.PersonName,
                Email = user.Email,
                PhoneNumber = user.PersonName,
            };
        }
    }
}
