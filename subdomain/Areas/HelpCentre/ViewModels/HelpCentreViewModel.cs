using subdomain.Areas.HelpCentre.Models;

namespace subdomain.Areas.HelpCentre.ViewModels
{
    public class HelpCentreViewModel
    {
        public List<HelpCategory> Categories { get; set; } = new();
    }
}