using subdomain.Areas.Blogs.Models;

namespace subdomain.Areas.Blogs.DummyData
{
    /// <summary>
    /// Static seed data for the blog. When a real API/DB is wired up,
    /// replace the calls to this class in BlogController with a service call —
    /// the views and view models won't need to change.
    /// </summary>
    public static class BlogDummyData
    {
        private static readonly List<BlogPost> _posts = Build();

        public static IReadOnlyList<BlogPost> GetAll() => _posts;

        public static BlogPost? GetById(int id) => _posts.FirstOrDefault(p => p.Id == id);

        public static BlogPost? GetBySlug(string slug) =>
            _posts.FirstOrDefault(p => p.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

        private static List<BlogPost> Build()
        {
            var date = new DateTime(2026, 3, 20);

            return new List<BlogPost>
            {
                new BlogPost
                {
                    Id = 1,
                    Title = "Product Spotlight: Clearer Signals, Stronger Protections, Smarter Growth",
                    Slug = "product-spotlight-clearer-signals",
                    Category = BlogCategory.Product,
                    ImageUrl = "/images/blog/product-spotlight.png",
                    PublishedDate = date,
                    Excerpt = "As your business continues to grow, the small details start to carry more weight.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "As your business continues to grow, the small details start to carry more weight." },
                        new() { Type = BlogBlockType.Paragraph, Text = "Having a clear understanding of what's happening at every stage – from what buyers are searching for to when an order is packed, handed off, and officially in transit – makes selling feel seamless. When you can plan with confidence, buyers know what to expect, and outcomes feel more aligned with the effort you're putting in." },
                        new() { Type = BlogBlockType.Paragraph, Text = "This month, we're focused on three key moments that shape your results: how buyers discover your items, the excitement that builds before your show even starts, and what happens when you ship your orders." },
                        new() { Type = BlogBlockType.Heading, Text = "Get discovered faster: new subcategories" },
                        new() { Type = BlogBlockType.Image, ImageUrl = "/images/blog/new-subcategories.png" },
                        new() { Type = BlogBlockType.Paragraph, Text = "We're rolling out new subcategories every month, and this month's drop opens up some in-demand, high potential spaces for sellers." },
                        new() { Type = BlogBlockType.Paragraph, Text = "As Lively grows, buyers are getting more specific about what they're looking for. Creating more specific subcategories helps match that energy. That level of intent leads to stronger engagement, higher conversion, and more repeat buyers for sellers in those categories." },
                        new() { Type = BlogBlockType.Paragraph, Text = "Here's what's new:" },
                        new() { Type = BlogBlockType.BulletList, Items = new List<string>
                            {
                                "Food & Drink: Exotic Snacks, Chocolate, Condiments & Sauces, Soda & Drinks",
                                "Fashion: Men's Grooming, Bath & Body Essentials, Baby & Kids Shoes",
                                "Electronics: Headphones & Speakers",
                                "Collectibles: Ancient Coins, Gold Nuggets",
                                "Arts & Handmade: Embroidery & Needlework, Scrapbook & Journaling, Stickers, Stamps, 3D Prints, Heat Transfers"
                            }
                        },
                        new() { Type = BlogBlockType.Paragraph, Text = "How to use it: List into the most specific category that fits your inventory. When your products are placed in the right space, discovery works harder for you, engagement gets stronger, and growth becomes more consistent." },
                        new() { Type = BlogBlockType.Heading, Text = "Run the items buyers already want: smarter pre-bids" },
                        new() { Type = BlogBlockType.Image, ImageUrl = "/images/blog/smarter-pre-bids.png" },
                        new() { Type = BlogBlockType.Paragraph, Text = "Pre-bids give you a preview of what buyers are excited about before your show even starts. Think of pre-bids as a built-in waitlist, and now it's easier for everyone to see and use." },
                        new() { Type = BlogBlockType.Paragraph, Text = "The impact is significant: shows with strong pre-bid activity see up to 7x more total sales and nearly 4x more orders than shows without it." },
                        new() { Type = BlogBlockType.Paragraph, Text = "Happy Selling!" },
                        new() { Type = BlogBlockType.Paragraph, Text = "– Lively Product Team" },
                    }
                },
                new BlogPost
                {
                    Id = 2,
                    Title = "10 Proven Strategies to Increase Your Live Stream Engagement",
                    Slug = "increase-live-stream-engagement",
                    Category = BlogCategory.GrowthAndTips,
                    ImageUrl = "/images/blog/live-stream-engagement.png",
                    PublishedDate = date,
                    Excerpt = "Practical tactics to keep your audience watching, chatting, and buying throughout your show.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "Engagement is the heartbeat of every successful live show. Here are ten strategies that consistently move the needle." },
                        new() { Type = BlogBlockType.Heading, Text = "Start with energy" },
                        new() { Type = BlogBlockType.Paragraph, Text = "The first sixty seconds set the tone. Greet viewers by name, tease what's coming, and create a reason to stay." },
                    }
                },
                new BlogPost
                {
                    Id = 3,
                    Title = "Introducing New Analytics Tools for Live Commerce Creators",
                    Slug = "new-analytics-tools",
                    Category = BlogCategory.Lively,
                    ImageUrl = null, // renders the yellow logo tile
                    PublishedDate = date,
                    Excerpt = "Understand your audience and sales performance with a refreshed analytics dashboard.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "Data should be easy to read and easy to act on. Our new analytics tools give creators a clearer picture of what's working." },
                        new() { Type = BlogBlockType.Heading, Text = "What's included" },
                        new() { Type = BlogBlockType.BulletList, Items = new List<string>
                            {
                                "Real-time viewer counts and retention curves",
                                "Per-show sales breakdowns",
                                "Repeat-buyer tracking"
                            }
                        },
                    }
                },
                new BlogPost
                {
                    Id = 4,
                    Title = "How Live Sellers Are Building Authentic Connections with Their Audience",
                    Slug = "building-authentic-connections",
                    Category = BlogCategory.Community,
                    ImageUrl = "/images/blog/authentic-connections.png",
                    PublishedDate = date,
                    Excerpt = "Authenticity wins. See how top sellers turn viewers into loyal community members.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "The sellers who grow fastest aren't the loudest — they're the most genuine. Connection beats polish every time." },
                        new() { Type = BlogBlockType.Heading, Text = "Show up consistently" },
                        new() { Type = BlogBlockType.Paragraph, Text = "A predictable schedule lets your community plan to be there. Consistency compounds into trust." },
                    }
                },
                new BlogPost
                {
                    Id = 5,
                    Title = "Keeping the Marketplace Safe: Our Approach to Buyer Protection",
                    Slug = "buyer-protection-approach",
                    Category = BlogCategory.TrustAndSafety,
                    ImageUrl = "/images/blog/buyer-protection.png",
                    PublishedDate = date,
                    Excerpt = "A look at the systems and policies that keep buying and selling on Lively secure.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "Trust is the foundation of every transaction. Here's how we protect both buyers and sellers." },
                        new() { Type = BlogBlockType.Heading, Text = "Layered protection" },
                        new() { Type = BlogBlockType.Paragraph, Text = "From verified identities to secure payouts, multiple safeguards work together behind the scenes." },
                    }
                },
                new BlogPost
                {
                    Id = 6,
                    Title = "From First Show to Full-Time: A Seller's Growth Journey",
                    Slug = "first-show-to-full-time",
                    Category = BlogCategory.Community,
                    ImageUrl = "/images/blog/sellers-journey.png",
                    PublishedDate = date,
                    Excerpt = "One seller's path from a nervous first stream to a thriving live commerce business.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "Every full-time seller started with a single show. This is the story of one of them." },
                    }
                },
                new BlogPost
                {
                    Id = 7,
                    Title = "Pricing Your Products for Live Selling Success",
                    Slug = "pricing-for-live-selling",
                    Category = BlogCategory.GrowthAndTips,
                    ImageUrl = "/images/blog/pricing-strategy.png",
                    PublishedDate = date,
                    Excerpt = "Pricing psychology that works in a fast-paced live environment.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "The right price does more than cover costs — it creates urgency and perceived value." },
                    }
                },
                new BlogPost
                {
                    Id = 8,
                    Title = "What's New on Lively This Quarter",
                    Slug = "whats-new-this-quarter",
                    Category = BlogCategory.Lively,
                    ImageUrl = null,
                    PublishedDate = date,
                    Excerpt = "A roundup of the features and improvements we shipped this quarter.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "We've been busy. Here's a tour of everything new on the platform." },
                    }
                },
                new BlogPost
                {
                    Id = 9,
                    Title = "A Smarter Checkout: Faster, Clearer, More Secure",
                    Slug = "smarter-checkout",
                    Category = BlogCategory.Product,
                    ImageUrl = "/images/blog/smarter-checkout.png",
                    PublishedDate = date,
                    Excerpt = "We rebuilt checkout from the ground up for speed and clarity.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "Checkout is where intent becomes a sale. We made every step faster and clearer." },
                    }
                },
                new BlogPost
                {
                    Id = 10,
                    Title = "Reporting and Resolving Issues: A Buyer's Guide",
                    Slug = "buyers-guide-reporting-issues",
                    Category = BlogCategory.TrustAndSafety,
                    ImageUrl = "/images/blog/reporting-issues.png",
                    PublishedDate = date,
                    Excerpt = "Know your options if something goes wrong with an order.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "Most orders go perfectly. For the rare ones that don't, here's exactly what to do." },
                    }
                },
                new BlogPost
                {
                    Id = 11,
                    Title = "Lighting and Sound: A Creator's Setup Checklist",
                    Slug = "creator-setup-checklist",
                    Category = BlogCategory.GrowthAndTips,
                    ImageUrl = "/images/blog/creator-setup.png",
                    PublishedDate = date,
                    Excerpt = "The gear and arrangement that make your stream look professional.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "You don't need a studio — just a few smart choices about light and sound." },
                    }
                },
                new BlogPost
                {
                    Id = 12,
                    Title = "Celebrating Our Top Community Sellers",
                    Slug = "celebrating-top-community-sellers",
                    Category = BlogCategory.Community,
                    ImageUrl = "/images/blog/community-sellers.png",
                    PublishedDate = date,
                    Excerpt = "Shining a light on the sellers who make the Lively community special.",
                    Body = new List<BlogContentBlock>
                    {
                        new() { Type = BlogBlockType.Paragraph, Text = "Behind every great marketplace is a great community. Here are some of our standouts." },
                    }
                },
            };
        }
    }
}
