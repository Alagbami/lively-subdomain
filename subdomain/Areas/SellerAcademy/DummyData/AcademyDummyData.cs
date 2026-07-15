using Rotex.Lively.Web.Client.Areas.SellerAcademy.Models;
using Rotex.Lively.Web.Client.Areas.SellerAcademy.ViewModels;

namespace Rotex.Lively.Web.Client.Areas.SellerAcademy.DummyData
{
    /// <summary>
    /// All static content for the Seller Academy's 5 pages.
    /// When an API/CMS is wired up, replace these builder calls in HomeController
    /// with a service call — the views and view models won't change.
    /// </summary>
    public static class AcademyDummyData
    {
        public static readonly AcademyNavItem[] Nav =
        {
            new() { Label = "Home",               Action = "Index" },
            new() { Label = "Go Live Guide",      Action = "GoLiveGuide" },
            new() { Label = "Grow Your Business", Action = "GrowYourBusiness" },
            new() { Label = "Resources",          Action = "Resources" },
            new() { Label = "Help",               Action = "Help" },
        };

        // ============================================================
        // HOME
        // ============================================================
        public static AcademyHomeViewModel BuildHome() => new()
        {
            ActivePage = "Index",
            HeroVideoUrl = "/images/academy/hero-video.png",
            QuickNav = new()
            {
                new() { Label = "Getting Started",                Anchor = "#getting-started" },
                new() { Label = "Community Guideline & Policies", Anchor = "#community-guidelines" },
                new() { Label = "Webinar & Blog Updates",         Anchor = "#webinars" },
                new() { Label = "Market Your Shows",              Anchor = "#market-shows" },
                new() { Label = "FAQs",                           Anchor = "#faqs" },
            },
            Sections = new()
            {
                new AcademySection
                {
                    Id = "getting-started",
                    Title = "Getting Started",
                    Body = "Your guide to going live on Lively. Check out the stages of going live and learn about the ways we can support your shows.",
                    ImageUrl = "/images/academy/getting-started.jpg",
                    ImageLeft = true,
                    Links = new()
                    {
                        new() { Text = "Preparing your account",  Icon = "bi-person" },
                        new() { Text = "Pre-show Steps",          Icon = "bi-list-check" },
                        new() { Text = "Showtime",                Icon = "bi-broadcast" },
                        new() { Text = "Post-show Steps",         Icon = "bi-cash-coin" },
                        new() { Text = "Shipping Guide",          Icon = "bi-box-seam" },
                        new() { Text = "Going Live Checklist",    Icon = "bi-card-checklist" },
                        new() { Text = "Seller Success Handbook", Icon = "bi-book" },
                    }
                },
                new AcademySection
                {
                    Id = "community-guidelines",
                    Title = "Community Guidelines & Policies",
                    Body = "Resources to help you stay in the know on policies, best practices, and important guidelines on keeping Lively a trustworthy and safe place.",
                    ImageUrl = "/images/academy/community.jpg",
                    ImageLeft = false,
                    YellowBackground = true,
                    Links = new()
                    {
                        new() { Text = "Seller Policies",      Icon = "bi-clock-history", ExternalArrow = true },
                        new() { Text = "General Policies",     Icon = "bi-file-text",     ExternalArrow = true },
                        new() { Text = "Community Guidelines", Icon = "bi-people",        ExternalArrow = true },
                    }
                },
                new AcademySection
                {
                    Id = "webinars",
                    Title = "Webinars & Blog Updates",
                    Body = "Check out our educational resources! Join our official Lively account, @Livelysellers, for topic-specific Q&As, interviews, webinars, and more. Check out the official Lively Blog to stay up-to-date on the platform and the community.",
                    ImageUrl = "/images/academy/webinars.jpg",
                    ImageLeft = true,
                    Links = new()
                    {
                        new() { Text = "@Livelysellers Account",          Icon = "bi-instagram", ExternalArrow = true },
                        new() { Text = "@Livelysellers YouTube Playlist", Icon = "bi-youtube",   ExternalArrow = true },
                        new() { Text = "Lively Blog",                     Icon = "bi-journal",   ExternalArrow = true, Url = "/Blogs/Blog/Index" },
                    }
                },
                new AcademySection
                {
                    Id = "market-shows",
                    Title = "Market Your Shows",
                    Body = "Learn how to use the Lively brand when promoting yourself on Lively, use category specific social assets you can personalize and share on your socials, and find best practices for designing your thumbnails.",
                    ImageUrl = "/images/academy/market-shows.jpg",
                    ImageLeft = false,
                    YellowBackground = true,
                    Links = new()
                    {
                        new() { Text = "Brand Guidelines",          Icon = "bi-bullseye", ExternalArrow = true },
                        new() { Text = "Social Media Templates",    Icon = "bi-images",   ExternalArrow = true },
                        new() { Text = "Show Thumbnail Guidelines", Icon = "bi-image",    ExternalArrow = true },
                    }
                },
                new AcademySection
                {
                    Id = "faqs",
                    Title = "FAQs & Help",
                    Body = "Our Help Site is home to how-to articles and FAQs. Our Platform Status site is your first stop for up-to-the-minute info on Lively server or platform updates. And our Seller Discord Server offers a social hub where you can connect and collaborate with other buyers and sellers.",
                    ImageUrl = "/images/academy/faqs.jpg",
                    ImageLeft = true,
                    Links = new()
                    {
                        new() { Text = "Help Site",       Icon = "bi-file-earmark", ExternalArrow = true },
                        new() { Text = "Platform Status", Icon = "bi-graph-up",     ExternalArrow = true },
                    }
                },
            }
        };

        // ============================================================
        // GO LIVE GUIDE
        // ============================================================
        public static GoLiveGuideViewModel BuildGoLiveGuide() => new()
        {
            ActivePage = "GoLiveGuide",
            HeroImageUrl = "/images/academy/golive-hero.jpg",
            QuickNav = new()
            {
                new() { Label = "Prepare Your Account",    Anchor = "#prepare-account" },
                new() { Label = "Pre-Show",                Anchor = "#pre-show" },
                new() { Label = "Showtime",                Anchor = "#showtime" },
                new() { Label = "Post Show And Shipping",  Anchor = "#post-show" },
                new() { Label = "Checklist",               Anchor = "#checklist" },
                new() { Label = "Level Up Your Promotion", Anchor = "#level-up" },
            },
            Blocks = new()
            {
                new GuideBlock
                {
                    Id = "prepare-account",
                    Title = "Set up your account and Payment",
                    Body = "Add your profile picture, confirm your username, add a return address, and a cash out method. To cash out payments to your bank account, you must set up your Lively account with Stripe and connect it within your Lively Settings.",
                    MediaImageUrl = "/images/academy/prepare-account.jpg",
                    Accordions = new()
                    {
                        new() { Header = "Account Setup Tips",      Body = "Complete every profile field — a finished profile builds buyer trust and unlocks all selling features." },
                        new() { Header = "Setup Payment for Web",   Body = "Open Settings → Payments and follow the Stripe connect flow from your web browser." },
                        new() { Header = "Setup Payment on Mobile", Body = "In the mobile app, go to Settings → Payments and complete the Stripe onboarding steps." },
                    }
                },
                new GuideBlock
                {
                    Id = "pre-show",
                    Title = "Schedule your first show",
                    Body = "Tap the + icon and select \u201CSchedule a Show\u201D, add a title, a thumbnail, and select the right category.",
                    MediaImageUrl = "/images/academy/schedule-show.png",
                    MediaLabel = "Schedule your Show",
                    HasVideo = true,
                    Accordions = new()
                    {
                        new() { Header = "How To", Body = "Use the + button, choose Schedule a Show, then fill in title, thumbnail, date and category." },
                        new() { Header = "Tips",   Body = "Schedule during your audience's peak hours and pick a clear, high-contrast thumbnail." },
                    }
                },
                new GuideBlock
                {
                    Id = "add-listings",
                    Title = "Add your listings",
                    Body = "Pre-loading items into your shop also makes it easier for you to focus on being more interactive and present with your audience during the show.",
                    MediaImageUrl = "/images/academy/add-listings.png",
                    MediaLabel = "Add listings",
                    HasVideo = true,
                    Accordions = new()
                    {
                        new() { Header = "How To",               Body = "Open your shop, tap Add Listing, upload photos, set price and quantity, then save." },
                        new() { Header = "Tips",                 Body = "Batch-add listings before the show so you can stay present with viewers while live." },
                        new() { Header = "Specialty Sales Types", Body = "Explore auctions, giveaways and buy-it-now formats to keep your show dynamic." },
                    }
                },
                new GuideBlock
                {
                    Id = "atmosphere",
                    Title = "Create a nice atmosphere",
                    Body = "Having a quality background, good lighting, and excellent audio and video quality during a livestream is essential for creating a professional and engaging experience for your audience, ultimately fostering a positive impression and encouraging viewer retention.",
                    MediaImageUrl = "/images/academy/atmosphere.jpg",
                    Accordions = new()
                    {
                        new() { Header = "How To",                   Body = "Set up a ring light facing you, use a clean backdrop, and test your mic before going live." },
                        new() { Header = "Our Recommended Products", Body = "A ring light, a phone tripod, and a clip-on microphone cover most setups affordably." },
                    }
                },
                new GuideBlock
                {
                    Id = "shipping-resources",
                    Title = "Get your Shipping Resources",
                    Body = "Optimize your fulfillment process by preparing shipping supplies in advance. Ensure you have boxes, sleeves, packaging materials, and labels ready before your show. This streamlines order processing, facilitates timely shipments, and enhances overall customer satisfaction.",
                    MediaImageUrl = "/images/academy/shipping.jpg",
                    Accordions = new()
                    {
                        new() { Header = "Our Recommended Shipping Supplies", Body = "Poly mailers, bubble wrap, a thermal label printer and branded thank-you cards." },
                    }
                },
                new GuideBlock
                {
                    Id = "share-show",
                    Title = "Share your show",
                    Body = "Harness social media to boost your following on Lively, utilizing it as a powerful tool to promote your livestream within your community.",
                    MediaImageUrl = "/images/academy/share-show.png",
                    MediaLabel = "Share Your Show",
                    Accordions = new()
                    {
                        new() { Header = "How to", Body = "Share your show link to Instagram, TikTok and WhatsApp, and pin it to your stories before going live." },
                    }
                },
                new GuideBlock
                {
                    Id = "private-stream",
                    Title = "Practice with a Private Stream",
                    Body = "Want to practice before going live? Use a private stream to get acquainted with the Live process, test your set-up, check out your sound and set-up, and practice using Seller Tools.",
                    MediaImageUrl = "/images/academy/private-stream.jpg",
                    Accordions = new()
                    {
                        new() { Header = "How To", Body = "Start a private stream from the show screen, run through your flow, and review the recording." },
                    }
                },
                new GuideBlock
                {
                    Id = "showtime",
                    Title = "Let's go live!",
                    Body = "Tap your show's thumbnail and click 'Start Show.' People who follow you or who have bookmarked your show will receive a notification that you're going live.",
                    MediaImageUrl = "/images/academy/showtime.png",
                    MediaLabel = "Showtime",
                    Accordions = new()
                    {
                        new() { Header = "Helpful Features", Body = "Pin items, run flash auctions, and use the spotlight to focus attention during your show." },
                    }
                },
                new GuideBlock
                {
                    Id = "engaged",
                    Title = "Be present + Keep audience engaged",
                    Body = "Pre-loading items into your shop also makes it easier for you to focus on being more interactive and present with your audience during the show.",
                    MediaImageUrl = "/images/academy/engaged.jpg",
                    Accordions = new()
                    {
                        new() { Header = "Tips",             Body = "Greet new viewers by name, answer questions live, and tease what's coming up next." },
                        new() { Header = "Helpful Features", Body = "Use polls, pinned comments and giveaways to keep energy high throughout the show." },
                    }
                },
                new GuideBlock
                {
                    Id = "post-show",
                    Title = "Notes on cancelling an order",
                    MediaImageUrl = "/images/academy/post-show.jpg",
                    Accordions = new()
                    {
                        new() { Header = "How To", Body = "Open the order in your Seller Dashboard, choose Cancel, select a reason, and confirm." },
                    }
                },
                new GuideBlock
                {
                    Id = "getting-paid",
                    Title = "Getting Paid",
                    Accordions = new()
                    {
                        new() { Header = "How To", Body = "Payouts process automatically to your connected Stripe account after orders are fulfilled." },
                    }
                },
                new GuideBlock
                {
                    Id = "shipping-howto",
                    Title = "Shipping How To's",
                    Body = "Sellers must ship items within 2 business days of the livestream. The faster you ship, the faster you get paid out, and faster shipping times lead to happier buyers.",
                    Accordions = new()
                    {
                        new() { Header = "Tips",
                            Body = "",
                            BulletItems = new()
                            {
                                "Block-and-drop times during the week to package and drop off your orders.",
                                "Save time by printing all your shipping labels and packing slips at once (best for thermal printers). Use Bulk Actions to generate and export labels or slips from your Seller Dashboard.",
                                "For more tips, you can click on this Shipping PDF.",
                            }
                        },
                        new() { Header = "How To",                            Body = "Print labels, attach them securely, and drop packages at your carrier within two days." },
                        new() { Header = "Protecting your items",             Body = "Use adequate padding and waterproof mailers to keep items safe in transit." },
                        new() { Header = "Unbundle/rebundle items",           Body = "Combine or split orders from the dashboard before generating shipping labels." },
                        new() { Header = "Edit shipment weight and dimensions", Body = "Adjust weight and dimensions on the label screen for accurate postage." },
                        new() { Header = "Print Labels",                      Body = "Use single or bulk printing from the Orders tab in your Seller Dashboard." },
                        new() { Header = "Bulk generate shipping labels",     Body = "Select multiple orders and choose Bulk Actions → Generate Labels." },
                        new() { Header = "Bulk confirm Lively Drop-Off",      Body = "Mark several orders as dropped off at once to speed up your payout." },
                    }
                },
            }
        };

        // ============================================================
        // GROW YOUR BUSINESS
        // ============================================================
        public static GrowBusinessViewModel BuildGrowBusiness() => new()
        {
            ActivePage = "GrowYourBusiness",
            HeroImageUrl = "/images/academy/grow-hero.jpg",
            QuickNav = new()
            {
                new() { Label = "Features",                 Anchor = "#features" },
                new() { Label = "Enhance Your Show",        Anchor = "#enhance" },
                new() { Label = "Troubleshooting",          Anchor = "#troubleshooting" },
                new() { Label = "Level Up Your Production", Anchor = "#level-up" },
            },
            Features = new()
            {
                new FeatureRow
                {
                    Title = "Promote Tools",
                    Body = "Leverage features such as Show Boost or Promote Full Show to enhance visibility, increase impressions, and drive more views to your livestream by securing sponsored spots that elevate your position in the feed.",
                    MediaImageUrl = "/images/academy/promote-show.png",
                    MediaLabel = "Promote Your Show",
                    HasVideo = true,
                },
                new FeatureRow
                {
                    Title = "Coupons and Giveaways",
                    Body = "Learn how to use Lively's marketing tools to grow your audience and reward your buyers! This video covers coupons, giveaways, shipping discounts, referral links, and multi casting to other platforms.",
                    MediaImageUrl = "/images/academy/sweeteners.png",
                    MediaLabel = "Add Sweeteners",
                    HasVideo = true,
                },
            }
        };

        // ============================================================
        // RESOURCES
        // ============================================================
        public static ResourcesViewModel BuildResources() => new()
        {
            ActivePage = "Resources",
            HeroImageUrl = "/images/academy/resources-hero.jpg",
            QuickNav = new()
            {
                new() { Label = "Brand Guideline", Anchor = "#brand-guidelines" },
                new() { Label = "Design Assets",   Anchor = "#design-resources" },
            },
            BrandGuidelines = new ResourceCard
            {
                Title = "New Brand Guidelines!",
                Body = "Our brand guidelines provide a framework for maintaining consistency and uniformity across all uses of Lively's visual and written communication. Adhering to our brand guidelines helps us present a cohesive and recognizable image, reinforces brand recognition and building a strong, cohesive brand identity. Use these brand guidelines if placing the Lively brand on your marketing materials. Please do not deviate from what is stated in the brand guidelines.",
                ImageUrl = "/images/academy/brand-guidelines.png",
                ButtonText = "Download Brand Guidelines",
            },
            DesignResources = new()
            {
                new ResourceCard
                {
                    Title = "Social Media templates",
                    Body = "Use our category specific social assets or create a personalize asset by adding your own photo. Save and share on your socials!",
                    ImageUrl = "/images/academy/social-templates.jpg",
                    ButtonText = "Canva Templates",
                },
                new ResourceCard
                {
                    Title = "Thumbnail Guidelines and best practices",
                    Body = "Learn best practices for designing your thumbnails and check for safe zones on your thumbnails before uploading.",
                    ImageUrl = "/images/academy/thumbnail-guidelines.jpg",
                    ButtonText = "Thumbnails Guidelines",
                },
            },
            MarketingResources = new()
            {
                new ResourceCard
                {
                    Title = "Holiday Prep Guide",
                    Body = "Top tips, tricks, and strategies from experienced sellers to help you take advantage of buyer surge this holiday season.",
                    ImageUrl = "/images/academy/holiday-prep.jpg",
                    ImageBackground = "#2C46E0",
                    ButtonText = "Explore The guide",
                },
            }
        };

        // ============================================================
        // HELP
        // ============================================================
        public static HelpViewModel BuildHelp() => new()
        {
            ActivePage = "Help",
            HeroImageUrl = "/images/academy/help-hero.jpg",
            HelpSections = new()
            {
                new AcademySection
                {
                    Id = "seller-help-center",
                    Title = "Seller Help Center",
                    Body = "Take a look at our Seller Help Center for in-depth answers on our most commonly asked questions.",
                },
                new AcademySection
                {
                    Id = "qa",
                    Title = "@livelysellers Q&A\u2019s",
                    Body = "Follow and tune into the livelysellers account on lively to learn from our very own Lively employees and answer any questions you have in our Q&As.",
                },
                new AcademySection
                {
                    Id = "email-support",
                    Title = "Email Support",
                    Body = "If the Help Center does not have the answer to your question or issue, please reach out to us at sellersupport@lively.com. If your buyers need assistance, have them check this article on how to contact support here.",
                },
            }
        };
    }
}