using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener2.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User Name is required")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [UIHint("Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}