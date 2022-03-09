using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace UserRegistrationMVCcore.Models
{
    public class UserClass
    {
        [Key]
        public int UserId {get; set;}
        [Required(ErrorMessage ="Please enter the username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter the password")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Pwd { get; set; }
        [Required(ErrorMessage = "Please enter the confirm password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Pwd")]
        public string Confirmpwd { get; set; }
        [Required(ErrorMessage = "Please enter the email")]
        public string Uemail { get; set; }
        [Required(ErrorMessage = "Please enter gender")]
        public string Gender { get; set; }
    }
}
