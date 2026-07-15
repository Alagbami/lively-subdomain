using Rotex.Lively.Web.Client.Areas.SellerAcademy.Models;

namespace Rotex.Lively.Web.Client.Areas.SellerAcademy.ViewModels
{
    /// <summary>Base VM — every page knows which nav item is active.</summary>
    public abstract class AcademyBaseViewModel
    {
        /// <summary>The action name of the active page (drives nav highlight).</summary>
        public string ActivePage { get; set; } = null!;
    }

    public class AcademyHomeViewModel : AcademyBaseViewModel
    {
        public string HeroTitle { get; set; } = "Learn how to sell, go live, and grow on Lively.";
        public string HeroSubtitle { get; set; } = "Short lessons, expert tips, and proven strategies to help you succeed as a seller on Lively.";
        public string? HeroVideoUrl { get; set; }
        public List<QuickNavPill> QuickNav { get; set; } = new();
        public List<AcademySection> Sections { get; set; } = new();
    }

    public class GoLiveGuideViewModel : AcademyBaseViewModel
    {
        public string HeroTitle { get; set; } = "Go Live Guide";
        public string HeroSubtitle { get; set; } = "All the essentials, from setting up your account to receiving payments.";
        public string? HeroImageUrl { get; set; }
        public List<QuickNavPill> QuickNav { get; set; } = new();
        public List<GuideBlock> Blocks { get; set; } = new();
    }

    public class GrowBusinessViewModel : AcademyBaseViewModel
    {
        public string HeroTitle { get; set; } = "Grow your Business";
        public string HeroQuote { get; set; } = "\u201CAlone we can do so little; together we can do so much\u201D";
        public string HeroQuoteAuthor { get; set; } = "@Helen Keller";
        public string? HeroImageUrl { get; set; }
        public List<QuickNavPill> QuickNav { get; set; } = new();
        public string FeaturesHeading { get; set; } = "Features to help you grow your business";
        public List<FeatureRow> Features { get; set; } = new();
    }

    public class ResourcesViewModel : AcademyBaseViewModel
    {
        public string HeroTitle { get; set; } = "Seller Resources";
        public string HeroSubtitle { get; set; } = "Find sources to elevate your shows, no matter what stage your business is in.";
        public string? HeroImageUrl { get; set; }
        public List<QuickNavPill> QuickNav { get; set; } = new();
        public ResourceCard BrandGuidelines { get; set; } = null!;
        public List<ResourceCard> DesignResources { get; set; } = new();
        public List<ResourceCard> MarketingResources { get; set; } = new();
    }

    public class HelpViewModel : AcademyBaseViewModel
    {
        public string HeroTitle { get; set; } = "Need Help?";
        public string HeroSubtitle { get; set; } = "Check our common resources to answer your questions!";
        public string? HeroImageUrl { get; set; }
        public List<AcademySection> HelpSections { get; set; } = new();
    }
}