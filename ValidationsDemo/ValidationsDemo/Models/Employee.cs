using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationsDemo.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="First Name is required.")]
        [RegularExpression("[A-Za-z]+",ErrorMessage ="Only alphabets.!")]
        [Display(Name ="First Name")]
        public string fname { get; set; }

        [Required]
        [RegularExpression("[0-9]+", ErrorMessage = "Only numbers.!")]
        public int salary { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email.!")]
        public string email { get; set; }

        [Required]
        [RegularExpression(@"[9876]\d{9}", ErrorMessage = "Invalid Mobile no.")]
        public string mobile { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[a-zA-Z!#$%&? ])[a-zA-Z0-9!#$%&?]{8,20}", ErrorMessage = "weak password.!")]
        public string password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Passwords mismatch.")]
        public string cnfpassword { get; set; }
    }
}