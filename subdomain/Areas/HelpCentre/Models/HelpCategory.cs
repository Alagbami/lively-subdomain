namespace subdomain.Areas.HelpCentre.Models
{
    public class HelpCategory
    {
        public string Title { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public string Controller { get; set; } = string.Empty;

        public string Action { get; set; } = "Index";
    }
}