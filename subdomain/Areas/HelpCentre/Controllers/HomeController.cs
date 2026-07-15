using Microsoft.AspNetCore.Mvc;
using subdomain.Areas.HelpCentre.Models;
using subdomain.Areas.HelpCentre.ViewModels;

namespace subdomain.Areas.HelpCentre.Controllers
{
    [Area("HelpCentre")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new HelpCentreViewModel
            {
                Categories = new List<HelpCategory>
                {
                    new()
                    {
                        Title = "Buying",
                        Slug = "buying",
                        Controller = "Buying"
                    },
                    new()
                    {
                        Title = "Selling",
                        Slug = "selling",
                        Controller = "Selling"
                    },
                    new()
                    {
                        Title = "Fans",
                        Slug = "fans",
                        Controller = "Fans"
                    },
                    new()
                    {
                        Title = "Creating",
                        Slug = "creating",
                        Controller = "Creating"
                    },
                    new()
                    {
                        Title = "Account",
                        Slug = "account",
                        Controller = "Account"
                    },
                    new()
                    {
                        Title = "Safety & Policies",
                        Slug = "safety-and-policies",
                        Controller = "SafetyPolicies"
                    }
                }
            };

            return View(viewModel);
        }
    }
}