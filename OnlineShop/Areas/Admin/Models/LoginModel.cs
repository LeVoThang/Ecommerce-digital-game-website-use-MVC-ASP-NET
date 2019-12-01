using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel

    {
        [Required(ErrorMessage = "Please type your User name")]
        public string Username { set; get; }

        [Required(ErrorMessage = "Please type your password")]
        public string Password { set; get; }

        public bool RememberMe { set; get; }
    }
}