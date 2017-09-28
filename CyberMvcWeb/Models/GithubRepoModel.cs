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
    public class GithubRepoModel : IGithubRepo
    {
        [DisplayName("Name")]
        [DisplayFormat(NullDisplayText = "")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [DisplayFormat(NullDisplayText = "")]
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [DisplayName("Repository link")]
        [DisplayFormat(NullDisplayText = "")]
        [JsonProperty("html_url")]
        public string RepoLink { get; set; }

        [DisplayName("Stargazers")]
        [DisplayFormat(NullDisplayText = "")]
        [JsonProperty("stargazers_count")]       
        public int StargazersCount { get; set; }
    }
}