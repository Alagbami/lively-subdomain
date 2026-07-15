namespace subdomain.Areas.Blogs.Models
{
    public static class BlogCategory
    {
        public const string Latest = "Latest";
        public const string Community = "Community";
        public const string Product = "Product";
        public const string GrowthAndTips = "Growth & Tips";
        public const string TrustAndSafety = "Trust & Safety";
        public const string Lively = "Lively";

        public static readonly string[] All =
        {
            Latest,
            Community,
            Product,
            GrowthAndTips,
            TrustAndSafety,
            Lively
        };
    }
}