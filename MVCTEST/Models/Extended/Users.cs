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

    }

    public class UserMetadata
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="First Name is Required")]
        [Display(Name ="First Name1")]
        public string FirstName { get; set; }
    }
}