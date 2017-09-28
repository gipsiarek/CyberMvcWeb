using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CyberMvcWeb.Models.Interfaces;
using Newtonsoft.Json;

namespace CyberMvcWeb.Models
{
    
    public class GithubUserModel : IGithubUser
    {
        public GithubUserModel()
        {
            Repositories = new List<GithubRepoModel>();
        }
        [DisplayName("Avatar")]
        [DisplayFormat(NullDisplayText = "")]
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [DisplayName("Location")]
        [DisplayFormat(NullDisplayText = "-")]
        [JsonProperty("location")]
        public string Location { get; set; }

        [DisplayName("Login")]
        [DisplayFormat(NullDisplayText = "")]
        [JsonProperty("login")]
        public string Login { get; set; }

        [DisplayName("User Name")]
        [DisplayFormat(NullDisplayText = "")]
        [JsonProperty("name")]
        public string UserName { get; set; }

        public List<GithubRepoModel> Repositories { get; set; }
    }
}