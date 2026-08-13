using Microsoft.AspNetCore.Mvc;
using YourNamespace.Areas.Legal.DummyData;

namespace YourNamespace.Areas.Legal.Controllers
{
    [Area("Legal")]
    public class LegalController : Controller
    {
        public IActionResult TermsAndConditions()
        {
            var model = LegalDummyDataService.GetTermsAndConditions();
            return View(model);
        }

        public IActionResult PrivacyPolicy()
        {
            var model = LegalDummyDataService.GetPrivacyPolicy();
            return View(model);
        }
    }
}