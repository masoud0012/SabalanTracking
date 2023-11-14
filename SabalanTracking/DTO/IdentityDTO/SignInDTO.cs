using System.ComponentModel.DataAnnotations;

namespace SabalanTracking.DTO.IdentityDTO
{
    public class SignInDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
