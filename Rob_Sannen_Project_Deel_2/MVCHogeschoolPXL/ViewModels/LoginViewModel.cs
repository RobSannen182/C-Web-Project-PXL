using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCHogeschoolPXL.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }
        
        [Display(Name = "Wachtwoord")]
        [Required]
        public string Password { get; set; }

    }
}
