using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace CyberMvcWeb.Models
{
    public class SummaryInfoModel
    {
        public SummaryInfoModel()
        {
            User = new GithubUserModel();
        }

 
        public GithubUserModel User { get; set; }
    }
}