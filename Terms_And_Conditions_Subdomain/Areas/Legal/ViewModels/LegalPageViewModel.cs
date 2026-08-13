using YourNamespace.Areas.Legal.Models;

namespace YourNamespace.Areas.Legal.ViewModels
{
    public class LegalPageViewModel
    {
        public string PageTitle { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string LastUpdated { get; set; } = string.Empty;
        public List<LegalSection> Sections { get; set; } = new();
    }
}