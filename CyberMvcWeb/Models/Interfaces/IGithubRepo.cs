using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMvcWeb.Models.Interfaces
{
    interface IGithubRepo
    {
        string Name { get; set; }
        string Description { get; set; }
        string RepoLink { get; set; }
        int StargazersCount { get; set; }
    }
}
