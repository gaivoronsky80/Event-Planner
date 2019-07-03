using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")] 
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")] 
        public string Password {get;set;}
    }
}