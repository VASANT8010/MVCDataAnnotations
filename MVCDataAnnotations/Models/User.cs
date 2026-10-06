using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace MVCDataAnnotations.Models
{
    public class User
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is required.")]
        [RegularExpression(@"[A-Za-z\s]{3,}", ErrorMessage = "Name must contain only alphabets and spaces, and be at least 3 characters long.")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "password is requeired.")]
        [RegularExpression(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).{8,}", ErrorMessage = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirmed password is required.")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is required.")]
        [System.Web.Mvc.Remote("isValidDate", "User", ErrorMessage = "Invalid date.")]
        public DateTime DOB { get; set; }

        public string Mobile { get; set; }
        [Display(Name = "Email Id")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "User Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }





}

