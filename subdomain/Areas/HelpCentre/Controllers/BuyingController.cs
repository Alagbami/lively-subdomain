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
        [HttpGet]
        public IActionResult MakeAnOffer()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FindOrderDetails()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FindPurchaseReceipt()
        {
            return View();
        }
        [HttpGet]
        public IActionResult WatchVideoReceipt()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DownloadOrderHistory()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TipSeller()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BookmarkShowsAndProducts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TermsAndConditions()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EnterStandardGiveaway()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RateAndReviewPurchase()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DirectBuyerMessages()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PurchaseRequest()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SellerProvidedSupport()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TrackOrder()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DelayedOrMissingOrder()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ShippingAddressChange()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SmartBundling()
        {
            return View();
        }
        [HttpGet]
        public IActionResult WeeklyBundlingFeature()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ShippingGuide()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Shipping()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ShippingPolicy()
        {
            return View();
        }
    }
}