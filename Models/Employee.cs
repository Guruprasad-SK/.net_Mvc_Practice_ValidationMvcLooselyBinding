using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationInMvc.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please Enter your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter your last name")]
        public string LasttName { get; set; }
        [Required(ErrorMessage = "Please Enter your Email")]
        [EmailAddress]
        public string  Email{ get; set; }
        [Required(ErrorMessage = "Please Enter your Age")]
        [Range(0,100)]
        public int Age { get; set; }
    }
}