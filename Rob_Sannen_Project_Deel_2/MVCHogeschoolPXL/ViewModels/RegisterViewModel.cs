using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCHogeschoolPXL.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }

        [Display(Name = "Wachtwoord")]
        [Required]
         public string Password { get; set; }

        [Display(Name = "Herhaal wachtwoord")]
        [Required]
        [Compare("Password", ErrorMessage ="Paswoord moet overeenkomen!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Rol")]
        [Required]
        public string RoleId { get; set; }
    }
}
