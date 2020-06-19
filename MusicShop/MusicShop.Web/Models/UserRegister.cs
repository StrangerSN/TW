using System.ComponentModel.DataAnnotations;

namespace MusicShop.Web.Models
{
    public class UserRegister
    {
        [Required]
        [Display(Name = "Username")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Username cannot be shorter than 4 characters.")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password cannot be shorter than 8 characters.")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [StringLength(30, ErrorMessage = "Too long email, maximum is 30 characters.")]
        public string Email { get; set; }
    }
}