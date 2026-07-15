using subdomain.Areas.Blogs.Models;

namespace subdomain.Areas.Blogs.ViewModels
{
    public class BlogDetailsViewModel
    {
        public BlogPost Post { get; set; } = null!;

        public IReadOnlyList<BlogPost> RelatedPosts { get; set; }
            = new List<BlogPost>();
    }
}