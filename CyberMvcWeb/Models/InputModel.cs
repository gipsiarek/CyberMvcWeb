using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CyberMvcWeb.Models
{
    public class InputModel
    {
        [Required]
        public string GithubUsername { get; set; }

        [DisplayFormat(NullDisplayText = "")]
        public string ErrorMessage { get; set; }

    }
}