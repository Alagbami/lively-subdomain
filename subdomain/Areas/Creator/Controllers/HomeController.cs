using Microsoft.AspNetCore.Mvc;
using Rotex.Lively.Web.Client.DummyData;

namespace Rotex.Lively.Web.Client.Areas.Creator.Controllers
{
    [Area("Creator")]
    public class HomeController : Controller
    {
        // GET: /Creator
        // GET: /Creator/Home
        // GET: /Creator/Home/Index
        public IActionResult Index()
        {
            var viewModel = CreatorHubData.Get();
            viewModel.FansTab = CreatorTabsData.GetFans();
            viewModel.EarningsTab = CreatorTabsData.GetEarnings();
            viewModel.AnalyticsTab = CreatorTabsData.GetAnalytics();
            viewModel.ShowsTab = CreatorShowsData.Get();   // ? populate the Shows tab data
            return View(viewModel);
        }

        // GET: /Creator/Home/ReferCreator
        public IActionResult ReferCreator()
        {
            var viewModel = ReferCreatorData.Get();
            return View("~/Areas/Creator/Views/Home/ReferCreator.cshtml", viewModel);
        }

        // GET: /Creator/Home/CreatorAnalytics
        public IActionResult CreatorAnalytics()
        {
            var viewModel = CreatorAnalyticsPageData.Get();
            return View("~/Areas/Creator/Views/Home/CreatorAnalytics.cshtml", viewModel);
        }
    }
}