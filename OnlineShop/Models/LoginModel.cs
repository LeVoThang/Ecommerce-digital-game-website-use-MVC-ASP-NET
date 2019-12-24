using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "User name")]
        [Required(ErrorMessage = "Please type your User name")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Please type your password")]
        [Display(Name = "Password")]
        public string Password { set; get; }

    }
}