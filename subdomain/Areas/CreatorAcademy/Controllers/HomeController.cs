using Microsoft.AspNetCore.Mvc;
using subdomain.Areas.CreatorAcademy.DummyData;

namespace subdomain.Areas.CreatorAcademy.Controllers
{
    [Area("CreatorAcademy")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(AcademyDummyData.BuildHome());
        }

        [HttpGet]
        public IActionResult GoLiveGuide()
        {
            return View(AcademyDummyData.BuildGoLiveGuide());
        }

        [HttpGet]
        public IActionResult GrowAudience()
        {
            return View(AcademyDummyData.BuildGrowAudience());
        }

        [HttpGet]
        public IActionResult Resources()
        {
            return View(AcademyDummyData.BuildResources());
        }

        [HttpGet]
        public IActionResult Help()
        {
            return View(AcademyDummyData.BuildHelp());
        }
    }
}