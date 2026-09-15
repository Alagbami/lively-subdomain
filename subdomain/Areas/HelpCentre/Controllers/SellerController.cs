using Microsoft.AspNetCore.Mvc;

namespace subdomain.Areas.HelpCentre.Controllers
{
    [Area("HelpCentre")]
    public class SellingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Getting Started
        [HttpGet]
        public IActionResult StartSelling()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ApplyToSell()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewSellerListingGuide()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShippingChecklist()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RehearsalMode()
        {
            return View();
        }

        // Listing Products
        [HttpGet]
        public IActionResult CreateProductListings()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListingConditions()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShippingProfiles()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProductVariants()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListingGuidelines()
        {
            return View();
        }

        // Going Live
        [HttpGet]
        public IActionResult ScheduleShow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShowManagement()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StartGiveaway()
        {
            return View();
        }

        [HttpGet]
        public IActionResult InviteCoHost()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RaidShow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UnderstandShowPerformance()
        {
            return View();
        }

        // Shipping
        [HttpGet]
        public IActionResult SetUpShipping()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShipAnOrder()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ManageShipments()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FixShippingProblem()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShipInternationally()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShippingGuidesByCountry()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShippingServiceOptions()
        {
            return View();
        }

        // Earnings & Finances
        [HttpGet]
        public IActionResult GettingPaid()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FeesAndCommissions()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EarningsStatements()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TaxesAndCompliance()
        {
            return View();
        }

        // Seller Tools
        [HttpGet]
        public IActionResult LivestreamTools()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PromoteTools()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CommunityBoost()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SurpriseSetFeature()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AccountHealthDashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ImproveSellerPerformance()
        {
            return View();
        }
        // Sub-category list pages
        [HttpGet]
        public IActionResult ShippingArticles()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListingProductsArticles()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GoingLiveArticles()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SellerToolsArticles()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ManageProductListings()
        {
            return View();
        }
        public IActionResult RunFlashSale()
        {
            return View();
        }
        public IActionResult CloneProductListings()
        {
            return View();
        }
        public IActionResult BuyItNowOffers()
        {
            return View();
        }
        public IActionResult ChooseQuantities()
        {
            return View();
        }
    }
}