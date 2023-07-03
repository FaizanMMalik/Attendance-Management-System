using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proj2mvc.Models
{
    public class Login1
    {
        [Display(Name = "Username")]
        [Required]
        public string username { get; set; }
        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}