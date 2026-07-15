using subdomain.Areas.CreatorAcademy.Models;

namespace subdomain.Areas.CreatorAcademy.ViewModels
{
    public abstract class AcademyBaseViewModel
    {
        public string ActivePage { get; set; } = null!;
    }

    public class AcademyHomeViewModel : AcademyBaseViewModel
    {
        public string HeroTitle { get; set; } = "Learn how to create, grow, and earn as a creator";
        public string HeroSubtitle { get; set; } = "Creator Academy helps you improve your content, grow your audience, and unlock new opportunities on the platform.";
        public string? HeroVideoUrl { get; set; }
        public List<QuickNavPill> QuickNav { get; set; } = new();
        public List<AcademySection> Sections { get; set; } = new();
    }

    public class GoLiveGuideViewModel : AcademyBaseViewModel
    {
        public string HeroTitle { get; set; } = "Go Live Guide";
        public string HeroSubtitle { get; set; } = "Step-by-step instructions to help you prepare, launch, and succeed with your first livestream on Lively.";
        public string? HeroImageUrl { get; set; }
        public List<QuickNavPill> QuickNav { get; set; } = new();
        public List<GuideBlock> Blocks { get; set; } = new();
    }

    public class GrowAudienceViewModel : AcademyBaseViewModel
    {
        public string HeroTitle { get; set; } = "Grow Your Audience";

        public string HeroSubtitle { get; set; } =
            "Learn proven strategies to build a loyal fanbase, increase engagement, and expand your reach on Lively.";

        public string? HeroImageUrl { get; set; }

        public List<QuickNavPill> QuickNav { get; set; } = new();

        public string FeaturesHeading { get; set; } =
            "Features to help you grow your business";

        public List<FeatureRow> Features { get; set; } = new();

        public List<InfoCard> Cards { get; set; } = new();
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