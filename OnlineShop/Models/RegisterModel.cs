using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class RegisterModel
    {
        [Key]
        public long ID { set; get; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please type your User Name")]

        public string UserName { set; get; }

        [Display(Name = "Password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password length has at least 6 character")]
        [Required(ErrorMessage = "Please type your password")]
        public string Password { set; get; }

        [Display(Name = "Password verify")]
        [Compare("Password", ErrorMessage = "Password is not correct")]
        public string ConfirmPassword { set; get; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please type your Full Name")]
        public string Name { set; get; }

        [Display(Name = "Address")]
        public string Address { set; get; }

        [Required(ErrorMessage = "Please type your Email")]
        [Display(Name = "Email")]
        public string Email { set; get; }

        [Display(Name = "Phone number")]
        public string Phone { set; get; }

        [Display(Name = "Province")]
        public string ProvinceID { set; get; }


        [Display(Name = "District")]
        public string DistrictID { set; get; }
    }
}