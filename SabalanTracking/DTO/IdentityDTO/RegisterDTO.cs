using SabalanTracking.Models.IdentityEntities;
using System.ComponentModel.DataAnnotations;

namespace SabalanTracking.DTO.IdentityDTO
{
    public class RegisterDTO
    {
        [Required]
        public string PersonName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } 

        public ApplicationUser ToApplicationUser()
        {
            return new ApplicationUser()
            {
                UserName = this.Email,
                Email=this.Email,
                PhoneNumber = this.PhoneNumber,
                PersonName = this.PersonName,
            };
        }
   
    }
    
}

