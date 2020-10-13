using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace User_Reqistration.Models
{
    public class Profile
    {
        [Required(ErrorMessage = "Enter FirstName !")]
        [Display(Name = "Enter FirstName :")]
        public string FirstName
        {
            get; set;
        }
        [Required(ErrorMessage = "Enter DOB !")]
        [Display(Name = "Enter DOB :")]
        public string DOB
        {
            get; set;
        }
        [Required(ErrorMessage = "Upload Profile Image !")]
        [Display(Name = "Profile Image :")]
        public string ProfilePicture
        {
            get; set;
        }
    }
}