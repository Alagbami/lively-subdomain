namespace subdomain.Areas.Blogs.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Excerpt { get; set; } = string.Empty;

        public List<BlogContentBlock> Body { get; set; } = new();

        public string DisplayDate =>
            PublishedDate.ToString("MMMM dd, yyyy");
    }

    public class BlogContentBlock
    {
        public BlogBlockType Type { get; set; }

        public string? Text { get; set; }

        public string? ImageUrl { get; set; }

        public List<string>? Items { get; set; }
    }

    public enum BlogBlockType
    {
        Paragraph,
        Heading,
        Image,
        BulletList
    }
}