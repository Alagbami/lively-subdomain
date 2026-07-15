using Microsoft.AspNetCore.Mvc;
using Rotex.Lively.Web.Client.Areas.SellerAcademy.DummyData;

namespace Rotex.Lively.Web.Client.Areas.SellerAcademy.Controllers
{
    [Area("SellerAcademy")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View(AcademyDummyData.BuildHome());

        [HttpGet]
        public IActionResult GoLiveGuide() => View(AcademyDummyData.BuildGoLiveGuide());

        [HttpGet]
        public IActionResult GrowYourBusiness() => View(AcademyDummyData.BuildGrowBusiness());

        [HttpGet]
        public IActionResult Resources() => View(AcademyDummyData.BuildResources());

        [HttpGet]
        public IActionResult Help() => View(AcademyDummyData.BuildHelp());
    }
}