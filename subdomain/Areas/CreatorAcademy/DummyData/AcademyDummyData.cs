using subdomain.Areas.CreatorAcademy.Models;
using subdomain.Areas.CreatorAcademy.ViewModels;

namespace subdomain.Areas.CreatorAcademy.DummyData
{
    /// <summary>
    /// All static content for the Creator Academy's 5 pages.
    /// Swap the Build*() calls in HomeController for a service later — views won't change.
    /// </summary>
    public static class AcademyDummyData
    {
        public static readonly AcademyNavItem[] Nav =
        {
            new() { Label = "Home",          Action = "Index" },
            new() { Label = "Go Live Guide", Action = "GoLiveGuide" },
            new() { Label = "Grow Audience", Action = "GrowAudience" },
            new() { Label = "Resources",     Action = "Resources" },
            new() { Label = "Help",          Action = "Help" },
        };

        // ============================================================
        // HOME
        // ============================================================
        public static AcademyHomeViewModel BuildHome() => new()
        {
            ActivePage = "Index",
            HeroVideoUrl = "/images/creator-academy/hero-video.png",
            QuickNav = new()
            {
                new() { Label = "Getting Started",                Anchor = "#getting-started" },
                new() { Label = "Community Guideline & Policies", Anchor = "#community-guidelines" },
                new() { Label = "Webinar & Blog Updates",         Anchor = "#webinars" },
                new() { Label = "Grow Your Content",              Anchor = "#grow-content" },
                new() { Label = "FAQs",                           Anchor = "#faqs" },
            },
            Sections = new()
            {
                new AcademySection
                {
                    Id = "getting-started",
                    Title = "Getting Started",
                    Body = "Your guide to going live on Lively. Check out the stages of going live and learn about the ways we can support your shows.",
                    ImageUrl = "/images/creator-academy/getting-started.jpg",
                    ImageLeft = true,
                    Links = new()
                    {
                        new() { Text = "Create Your Creator Profile",  Icon = "bi-person" },
                        new() { Text = "Prepare Your Streaming Setup",  Icon = "bi-mic" },
                        new() { Text = "Plan Your First Show",          Icon = "bi-calendar-event" },
                        new() { Text = "Go Live on Lively",             Icon = "bi-broadcast" },
                        new() { Text = "Promote Your Shows",            Icon = "bi-megaphone" },
                    }
                },
                new AcademySection
                {
                    Id = "community-guidelines",
                    Title = "Community Guidelines & Policies",
                    Body = "Resources to help you stay in the know on policies, best practices, and important guidelines on keeping Lively a trustworthy and safe place.",
                    ImageUrl = "/images/creator-academy/community.jpg",
                    ImageLeft = false,
                    YellowBackground = true,
                    Links = new()
                    {
                        new() { Text = "Creator Policies",     Icon = "bi-clock-history", ExternalArrow = true },
                        new() { Text = "General Policies",     Icon = "bi-file-text",     ExternalArrow = true },
                        new() { Text = "Community Guidelines", Icon = "bi-people",        ExternalArrow = true },
                    }
                },
                new AcademySection
                {
                    Id = "webinars",
                    Title = "Webinars & Blog Updates",
                    Body = "Explore educational resources designed to help creators grow on Lively. Join our official creator channels for livestream tips, audience engagement strategies, show ideas, and platform updates. Stay connected with the Lively community and learn how successful creators build loyal fans and monetize their shows.",
                    ImageUrl = "/images/creator-academy/webinars.jpg",
                    ImageLeft = true,
                    Links = new()
                    {
                        new() { Text = "@Livelycreators Account",          Icon = "bi-instagram", ExternalArrow = true },
                        new() { Text = "@Livelycreators YouTube Playlist", Icon = "bi-youtube",   ExternalArrow = true },
                        new() { Text = "Lively Blog",                      Icon = "bi-journal",   ExternalArrow = true, Url = "/Blogs/Blog/Index" },
                    }
                },
                new AcademySection
                {
                    Id = "grow-content",
                    Title = "Grow Your Content",
                    Body = "Learn how to expand your presence as a creator on Lively. Discover ways to build your brand, use customizable social assets to promote your content, and follow best practices to design thumbnails that attract viewers and grow your audience.",
                    ImageUrl = "/images/creator-academy/grow-content.jpg",
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
                    Body = "Our Help Site is home to how-to articles and FAQs. Our Platform Status site is your first stop for up-to-the-minute info on Lively server or platform updates. And our Creator Discord Server offers a social hub where you can connect and collaborate with other buyers and sellers.",
                    ImageUrl = "/images/creator-academy/faqs.jpg",
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
            HeroImageUrl = "/images/creator-academy/golive-hero.jpg",
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
                    Body = "Add your profile picture, confirm your username, add a return address, and a cash out method. To cash out payments to your bank account, you must set up your Lively account with Stripe and connect it with your Lively Settings. You can do this on your web browser or on the mobile app.",
                    MediaImageUrl = "/images/creator-academy/prepare-account.jpg",
                    Accordions = new()
                    {
                        new() { Header = "Account Setup Tips",      Body = "Complete every profile field — a finished profile builds viewer trust and unlocks all creator features." },
                        new() { Header = "Setup Payment for Web",   Body = "Open Settings → Payments and follow the Stripe connect flow from your web browser." },
                        new() { Header = "Setup Payment on Mobile", Body = "In the mobile app, go to Settings → Payments and complete the Stripe onboarding steps." },
                    }
                },
                new GuideBlock
                {
                    Id = "pre-show",
                    Title = "Schedule your first show",
                    Body = "Tap the + icon and select \u201CSchedule a Show,\u201D add a title, a thumbnail, and select the right category.",
                    MediaImageUrl = "/images/creator-academy/schedule-show.jpg",
                    Accordions = new()
                    {
                        new() { Header = "How To", Body = "Use the + button, choose Schedule a Show, then fill in title, thumbnail, date and category." },
                        new() { Header = "Tips",   Body = "Schedule during your audience's peak hours and pick a clear, high-contrast thumbnail." },
                    }
                },
                new GuideBlock
                {
                    Id = "plan-content",
                    Title = "Plan your show content",
                    Body = "Decide the format of your show. This could be music, talk shows, interviews, comedy, Q&A sessions, or fan hangouts.",
                    MediaImageUrl = "/images/creator-academy/plan-content.jpg",
                    Accordions = new()
                    {
                        new() { Header = "How To",            Body = "Pick a format, outline a rough run-of-show, and prepare any segments or talking points in advance." },
                        new() { Header = "Tips",              Body = "Keep energy high, leave room for live interaction, and have a backup segment ready." },
                        new() { Header = "Show Format Ideas", Body = "Music sets, talk shows, interviews, comedy, Q&A sessions, and fan hangouts all perform well." },
                    }
                },
                new GuideBlock
                {
                    Id = "atmosphere",
                    Title = "Create a nice atmosphere",
                    Body = "Having a quality background, good lighting, and excellent audio and video quality during a livestream is essential for creating a professional and engaging experience for your audience, ultimately fostering a positive impression and encouraging viewer retention.",
                    MediaImageUrl = "/images/creator-academy/atmosphere.jpg",
                    Accordions = new()
                    {
                        new() { Header = "How To",                   Body = "Set up a ring light facing you, use a clean backdrop, and test your mic before going live." },
                        new() { Header = "Our Recommended Products", Body = "A ring light, a phone tripod, and a clip-on microphone cover most setups affordably." },
                    }
                },
                new GuideBlock
                {
                    Id = "promote-show",
                    Title = "Promote your show",
                    Body = "Share your upcoming livestream on social media and with your community so fans know when to join.",
                    MediaImageUrl = "/images/creator-academy/promote-show.jpg",
                    Accordions = new()
                    {
                        new() { Header = "How To", Body = "Share your show link to Instagram, TikTok and WhatsApp, and pin it to your stories before going live." },
                    }
                },
                new GuideBlock
                {
                    Id = "private-stream",
                    Title = "Practice with a private stream",
                    Body = "Test your setup using a private stream to check your lighting, sound, and internet connection before going live publicly.",
                    MediaImageUrl = "/images/creator-academy/private-stream.jpg",
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
                    MediaImageUrl = "/images/creator-academy/showtime.jpg",
                    Accordions = new()
                    {
                        new() { Header = "Helpful Features", Body = "Pin items, run polls, and use the spotlight to focus attention during your show." },
                    }
                },
                new GuideBlock
                {
                    Id = "engaged",
                    Title = "Be present + Keep audience engaged",
                    Body = "Interact with your viewers by responding to chat messages, acknowledging supporters, and creating an entertaining experience.",
                    MediaImageUrl = "/images/creator-academy/engaged.jpg",
                    Accordions = new()
                    {
                        new() { Header = "Tips", Body = "Greet new viewers by name, answer questions live, and tease what's coming up next." },
                    }
                },
            }
        };

        // ============================================================
        // GROW AUDIENCE
        // ============================================================
        public static GrowAudienceViewModel BuildGrowAudience() => new()
        {
            ActivePage = "GrowAudience",
            HeroImageUrl = "/images/creator-academy/grow-hero.jpg",
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
                    MediaImageUrl = "/images/creator-academy/promote-tools.jpg",
                },
            },
            Cards = new()
            {
                new InfoCard { Icon = "bi-megaphone", Title = "Promotion Tools",            Body = "Use announcements and notifications to attract viewers and build anticipation for your shows." },
                new InfoCard { Icon = "bi-person",    Title = "Creator Collaborations",     Body = "Stream with other creators to reach new audiences and create unique content together." },
                new InfoCard { Icon = "bi-heart",     Title = "Fans Engagements Strategies", Body = "Create interactive moments with your viewers to build lasting relationships." },
                new InfoCard { Icon = "bi-calendar3", Title = "Consistency and Scheduling", Body = "Regular shows help build loyal fans who know when to tune in for your contents." },
            }
        };

        // ============================================================
        // RESOURCES
        // ============================================================
        public static ResourcesViewModel BuildResources() => new()
        {
            ActivePage = "Resources",
            HeroImageUrl = "/images/creator-academy/resources-hero.jpg",
            QuickNav = new()
            {
                new() { Label = "Brand Guideline", Anchor = "#brand-guidelines" },
                new() { Label = "Design Assets",   Anchor = "#design-resources" },
            },
            BrandGuidelines = new ResourceCard
            {
                Title = "New Brand Guidelines!",
                Body = "Our brand guidelines provide a framework for maintaining consistency and uniformity across all uses of Lively's visual and written communication. Adhering to our brand guidelines helps us present a cohesive and recognizable image, reinforces brand recognition and building a strong, cohesive brand identity. Use these brand guidelines if placing the Lively brand on your marketing materials. Please do not deviate from what is stated in the brand guidelines.",
                ImageUrl = "/images/creator-academy/brand-guidelines.jpg",
                ButtonText = "Download Brand Guidelines",
            },
            DesignResources = new()
            {
                new ResourceCard
                {
                    Title = "Social Media templates",
                    Body = "Use our category specific social assets or create a personalize asset by adding your own photo. Save and share on your socials!",
                    ImageUrl = "/images/creator-academy/social-templates.jpg",
                    ButtonText = "Canva Templates",
                },
                new ResourceCard
                {
                    Title = "Thumbnail Guidelines and best practices",
                    Body = "Learn best practices for designing your thumbnails and check for safe zones on your thumbnails before uploading.",
                    ImageUrl = "/images/creator-academy/thumbnail-guidelines.jpg",
                    ButtonText = "Thumbnails Guidelines",
                },
            },
            MarketingResources = new()
            {
                new ResourceCard
                {
                    Title = "Holiday Prep Guide",
                    Body = "Top tips, tricks, and strategies from experienced sellers to help you take advantage of buyer surge this holiday season.",
                    ImageUrl = "/images/creator-academy/holiday-prep.jpg",
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
            HeroImageUrl = "/images/creator-academy/help-hero.jpg",
            HelpSections = new()
            {
                new AcademySection
                {
                    Id = "creator-help-center",
                    Title = "Creator Help Center",
                    Body = "Take a look at our Creator Help Center for in-depth answers on our most commonly asked questions.",
                },
                new AcademySection
                {
                    Id = "qa",
                    Title = "@livelycreator Q&A\u2019s",
                    Body = "Follow and tune into the livelycreator account on lively to learn from our very own Lively employees and answer any questions you have in our Q&As.",
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
