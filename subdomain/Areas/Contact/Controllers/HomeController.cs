using Microsoft.AspNetCore.Mvc;
using Rotex.Lively.Web.Client.Areas.Contact.ViewModels;
using Rotex.Lively.Web.Client.Areas.Contact.DummyData;

namespace Rotex.Lively.Web.Client.Areas.Contact.Controllers
{
    [Area("Contact")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new ContactViewModel
            {
                RequestTypes = ContactDummyDataService.GetRequestTypes(),
                Regions = ContactDummyDataService.GetRegions(),
                ConfirmationOptions = ContactDummyDataService.GetConfirmationOptions(),
                HelpOptions = ContactDummyDataService.GetHelpOptions(),
                Countries = ContactDummyDataService.GetCountries(),
                AppealOptions = ContactDummyDataService.GetAppealOptions()
            };
            return View(viewModel);
        }

        public IActionResult Search(string q)
        {
            var viewModel = new ContactViewModel
            {
                RequestTypes = ContactDummyDataService.GetRequestTypes(),
                Regions = ContactDummyDataService.GetRegions(),
                ConfirmationOptions = ContactDummyDataService.GetConfirmationOptions(),
                HelpOptions = ContactDummyDataService.GetHelpOptions(),
                Countries = ContactDummyDataService.GetCountries(),
                AppealOptions = ContactDummyDataService.GetAppealOptions()
            };

            ViewData["Query"] = q ?? string.Empty;
            return View(viewModel);
        }
    }
}