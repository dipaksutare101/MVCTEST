using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCTEST.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConfirmPassword { get; set; }
    }

    public class UserMetadata
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="First Name is Required")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings =false ,ErrorMessage ="Last Name is Required")]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings =false ,ErrorMessage ="Email is Required")]
        [Display(Name="Email")]
        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(ConvertEmptyStringToNull =true , DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "DateofBirth is Required")]
        public DateTime DateofBirth { get; set; }

        [Display(Name="Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Minimum Length 6 Charater Required")]
        public string Password { get; set; }

        [Display(Name ="Confirm Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Comfirm Password is Required")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage="Confirm Password and Password Must be Match")]
        public string ConfirmPassword { get; set; }

        public bool IsEmailVarified { get; set; }

        public Guid ActivationCode { get; set; }
    }
}