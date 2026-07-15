namespace subdomain.Areas.CreatorAcademy.Models
{
    /// <summary>A single navigable page in the academy (drives the top nav).</summary>
    public class AcademyNavItem
    {
        public string Label { get; set; } = null!;
        public string Action { get; set; } = null!;
    }

    /// <summary>A pill button used in the "quick navigation" hero cards.</summary>
    public class QuickNavPill
    {
        public string Label { get; set; } = null!;
        public string Anchor { get; set; } = "#";
    }

    /// <summary>A link row inside a content section (icon + text + optional url).</summary>
    public class AcademyLink
    {
        public string Text { get; set; } = null!;
        public string Url { get; set; } = "#";
        public string Icon { get; set; } = "bi-arrow-right";
        public bool ExternalArrow { get; set; }
    }

    /// <summary>A content section with heading, body, optional image, and links.</summary>
    public class AcademySection
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public string? ImageUrl { get; set; }
        public bool ImageLeft { get; set; } = true;
        public bool YellowBackground { get; set; }
        public List<AcademyLink> Links { get; set; } = new();
    }

    /// <summary>A collapsible accordion (used heavily on the Go Live Guide).</summary>
    public class AccordionItem
    {
        public string Header { get; set; } = null!;
        public string Body { get; set; } = "";
        public List<string>? BulletItems { get; set; }
    }

    /// <summary>A guide block: heading + body + accordions + optional media tile.</summary>
    public class GuideBlock
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public string? MediaImageUrl { get; set; }
        public string? MediaLabel { get; set; }
        public bool HasVideo { get; set; }
        public List<AccordionItem> Accordions { get; set; } = new();
    }

    /// <summary>A feature row (Grow Audience: Promote Tools, etc.).</summary>
    public class FeatureRow
    {
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string? MediaImageUrl { get; set; }
        public string? MediaLabel { get; set; }
        public bool HasVideo { get; set; }
    }

    /// <summary>A small info card in a grid (icon + title + body). Creator-only.</summary>
    public class InfoCard
    {
        public string Icon { get; set; } = "bi-stars";
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
    }

    /// <summary>A resource card (Resources page: brand guidelines, templates, etc.).</summary>
    public class ResourceCard
    {
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public string ButtonText { get; set; } = "Learn more";
        public string ButtonUrl { get; set; } = "#";
        public string? ImageBackground { get; set; }
    }
}
