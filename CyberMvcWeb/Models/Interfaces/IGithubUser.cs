using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMvcWeb.Models.Interfaces
{
    interface IGithubUser
    {
        string AvatarUrl { get; set; }
        string Location { get; set; }
        string Login { get; set; }
        string UserName { get; set; }
    }
}
