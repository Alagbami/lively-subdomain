using Microsoft.AspNetCore.Mvc;
using subdomain.Areas.Blogs.DummyData;
using subdomain.Areas.Blogs.Models;
using subdomain.Areas.Blogs.ViewModels;

namespace subdomain.Areas.Blogs.Controllers
{
    [Area("Blogs")]
    public class BlogController : Controller
    {
        private const int PageSize = 9;

        [HttpGet]
        public IActionResult Index(
            string? category,
            string? search,
            int page = 1)
        {
            category = string.IsNullOrWhiteSpace(category)
                ? BlogCategory.Latest
                : category;

            IEnumerable<BlogPost> query = BlogDummyData.GetAll();

            // "Latest" means show posts from every category.
            if (!category.Equals(
                    BlogCategory.Latest,
                    StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(post =>
                    post.Category.Equals(
                        category,
                        StringComparison.OrdinalIgnoreCase));
            }

            // Search title and excerpt.
            if (!string.IsNullOrWhiteSpace(search))
            {
                var searchTerm = search.Trim();

                query = query.Where(post =>
                    post.Title.Contains(
                        searchTerm,
                        StringComparison.OrdinalIgnoreCase)
                    ||
                    post.Excerpt.Contains(
                        searchTerm,
                        StringComparison.OrdinalIgnoreCase));
            }

            var filteredPosts = query
                .OrderByDescending(post => post.PublishedDate)
                .ToList();

            var totalPages = Math.Max(
                1,
                (int)Math.Ceiling(
                    filteredPosts.Count / (double)PageSize));

            page = Math.Clamp(page, 1, totalPages);

            var currentPagePosts = filteredPosts
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            var viewModel = new BlogListViewModel
            {
                Posts = currentPagePosts,
                ActiveCategory = category,
                SearchTerm = search,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var post = BlogDummyData.GetById(id);

            if (post is null)
            {
                return NotFound();
            }

            var relatedPosts = BlogDummyData.GetAll()
                .Where(item =>
                    item.Id != post.Id &&
                    item.Category == post.Category)
                .Concat(
                    BlogDummyData.GetAll()
                        .Where(item =>
                            item.Id != post.Id &&
                            item.Category != post.Category))
                .Take(3)
                .ToList();

            var viewModel = new BlogDetailsViewModel
            {
                Post = post,
                RelatedPosts = relatedPosts
            };

            return View(viewModel);
        }
    }
}