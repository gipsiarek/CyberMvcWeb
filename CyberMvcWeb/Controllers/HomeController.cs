using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CyberMvcWeb.Models;
using Newtonsoft.Json;


namespace CyberMvcWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            InputModel model = new InputModel();
            return View("Index", model);
        }

        public ActionResult Summary()
        {
            ViewBag.Message = "Your summary page.";

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Subscribe(InputModel model)
        {
            var summary = new SummaryInfoModel();
            if (ModelState.IsValid)
            {
                try
                {
                    summary.User = await GetUser(model.GithubUsername);
                    var repos = await GetRepositories($"{model.GithubUsername}/repos");
                    summary.User.Repositories = repos.OrderByDescending(x => x.StargazersCount).Take(5).ToList();
                    return View("Summary", summary);
                }
                catch (Exception ex)
                {
                    model.ErrorMessage = ex.Message;
                    return View("Index", model);
                }
            }

            return View("Summary", model);
        }

        private async Task<List<GithubRepoModel>> GetRepositories(string v)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "-");
                    return JsonConvert.DeserializeObject<List<GithubRepoModel>>(
                        await client.GetStringAsync($"{Properties.Settings.Default.UsersApiAdress}{v}"));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Repository {v} not found. {ex.Message}");
            }
        }

        public async Task<GithubUserModel> GetUser(string username)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "-");
                    return JsonConvert.DeserializeObject<GithubUserModel>(
                        await client.GetStringAsync($"{Properties.Settings.Default.UsersApiAdress}{username}"));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"User '{username}' not found. {ex.Message}");
            }
        }
    }
}