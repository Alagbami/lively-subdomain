namespace Rotex.Lively.Web.Client.Areas.SellerAcademy.Models
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
        public string Anchor { get; set; } = "#"; // in-page anchor target
    }

    /// <summary>A link row inside a content section (icon + text + optional url).</summary>
    public class AcademyLink
    {
        public string Text { get; set; } = null!;
        public string Url { get; set; } = "#";
        public string Icon { get; set; } = "bi-arrow-right"; // bootstrap-icons class
        public bool ExternalArrow { get; set; } // shows trailing arrow (→) like screenshots
    }

    /// <summary>A content section with heading, body, optional image, and links.</summary>
    public class AcademySection
    {
        public string Id { get; set; } = null!;          // anchor id
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public string? SecondaryBody { get; set; }       // optional 2nd paragraph
        public string? ImageUrl { get; set; }
        public bool ImageLeft { get; set; } = true;       // image side
        public bool YellowBackground { get; set; }        // full-width yellow band
        public List<AcademyLink> Links { get; set; } = new();
    }

    /// <summary>A collapsible accordion (used heavily on the Go Live Guide).</summary>
    public class AccordionItem
    {
        public string Header { get; set; } = null!;
        public string Body { get; set; } = null!;
        public List<string>? BulletItems { get; set; }
    }

    /// <summary>A guide block: heading + body + a stack of accordions + optional media tile.</summary>
    public class GuideBlock
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public string? MediaImageUrl { get; set; }   // the yellow video/thumbnail tile
        public string? MediaLabel { get; set; }       // e.g. "Schedule your Show"
        public bool HasVideo { get; set; }            // shows play button overlay
        public List<AccordionItem> Accordions { get; set; } = new();
    }

    /// <summary>A feature row (Grow Your Business: Promote Tools, Coupons, etc.).</summary>
    public class FeatureRow
    {
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string? MediaImageUrl { get; set; }
        public string? MediaLabel { get; set; }
        public bool HasVideo { get; set; }
    }

    /// <summary>A resource card (Resources page: brand guidelines, templates, etc.).</summary>
    public class ResourceCard
    {
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public string ButtonText { get; set; } = "Learn more";
        public string ButtonUrl { get; set; } = "#";
        public string? ImageBackground { get; set; } // optional bg color for the image tile
    }
}