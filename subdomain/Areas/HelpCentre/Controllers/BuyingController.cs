using Microsoft.AspNetCore.Mvc;

namespace subdomain.Areas.HelpCentre.Controllers
{
    [Area("HelpCentre")]
    public class BuyingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PreBid()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BuyNowPayLater()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProtectionPolicy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CancelOrder()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PaymentMethods()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShippingAddress()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChatTags()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BuyingItems()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BuyingOnLively()
        {
            return View();
        }

        [HttpGet]
        public IActionResult HowToBid()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FixPaymentIssue()
        {
            return View();
        }
    }
}