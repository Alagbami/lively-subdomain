using subdomain.Areas.Blogs.Models;

namespace subdomain.Areas.Blogs.ViewModels
{
    public class BlogListViewModel
    {
        public IReadOnlyList<BlogPost> Posts { get; set; }
            = new List<BlogPost>();

        public string ActiveCategory { get; set; }
            = BlogCategory.Latest;

        public string? SearchTerm { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalPages { get; set; } = 1;

        public bool HasNewerPosts => CurrentPage > 1;

        public bool HasOlderPosts => CurrentPage < TotalPages;

        public string[] Categories => BlogCategory.All;
    }
}